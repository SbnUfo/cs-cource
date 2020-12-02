CREATE TABLE [Status](
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [Name] VARCHAR(20) NOT NULL,
    CONSTRAINT PK_Status_Id PRIMARY KEY([Id]),
    CONSTRAINT UQ_Status_Name UNIQUE ([Name])
);
INSERT INTO [Status]
VALUES
    ('Created'),
    ('Ready'),
    ('Failed');

CREATE TABLE [Contact](
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [ContactId] VARCHAR(32) NOT NULL,
    CONSTRAINT PK_Contact_Id PRIMARY KEY ([Id]),
    CONSTRAINT UQ_Contact_ContactId UNIQUE ([ContactId])
)
INSERT INTO [Contact]
VALUES
    ('Id001'),
    ('Id002'),
    ('Id003');

CREATE TABLE [Reminder](
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [StatusId] INT NOT NULL,
    [DateTime] DATETIMEOFFSET NOT NULL,
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
)
INSERT INTO [Reminder] ([Id], [StatusId], [DateTime], [Message], [ContactId])
VALUES
    (NEWID(), 1, SYSUTCDATETIME(), 'Сделать домашку №1', 1),
    (NEWID(), 1, SYSUTCDATETIME(), 'Сделать домашку №2', 1),
    (NEWID(), 3, SYSUTCDATETIME(), 'Сделать домашку №3', 2)
