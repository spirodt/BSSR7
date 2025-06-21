-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[KontrolNaSmetkiPoDatum] 
(
	-- Add the parameters for the function here
	@DatumOD datetime, 
	@DatumDo datetime
)
RETURNS TABLE 
AS
RETURN 
(
  select * from KontrolaNaSmetka where DatumPocetok between	 @DatumOD and @DatumDo
)