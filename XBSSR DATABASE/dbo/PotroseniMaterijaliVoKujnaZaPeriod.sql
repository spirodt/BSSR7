-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
--Declare @DatumPocetok datetime = getDate()
--Declare @DatumKraj datetime =  getDate()
--Declare @FirmaID int = 1
--Declare @ObjektID int = 1
--exec PotroseniMaterijaliVoKujnaZaPeriod @DatumPocetok, @DatumKraj,@FirmaID,@ObjektID 
--=============================================
CREATE  PROCEDURE [dbo].[PotroseniMaterijaliVoKujnaZaPeriod] (
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
			SELECT * FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2)  and OtpecatenaFiskalna = 1 and NormativNaziv is not null
		END
		ELSE
		BEGIN
			SELECT * FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2) and NormativNaziv is not null
		END

		
END
