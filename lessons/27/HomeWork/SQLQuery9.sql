CREATE TABLE [Status](
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [Name] VARCHAR(20) NOT NULL,

    CONSTRAINT PK_Status_Id PRIMARY KEY([Id]),
    CONSTRAINT UQ_Status_Name UNIQUE ([Name])
);
CREATE TABLE [Contact](
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [ContactId] VARCHAR(32) NOT NULL,

    CONSTRAINT PK_Contact_Id PRIMARY KEY ([Id]),
    CONSTRAINT UQ_Contact_ContactId UNIQUE ([ContactId])
);
CREATE TABLE [Reminder](
    [Id] UNIQUEIDENTIFIER NOT NULL DEFAULT newid(),
	[DateTime] DATETIMEOFFSET NOT NULL,
    [StatusId] INT NOT NULL,
    [Message] VARCHAR(512) NOT NULL,
    [ContactId] INT NOT NULL,

    CONSTRAINT PK_Reminder_Id PRIMARY KEY ([Id]),
    CONSTRAINT FK__StatusId_StatusId FOREIGN KEY ([StatusId])
        REFERENCES [Status]([Id])
            ON DELETE CASCADE
            ON UPDATE CASCADE,
    CONSTRAINT FK_ContactId_Contact_Id FOREIGN KEY ([ContactId])
        REFERENCES [Contact]([Id])
            ON DELETE CASCADE
            ON UPDATE CASCADE
);

INSERT INTO [Status] VALUES
    ('Created'),
    ('Ready'),
    ('Sent'),
    ('Failed')
INSERT INTO [Contact] VALUES
    ('Id001'),
    ('Id002'),
    ('Id003'),
    ('Id004')
insert into [Reminder] VALUES
    (default, '2020-12-02 21:41:00 +03:00', 1, 'Сделать домашку №1', 1),
    (default, '2020-12-02 21:42:00 +03:00', 2, 'Сделать домашку №2', 3),
    (default, '2020-12-02 21:43:00 +03:00', 3, 'Сделать домашку №3', 2),
    (default, '2020-12-02 21:44:00 +03:00', 4, 'Сделать домашку №4', 4)

