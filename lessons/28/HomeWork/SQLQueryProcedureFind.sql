CREATE PROCEDURE [GetReminder] (
    @Id uniqueidentifier
)
AS
BEGIN
    SELECT * FROM [Reminder]
    where @Id = [Id];
END
GO

EXECUTE [GetReminder]
@id = 'ID004';

select @Id
