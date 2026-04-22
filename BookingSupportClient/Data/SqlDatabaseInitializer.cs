using Microsoft.Data.SqlClient;

namespace BookingSupportClient.Data;

public static class SqlDatabaseInitializer
{
    public static void EnsureCreated()
    {
        Directory.CreateDirectory(DatabaseSettings.DatabaseDirectory);

        using var masterConnection = new SqlConnection(DatabaseSettings.MasterConnectionString);
        masterConnection.Open();

        var createDatabaseSql = $"""
            IF DB_ID(N'{DatabaseSettings.DatabaseName}') IS NULL
            BEGIN
                CREATE DATABASE [{DatabaseSettings.DatabaseName}]
                ON PRIMARY (NAME = N'{DatabaseSettings.DatabaseName}', FILENAME = '{DatabaseSettings.DatabaseFilePath.Replace("'", "''")}')
            END
            """;

        using (var command = new SqlCommand(createDatabaseSql, masterConnection))
        {
            command.ExecuteNonQuery();
        }

        using var appConnection = new SqlConnection(DatabaseSettings.AppConnectionString);
        appConnection.Open();

        var schemaSql = """
            IF OBJECT_ID(N'dbo.BookingNotes', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.BookingNotes
                (
                    NoteId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    BookingId INT NOT NULL,
                    NoteText NVARCHAR(MAX) NOT NULL,
                    CreatedBy NVARCHAR(120) NOT NULL,
                    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_BookingNotes_CreatedAt DEFAULT SYSUTCDATETIME()
                );
            END;

            IF OBJECT_ID(N'dbo.Bookings', N'U') IS NULL
            BEGIN
                CREATE TABLE dbo.Bookings
                (
                    BookingId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    CustomerName NVARCHAR(200) NOT NULL,
                    CustomerContact NVARCHAR(200) NOT NULL,
                    ProductCode NVARCHAR(100) NOT NULL,
                    BookingDate DATE NOT NULL,
                    SelectedDate DATE NOT NULL,
                    Status NVARCHAR(50) NOT NULL,
                    CheckoutReference NVARCHAR(120) NOT NULL,
                    CheckoutDataJson NVARCHAR(MAX) NOT NULL,
                    InternalNotes NVARCHAR(MAX) NOT NULL,
                    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Bookings_CreatedAt DEFAULT SYSUTCDATETIME(),
                    UpdatedAt DATETIME2 NOT NULL CONSTRAINT DF_Bookings_UpdatedAt DEFAULT SYSUTCDATETIME(),
                    CONSTRAINT UQ_Bookings_CheckoutReference UNIQUE (CheckoutReference)
                );
            END;

            IF OBJECT_ID(N'dbo.BookingNotes', N'U') IS NOT NULL
               AND NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_BookingNotes_Bookings')
            BEGIN
                ALTER TABLE dbo.BookingNotes
                ADD CONSTRAINT FK_BookingNotes_Bookings
                    FOREIGN KEY (BookingId) REFERENCES dbo.Bookings(BookingId) ON DELETE CASCADE;
            END;

            IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Bookings_Status_SelectedDate' AND object_id = OBJECT_ID(N'dbo.Bookings'))
            BEGIN
                CREATE INDEX IX_Bookings_Status_SelectedDate ON dbo.Bookings(Status, SelectedDate);
            END;
            """;

        using var schemaCommand = new SqlCommand(schemaSql, appConnection);
        schemaCommand.ExecuteNonQuery();
    }
}
