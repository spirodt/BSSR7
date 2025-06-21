-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
--   Select dbo.NaredeBrojNaSmetka() as Broj
-- =============================================
CREATE FUNCTION [dbo].[NaredenBrojNaFiskalna]()

RETURNS  int
AS
BEGIN
    Declare @Result int = 0
	Select @Result = Broj from tblFiskalniSmetki where ID = (Select MAX(ID) from tblFiskalniSmetki)
	set @Result = @Result + 1
	Return @Result
END
