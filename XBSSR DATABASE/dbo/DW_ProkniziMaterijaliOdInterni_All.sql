
CREATE  PROCEDURE [dbo].[DW_ProkniziMaterijaliOdInterni_All] (
	     
		 @FirmaID INT = 1,
		 @ObjektID INT = 4,
		 @UserID INT = 31		 
		 )
AS
BEGIN
DECLARE @tblDokumentiID INT
if( Exists(Select tblDokumentID from tblKnizenjeM where tblDokumentID = @tblDokumentiID))
	BEGIN
		return
	END
	  Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int
	  declare @Artikal int = null
	  declare @Kolicina decimal(18,4)
	  declare @Iznos decimal(18,2)
	  declare @ProdaznaCena decimal(18,2)
	  declare @Sifra nvarchar(20)
	  declare @SmetkaID int = null
	  DECLARE @DatumNaPocetokNaSmetka DATETIME
	  DECLARE @DatumNaKrajNaSmetka DATETIME
	  
	  DECLARE @tblArtikalID_N INT
	  DECLARE @Kolicina_N DECIMAL(18,4)
	  DECLARE @tblEdinecnaMerka INT
	  DECLARE @tblDDVID INT
	  DECLARE @OdObjekt INT
	  DECLARE @DoObjekt INT
	  DECLARE @tipNaKnizenje INT 
	  
	  DECLARE @NabavnaCena DECIMAL(18,2),@EdinecnaCena DECIMAL(18,2),@IznosSoDDV DECIMAL(18,2),@IznosBezDDV DECIMAL(18,2),@IznosDDV DECIMAL(18,2)
	  
	  
	  
	  DECLARE @OtpecatenaFiskalna BIT = NULL 
	  
	  DECLARE @DDVProcent DECIMAL(18,2)
	  DECLARE Dokument_Cursor CURSOR FOR SELECT tblDokumentID , ArtikalID,  Kolicina, DDVStapka ,DDVIznos, Iznos, IznosBezDDV  FROM viewDokumentiStavki --WHERE tblDokumentID = @tblDokumentiID
		    OPEN Dokument_Cursor
				FETCH NEXT FROM Dokument_Cursor INTO @tblDokumentiID , @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
			WHILE @@FETCH_STATUS = 0
			BEGIN
				BEGIN

				SELECT @DatumNaPocetokNaSmetka = Datum ,@UserID = tblUserID, @OdObjekt =  OdObjektID, @DoObjekt = DoObjektID FROM tblDokumenti WHERE ID = @tblDokumentiID
				SELECT @tipNaKnizenje = TipNaKnizenje FROM viewDokumenti WHERE ID = @tblDokumentiID

					SET @tblNormativID = NULL
					SELECT @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,
					@ProdaznaCena = ProdaznaCena FROM tblArtikal WHERE ID = @tblArtikalID 
					
					SELECT @EdinecnaCena = NabavnaCenaBezDDV FROM tblPriemStavki WHERE tblArtikalID = @tblArtikalID 
					IF(@ProdaznaCena IS NOT NULL) AND (@tipNaKnizenje <> 0)
					BEGIN
						INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
						  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
						  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblDokumentID,tblPriemID,
						  OtpecatenaFiskalna,tblObjektiIDOD,tblObjektiIDDO)
					   VALUES(@tblNormativID,@tblArtikalID,0,ISNULL(@ProdaznaCena,0),@Kolicina,@Sifra,
						  ISNULL(@tblEdinecnaMerka,0),@tblDDVID,@tipNaKnizenje,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
						  @DatumNaPocetokNaSmetka,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaPocetokNaSmetka,NULL,@tblDokumentiID,NULL,
						  @OtpecatenaFiskalna,@OdObjekt, @DoObjekt)
					END	  
				END 
												
				FETCH NEXT FROM Dokument_Cursor INTO @tblDokumentiID , @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
	        END	
	   CLOSE Dokument_Cursor;
	   DEALLOCATE Dokument_Cursor; 

END