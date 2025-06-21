CREATE PROCEDURE XXX_DeleteAll AS 
BEGIN
	DELETE FROM dbo.tblKnizenjeM
	DELETE FROM dbo.tblNalogStavki
	DELETE FROM dbo.tblNalog
	DELETE FROM dbo.tblFiskalniSmetki
	DELETE FROM dbo.tblSmetka
	DELETE FROM dbo.tblDokumenti
	DELETE FROM dbo.tblPriem
	DELETE FROM dbo.tblZalihaNaArtikli
	DELETE FROM dbo.tblFaktura
END