CREATE PROCEDURE [CreateReminder] (
    @Id uniqueidentifier output,
    @StatusId int,
	@DateTime datetimeoffset,
    @Message varchar (512),
    @ContactId int OUTPUT 
)
AS
BEGIN
    SET NOCOUNT ON;
    Set @Id = NEWID()
    INSERT into [Reminder] ([Id],[StatusId],[DateTime],[Message],[ContactId]) VALUES (@Id, @StatusId, @DateTime, @Message, @ContactId)
END
GO

DECLARE @id UNIQUEIDENTIFIER;

EXEC [CreateReminder]
    @Id = @Id output,
    @StatusId = 1,
	@DateTime = SYSUTCDATETIME,
    @Message = 'Сделать домашку №1',
    @ContactId = 1;

SELECT @id;




