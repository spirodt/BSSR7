-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- exec StavkiVoSmetkaTouch 4055
-- =============================================
CREATE PROCEDURE [dbo].[StavkiVoSmetkaTouch] (
	 @SmetkaID int
)
AS
BEGIN
		select Naziv, Kolicina, Iznos , ProdaznaCena, Sifra, NalogID, ArtikalID as Artikal, Tip, Zabeleska  from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID
			
END