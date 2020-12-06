SELECT
    Document.Name AS 'Документ',
    Document.Pages AS 'Страницы',
    CONCAT(Sender.Fullname,', ', SenderPosition.Name)  AS 'Отправитель ФИО, должность',
    CONCAT(SenderCity.Name, ', ул. ', SenderAddress.Street, ', д. ',SenderAddress.House) AS 'Отправитель, адрес',
    CONCAT(Recipient.Fullname, ', ', RecipientPosition.Name) AS 'Получатель ФИО, должность',
    CONCAT(RecipientCity.Name, ', ул. ', RecipientAddress.Street, ', д. ',RecipientAddress.House) AS 'Получатель, адрес',
    CONCAT(S.Name,', ' DocumentStatus.DateTime) AS 'Статус, дата'


FROM [DocumentStatus] AS DocumentStatus
    JOIN [Document] AS Document
     ON DocumentStatus.DocumentId = Document.Id
    JOIN [Employee] AS Sender
     ON DocumentStatus.SenderId = Sender.Id
    JOIN [Address] AS SenderAddress
     ON DocumentStatus.SenderAddressId = SenderAddress.Id
    JOIN [City] AS SenderCity
     ON SenderAddress.CityId = SenderCity.Id
    JOIN [Position] AS SenderPosition
     ON Sender.PositiONId = SenderPosition.Id
    JOIN [Employee] AS Recipient
     ON DocumentStatus.RecipientId = Recipient.Id
    JOIN [Address] AS RecipientAddress
     ON DocumentStatus.RecipientAddressId = RecipientAddress.Id
    JOIN [City] AS RecipientCity
     ON RecipientAddress.CityId = RecipientCity.Id
    JOIN [Position] AS RecipientPosition
     ON Recipient.PositionId = RecipientPosition.Id
    JOIN [Status] AS S
     ON DocumentStatus.StatusId = S.Id

GROUP BY Document.Name,
         Document.Pages,
         Sender.Fullname,
         SenderPosition.Name,
         CONCAT(SenderCity.Name, ', ул. ', SenderAddress.Street, ', д. ',SenderAddress.House),
         Recipient.Fullname,
         RecipientPositiON.Name,
         CONCAT(RecipientCity.Name, ', ул. ', RecipientAddress.Street, ', д. ',RecipientAddress.House)