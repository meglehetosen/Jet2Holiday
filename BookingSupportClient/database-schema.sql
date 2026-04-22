CREATE TABLE dbo.Bookings
(
    BookingId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    CustomerName NVARCHAR(200) NOT NULL,
    CustomerContact NVARCHAR(200) NOT NULL,
    ProductCode NVARCHAR(100) NOT NULL,
    BookingDate DATE NOT NULL,
    SelectedDate DATE NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    CheckoutReference NVARCHAR(120) NOT NULL UNIQUE,
    CheckoutDataJson NVARCHAR(MAX) NOT NULL,
    InternalNotes NVARCHAR(MAX) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    UpdatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE dbo.BookingNotes
(
    NoteId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    BookingId INT NOT NULL,
    NoteText NVARCHAR(MAX) NOT NULL,
    CreatedBy NVARCHAR(120) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_BookingNotes_Bookings FOREIGN KEY (BookingId) REFERENCES dbo.Bookings(BookingId) ON DELETE CASCADE
);

CREATE INDEX IX_Bookings_Status_SelectedDate ON dbo.Bookings(Status, SelectedDate);
