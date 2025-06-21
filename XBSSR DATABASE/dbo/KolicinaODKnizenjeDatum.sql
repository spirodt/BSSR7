
-- =============================================
-- Author:		Spiro
-- Create date: 10.07.2014
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[KolicinaODKnizenjeDatum] 
(
	-- Add the parameters for the function here
	@ID int,
	@TipNaKnizenje int,
	@DatumPocetok datetime,
	@DatumKraj datetime
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	-- Add the T-SQL statements to compute the return value here
	
	IF(@TipNaKnizenje = 1 )
	BEGIN
		SELECT @Result = SUM(Kolicina) from tblKnizenjeM 
		where (DatumNaPocetok between @DatumPocetok and @DatumKraj) AND ((tblArtikalID = @ID and tipNaKnizenje  = 1) OR (tblArtikalID = @ID and tipNaKnizenje  = 2))
	END
	
	IF(@TipNaKnizenje = 3 )
	BEGIN
		SELECT @Result = SUM(Kolicina) from tblKnizenjeM 
		where(DatumNaPocetok between @DatumPocetok and @DatumKraj) and  (tblArtikalID = @ID and tipNaKnizenje  = 3)
					    
	END
	

	-- Return the result of the function
	RETURN isnull(@Result,0)

END
