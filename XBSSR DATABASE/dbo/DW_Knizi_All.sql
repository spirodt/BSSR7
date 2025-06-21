CREATE PROCEDURE [dbo].[DW_Knizi_All] 
	-- Add the parameters for the stored procedure here
	@UserID int = 0, 
	@FirmaID int = 0,
	@ObjektID INT = 0
AS
BEGIN
	DECLARE	@return_value int

		EXEC	@return_value = [dbo].[DW_ProkniziMaterijaliODFaktura_All]
				@FirmaID,
				@ObjektID,
				@UserID

		SELECT	'Return Value' = @return_value

		EXEC	@return_value = [dbo].[DW_ProkniziMaterijaliOdInterni_All]
				@FirmaID,
				@ObjektID,
				@UserID

		SELECT	'Return Value' = @return_value

		EXEC	@return_value = [DW_ProkniziMaterijaliODPriem_All]
				@FirmaID,
				@ObjektID,
				@UserID

		SELECT	'Return Value' = @return_value

		EXEC	@return_value = [dbo].[DW_ProkniziMaterijaliZaSmetka_All]
				@FirmaID,
				@ObjektID,
				@UserID

		SELECT	'Return Value' = @return_value

END

/****** Object:  StoredProcedure [dbo].[getPregeledNaNabavkiPoPartnerIPlakjanja]    Script Date: 09/09/2017 2:29:21 PM ******/
SET ANSI_NULLS ON