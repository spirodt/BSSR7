-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[BrojNaFakturaSporedPartner] 
(
	-- Add the parameters for the function here
	@PartnerID int,
	@FakturaID int
)
RETURNS nvarchar(50)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result nvarchar(50)
	DECLARE @BrojSreden nvarchar(50)
	
	Select @BrojSreden = A.Broj from (select ID, CAST( ROW_NUMBER() OVER( PARTITION BY  tblPartnerID ORDER BY tblpartnerID DESC) as nvarchar(10)) as Broj
	from tblFaktura where tblPartnerID = @PartnerID 
	Group by ID, tblPartnerID ) as A where A.ID = @FakturaID
	
	
		
	Select @Result = CAST(Broj as nvarchar(10)) + ' / ' + SifraPartner 
	+ ' / ' +  @BrojSreden from viewFakturi
	where tblPartnerID = @PartnerID and ID = @FakturaID
	Group By SifraPartner, Broj 
	
	
	-- Return the result of the function
	RETURN @Result 

END
