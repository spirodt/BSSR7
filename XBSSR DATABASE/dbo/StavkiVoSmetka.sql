CREATE PROCEDURE [dbo].[StavkiVoSmetka] (  
  @SmetkaID int  
)  
AS  
BEGIN  
  select Naziv,SUM(Kolicina)as Kolicina,SUM(Iznos) as Iznos,ProdaznaCena,Sifra,0 as NalogID,Naziv,Tip,ArtikalID as Artikal,Sifra2,Rabat,MkProizvod,  
     CenaSoRabatIddv,CenaBezDDV,DDVProcent,SUM(PresmetanDDV)as PresmetanDDV,SUM(IznosBezDDV)AS IznosBezDDV ,' ' as Zabeleska ,SmetkaID,Danok  
    from viewArtikliVoSmetkaKASA  
    where SmetkaID = @SmetkaID  
    Group by Naziv,ProdaznaCena,Sifra,Naziv,Tip,ArtikalID,Sifra2,Rabat,MkProizvod,  
     CenaSoRabatIddv,CenaBezDDV,DDVProcent,SmetkaID,Danok  
	 ORDER BY viewArtikliVoSmetkaKASA.Naziv
END
