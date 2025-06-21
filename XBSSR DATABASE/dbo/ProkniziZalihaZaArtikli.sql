-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[ProkniziZalihaZaArtikli] 
	-- Add the parameters for the stored procedure here
AS
BEGIN

	DECLARE @TipNaDokumentID INT = 16


	--Smetki 
INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT ArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, SmetkaID, @TipNaDokumentID 
		FROM dbo.viewArtikliVoSmetkaKASA 
		WHERE SmetkaID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID )
		GROUP BY ArtikalID, SmetkaID

	INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT tblArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, tblFakturaID, @TipNaDokumentID 
		FROM dbo.viewFakturiStavki 
		WHERE tblFakturaID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID )
		GROUP BY tblArtikalID, tblFakturaID


		SET @TipNaDokumentID = 17
	-- Priemi
INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT tblArtikalID,SUM(Kolicina) AS Vlez, 0 AS Izlez, tblPriemID, @TipNaDokumentID 
		FROM dbo.viewPriemStavki 
		WHERE tblPriemID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID )
		GROUP BY tblArtikalID, tblPriemID


		SET @TipNaDokumentID = 12

INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT ArtikalID,SUM(Kolicina) AS Vlez, 0 AS Izlez, tblDokumentID, @TipNaDokumentID 
		FROM dbo.viewDokumentiStavki 
		WHERE tblDokumentID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID )
		GROUP BY ArtikalID, tblDokumentID


		SET @TipNaDokumentID = 13

INSERT INTO [dbo].[tblZalihaNaArtikli]
           ([tblArtikalID]
           ,[Vlez]
           ,[Izlez]
           ,[IDNaDokument]
		   ,[TIpDokument])
		SELECT ArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, tblDokumentID, @TipNaDokumentID 
		FROM dbo.viewDokumentiStavki 
		WHERE tblDokumentID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID )
		GROUP BY ArtikalID, tblDokumentID


END