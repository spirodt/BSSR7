﻿-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	31.08.2014
-- =============================================
CREATE FUNCTION [dbo].[IznosOdNalozi]
(
	-- Add the parameters for the function here
	@tblSmetkaID int
)
RETURNS decimal(18,2)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result decimal(18,2)

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = SUM(Suma) from NaloziPregled where SmetkaID = @tblSmetkaID 
	
	-- Return the result of the function
	RETURN @Result

END