--select * from tblSmetka where id = 1907 order by ID desc
--select * from tblSmetkaStavki where tblSmetkaID = 1907 order by ID desc

--declare @Date datetime = getdate() exec InsertSmetkaIzmeneta 1907,10,@Date,'spiro'
CREATE procedure [dbo].[InsertSmetkaIzmeneta]
(
	@SmetkaID int, 
	@Tip int,
	@Datum dateTime,
	@ZabeleskaOdIzmena nvarchar(max) 
)
as
begin 
	DECLARE  @Broj int
	DECLARE  @DatumPocetok datetime
	DECLARE  @DatumKraj datetime
	DECLARE  @DatumPNalog datetime
	DECLARE  @DatumKNalog datetime
	DECLARE  @tblUserID int
	DECLARE  @Smena_ID int
	DECLARE  @Zatvorena bit 
	DECLARE  @Zavrsen bit
	DECLARE  @FirmaID int 
	DECLARE  @ObjektID int
	DECLARE  @ZabeleskaNalog nvarchar(350)
	DECLARE  @Izmeneta int
	Declare  @BrojNaNalog int
	Declare  @tblNalogIzmenetaID int
	Declare  @SmetkaIzmenetaID int
	declare  @Zabeleska nvarchar(max)
	Declare  @TipNaNalog int
	declare  @KolicinaODNalog decimal(9,2)
	declare  @tblArtikalID int
	declare  @tblNomativID int
	declare  @tblNalogID int
	declare  @Status int 
	declare  @Kolicina int
	declare  @IDNalog int
	declare  @tblSmetkaID int
	declare  @Cena decimal(18,2)
	declare  @DatumNaIzmena datetime
	declare  @SmetkaStavkaID int
	declare  @IdStavkaNalog int
	declare  @tblPartnerID int
	declare  @ImaPopust int
	declare  @ProcentNaPopust decimal(18,2)
	declare  @Rabat1 decimal(18,4)
	declare  @KodNaDokument nvarchar(70)
	
	-- Kreiraj Smetka 
	
	Declare  cSmetka cursor for Select * from tblSmetka where ID = @SmetkaID
	open cSmetka
		FETCH NEXT FROM cSmetka into @tblSmetkaID, @Broj, @DatumPocetok, @DatumKraj,@tblUserID,@Smena_ID,@Zatvorena,@FirmaID,@ObjektID,@Zabeleska,@ImaPopust,@ProcentNaPopust,@Izmeneta,@tblPartnerID,@KodNaDokument
	WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO tblSmetkaIzmeneta (Broj, DatumPocetok, DatumKraj,tblUserID,Smena_ID,Zatvorena,FirmaID,ObjektID,Zabeleska,Izmeneta,DatumNaIzmena,tblSmetkaIzmenetaID,tblPartnerID)
			VALUES (@Broj, @DatumPocetok, @DatumKraj,@tblUserID,@Smena_ID,@Zatvorena,@FirmaID,@ObjektID,@ZabeleskaOdIzmena,@Tip,@Datum,@SmetkaID,@tblPartnerID)			
			FETCH NEXT FROM cSmetka into @tblSmetkaID, @Broj, @DatumPocetok, @DatumKraj,@tblUserID,@Smena_ID,@Zatvorena,@FirmaID,@ObjektID,@Zabeleska,@ImaPopust,@ProcentNaPopust,@Izmeneta,@tblPartnerID,@KodNaDokument
		END
	CLOSE cSmetka
	DEALLOCATE cSmetka 
	
	-- Zemi i insertiraj za smetka ID
	select top 1 @SmetkaIzmenetaID = tblSmetkaIzmeneta.ID from tblSmetkaIzmeneta order by ID desc
	
	
	DECLARE cNalog cursor for select * from tblNalog where SmetkaID = @SmetkaID
			open cNalog
			FETCH NEXT FROM cNalog into @IDNalog, @BrojNaNalog, @ZabeleskaNalog, @DatumPNalog, @DatumKNalog, @FirmaID, @Smena_ID,@Zavrsen, @TipNaNalog,@SmetkaID
			WHILE @@FETCH_STATUS = 0
			
				BEGIN
				INSERT INTO tblNalogIzmeneta (Broj,Zabeleska,DatumPocetok,DatumKraj,FirmaID,Smena_ID,Zavrsen,TipNaNalog,SmetkaID,DatumNaIzmena)
				VALUES(@BrojNaNalog,@ZabeleskaNalog,@DatumPNalog,@DatumKNalog,@FirmaID,@Smena_ID,@Zavrsen,@TipNaNalog,@SmetkaIzmenetaID,@Datum)
				select top 1 @tblNalogIzmenetaID = ID from tblNalogIzmeneta order by ID desc
				--
					declare cNalogStavki cursor for select * from tblNalogStavki where tblNalogID = @IDNalog
					open cNalogStavki
					FETCH NEXT FROM cNalogStavki into @IdStavkaNalog, @IDNalog, @tblNomativID, @tblArtikalID,@KolicinaODNalog,@Rabat1
					WHILE @@FETCH_STATUS = 0 
					BEGIN
						INSERT into tblNalogStavkiIzmeneta ( tblNalogIzmenetaID, Kolicina, tblArtikalID, tblNomativID,Rabat1)
						VALUES( @tblNalogIzmenetaID, @KolicinaODNalog, @tblArtikalID, @tblNomativID,@Rabat1)
						FETCH NEXT FROM cNalogStavki into @IdStavkaNalog, @IDNalog, @tblNomativID, @tblArtikalID,@KolicinaODNalog,@Rabat1
					END
										Close cNalogStavki
					DEALLOCATE cNalogStavki 
				--		
					FETCH NEXT FROM cNalog into @IDNalog, @BrojNaNalog, @ZabeleskaNalog, @DatumPNalog, @DatumKNalog, @FirmaID, @Smena_ID,@Zavrsen, @TipNaNalog,@SmetkaID
					
				END
			Close cNalog
			DEALLOCATE cNalog
			
	Declare  cSmetkaStavki cursor for select * from tblSmetkaStavki where tblSmetkaID = @SmetkaID
	open cSmetkaStavki
		FETCH NEXT FROM cSmetkaStavki into  @SmetkaStavkaID,@SmetkaID, @tblNalogID,@Status,@Kolicina,@Cena
	WHILE @@FETCH_STATUS = 0
		BEGIN
			INSERT INTO tblSmetkaStavkiIzmeneta (tblSmetkaID,tblNalogID,[Status],Kolicina,Cena,DatumNaIzmena,tblSmetkaIzmenetaID)
			VALUES (@tblSmetkaID, @tblNalogID, @Status,@Kolicina,@Cena,@DatumNaIzmena,@SmetkaIzmenetaID)
			FETCH NEXT FROM cSmetkaStavki into  @SmetkaStavkaID,@SmetkaID, @tblNalogID,@Status,@Kolicina,@Cena
		END
	CLOSE cSmetkaStavki
	DEALLOCATE cSmetkaStavki 
	
END