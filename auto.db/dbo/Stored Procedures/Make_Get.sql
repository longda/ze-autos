
create PROCEDURE Make_Get 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;

    IF (@Id = 0)
	BEGIN

	SELECT 
		[Id]
		,[Name]
	FROM
		[dbo].[Make]

	END
	ELSE
	BEGIN

	SELECT 
		[Id]
		,[Name]
	FROM
		[dbo].[Make]
	WHERE
		[Id] = @Id

	END
END
