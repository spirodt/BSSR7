-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
--   Select dbo.NaredeBrojNaSmetka() as Broj
-- =============================================
CREATE FUNCTION [dbo].[NaredeBrojNaSmetka]()

RETURNS  int
AS
BEGIN
    Declare @Result int = 0
	Select @Result = broj from tblSmetka where ID = (Select MAX(ID) from tblSmetka)
	set @Result = @Result + 1
	Return @Result
END
