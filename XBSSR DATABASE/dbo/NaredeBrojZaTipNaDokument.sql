-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
--   Select dbo.NaredeBrojNaSmetka() as Broj
-- =============================================
Create FUNCTION [dbo].[NaredeBrojZaTipNaDokument](
	@TipNaDokument int
)
RETURNS  int
AS
BEGIN
    Declare @Result int = 0
	Select @Result = broj from tblDokumenti where ID = (Select MAX(ID) from tblDokumenti where TipNaDokument = @TipNaDokument) and TipNaDokument = @TipNaDokument
	set @Result = @Result + 1
	Return @Result
END
