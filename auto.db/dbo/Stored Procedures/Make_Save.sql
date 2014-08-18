
CREATE PROCEDURE Make_Save 
	@Id INT,
	@Name NVARCHAR(128),
	@Ide INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

    IF (@Id = 0)
	BEGIN

	INSERT INTO 
		[dbo].[Make]
		(
			[Name]
		)
	VALUES
		(
			@Name
		)

	SELECT @Ide = SCOPE_IDENTITY()
	RETURN @Ide
	END
	ELSE
	BEGIN

	UPDATE
		[dbo].[Make]
	SET
		[Name] = @Name
	WHERE 
		[Id] = @Id
	END

	SELECT @Ide = @Id
	RETURN @Ide
END

