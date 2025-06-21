-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
--exec StavkiVoNalog 1865
--exec StavkiVoNalogKasa 1865
-- =============================================
CREATE PROCEDURE [dbo].[StavkiVoNalog] (
	 @NalogID int
)
AS
BEGIN

		Select  ArtikliNalog.Naziv, ArtikliNalog.Kolicina, ArtikliNalog.Iznos, ArtikliNalog.CenaSoRabatIddv as ProdaznaCena, ArtikliNalog.Sifra, ArtikliNalog.NalogID,
		ArtikliNalog.ArtikalID as Artikal,ArtikliNalog.Tip,
		ArtikliNalog.Zabeleska
  from ( select * from viewArtikliVoSmetkaKASA where NalogID = @NalogID ) as ArtikliNalog
  
  			
END
