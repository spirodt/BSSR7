
-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[PartnerOdPriemPosledenArtikal] 
(
	-- Add the parameters for the function here
	@tblArtikalID int
)
RETURNS nvarchar(max)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(max)

	-- Add the T-SQL statements to compute the return value here
	SELECT top 1 @Result = tblPartneri.Naziv from tblPriemStavki
left outer join tblPriem on tblPriem.ID = tblPriemStavki.tblPriemID
left outer join tblPartneri on tblPartneri.ID = tblPriem.tblPartnerID
where tblPriemStavki.tblArtikalID = @tblArtikalID and tblPriem.PriemBroj <> 12 
order by tblPriemStavki.ID desc


	-- Return the result of the function
	RETURN @Result

END

