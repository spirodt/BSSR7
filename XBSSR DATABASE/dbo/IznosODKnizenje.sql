-- =============================================
-- Author:		Spiro
-- Create date: 10.07.2014
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[IznosODKnizenje] 
(
	-- Add the parameters for the function here
	@ID int,
	@TipNaKnizenje int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	-- Add the T-SQL statements to compute the return value here
	
	IF(@TipNaKnizenje = 1 )
	BEGIN
		SELECT @Result = SUM(IznosSoDDV) from tblKnizenjeM where  (tblArtikalID = @ID and tipNaKnizenje  = 1) OR (tblArtikalID = @ID and tipNaKnizenje  = 2)
	END
	
	IF(@TipNaKnizenje = 3 )
	BEGIN
		SELECT @Result = SUM(IznosSoDDV) from tblKnizenjeM where  (tblArtikalID = @ID and tipNaKnizenje  = 3)
					    
	END
	

	-- Return the result of the function
	RETURN isnull(@Result,0)

END