
CREATE PROCEDURE Make_Delete 
	@Id INT
AS
BEGIN

	-- ugh, this is so bad... soft deletes might be better.
	DELETE FROM 
		[dbo].[Vehicle]
	WHERE 
		[Id] IN
		(
			SELECT 
				[ID] 
			FROM 
				[dbo].[Vehicle] 
			WHERE 
				[MakeId] = @ID
		)

	DELETE FROM 
		[dbo].[Make]
	WHERE 
		[Id] = @Id
END