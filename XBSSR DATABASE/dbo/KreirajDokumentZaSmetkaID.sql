CREATE PROCEDURE KreirajDokumentZaSmetkaID 
	-- Add the parameters for the stored procedure here
	@tipNaDokumentId int = 0, 
	@SmetkaId int = 0
AS
BEGIN
	
	INSERT INTO dbo.tblDokumenti
	(
	    Broj,
	    TipNaDokument,
	    Datum,
	    OdObjektID,
	    DoObjektID,
	    tblUserID,
	    Zabeleska,
	    tblPartnerID,
	    FirmaID,
	    KodNaDokument,
	    BrojNaDokument
	)
	VALUES
	(   
	
		(SELECT MAX(Broj) + 1 FROM dbo.tblDokumenti),         -- Broj - int
	    @tipNaDokumentId,         -- TipNaDokument - int
	    GETDATE(), -- Datum - date
	    (SELECT TOP 1 ID FROM dbo.tblObjekti),         -- OdObjektID - int
	    (SELECT TOP 1 ID FROM dbo.tblObjekti),         -- DoObjektID - int
	    (SELECT TOP 1 ID FROM dbo.tblUsers),         -- tblUserID - int
	    N'Сторно за сметка ' + (SELECT TOP 1 CAST(broj AS NVARCHAR(max)) FROM dbo.tblSmetka WHERE ID = @SmetkaId),       -- Zabeleska - nvarchar(max)
	    (SELECT ID FROM dbo.tblPartneri WHERE Sifra LIKE '99999'),         -- tblPartnerID - int
	    (SELECT TOP 1 ID FROM dbo.tblFirma),         -- FirmaID - int
	    N'',       -- KodNaDokument - nvarchar(70)
	    N''        -- BrojNaDokument - nvarchar(50)
	    )

		DECLARE @DocId INT = (SELECT TOP 1 @@IDENTITY FROM dbo.tblDokumenti)

		INSERT INTO dbo.tblDokumentStavki
		(
		    tblDokumentID,
		    tblArtikalID,
		    tblNormativID,
		    Cena,
		    Kolicina,
		    Iznos,
		    Rabat1
		)

		(SELECT @DocId, ArtikalID,NULL,CenaSoRabatIddv,Kolicina, Iznos,Rabat FROM dbo.viewArtikliVoSmetkaKASA WHERE SmetkaId = @SmetkaId)


		
END