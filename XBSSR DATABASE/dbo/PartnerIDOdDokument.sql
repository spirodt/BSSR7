
-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
create FUNCTION [dbo].[PartnerIDOdDokument] 
(
	-- Add the parameters for the function here
	@BrojNaDokument int,
	@TipNaDokument int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int

	if(@TipNaDokument = 1)
	BEGIN
		select @Result = tblPartnerID from tblSmetka where Broj = @BrojNaDokument
		RETURN @Result
	END

	if(@TipNaDokument = 2)
	BEGIN
		select @Result = tblPartnerID from tblFaktura where Broj = @BrojNaDokument
		RETURN @Result
	END
	
	if(@TipNaDokument = 3)
	BEGIN
		select @Result = tblPartnerID from tblPriem where PriemBroj = @BrojNaDokument
		RETURN @Result
	END
	-- Return the result of the function
		select @Result = tblPartnerID from tblDokumenti where Broj = @BrojNaDokument
		RETURN @Result

END

