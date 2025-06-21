
CREATE PROCEDURE [dbo].[DW_ProkniziMaterijaliODPriem_All] (
	     
		 @FirmaID INT = 1,
		 @ObjektID INT = 1,
		 @UserID INT = 1		 
		 )
AS
BEGIN
DECLARE @tblPriemID INT
if( Exists(Select tblPriemID from tblKnizenjeM where tblPriemID = @tblPriemID))
	BEGIN
		return
	END
	  Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int,@tblFakturaID int = null
	  declare @Artikal int = null
	  declare @Kolicina decimal(18,4)
	  DECLARE @Iznos DECIMAL(18,2)
	  DECLARE @ProdaznaCena DECIMAL(18,2)
	  DECLARE @Sifra NVARCHAR(20)
	  DECLARE @SmetkaID INT = NULL
	  DECLARE @DatumNaPocetokNaSmetka DATETIME
	  DECLARE @DatumNaKrajNaSmetka DATETIME
	  DECLARE @DatumNaKniznje DATETIME = GETDATE()
	  
	  DECLARE @tblArtikalID_N INT
	  DECLARE @Kolicina_N DECIMAL(18,4)
	  DECLARE @tblEdinecnaMerka INT
	  DECLARE @tblDDVID INT
	  
	  DECLARE @NabavnaCena DECIMAL(18,2),@EdinecnaCena DECIMAL(18,2),@IznosSoDDV DECIMAL(18,2),@IznosBezDDV DECIMAL(18,2),@IznosDDV DECIMAL(18,2)
	  
	  DECLARE @OtpecatenaFiskalna BIT = NULL 
	  
	  DECLARE @DDVProcent DECIMAL(18,2)
	  DECLARE Smetka_Cursor CURSOR FOR SELECT tblPriemID ,tblArtikalID, Kolicina, DDVStapka, DDV,NabavnaCenaSoDDV, IznosBezDDV, IznosSoDDV, Sifra FROM viewPriemStavki --WHERE tblPriemID = @tblPriemID
		    OPEN Smetka_Cursor
				FETCH NEXT FROM Smetka_Cursor INTO @tblPriemID,@tblArtikalID, @Kolicina, @DDVProcent, @IznosDDV,@Iznos, @IznosBezDDV, @IznosSoDDV, @Sifra
			WHILE @@FETCH_STATUS = 0
			BEGIN
				BEGIN
				
				SELECT @DatumNaPocetokNaSmetka  = PriemDatum,@DatumNaKrajNaSmetka = IspratnicaFakturaDatum ,@UserID = tblUserID FROM tblPriem WHERE ID = @tblPriemID
				SET @DatumNaKniznje = @DatumNaPocetokNaSmetka

					SET @tblNormativID = NULL
					SELECT @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,
					@ProdaznaCena = ProdaznaCena FROM tblArtikal WHERE ID = @tblArtikalID 
					
					SELECT @EdinecnaCena = NabavnaCenaSoDDV FROM tblPriemStavki WHERE tblArtikalID = @tblArtikalID AND @tblPriemID = tblPriemID
					
					INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
					  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
					  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
					  OtpecatenaFiskalna)
				   VALUES(@tblNormativID,@tblArtikalID,0,@ProdaznaCena,@Kolicina,@Sifra,
					  @tblEdinecnaMerka,@tblDDVID,3,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
					  @DatumNaKniznje,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,@tblPriemID,
					  @OtpecatenaFiskalna)
				END 
												
				FETCH NEXT FROM Smetka_Cursor INTO @tblPriemID,@tblArtikalID, @Kolicina, @DDVProcent, @IznosDDV,@Iznos, @IznosBezDDV, @IznosSoDDV, @Sifra
	        END	
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 

END