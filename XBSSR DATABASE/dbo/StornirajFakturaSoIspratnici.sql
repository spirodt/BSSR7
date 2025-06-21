-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
--exec StornirajFakturaSoIspratnici 63,2,7
-- =============================================
CREATE PROCEDURE [dbo].[StornirajFakturaSoIspratnici] 
	-- Add the parameters for the stored procedure here
	@FakturaID int, 
	@TipNaDokumentSeKnizi int,
	@TipNaDokumentNeSeKnizi int
AS
BEGIN
     delete from tblKnizenjeM where tblFakturaID = @FakturaID
     if(ISNULL( (Select ListaNaIspratnici from tblFaktura where ID = @FakturaID),'') <> '')
     BEGIN
		
		Declare @ListaSoIspratini  nvarchar(max)
	    select @ListaSoIspratini = REPLACE(ListaNaIspratnici,';',',') from tblFaktura where ID = @FakturaID
	    update tblDokumenti set TipNaDokument = @TipNaDokumentSeKnizi where Broj  in ( CAST(@ListaSoIspratini as nvarchar(max))) AND TipNaDokument =  @TipNaDokumentNeSeKnizi
	
     END
	
	
END
