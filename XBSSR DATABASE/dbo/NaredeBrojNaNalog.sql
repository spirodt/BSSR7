-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
--   Select dbo.NaredeBrojNaNalog() as Broj
-- =============================================
CREATE FUNCTION [dbo].[NaredeBrojNaNalog]()

RETURNS  int
AS
BEGIN
    Declare @Result int = 0
	Select @Result = broj from tblNalog where ID = (Select MAX(ID) from tblNalog)
	set @Result = @Result + 1
	Return @Result
END
