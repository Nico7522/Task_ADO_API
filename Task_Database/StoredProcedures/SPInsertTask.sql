CREATE PROCEDURE [dbo].[SPInsertTask]
	@Title NVARCHAR(100),
	@Description NVARCHAR(500)

	AS
BEGIN

INSERT INTO [Task] (Title, [Description]) OUTPUT inserted.* VALUES (@Title, @Description)

END
