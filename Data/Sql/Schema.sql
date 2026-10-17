
IF OBJECT_ID(N'dbo.Rooms', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Rooms
    (
        RoomId INT IDENTITY(1,1) PRIMARY KEY,
        RoomNumber NVARCHAR(20) NOT NULL UNIQUE,
        RoomType NVARCHAR(50) NOT NULL,
        PricePerNight DECIMAL(10,2) NOT NULL,
        Status NVARCHAR(20) NOT NULL
            CONSTRAINT DF_Rooms_Status DEFAULT 'Available',

        CONSTRAINT CK_Rooms_Price
            CHECK (PricePerNight >= 0),

        CONSTRAINT CK_Rooms_Status
            CHECK (Status IN
                ('Available', 'Occupied', 'Maintenance'))
    );
END;

IF OBJECT_ID(N'dbo.Customers', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Customers
    (
        CustomerId INT IDENTITY(1,1) PRIMARY KEY,
        FullName NVARCHAR(150) NOT NULL,
        Phone NVARCHAR(30) NOT NULL,
        Email NVARCHAR(254) NULL,
        CreatedAt DATETIME2 NOT NULL
            CONSTRAINT DF_Customers_CreatedAt
            DEFAULT SYSUTCDATETIME()
    );
END;

IF OBJECT_ID(N'dbo.Reservations', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Reservations
    (
        ReservationId INT IDENTITY(1,1) PRIMARY KEY,

        RoomId INT NOT NULL,
        CustomerId INT NOT NULL,

        CheckInDate DATE NOT NULL,
        CheckOutDate DATE NOT NULL,

        BookingStatus NVARCHAR(20) NOT NULL
            CONSTRAINT DF_Reservations_Status
            DEFAULT 'Booked',

        CreatedAt DATETIME2 NOT NULL
            CONSTRAINT DF_Reservations_CreatedAt
            DEFAULT SYSUTCDATETIME(),

        CONSTRAINT FK_Reservations_Rooms
            FOREIGN KEY (RoomId)
            REFERENCES dbo.Rooms(RoomId),

        CONSTRAINT FK_Reservations_Customers
            FOREIGN KEY (CustomerId)
            REFERENCES dbo.Customers(CustomerId),

        CONSTRAINT CK_Reservations_Dates
            CHECK (CheckOutDate > CheckInDate),

        CONSTRAINT CK_Reservations_Status
            CHECK (BookingStatus IN
                ('Booked', 'CheckedIn', 'CheckedOut', 'Cancelled'))
    );

    CREATE INDEX IX_Reservations_Room_Dates
        ON dbo.Reservations
            (RoomId, CheckInDate, CheckOutDate);
END;
