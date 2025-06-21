-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- exec StavkiVoNalog 7
-- =============================================
CREATE PROCEDURE [dbo].[StavkiVoNalogKasa] (
	 @NalogID int
)
AS
BEGIN

select * from viewArtikliVoSmetkaKASA where NalogID = @NalogID
--Select  ArtikliNalog.Artikal as ArtikalID, ArtikliNalog.Sifra,ArtikliNalog.Sifra2 ,
--        ArtikliNalog.Naziv, ArtikliNalog.Kolicina, ArtikliNalog.Rabat,
--        ArtikliNalog.ProdaznaCena as ProdaznaCena,
--        ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat )  as CenaSoRabatIddv,
--        (ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat ) ) / (( 1 + DDV.Procent / 100)) as CenaBezDDV,
--        DDV.Procent as DDVProcent,
--        (ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat ) - (ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat ) ) / (( 1 + DDV.Procent / 100)) ) as PresmetanDDV,
--        (ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat)) * ArtikliNalog.Kolicina as Iznos,
--        (ArtikliNalog.ProdaznaCena - ( (ArtikliNalog.ProdaznaCena  / 100) * ArtikliNalog.Rabat ) ) / (( 1 + DDV.Procent / 100)) * ArtikliNalog.Kolicina as IznosBezDDV,
--        ArtikliNalog.NalogID ,ArtikliNalog.Tip, Nal.Zabeleska 
--  from (
--  select NS.tblNalogID as NalogID ,SUM(NS.Kolicina) as Kolicina ,A.ID as Artikal, isnull(NS.Rabat1,0) AS Rabat, a.Sifra, A.AltSifra as Sifra2 ,A.Naziv,A.ProdaznaCena ,A.ProdaznaCena * SUM(NS.Kolicina) as Iznos, 0 as Tip, A.tblDDVStavkaID as DDVID
--		from tblNalogStavki NS
--		left outer join tblArtikal A on A.ID = NS.tblArtikalID
--		Where NS.tblNalogID = @NalogID and NS.tblArtikalID is not null
--		Group by NS.tblNalogID,A.ID, a.Sifra ,A.Naziv, A.ProdaznaCena, A.tblDDVStavkaID, NS.Rabat1, A.AltSifra
--		UNION ALL
--		select NS.tblNalogID as NalogID, SUM(NS.Kolicina) as Kolicina ,N.ID as Artikal,isnull(NS.Rabat1,0) AS Rabat, N.Sifra,'' as Sifra2,N.Naziv,N.Cena,N.Cena * SUM(NS.Kolicina) as Iznos, 1 as Tip, N.tblDDVStavkaID as DDVID from tblNalogStavki NS
--		left outer join tblNormativ N on N.ID = NS.tblNomativID
--		Where NS.tblNalogID = @NalogID and NS.tblNomativID is not null
--		Group by NS.tblNalogID ,N.ID, N.Sifra ,N.Naziv, N.Cena, N.tblDDVStavkaID, NS.Rabat1
--		) as ArtikliNalog
--		left outer join tblNalog Nal on Nal.ID = ArtikliNalog.NalogID and Nal.ID = @NalogId
--		left outer join tblDDVStavka DDV on DDV.ID = ArtikliNalog.DDVID
		
		
			
END