CREATE  PROCEDURE [dbo].[ProkniziMaterijaliODPriem] (
	     @tblPriemID int,
		 @FirmaID int = 1,
		 @ObjektID int = 1,
		 @UserID int = 1		 
		 )
AS
BEGIN
if( Exists(Select tblPriemID from tblKnizenjeM where tblPriemID = @tblPriemID))
	BEGIN
		return
	END
	  Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int,@tblFakturaID int = null
	  declare @Artikal int = null
	  declare @Kolicina decimal(18,4)
	  declare @Iznos decimal(18,2)
	  declare @ProdaznaCena decimal(18,2)
	  declare @Sifra nvarchar(20)
	  declare @SmetkaID int = null
	  Declare @DatumNaPocetokNaSmetka datetime
	  Declare @DatumNaKrajNaSmetka datetime
	  Declare @DatumNaKniznje datetime = getdate()
	  
	  declare @tblArtikalID_N int
	  declare @Kolicina_N decimal(18,4)
	  Declare @tblEdinecnaMerka int
	  Declare @tblDDVID int
	  
	  DEclare @NabavnaCena decimal(18,2),@EdinecnaCena decimal(18,2),@IznosSoDDV decimal(18,2),@IznosBezDDV decimal(18,2),@IznosDDV decimal(18,2)
	  
	  select @DatumNaPocetokNaSmetka  = PriemDatum,@DatumNaKrajNaSmetka = IspratnicaFakturaDatum ,@UserID = tblUserID from tblPriem where ID = @tblPriemID
	  set @DatumNaKniznje = @DatumNaPocetokNaSmetka
	  Declare @OtpecatenaFiskalna bit = null 
	  

	    DECLARE @TipNaDokumentID INT = 17
	-- Priemi
		INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT tblArtikalID,SUM(Kolicina) AS Vlez, 0 AS Izlez, tblPriemID, @TipNaDokumentID 
		FROM dbo.viewPriemStavki 
		WHERE tblPriemID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID ) AND tblPriemID = @tblPriemID
		GROUP BY tblArtikalID, tblPriemID

	  declare @DDVProcent decimal(18,2)
	  DECLARE Smetka_Cursor Cursor for select tblArtikalID, Kolicina, DDVStapka, DDV,NabavnaCenaSoDDV, IznosBezDDV, IznosSoDDV, Sifra from viewPriemStavki where tblPriemID = @tblPriemID
		    OPEN Smetka_Cursor
				FETCH NEXT FROM Smetka_Cursor into @tblArtikalID, @Kolicina, @DDVProcent, @IznosDDV,@Iznos, @IznosBezDDV, @IznosSoDDV, @Sifra
			WHILE @@FETCH_STATUS = 0
			BEGIN
				BEGIN
					set @tblNormativID = null
					Select @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,
					@ProdaznaCena = ProdaznaCena from tblArtikal where ID = @tblArtikalID 
					
					select @EdinecnaCena = NabavnaCenaSoDDV from tblPriemStavki where tblArtikalID = @tblArtikalID and @tblPriemID = tblPriemID
					
					INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
					  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
					  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
					  OtpecatenaFiskalna)
				   values(@tblNormativID,@tblArtikalID,0,@ProdaznaCena,@Kolicina,@Sifra,
					  @tblEdinecnaMerka,@tblDDVID,3,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
					  @DatumNaKniznje,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,@tblPriemID,
					  @OtpecatenaFiskalna)
				END 
												
				FETCH NEXT FROM Smetka_Cursor into @tblArtikalID, @Kolicina, @DDVProcent, @IznosDDV,@Iznos, @IznosBezDDV, @IznosSoDDV, @Sifra
	        END	
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 

END
