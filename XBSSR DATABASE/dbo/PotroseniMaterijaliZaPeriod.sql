-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
--Declare @DatumPocetok datetime = CONVERT(datetime,'10.10.2001')
--Declare @DatumKraj datetime =  CONVERT(datetime,'10.10.2015')
--Declare @FirmaID int = 1
--Declare @ObjektID int = 1
--exec PotroseniMaterijaliZaPeriod @DatumPocetok, @DatumKraj,@FirmaID,@ObjektID ,1
-- =============================================
CREATE  PROCEDURE [dbo].[PotroseniMaterijaliZaPeriod] (
	     @DatumPocetok datetime,
		 @DatumKraj datetime,
		 @FirmaID int = 1,
		 @ObjektID int = 1,
		 @SamoFiskalNa bit 
)
AS
BEGIN
		if(@SamoFiskalNa = 1) 
		BEGIN
			SELECT * FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2)  and OtpecatenaFiskalna = 1 and NormativNaziv is null
		END
		ELSE
		BEGIN
			SELECT * FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2) and NormativNaziv is null
		END
	   
	   --drop table mat
			
END
