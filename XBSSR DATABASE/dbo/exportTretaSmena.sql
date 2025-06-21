CREATE PROCEDURE exportTretaSmena 
(
	@DatumOD DATETIME,
	@DatumDO DATETIME,
	@tblUserId INT,
	@tblObjektID INT
)
AS
BEGIN
	SELECT 
	SUBSTRING(p.EDB,0,CHARINDEX('-',p.EDB,0)) AS Maticen,
	CONVERT(varchar, DatumPocetok, 112) AS Datum,
	REPLACE(STR(CAST(SUM(Iznos) AS INT), 6), SPACE(1), '0')  AS Iznos,
	SUBSTRING(p.EDB,0,CHARINDEX('-',p.EDB,0)) + CONVERT(varchar, DatumPocetok, 112) + REPLACE(STR(CAST(SUM(Iznos) AS INT), 6), SPACE(1), '0') AS Result
	FROM dbo.viewSmetki
	LEFT JOIN dbo.tblPartneri p ON p.ID = tblPartnerID 
	WHERE (DatumPocetok BETWEEN @DatumOD AND @DatumDO)  
	 AND viewSmetki.ObjektID = @tblObjektID -- objekt treta smena
	AND DatumKraj IS NOT NULL AND dbo.viewSmetki.Iznos <> 0 
	GROUP BY p.edb, CONVERT(varchar, DatumPocetok, 112)
	ORDER BY p.edb, Datum ASC
END