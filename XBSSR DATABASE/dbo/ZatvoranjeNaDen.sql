-- =============================================
-- Author:		spiro
-- Create date: 29.09.2014
-- Description:	vraca suma od promet i fiskalna
-- =============================================
create FUNCTION [dbo].[ZatvoranjeNaDen] 
(	
	-- Add the parameters for the function here
	@DatumPocetok date 
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	Select SUM(VkupenPromet) as IznosOdSmetki, SUM(VkupnoFiskalna) as IznosFiskalna from KontrolaNaSmetka Where
	CAST(DatumPocetok as DATE) =  @DatumPocetok
)