
CREATE PROCEDURE Report_Mileage 
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		m.Name AS [Make],
		MIN([Mpg]) AS [MinMpg],
		MAX([Mpg]) AS [MaxMpg],
		AVG([Mpg]) AS [AveMpg]
	FROM 
		[dbo].[Vehicle] v
	INNER JOIN
		[dbo].[Make] m
		ON m.Id = v.MakeId
	GROUP BY
		m.Name
END

