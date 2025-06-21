-- =============================================
-- Author:		Spiro
-- Create date: 
-- Description:	
-- exec dbo.InsertArtikalAkoGoNema '55'
-- =============================================
CREATE PROCEDURE [dbo].[InsertArtikalAkoGoNema] 
	-- Add the parameters for the stored procedure here
	@Sifra nvarchar(max) = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	RETURN 0
INSERT INTO [dbo].[tblArtikal]
           ([Sifra]
           ,[Naziv]
           ,[tblDDVStavkaID]
           ,[PodgrupaID]
           ,[tblEdinecniMerkiID]
           ,[AltNaziv]
           ,[AltSifra]
           ,[KlucniZborovi]
           ,[NabavnaCena]
           ,[ProdaznaCena]
           ,[FirmaID]
           ,[Status]
           ,[EDMIzlez]
           ,[KolicinaT]
           ,[MinimalnaKolicinaNaZaliha]
           ,[RedenBroj]
           ,[Barkod1]
           ,[Barkod2]
           ,[AltNaziv2]
           ,[Image]
           ,[SePecatiVoKujna]
           ,[SePacatiNaSank]
           ,[DenoviZaGarancija]
           ,[DomasenProizvod]
           ,[CenaNaGolemo])
      select [Sifra]
           ,[Naziv]
           ,[tblDDVStavkaID]
           ,[PodgrupaID]
           ,[tblEdinecniMerkiID]
           ,[AltNaziv]
           ,[AltSifra]
           ,[KlucniZborovi]
           ,[NabavnaCena]
           ,[ProdaznaCena]
           ,[FirmaID]
           ,[Status]
           ,[EDMIzlez]
           ,[KolicinaT]
           ,[MinimalnaKolicinaNaZaliha]
           ,[RedenBroj]
           ,[Barkod1]
           ,[Barkod2]
           ,[AltNaziv2]
           ,[Image]
           ,[SePecatiVoKujna]
           ,[SePacatiNaSank]
           ,[DenoviZaGarancija]
           ,[DomasenProizvod]
           ,[CenaNaGolemo] from tblArtikal_NotUsed where Sifra = @Sifra 

		   delete from tblArtikal_NotUsed where Sifra LIKE @Sifra
END