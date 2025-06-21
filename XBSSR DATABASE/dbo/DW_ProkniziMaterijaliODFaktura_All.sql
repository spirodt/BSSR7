
CREATE  PROCEDURE [dbo].[DW_ProkniziMaterijaliODFaktura_All] (
	     
		 @FirmaID INT = 1,
		 @ObjektID INT = 1,
		 @UserID INT = 1		 
		 )
AS
BEGIN
	DECLARE @tblFakturaID INT
	if( Exists(Select tblFakturaID from tblKnizenjeM where tblFakturaID = @tblFakturaID))
	BEGIN
		return
	END


	  Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int
	  declare @Artikal int = null
	  declare @Kolicina decimal(18,4)
	  DECLARE @Iznos DECIMAL(18,2)
	  DECLARE @ProdaznaCena DECIMAL(18,2)
	  DECLARE @Sifra NVARCHAR(20)
	  DECLARE @SmetkaID INT = NULL
	  DECLARE @DatumNaPocetokNaSmetka DATETIME
	  DECLARE @DatumNaKrajNaSmetka DATETIME
	  
	  DECLARE @tblArtikalID_N INT
	  DECLARE @Kolicina_N DECIMAL(18,4)
	  DECLARE @tblEdinecnaMerka INT
	  DECLARE @tblDDVID INT
	  
	  DECLARE @NabavnaCena DECIMAL(18,2),@EdinecnaCena DECIMAL(18,2),@IznosSoDDV DECIMAL(18,2),@IznosBezDDV DECIMAL(18,2),@IznosDDV DECIMAL(18,2)
	  
	
	  DECLARE @OtpecatenaFiskalna BIT = NULL 
	  
	  DECLARE @DDVProcent DECIMAL(18,2)
	  DECLARE Smetka_Cursor CURSOR FOR SELECT  tblFakturaID, tblArtikalID, Kolicina, DDV,DDVIznos, Iznos, IznosBezDDV FROM viewFakturiStavki --WHERE tblFakturaID = @tblFakturaID
		    OPEN Smetka_Cursor
				FETCH NEXT FROM Smetka_Cursor INTO @tblFakturaID,@tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
			WHILE @@FETCH_STATUS = 0
			BEGIN
				BEGIN
				  SELECT @DatumNaPocetokNaSmetka = Datum,@DatumNaKrajNaSmetka = Valuta ,@UserID = tblUserID FROM tblFaktura WHERE ID = @tblFakturaID
					SET @tblNormativID = NULL
					SELECT @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,
					@ProdaznaCena = ProdaznaCena FROM tblArtikal WHERE ID = @tblArtikalID 
					
					SELECT @EdinecnaCena = NabavnaCenaBezDDV FROM tblPriemStavki WHERE tblArtikalID = @tblArtikalID 
					IF(@ProdaznaCena IS NOT NULL) 
					BEGIN
						INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
						  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
						  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
						  OtpecatenaFiskalna)
					   VALUES(@tblNormativID,@tblArtikalID,0,ISNULL(@ProdaznaCena,0),@Kolicina,@Sifra,
						  ISNULL(@tblEdinecnaMerka,0),@tblDDVID,2,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
						  @DatumNaPocetokNaSmetka,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,NULL,
						  @OtpecatenaFiskalna)
					END	  
				END 
												
				FETCH NEXT FROM Smetka_Cursor INTO @tblFakturaID,@tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
	        END	
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 

END