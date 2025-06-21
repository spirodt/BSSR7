-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[KontrolaNaSmetkaPoID]
(
	@tblSmetkaID int
)
RETURNS TABLE 
AS
RETURN 
(
  select * from KontrolaNaSmetka where SmetkaID = @tblSmetkaID
)