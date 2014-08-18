
create PROCEDURE Vehicle_Save 
	@Id INT,
	@MakeId INT,
	@Mpg INT,
	@UserId INT,
	@Ide INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

    IF (@Id = 0)
	BEGIN

	INSERT INTO 
		[dbo].[Vehicle]
		(
			[MakeId]
           ,[Mpg]
           ,[UserId]
		)
	VALUES
		(
			@MakeId
           ,@Mpg
           ,@UserId
		)

	SELECT @Ide = SCOPE_IDENTITY()
	RETURN @Ide
	END
	ELSE
	BEGIN

	UPDATE
		[dbo].[Vehicle]
	SET
		[MakeId] = @MakeId
        ,[Mpg] = @Mpg
        ,[UserId] = @UserId
	WHERE 
		[Id] = @Id
	END

	SELECT @Ide = @Id
	RETURN @Ide
END

