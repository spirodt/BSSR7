CREATE  PROCEDURE [dbo].[ProkniziMaterijaliZaSmetka] (
	     @SmetkaID int,
		 @FirmaID int = 1,
		 @ObjektID int = 1
		 )
AS
BEGIN
	if( Exists(Select tblSmetkaID from tblKnizenjeM where tblSmetkaID = @SmetkaID))
	BEGIN
		return
	END

	  Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int,@tblFakturaID int = null,@tblPriemID int = null
	  declare @Artikal int = null
	  declare @Kolicina decimal(18,4)
	  declare @Iznos decimal(18,2)
	  declare @ProdaznaCena decimal(18,2)
	  declare @Sifra nvarchar(20)
	  
	  Declare @DatumNaPocetokNaSmetka datetime
	  Declare @DatumNaKrajNaSmetka datetime
	  Declare @DatumNaKniznje datetime = getdate()
	  Declare @UserID int
	  declare @tblArtikalID_N int
	  declare @Kolicina_N decimal(18,4)
	  Declare @tblEdinecnaMerka int
	  Declare @tblDDVID int
	  Declare @Rabat decimal(18,2)
	  declare @IznosNaRabat decimal(18,2)
	  declare @ProdaznaCenaSoRabat decimal (18,2)
	  
	  DEclare @NabavnaCena decimal(18,2),@EdinecnaCena decimal(18,2),@IznosSoDDV decimal(18,2),@IznosBezDDV decimal(18,2),@IznosDDV decimal(18,2)
	  
	  select @DatumNaPocetokNaSmetka  = DatumPocetok,@DatumNaKrajNaSmetka = DatumKraj ,@UserID = tblUserID
	  from tblSmetka  where ID = @SmetkaID
	  set @DatumNaKniznje = @DatumNaPocetokNaSmetka
	  Declare @OtpecatenaFiskalna bit 
	  if(EXISTS(select tblSmetkaID from tblFiskalniSmetki where tblSmetkaID = @SmetkaID))
	  BEGIN
		set @OtpecatenaFiskalna = 1
	  END
	  else 
	  BEGIN
		set @OtpecatenaFiskalna = 0
	  END


	  	DECLARE @TipNaDokumentID INT = 16


	--Smetki 
		INSERT INTO [dbo].[tblZalihaNaArtikli]
				   ([tblArtikalID]
				   ,[Vlez]
				   ,[Izlez]
				   ,[IDNaDokument]
				   ,[TIpDokument])
				SELECT ArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, SmetkaID, @TipNaDokumentID 
				FROM dbo.viewArtikliVoSmetkaKASA 
				WHERE SmetkaID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID ) AND SmetkaID = @SmetkaID
				GROUP BY ArtikalID, SmetkaID
			  declare @DDVProcent decimal(18,2)

	  DECLARE Smetka_Cursor Cursor for select SmetkaID,Kolicina,Iznos,ProdaznaCena, Sifra, ArtikalID, Tip, Rabat,(ProdaznaCena * Kolicina) - (CenaSoRabatIddv * Kolicina) ,CenaSoRabatIddv from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID
		    OPEN Smetka_Cursor
			FETCH NEXT FROM Smetka_Cursor into @SmetkaID,@Kolicina,@Iznos,@ProdaznaCena,@Sifra,@Artikal,@Tip,@Rabat,@IznosNaRabat,@ProdaznaCenaSoRabat
			WHILE @@FETCH_STATUS = 0
			BEGIN
				IF (@Tip = 0)
					BEGIN
					set @tblNormativID = null
					set @tblArtikalID = @Artikal
					Select @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,@ProdaznaCena = ProdaznaCena from tblArtikal
					where ID = @tblArtikalID 
					select @EdinecnaCena = isnull(AVG(NabavnaCenaSoDDV),0) from tblPriemStavki where tblArtikalID = @tblArtikalID 
					select @DDVProcent = Procent from tblDDVStavka Where ID = @tblDDVID
					
					set @IznosSoDDV = @Iznos
					set @IznosBezDDV = (@Iznos / (1 + @DDVProcent / 100))
					set @IznosDDV = @Iznos - @IznosBezDDV
					
					INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
					  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
					  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
					  OtpecatenaFiskalna,Rabat,IznosNaRabat,ProdaznaCenaSoRabat )
				   values(@tblNormativID,@tblArtikalID,@Tip,@ProdaznaCena,@Kolicina,@Sifra,
					  @tblEdinecnaMerka,@tblDDVID,1,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
					  @DatumNaKniznje,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,@tblPriemID,
					  @OtpecatenaFiskalna,@Rabat,@IznosNaRabat,@ProdaznaCenaSoRabat )
					END 
				IF (@Tip = 1)
					BEGIN						
						set @tblNormativID = @Artikal
						
						DECLARE Normativ_Cursor Cursor for Select tblArtikalID,Kolicina from tblNormativStavki where tblNormativID = @Artikal
						OPEN Normativ_Cursor
							FETCH NEXT FROM Normativ_Cursor into @tblArtikalID_N, @Kolicina_N
						WHILE @@FETCH_STATUS = 0
							BEGIN
					
							Select @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,@ProdaznaCena = ProdaznaCena from tblArtikal
							where ID = @tblArtikalID_N 
							
							select @EdinecnaCena = isnull(AVG(NabavnaCenaSoDDV),0) from tblPriemStavki where tblArtikalID = @tblArtikalID_N 
							select @DDVProcent = Procent from tblDDVStavka Where ID = @tblDDVID
							set @tblArtikalID = @Artikal
							
							set @IznosSoDDV = @Iznos
							set @IznosBezDDV = (@Iznos / (1 + @DDVProcent / 100))
							set @IznosDDV = @Iznos - @IznosBezDDV
					
							INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
							  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
							  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,
							  OtpecatenaFiskalna,Rabat,IznosNaRabat,ProdaznaCenaSoRabat)
						   values(@tblNormativID,@tblArtikalID_N,@Tip,@ProdaznaCena,@Kolicina * @Kolicina_N,@Sifra,
							  @tblEdinecnaMerka,@tblDDVID,1,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,
							  @DatumNaKniznje,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaKrajNaSmetka,@SmetkaID,@tblFakturaID,@tblPriemID,
							  @OtpecatenaFiskalna,@Rabat,@IznosNaRabat,@ProdaznaCenaSoRabat )
							  
							   FETCH NEXT FROM Normativ_Cursor into @tblArtikalID_N, @Kolicina_N
							END	
						CLOSE Normativ_Cursor;
						DEALLOCATE Normativ_Cursor; 
												
					END	
					
				FETCH NEXT FROM Smetka_Cursor into @SmetkaID,@Kolicina,@Iznos,@ProdaznaCena,@Sifra,@Artikal,@Tip,@Rabat,@IznosNaRabat,@ProdaznaCenaSoRabat
	        END	
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 

END
