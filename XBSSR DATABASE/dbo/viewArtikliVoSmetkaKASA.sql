
--select * from  viewArtikliVoSmetkaKASA order by SmetkaID desc 

CREATE VIEW [dbo].[viewArtikliVoSmetkaKASA]
AS
Select    ArtikalID,Sifra,Sifra2,Naziv,Kolicina,Rabat,ProdaznaCena,isnull(MkProizvod,'false') as MkProizvod,CenaSoRabatIddv as CenaSoRabatIddv,
		CenaBezDDV as CenaBezDDV,DDVProcent,PresmetanDDV as PresmetanDDV,Iznos as Iznos, IznosBezDDV as IznosBezDDV, NalogID,Tip,Zabeleska,SmetkaID,Danok
		from viewArtikliVoSmetkaKASAbezZaokruzuenje
