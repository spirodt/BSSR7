--exec [dbo].[GenerirajDokumenti] '2023-04-13 09:09:24.150','2023-04-30 09:09:24.150','2023-04-01 09:09:24.150',1,'',18.51

CREATE PROCEDURE [dbo].[GenerirajDokumenti] 
	-- Add the parameters for the stored procedure here
	@datum DATETIME = getdate ,
	@datumNaValuta DATETIME = getdate ,
	@datumPeriod DATETIME = getdate ,
	@UserId int = 0,
	@Zabeleska nvarchar(max),
	@CenaZaStruja decimal(18,2),
	@PatientIdOd int = 1,
	@PatientIdDO int = 500
AS
BEGIN
	SET NOCOUNT ON;
	
	BEGIN transaction generiraj

	--delete from tblDokumenti
	--Where ID not in( select tblDokumentID from tblKnizenjeM ) AND
	--BrojNaDokument LIKE '1-'+ FORMAT(@datum,'MM') + FORMAT(@datum,'yy') + '-%'

    INSERT INTO [dbo].[tblDokumenti]
           ([Broj]
           ,[TipNaDokument]
           ,[Datum]
           ,[OdObjektID]
           ,[DoObjektID]
           ,[tblUserID]
           ,[Zabeleska]
           ,[tblPartnerID]
           ,[FirmaID]
           ,[KodNaDokument]
		   ,[DatumNaValuta]
		   ,[DatumPeriod])
     select 
           0
           ,1
           ,@datum
           ,1
           ,NULL
           ,@UserId
           ,@Zabeleska
           ,ID
           ,1
           ,NEWID(),
		   @datumNaValuta,
		   @datumPeriod
		   from tblPartneri where Tip = 3 and ID BETWEEN @PatientIdOd AND @PatientIdDO

		   Declare @document_id int
		   Declare @tblPartner_ID int
		  

		    DECLARE @counterD int
			SET @counterD = 0
			UPDATE tblDokumenti
			SET @counterD = Broj = @counterD + 1

			UPDATE tblDokumenti set 
			[BrojNaDokument] = CAST(TipNaDokument  as Varchar(1))+ '-'+ FORMAT(DatumPeriod,'MM') + FORMAT(DatumPeriod,'yy') + '-' + FORMAT(CONVERT(INT,(select BrojNaStan from tblPartneri where ID = tblDokumenti.tblPartnerID)), '000')		
			WHERE TipNaDokument = 1

			UPDATE tblDokumenti set 
			UniqueIdPlacanje = UPPER(CONCAT(SUBSTRING(KodNaDokument,1,4),right(BrojNaDokument,3)))
			WHERE TipNaDokument = 1
			
			
			 DECLARE c_stavki CURSOR  
			 FOR SELECT  ID, tblPartnerID from viewDokumenti
		     where BrojNaDokument LIKE '1-'+ FORMAT(@datum,'MM') + FORMAT(@datum,'yy') + '-%'
			 and tblPartnerID BETWEEN @PatientIdOd AND @PatientIdDO

			OPEN c_stavki  
			FETCH NEXT FROM c_stavki INTO @document_id , @tblPartner_ID;
			WHILE @@FETCH_STATUS = 0  
			BEGIN  
			INSERT INTO [dbo].[tblDokumentStavki]
           ([tblDokumentID]
           ,[tblArtikalID]
           ,[tblNormativID]
           ,[Cena]
           ,[Kolicina]
           ,[Iznos]
           ,[Rabat1])
			select 
				
				@document_id as DocumentId,
				ID as ArtikalId,
				NULL as NormativId,
				CASE 
				   WHEN (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) <> 0
				   THEN (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID)
					WHEN ProdaznaCena = 0 AND (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) = 0
						THEN @CenaZaStruja
				ELSE ProdaznaCena
				END as Cena,

				(
					CASE WHEN (select isnull(tblDokumentiTemplate.Kolicina,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) <> 0
							THEN (select isnull(tblDokumentiTemplate.Kolicina,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID)
						ELSE
							(select DefaultKolicina from tblPartneri where  ID = @tblPartner_ID )
						END
				  ) as Kolicina,

				((CASE 
				   WHEN (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) <> 0
				   THEN (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID)
					WHEN ProdaznaCena = 0 AND (select isnull(Cena,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) = 0
						THEN @CenaZaStruja
				ELSE ProdaznaCena
				END)
				  * 
				  (
					CASE WHEN (select isnull(tblDokumentiTemplate.Kolicina,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID) <> 0
							THEN (select isnull(tblDokumentiTemplate.Kolicina,0) from tblDokumentiTemplate where tblArtikalID = viewArtikli.ID)
						ELSE
							(select DefaultKolicina from tblPartneri where  ID = @tblPartner_ID )
						END
				  ))as Iznos,
				0 as Rabat
			from viewArtikli 
			
			where ID in 
			(select [tblArtikalID] from tblDokumentiTemplate )


				FETCH NEXT FROM c_stavki INTO @document_id , @tblPartner_ID;
			END
			CLOSE c_stavki  
			DEALLOCATE c_stavki

	COMMIT transaction generiraj
END