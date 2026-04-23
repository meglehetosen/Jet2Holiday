using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotcakesApiRunner
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            try
            {
                var baseUrl = "http://20.67.251.10/";
                var apiKey = "1-16c0cacd-f831-467a-8800-772f2b69967c";
                var bvin = "30BD0E97-1683-4D4A-A4D6-66DF840160D3";

                var developerId = "jet2holiday";
                var key = "BookingId";
                var value = "ABC-001";
                var recalc = false;

                Console.WriteLine("=== Hotcakes Order CustomProperty Updater ===");
                Console.WriteLine("Base URL    : " + baseUrl);
                Console.WriteLine("Order Bvin  : " + bvin);
                Console.WriteLine("Set property: " + developerId + ":" + key + "=" + value);
                Console.WriteLine();

                var api = new Api(baseUrl, apiKey);

                Console.WriteLine("1. API kapcsolat ellenőrzése: OrdersFindAll()");
                var allOrdersResp = api.OrdersFindAll();

                if (allOrdersResp == null)
                {
                    Console.WriteLine("HIBA: az OrdersFindAll() null választ adott.");
                    return 1;
                }

                Console.WriteLine("OrdersFindAll Errors count: " + (allOrdersResp.Errors != null ? allOrdersResp.Errors.Count : -1));
                Console.WriteLine("OrdersFindAll Content null: " + (allOrdersResp.Content == null));

                if (allOrdersResp.Errors != null && allOrdersResp.Errors.Count > 0)
                {
                    Console.WriteLine("OrdersFindAll API hibák:");
                    foreach (var err in allOrdersResp.Errors)
                    {
                        Console.WriteLine("- " + err.Description);
                    }
                }

                if (allOrdersResp.Content != null)
                {
                    Console.WriteLine("Lekért order snapshotok száma: " + allOrdersResp.Content.Count);
                    Console.WriteLine("Első néhány order:");
                    foreach (var order in allOrdersResp.Content.Take(5))
                    {
                        Console.WriteLine("- Bvin: " + order.bvin + ", OrderNumber: " + order.OrderNumber);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("2. Konkrét order lekérése: OrdersFind(bvin)");

                var findResp = api.OrdersFind(bvin);

                Console.WriteLine("OrdersFind lefutott.");

                if (findResp == null)
                {
                    Console.WriteLine("HIBA: findResp == null");
                    return 1;
                }

                Console.WriteLine("OrdersFind Errors count: " + (findResp.Errors != null ? findResp.Errors.Count : -1));
                Console.WriteLine("OrdersFind Content null: " + (findResp.Content == null));

                if (findResp.Errors != null && findResp.Errors.Count > 0)
                {
                    Console.WriteLine("OrdersFind API hibák:");
                    foreach (var err in findResp.Errors)
                    {
                        Console.WriteLine("- " + err.Description);
                    }
                }

                if (findResp.Content == null)
                {
                    Console.WriteLine("HIBA: az API válaszolt, de nem adott vissza order tartalmat.");
                    return 1;
                }

                var dto = findResp.Content;
                if (dto.CustomProperties == null)
                {
                    dto.CustomProperties = new List<CustomPropertyDTO>();
                }

                Console.WriteLine("Order sikeresen lekérve.");
                Console.WriteLine("OrderNumber: " + dto.OrderNumber);
                Console.WriteLine("Bvin       : " + dto.Bvin);
                Console.WriteLine("CustomProperties count: " + dto.CustomProperties.Count);
                Console.WriteLine();

                Console.WriteLine("3. Custom property beállítása");

                var prop = dto.CustomProperties.FirstOrDefault(p =>
                    string.Equals(p.DeveloperId, developerId, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(p.Key, key, StringComparison.OrdinalIgnoreCase));

                if (prop == null)
                {
                    Console.WriteLine("A property még nem létezett, létrehozom.");

                    prop = new CustomPropertyDTO
                    {
                        DeveloperId = developerId,
                        Key = key,
                        Value = value
                    };

                    dto.CustomProperties.Add(prop);
                }
                else
                {
                    Console.WriteLine("A property már létezett. Régi érték: " + prop.Value);
                    prop.Value = value;
                }

                Console.WriteLine("4. Order frissítése: OrdersUpdate(...)");

                var updateResp = api.OrdersUpdate(dto, recalc);

                if (updateResp == null)
                {
                    Console.WriteLine("HIBA: az OrdersUpdate null választ adott.");
                    return 1;
                }

                Console.WriteLine("OrdersUpdate Errors count: " + (updateResp.Errors != null ? updateResp.Errors.Count : -1));
                Console.WriteLine("OrdersUpdate Content null: " + (updateResp.Content == null));

                if (updateResp.Errors != null && updateResp.Errors.Count > 0)
                {
                    Console.WriteLine("OrdersUpdate API hibák:");
                    foreach (var err in updateResp.Errors)
                    {
                        Console.WriteLine("- " + err.Description);
                    }
                }

                if (updateResp.Content == null)
                {
                    Console.WriteLine("HIBA: az update nem adott vissza tartalmat.");
                    return 1;
                }

                Console.WriteLine();
                Console.WriteLine("Sikeres frissítés.");
                Console.WriteLine("Order Bvin: " + updateResp.Content.Bvin);

                var savedProps = updateResp.Content.CustomProperties ?? new List<CustomPropertyDTO>();

                var savedProp = savedProps.FirstOrDefault(p =>
                    string.Equals(p.DeveloperId, developerId, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(p.Key, key, StringComparison.OrdinalIgnoreCase));

                if (savedProp != null)
                {
                    Console.WriteLine("Mentett property: " + savedProp.DeveloperId + ":" + savedProp.Key + "=" + savedProp.Value);
                }

                Console.WriteLine();
                Console.WriteLine("Kész.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("KIVÉTEL TÖRTÉNT:");
                Console.WriteLine(ex.ToString());
                return 1;
            }
        }
    }
}

