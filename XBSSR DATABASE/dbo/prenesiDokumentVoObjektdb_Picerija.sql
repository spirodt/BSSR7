CREATE PROCEDURE prenesiDokumentVoObjektdb_Picerija(
    @dokumentMagacinID INT,
	@TipDokumentID INT ,
	@DoObjektID int
) AS
BEGIN

	--BEGIN TRANSACTION prefrliDokument

	DECLARE @dokumentMagacinBroj INT 
	SELECT @dokumentMagacinBroj = Broj FROM  BSG_MAGACIN.dbo.tblDokumenti WHERE ID = @dokumentMagacinID AND DoObjektID = @DoObjektID AND TipNaDokument = @TipDokumentID

	IF NOT EXISTS (SELECT * FROM BSG_PICERIJA.dbo.viewDokumenti WHERE 
			Broj = @dokumentMagacinBroj AND  TipDokumentID = 1)
	BEGIN
		INSERT INTO BSG_PICERIJA.dbo.tblDokumenti
		(
		    Broj,
		    TipNaDokument,
		    Datum,
		    DoObjektID,
			OdObjektID,
		    tblUserID,
		    Zabeleska,
		    tblPartnerID,
		    FirmaID,
		    KodNaDokument,
		    BrojNaDokument
		) SELECT Broj,
		    1,
		    Datum,
		    OdObjektID,
		    DoObjektID,
		    tblUserID,
		    Zabeleska,
		    tblPartnerID,
		    FirmaID,
		    KodNaDokument,
		    BrojNaDokument FROM BSG_MAGACIN.dbo.tblDokumenti WHERE ID = @dokumentMagacinID

			declare @IfDokumentForInsert int
			SELECT @IfDokumentForInsert =   (SELECT SCOPE_IDENTITY())

			INSERT INTO BSG_PICERIJA.dbo.tblDokumentStavki
			(
			    tblDokumentID,
			    tblArtikalID,
			    tblNormativID,
			    Cena,
			    Kolicina,
			    Iznos,
			    Rabat1
			)  SELECT @IfDokumentForInsert,
			    tblArtikalID,
			    tblNormativID,
			    Cena,
			    Kolicina,
			    Iznos,
			    Rabat1 FROM BSG_MAGACIN.dbo.tblDokumentStavki WHERE tblDokumentID = @dokumentMagacinID
			
	
	--COMMIT TRANSACTION prefrliDokument
	
	END
END