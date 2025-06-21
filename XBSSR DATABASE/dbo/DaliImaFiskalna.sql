-- =============================================
-- Author:		Spiro
-- Create date: 10.07.2014
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[DaliImaFiskalna] 
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
	IF @ID is null 
	BEGIN
		set @Result = 0
	END
	
	SELECT @Result =ID from tblFiskalniSmetki where  tblSmetkaID = @ID and Stornirana = 0
	
	IF @Result is null
		BEGIN
			set @Result = 1
		END
	ELSE
		BEGIN
			set @Result = 2
		END
	
	RETURN @Result
END