-- =============================================
-- Author:		Spiro
-- Create date: 10.07.2014
-- Description:	
-- =============================================
create FUNCTION [dbo].[DnevenPrometFiskalna] 
(
	-- Add the parameters for the function here
	@Datum datetime
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	-- Add the T-SQL statements to compute the return value here
	
	SELECT @Result = sum (Iznos) from tblFiskalniSmetki where cast (Datum as Date) = cast (@Datum as Date) and Stornirana = 0
	
	

	-- Return the result of the function
	RETURN isnull(@Result,0)

END
