-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[getMomentalnaZalihaNaArtikal] 
(
	-- Add the parameters for the function here
	@tblArtikalID DECIMAL(18,2)
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result DECIMAL(18,2)

   ;WITH Zaliha_Cte (tblArtikalID,Vlez,Izlez)
	AS
	(
	   SELECT tblArtikalID,Vlez,Izlez FROM dbo.tblZalihaNaArtikli WHERE tblArtikalID = @tblArtikalID
	)
	-- Define the outer query referencing the CTE name.
	SELECT @Result = SUM(Vlez - Izlez)  FROM Zaliha_Cte GROUP BY Zaliha_Cte.tblArtikalID

	-- Return the result of the function
	RETURN @Result

END