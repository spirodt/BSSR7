CREATE PROCEDURE [dbo].[StavkiZaFiskalNa] (    
  @SmetkaID int,    
  @SoPopust int,    
  @Popust decimal(18,2)    
)    
AS    
BEGIN    
      
  if(@SoPopust = 0)    
   BEGIN    
   select ArtikalID,SIFRA,MkProizvod,Naziv,
   CAST(CenaSoRabatIddv as decimal(18,2)) as CenaSoRabatIddv,
   isnull(SUM(Kolicina),0) as Kolicina,Danok from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID 
   GROUP BY ArtikalID,SIFRA,MkProizvod,Naziv,CenaSoRabatIddv,Danok
    ORDER BY Naziv    
   END    
  ELSE    
   BEGIN    
  select ArtikalID,SIFRA,MkProizvod,Naziv,
   CAST(CenaSoRabatIddv as decimal(18,2)) as CenaSoRabatIddv,
   isnull(SUM(Kolicina),0) as Kolicina,Danok from viewArtikliVoSmetkaKASA where SmetkaID = @SmetkaID 
   GROUP BY ArtikalID,SIFRA,MkProizvod,Naziv,CenaSoRabatIddv,Danok
    ORDER BY Naziv   
   END    
END
