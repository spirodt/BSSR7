-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[IznosNaPlacanjaOdPartner] 
(
	-- Add the parameters for the function here
	@tblPartnerID int,
	@DatumPocetok datetime,
	@DatumKraj datetime,
	@UplataIsplata int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	if(@UplataIsplata = 0)
	BEGIN
		SELECT @Result = SUM(Pobaruva) from  viewIzvodiStavki where PartnerID = @tblPartnerID and DatumNaIzvod Between @DatumPocetok and @DatumKraj 
	END
	
	if(@UplataIsplata = 1)
	BEGIN
		SELECT @Result = SUM(Dolzi) from  viewIzvodiStavki where PartnerID = @tblPartnerID and DatumNaIzvod Between @DatumPocetok and @DatumKraj 
	END
		

	-- Return the result of the function
	RETURN @Result

END
