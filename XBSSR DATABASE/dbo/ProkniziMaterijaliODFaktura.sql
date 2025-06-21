CREATE  PROCEDURE [dbo].[ProkniziMaterijaliODFaktura] (
	     @tblFakturaID int,
		 @FirmaID int = 1,
		 @ObjektID int = 1,
		 @UserID int = 1		 
		 )
AS
BEGIN

	if( Exists(Select tblFakturaID from tblKnizenjeM where tblFakturaID = @tblFakturaID))
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
	  Declare @DatumNaPocetokNaSmetka datetime
	  Declare @DatumNaKrajNaSmetka datetime
	  
	  declare @tblArtikalID_N int
	  declare @Kolicina_N decimal(18,4)
	  Declare @tblEdinecnaMerka int
	  Declare @tblDDVID int
	  
	  DEclare @NabavnaCena decimal(18,2),@EdinecnaCena decimal(18,2),@IznosSoDDV decimal(18,2),@IznosBezDDV decimal(18,2),@IznosDDV decimal(18,2)
	  
	  select @DatumNaPocetokNaSmetka = Datum,@DatumNaKrajNaSmetka = Valuta ,@UserID = tblUserID from tblFaktura where ID = @tblFakturaID
	  Declare @OtpecatenaFiskalna bit = null 
	  

	  
	INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT tblArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, tblFakturaID, 16 
		FROM dbo.viewFakturiStavki 
		WHERE tblFakturaID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = 16 ) AND tblFakturaID = @tblFakturaID
		GROUP BY tblArtikalID, tblFakturaID


	  declare @DDVProcent decimal(18,2)
	  DECLARE Smetka_Cursor Cursor for select tblArtikalID, Kolicina, DDV,DDVIznos, Iznos, IznosBezDDV from viewFakturiStavki where tblFakturaID = @tblFakturaID
		    OPEN Smetka_Cursor
				FETCH NEXT FROM Smetka_Cursor into @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
			WHILE @@FETCH_STATUS = 0
			BEGIN
				BEGIN
					set @tblNormativID = null
					Select @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,
					@ProdaznaCena = ProdaznaCena, @Sifra = Sifra from tblArtikal where ID = @tblArtikalID 
					
					select @EdinecnaCena = NabavnaCenaBezDDV from tblPriemStavki where tblArtikalID = @tblArtikalID 
					if(@ProdaznaCena is not null) 
					BEGIN
						INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
						  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
						  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
						  OtpecatenaFiskalna)
					   values(@tblNormativID,@tblArtikalID,0,isnull(@ProdaznaCena,0),@Kolicina,@Sifra,
						  isnull(@tblEdinecnaMerka,0),@tblDDVID,2,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
						  @DatumNaPocetokNaSmetka,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,null,
						  @OtpecatenaFiskalna)
					END	  
				END 
												
				FETCH NEXT FROM Smetka_Cursor into @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV
	        END	
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 

END
