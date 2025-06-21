-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[AkcijaVrzDokument] 
	-- Add the parameters for the stored procedure here
	@DokumentID int = 0,
	@PratenOD nvarchar(100), 
	@PratenDO nvarchar(150),  
	@PratenPrimen bit,
	@TipNaDokumentStr nvarchar(100),
	@TipNaVnes int,
	@DokumentValue nvarchar(max)
	
AS
BEGIN
	DECLARE @Naziv nvarchar(150) 
	DECLARE @Zabeleska nvarchar(150)  
	DECLARE @Status int
	DECLARE @FirmaID int 
	declare @BrojNaDokument int
	DECLARE @DatumNaPracanje datetime 
	DECLARE @DatumNaPoslednaIzmenaNaStatus datetime 
	DECLARE @DatumNaPotvrda datetime 
	DECLARE @DatumNaKnizenje datetime 
	DECLARE @GeneriranKodNaDokument nvarchar(50) 
	DECLARE @ODObjekt int 
	DECLARE @DoObjekt int
	
	
	select @FirmaID = FirmaID from tblDokumenti where ID = @DokumentID
	 
	 Select @Zabeleska = @Zabeleska,@ODObjekt = OdObjektID, @DoObjekt = DoObjektID,@BrojNaDokument = Broj, @DatumNaKnizenje = Datum from viewDokumenti where ID = @DokumentID
	 set @Naziv = @TipNaDokumentStr + '_' + CAST(@BrojNaDokument as nvarchar(20))
	IF( @TipNaVnes = 1 )
		BEGIN
			IF NOT EXISTS(Select DokumentID from tblElektronskoPracanje where DokumentID = @DokumentID)
				BEGIN
				Set @Status = 1
				set @DatumNaPracanje = GETDATE()
				set @DatumNaPoslednaIzmenaNaStatus = null
				set @GeneriranKodNaDokument = @TipNaDokumentStr +'_'+CAST(@BrojNaDokument as nvarchar(15)) + '_'+ @PratenOD + '_' + CAST(@DokumentID as nvarchar(15)) + '_' + CAST(GETDATE() as nvarchar(30))
				INSERT INTO tblElektronskoPracanje 
				(DokumentID,Naziv,Zabeleska,DokumentValue,Status,FirmaID,PratenOD,PratenDO,DatumNaPracanje,DatumNaPoslednaIzmenaNaStatus,PratenPrimen,DatumNaPotvrda,DatumNaKnizenje,GeneriranKodNaDokument,ODObjekt,DoObjekt)
				VALUES
				(@DokumentID,@Naziv,@Zabeleska,@DokumentValue,@Status,@FirmaID,@PratenOD,@PratenDO,@DatumNaPracanje,@DatumNaPoslednaIzmenaNaStatus,@PratenPrimen,@DatumNaPotvrda,@DatumNaKnizenje,@GeneriranKodNaDokument,@ODObjekt,@DoObjekt)
				END
			ELSE
				BEGIN
					set @GeneriranKodNaDokument = 'C_'+@TipNaDokumentStr +'_'+CAST(@BrojNaDokument as nvarchar(15)) + '_'+ @PratenOD + '_' + CAST(@DokumentID as nvarchar(15)) + '_' + CAST(GETDATE() as nvarchar(30))
					Set @Status = 2
					set @DatumNaPoslednaIzmenaNaStatus = GETDATE()
					Update tblElektronskoPracanje set DatumNaPracanje = GETDATE(), DatumNaPoslednaIzmenaNaStatus = @DatumNaPoslednaIzmenaNaStatus
					Where DokumentID = @DokumentID	
				END
			END
			 
		END
--