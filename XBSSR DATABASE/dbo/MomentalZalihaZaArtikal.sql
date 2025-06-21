-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[MomentalZalihaZaArtikal] 
(
	-- Add the parameters for the function here
	@tblArtikalID int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int
	select @Result = isnull(PreostanataKolicina,0) from viewPopis where tblArtikalID = @tblArtikalID
	RETURN @Result

END
