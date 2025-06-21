-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[SiteSmetkiZaPartner] 
(	
	-- Add the parameters for the function here
	@StartDate DATETIME, 
	@EndDate DATETIME,
	@tblPartnerID INT
)
RETURNS TABLE 
AS
RETURN 
(	
	SELECT * FROM dbo.viewSmetki WHERE DatumPocetok BETWEEN @StartDate AND @EndDate AND tblPartnerID = @tblPartnerID
)