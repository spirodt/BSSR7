-- =============================================
-- Author:		Spiro
-- Create date: 10.07.2014
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[IznosFiskalna] 
(
	-- Add the parameters for the function here
	@ID int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	-- Add the T-SQL statements to compute the return value here
	
	SELECT @Result = Iznos from tblFiskalniSmetki where  tblSmetkaID = @ID and Stornirana = 0
	

	-- Return the result of the function
	RETURN isnull(@Result,0)

END