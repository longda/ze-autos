
CREATE PROCEDURE Vehicle_Get 
	@Id INT,
	@UserId INT
AS
BEGIN
	SET NOCOUNT ON;

	IF (@UserId !=0)
	BEGIN

	SELECT 
		[Id]
		,[MakeId]
		,[Mpg]
		,[UserId]
	FROM
		[dbo].[Vehicle]
	WHERE
		[UserId] = @UserId

	END
	ELSE IF (@Id = 0)
	BEGIN

	SELECT 
		[Id]
		,[MakeId]
		,[Mpg]
		,[UserId]
	FROM
		[dbo].[Vehicle]

	END
	ELSE
	BEGIN

	SELECT 
		[Id]
		,[MakeId]
		,[Mpg]
		,[UserId]
	FROM
		[dbo].[Vehicle]
	WHERE
		[Id] = @Id

	END
END
