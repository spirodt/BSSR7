-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[NajdiMinMaxOdPregledNaSmetki]()
RETURNS 
@Table_result TABLE 
(
	MinPresmetkovna NVARCHAR(20),
	MaxPresmetkovna NVARCHAR(20),
	MinPartner NVARCHAR(20),
	MaxPartner NVARCHAR(20)
)
AS
BEGIN
	
	DECLARE @MinPresmetkovna NVARCHAR(20)
	DECLARE @MaxPresmetkovna NVARCHAR(20)
	DECLARE @MinPartner NVARCHAR(20)
	DECLARE @MaxPartner NVARCHAR(20)


	SELECT TOP 1 @MinPresmetkovna = Sifra FROM dbo.tblPresmetkovniEdinici ORDER BY 1 ASC
	SELECT TOP 1 @MaxPresmetkovna = Sifra FROM dbo.tblPresmetkovniEdinici ORDER BY 1 DESC
	SELECT TOP 1 @MinPartner = Sifra FROM dbo.tblPartneri ORDER BY 1 ASC
	SELECT TOP 1 @MaxPartner = Sifra FROM dbo.tblPartneri ORDER BY 1 DESC

		INSERT INTO @Table_result
	(
	    MinPresmetkovna,
	    MaxPresmetkovna,
	    MinPartner,
		MaxPartner
	)

	SELECT @MinPresmetkovna,@MaxPresmetkovna,@MinPartner,@MaxPartner

	
	RETURN 
END