using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Orders;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace HotcakesBookingSync
{
    internal static class Program
    {
        private static readonly SyncSettings Settings = new SyncSettings
        {
            BaseUrl = "http://20.67.251.10/",
            ApiKey = "1-16c0cacd-f831-467a-8800-772f2b69967c",
            SqlConnectionString = @"Data Source=localhost\SQLEXPRESS;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;",
            DeveloperId = "jet2holiday"
        };

        private static int Main(string[] args)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Settings.ApiKey))
                {
                    Console.WriteLine("Hianyzo API kulcs.");
                    return 1;
                }

                if (string.IsNullOrWhiteSpace(Settings.SqlConnectionString))
                {
                    Console.WriteLine("Hianyzo SQL connection string.");
                    return 1;
                }

                Console.WriteLine("=== Hotcakes Booking Sync ===");
                Console.WriteLine("Parositas: Order.Bvin == Foglalas.OrderBvin");
                Console.WriteLine();

                TestSqlConnection(Settings.SqlConnectionString);

                var bookings = LoadBookings(Settings.SqlConnectionString);
                Console.WriteLine("Foglalas rekordok betoltve: " + bookings.Count);

                var api = new Api(Settings.BaseUrl, Settings.ApiKey);

                var allOrdersResp = api.OrdersFindAll();
                EnsureApiSuccess(allOrdersResp, "OrdersFindAll");

                var orderSnapshots = allOrdersResp.Content ?? new List<OrderSnapshotDTO>();
                Console.WriteLine("Hotcakes order snapshotok: " + orderSnapshots.Count);

                var updated = 0;
                var skipped = 0;

                foreach (var snapshot in orderSnapshots)
                {
                    if (string.IsNullOrWhiteSpace(snapshot.bvin))
                    {
                        skipped++;
                        continue;
                    }

                    var orderResp = api.OrdersFind(snapshot.bvin);
                    EnsureApiSuccess(orderResp, "OrdersFind(" + snapshot.bvin + ")");

                    var order = orderResp.Content;
                    if (order == null)
                    {
                        skipped++;
                        continue;
                    }

                    order.CustomProperties = order.CustomProperties ?? new List<CustomPropertyDTO>();

                    var matchedBookings = bookings
                        .Where(b => string.Equals(
                            SafeTrim(b.OrderBvin),
                            SafeTrim(order.bvin),
                            StringComparison.OrdinalIgnoreCase))
                        .OrderBy(b => b.FoglalasId)
                        .ToList();

                    if (matchedBookings.Count == 0)
                    {
                        skipped++;
                        continue;
                    }

                    var changed = ApplyBookingProperties(order, matchedBookings, Settings.DeveloperId);

                    if (!changed)
                    {
                        skipped++;
                        continue;
                    }

                    var updateResp = api.OrdersUpdate(order, false);
                    EnsureApiSuccess(updateResp, "OrdersUpdate(" + order.bvin + ")");

                    updated++;
                    Console.WriteLine("Frissitve: " + order.bvin + " | foglalasok: " + matchedBookings.Count);
                }

                Console.WriteLine();
                Console.WriteLine("KESZ");
                Console.WriteLine("Frissitve: " + updated);
                Console.WriteLine("Kihagyva : " + skipped);

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("VEGZETES HIBA:");
                Console.WriteLine(ex.ToString());
                return 1;
            }
        }

        private static void TestSqlConnection(string connectionString)
        {
            Console.WriteLine("SQL kapcsolat teszt...");
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand("SELECT TOP 1 name FROM [Jet2HolidaySQLdb].[sys].[tables]", conn))
                {
                    var result = cmd.ExecuteScalar();
                    Console.WriteLine("SQL kapcsolat OK. Elso tabla: " + Convert.ToString(result));
                }
            }

            Console.WriteLine();
        }

        private static List<FoglalasRecord> LoadBookings(string connectionString)
        {
            var result = new List<FoglalasRecord>();

            const string sql = @"
SELECT
    FoglalasId,
    OrderBvin,
    UserId,
    ProductBvin,
    Telefon,
    Lokacio,
    ErkezesDatum,
    TavozasDatum,
    VendegSzam,
    LetrehozasDatuma,
    Status,
    IsCancelled,
    CancellationReason,
    LastModifiedDate,
    HandledByUserId,
    BookingReference,
    EjszakakSzama
FROM [Jet2HolidaySQLdb].[dbo].[Foglalas]";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new FoglalasRecord
                        {
                            FoglalasId = GetInt(reader, "FoglalasId"),
                            OrderBvin = GetString(reader, "OrderBvin"),
                            UserId = GetString(reader, "UserId"),
                            ProductBvin = GetString(reader, "ProductBvin"),
                            Telefon = GetString(reader, "Telefon"),
                            Lokacio = GetString(reader, "Lokacio"),
                            ErkezesDatum = GetNullableDateTime(reader, "ErkezesDatum"),
                            TavozasDatum = GetNullableDateTime(reader, "TavozasDatum"),
                            VendegSzam = GetNullableInt(reader, "VendegSzam"),
                            LetrehozasDatuma = GetNullableDateTime(reader, "LetrehozasDatuma"),
                            Status = GetString(reader, "Status"),
                            IsCancelled = GetBool(reader, "IsCancelled"),
                            CancellationReason = GetString(reader, "CancellationReason"),
                            LastModifiedDate = GetNullableDateTime(reader, "LastModifiedDate"),
                            HandledByUserId = GetString(reader, "HandledByUserId"),
                            BookingReference = GetString(reader, "BookingReference"),
                            EjszakakSzama = GetNullableInt(reader, "EjszakakSzama")
                        });
                    }
                }
            }

            return result;
        }

        private static bool ApplyBookingProperties(OrderDTO order, List<FoglalasRecord> bookings, string developerId)
        {
            var changed = false;

            changed |= SetProperty(order.CustomProperties, developerId, "BookingCount", bookings.Count.ToString(CultureInfo.InvariantCulture));

            for (int i = 0; i < bookings.Count; i++)
            {
                var b = bookings[i];
                var prefix = "Booking_" + i + "_";

                changed |= SetProperty(order.CustomProperties, developerId, prefix + "FoglalasId", b.FoglalasId.ToString(CultureInfo.InvariantCulture));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "OrderBvin", b.OrderBvin);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "UserId", b.UserId);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "ProductBvin", b.ProductBvin);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "Telefon", b.Telefon);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "Lokacio", b.Lokacio);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "ErkezesDatum", FormatDate(b.ErkezesDatum));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "TavozasDatum", FormatDate(b.TavozasDatum));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "VendegSzam", FormatNullableInt(b.VendegSzam));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "LetrehozasDatuma", FormatDateTime(b.LetrehozasDatuma));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "Status", b.Status);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "IsCancelled", b.IsCancelled ? "true" : "false");
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "CancellationReason", b.CancellationReason);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "LastModifiedDate", FormatDateTime(b.LastModifiedDate));
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "HandledByUserId", b.HandledByUserId);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "BookingReference", b.BookingReference);
                changed |= SetProperty(order.CustomProperties, developerId, prefix + "EjszakakSzama", FormatNullableInt(b.EjszakakSzama));
            }

            return changed;
        }

        private static bool SetProperty(List<CustomPropertyDTO> props, string developerId, string key, string value)
        {
            var safeValue = value ?? string.Empty;

            var existing = props.FirstOrDefault(p =>
                string.Equals(p.DeveloperId, developerId, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(p.Key, key, StringComparison.OrdinalIgnoreCase));

            if (existing == null)
            {
                props.Add(new CustomPropertyDTO
                {
                    DeveloperId = developerId,
                    Key = key,
                    Value = safeValue
                });
                return true;
            }

            if (string.Equals(existing.Value ?? string.Empty, safeValue, StringComparison.Ordinal))
            {
                return false;
            }

            existing.Value = safeValue;
            return true;
        }

        private static void EnsureApiSuccess<T>(ApiResponse<T> response, string operationName)
        {
            if (response == null)
            {
                throw new Exception(operationName + " null valaszt adott.");
            }

            if (response.Errors != null && response.Errors.Count > 0)
            {
                var msg = string.Join(" | ", response.Errors.Select(e => e.Description));
                throw new Exception(operationName + " API hiba: " + msg);
            }
        }

        private static string SafeTrim(string input)
        {
            return (input ?? string.Empty).Trim();
        }

        private static string FormatDate(DateTime? value)
        {
            return value.HasValue
                ? value.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
                : string.Empty;
        }

        private static string FormatDateTime(DateTime? value)
        {
            return value.HasValue
                ? value.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                : string.Empty;
        }

        private static string FormatNullableInt(int? value)
        {
            return value.HasValue
                ? value.Value.ToString(CultureInfo.InvariantCulture)
                : string.Empty;
        }

        private static string GetString(SqlDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? string.Empty : Convert.ToString(reader.GetValue(ordinal));
        }

        private static int GetInt(SqlDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return Convert.ToInt32(reader.GetValue(ordinal));
        }

        private static int? GetNullableInt(SqlDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? (int?)null : Convert.ToInt32(reader.GetValue(ordinal));
        }

        private static bool GetBool(SqlDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return !reader.IsDBNull(ordinal) && Convert.ToBoolean(reader.GetValue(ordinal));
        }

        private static DateTime? GetNullableDateTime(SqlDataReader reader, string columnName)
        {
            var ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader.GetValue(ordinal));
        }
    }

    internal sealed class SyncSettings
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string SqlConnectionString { get; set; }
        public string DeveloperId { get; set; }
    }

    internal sealed class FoglalasRecord
    {
        public int FoglalasId { get; set; }
        public string OrderBvin { get; set; }
        public string UserId { get; set; }
        public string ProductBvin { get; set; }
        public string Telefon { get; set; }
        public string Lokacio { get; set; }
        public DateTime? ErkezesDatum { get; set; }
        public DateTime? TavozasDatum { get; set; }
        public int? VendegSzam { get; set; }
        public DateTime? LetrehozasDatuma { get; set; }
        public string Status { get; set; }
        public bool IsCancelled { get; set; }
        public string CancellationReason { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string HandledByUserId { get; set; }
        public string BookingReference { get; set; }
        public int? EjszakakSzama { get; set; }
    }
}
