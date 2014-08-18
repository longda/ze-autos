
create PROCEDURE Vehicle_Delete 
	@Id INT
AS
BEGIN
	DELETE FROM 
		[dbo].[Vehicle]
	WHERE 
		[Id] = @Id
END