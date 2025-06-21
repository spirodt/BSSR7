CREATE PROCEDURE dbo.srediArtikliNormativiRedenBroj
AS 
BEGIN
	UPDATE dbo.tblNormativ SET RedenBroj = b.RowN FROM (SELECT ROW_NUMBER() OVER(ORDER BY A.countAll DESC) AS RowN,A.countAll,A.tblNomativID
	FROM (SELECT COUNT(tblNomativID) AS countAll, tblNomativID FROM dbo.tblNalogStavki
	GROUP BY tblNomativID) AS A) AS B
	WHERE B.tblNomativID = ID
	UPDATE dbo.tblNormativ SET RedenBroj = 999999999 WHERE RedenBroj IS NULL

	SELECT * FROM dbo.tblNormativ ORDER BY RedenBroj ASC



	UPDATE dbo.tblArtikal SET RedenBroj = b.RowN FROM (SELECT ROW_NUMBER() OVER(ORDER BY A.countAll DESC) AS RowN,A.countAll,A.tblArtikalID
	FROM (SELECT COUNT(tblArtikalID) AS countAll, tblArtikalID FROM dbo.tblNalogStavki
	GROUP BY tblArtikalID) AS A) AS B
	WHERE B.tblArtikalID = ID
	UPDATE dbo.tblArtikal SET RedenBroj = 999999999 WHERE RedenBroj IS NULL

	SELECT * FROM dbo.tblArtikal ORDER BY RedenBroj ASC
END