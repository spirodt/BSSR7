-- =============================================
-- Author:		spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[prCenaSoRabat] 
(	
	-- Add the parameters for the function here
	@NabavnaCenaBezDDV decimal(18,2), 
	@SumaODRabat decimal(18,2)
)
RETURNS decimal(18,2) 
AS
BEGIN

    
	RETURN  @NabavnaCenaBezDDV - (@NabavnaCenaBezDDV / 100 * @SumaODRabat)
	
END
