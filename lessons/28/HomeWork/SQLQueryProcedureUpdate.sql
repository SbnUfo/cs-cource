create PROCEDURE [UpdateReminder]
(
    @Id uniqueidentifier,
    @StatusId int,
	@DateTime datetimeoffset,
    @Message varchar (512),
    @ContactId int OUTPUT
)
AS
BEGIN
    UPDATE [Reminder]
    set [StatusId] = @StatusId,
	[DateTime] = @DateTime,
    [Message] = @Message,
    [ContactId] = @ContactId
    WHERE [Id] = @Id;
END
go

EXEC [UpdateReminder]
@Id = @Id output,
@StatusId = 3,
@DateTime = SYSUTCDATETIME,
@Message = 'Сделать домашку №3',
@ContactId = 3;

Select * FROM [Reminder]
Where [Id] = 'Id001';

--JOIN
SELECT *
FROM [Reminder] AS R

