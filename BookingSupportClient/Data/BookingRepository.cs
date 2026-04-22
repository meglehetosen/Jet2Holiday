using System.Data;
using System.Text.Json;
using BookingSupportClient.Models;
using Microsoft.Data.SqlClient;

namespace BookingSupportClient.Data;

public sealed class BookingRepository
{
    public IReadOnlyList<BookingRecord> GetBookings(string? searchText = null, string? status = null)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT BookingId, CustomerName, CustomerContact, ProductCode, BookingDate, SelectedDate,
                   Status, CheckoutReference, CheckoutDataJson, InternalNotes, CreatedAt, UpdatedAt
            FROM dbo.Bookings
            WHERE (@SearchText IS NULL OR CustomerName LIKE '%' + @SearchText + '%' OR ProductCode LIKE '%' + @SearchText + '%' OR CheckoutReference LIKE '%' + @SearchText + '%')
              AND (@Status IS NULL OR @Status = '' OR Status = @Status)
            ORDER BY SelectedDate DESC, UpdatedAt DESC;
            """;
        command.Parameters.AddWithValue("@SearchText", string.IsNullOrWhiteSpace(searchText) ? DBNull.Value : searchText.Trim());
        command.Parameters.AddWithValue("@Status", string.IsNullOrWhiteSpace(status) || status == "All" ? DBNull.Value : status);

        using var reader = command.ExecuteReader();
        var results = new List<BookingRecord>();
        while (reader.Read())
        {
            results.Add(MapBooking(reader));
        }

        return results;
    }

    public BookingRecord InsertBooking(BookingRecord booking)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO dbo.Bookings
            (
                CustomerName, CustomerContact, ProductCode, BookingDate, SelectedDate,
                Status, CheckoutReference, CheckoutDataJson, InternalNotes, CreatedAt, UpdatedAt
            )
            OUTPUT INSERTED.BookingId, INSERTED.CustomerName, INSERTED.CustomerContact, INSERTED.ProductCode,
                   INSERTED.BookingDate, INSERTED.SelectedDate, INSERTED.Status, INSERTED.CheckoutReference,
                   INSERTED.CheckoutDataJson, INSERTED.InternalNotes, INSERTED.CreatedAt, INSERTED.UpdatedAt
            VALUES
            (
                @CustomerName, @CustomerContact, @ProductCode, @BookingDate, @SelectedDate,
                @Status, @CheckoutReference, @CheckoutDataJson, @InternalNotes, SYSUTCDATETIME(), SYSUTCDATETIME()
            );
            """;
        AddBookingParameters(command, booking);

        using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
        reader.Read();
        return MapBooking(reader);
    }

    public BookingRecord UpdateBooking(BookingRecord booking)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            UPDATE dbo.Bookings
            SET CustomerName = @CustomerName,
                CustomerContact = @CustomerContact,
                ProductCode = @ProductCode,
                BookingDate = @BookingDate,
                SelectedDate = @SelectedDate,
                Status = @Status,
                CheckoutReference = @CheckoutReference,
                CheckoutDataJson = @CheckoutDataJson,
                InternalNotes = @InternalNotes,
                UpdatedAt = SYSUTCDATETIME()
            OUTPUT INSERTED.BookingId, INSERTED.CustomerName, INSERTED.CustomerContact, INSERTED.ProductCode,
                   INSERTED.BookingDate, INSERTED.SelectedDate, INSERTED.Status, INSERTED.CheckoutReference,
                   INSERTED.CheckoutDataJson, INSERTED.InternalNotes, INSERTED.CreatedAt, INSERTED.UpdatedAt
            WHERE BookingId = @BookingId;
            """;
        command.Parameters.AddWithValue("@BookingId", booking.BookingId);
        AddBookingParameters(command, booking);

        using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
        if (!reader.Read())
        {
            throw new InvalidOperationException("A kiválasztott foglalás már nem található az adatbázisban.");
        }

        return MapBooking(reader);
    }

    public void DeleteBooking(int bookingId)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM dbo.Bookings WHERE BookingId = @BookingId;";
        command.Parameters.AddWithValue("@BookingId", bookingId);
        command.ExecuteNonQuery();
    }

    public IReadOnlyList<BookingNote> GetNotes(int bookingId)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT NoteId, BookingId, NoteText, CreatedBy, CreatedAt
            FROM dbo.BookingNotes
            WHERE BookingId = @BookingId
            ORDER BY CreatedAt DESC;
            """;
        command.Parameters.AddWithValue("@BookingId", bookingId);

        using var reader = command.ExecuteReader();
        var results = new List<BookingNote>();
        while (reader.Read())
        {
            results.Add(new BookingNote
            {
                NoteId = reader.GetInt32(0),
                BookingId = reader.GetInt32(1),
                NoteText = reader.GetString(2),
                CreatedBy = reader.GetString(3),
                CreatedAt = reader.GetDateTime(4)
            });
        }

        return results;
    }

    public BookingNote AddNote(int bookingId, string noteText, string createdBy)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO dbo.BookingNotes (BookingId, NoteText, CreatedBy, CreatedAt)
            OUTPUT INSERTED.NoteId, INSERTED.BookingId, INSERTED.NoteText, INSERTED.CreatedBy, INSERTED.CreatedAt
            VALUES (@BookingId, @NoteText, @CreatedBy, SYSUTCDATETIME());
            """;
        command.Parameters.AddWithValue("@BookingId", bookingId);
        command.Parameters.AddWithValue("@NoteText", noteText);
        command.Parameters.AddWithValue("@CreatedBy", createdBy);

        using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
        reader.Read();
        return new BookingNote
        {
            NoteId = reader.GetInt32(0),
            BookingId = reader.GetInt32(1),
            NoteText = reader.GetString(2),
            CreatedBy = reader.GetString(3),
            CreatedAt = reader.GetDateTime(4)
        };
    }

    public BookingRecord UpsertCheckout(CheckoutPayload payload)
    {
        using var connection = CreateOpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            MERGE dbo.Bookings AS target
            USING (
                SELECT
                    @CheckoutReference AS CheckoutReference,
                    @CustomerName AS CustomerName,
                    @CustomerContact AS CustomerContact,
                    @ProductCode AS ProductCode,
                    @BookingDate AS BookingDate,
                    @SelectedDate AS SelectedDate,
                    @Status AS Status,
                    @CheckoutDataJson AS CheckoutDataJson
            ) AS source
            ON target.CheckoutReference = source.CheckoutReference
            WHEN MATCHED THEN
                UPDATE SET
                    CustomerName = source.CustomerName,
                    CustomerContact = source.CustomerContact,
                    ProductCode = source.ProductCode,
                    BookingDate = source.BookingDate,
                    SelectedDate = source.SelectedDate,
                    Status = source.Status,
                    CheckoutDataJson = source.CheckoutDataJson,
                    UpdatedAt = SYSUTCDATETIME()
            WHEN NOT MATCHED THEN
                INSERT (CustomerName, CustomerContact, ProductCode, BookingDate, SelectedDate, Status, CheckoutReference, CheckoutDataJson, InternalNotes, CreatedAt, UpdatedAt)
                VALUES (source.CustomerName, source.CustomerContact, source.ProductCode, source.BookingDate, source.SelectedDate, source.Status, source.CheckoutReference, source.CheckoutDataJson, N'', SYSUTCDATETIME(), SYSUTCDATETIME())
            OUTPUT inserted.BookingId, inserted.CustomerName, inserted.CustomerContact, inserted.ProductCode,
                   inserted.BookingDate, inserted.SelectedDate, inserted.Status, inserted.CheckoutReference,
                   inserted.CheckoutDataJson, inserted.InternalNotes, inserted.CreatedAt, inserted.UpdatedAt;
            """;

        command.Parameters.AddWithValue("@CheckoutReference", payload.CheckoutReference);
        command.Parameters.AddWithValue("@CustomerName", payload.CustomerName);
        command.Parameters.AddWithValue("@CustomerContact", payload.CustomerContact);
        command.Parameters.AddWithValue("@ProductCode", payload.ProductCode);
        command.Parameters.AddWithValue("@BookingDate", payload.BookingDate.Date);
        command.Parameters.AddWithValue("@SelectedDate", payload.SelectedDate.Date);
        command.Parameters.AddWithValue("@Status", payload.Status);
        command.Parameters.AddWithValue("@CheckoutDataJson", JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = true }));

        using var reader = command.ExecuteReader(CommandBehavior.SingleRow);
        reader.Read();
        return MapBooking(reader);
    }

    private static SqlConnection CreateOpenConnection()
    {
        var connection = new SqlConnection(DatabaseSettings.AppConnectionString);
        connection.Open();
        return connection;
    }

    private static void AddBookingParameters(SqlCommand command, BookingRecord booking)
    {
        command.Parameters.AddWithValue("@CustomerName", booking.CustomerName.Trim());
        command.Parameters.AddWithValue("@CustomerContact", booking.CustomerContact.Trim());
        command.Parameters.AddWithValue("@ProductCode", booking.ProductCode.Trim());
        command.Parameters.AddWithValue("@BookingDate", booking.BookingDate.Date);
        command.Parameters.AddWithValue("@SelectedDate", booking.SelectedDate.Date);
        command.Parameters.AddWithValue("@Status", booking.Status.Trim());
        command.Parameters.AddWithValue("@CheckoutReference", booking.CheckoutReference.Trim());
        command.Parameters.AddWithValue("@CheckoutDataJson", string.IsNullOrWhiteSpace(booking.CheckoutDataJson) ? "{}" : booking.CheckoutDataJson);
        command.Parameters.AddWithValue("@InternalNotes", booking.InternalNotes.Trim());
    }

    private static BookingRecord MapBooking(SqlDataReader reader)
    {
        return new BookingRecord
        {
            BookingId = reader.GetInt32(0),
            CustomerName = reader.GetString(1),
            CustomerContact = reader.GetString(2),
            ProductCode = reader.GetString(3),
            BookingDate = reader.GetDateTime(4),
            SelectedDate = reader.GetDateTime(5),
            Status = reader.GetString(6),
            CheckoutReference = reader.GetString(7),
            CheckoutDataJson = reader.GetString(8),
            InternalNotes = reader.GetString(9),
            CreatedAt = reader.GetDateTime(10),
            UpdatedAt = reader.GetDateTime(11)
        };
    }
}
