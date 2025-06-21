CREATE FUNCTION [dbo].[ProdazbaOdSmetki]     
(     
 -- Add the parameters for the function here    
 @DateStart datetime,     
 @DateEnd datetime    
)    
RETURNS TABLE     
AS  
RETURN     
(    
 --select * from viewArtikliVoSmetkaKASA 
 
SELECT  ArtikalID AS Artikal,
		 Sifra,
		 Naziv, 
		 SUM(Kolicina) as Kolicina, 
		 CenaBezDDV,
		 DDVProcent,
		 SUM(PresmetanDDV) as PresmetanDDV,
		 ProdaznaCena,
		 SUM(IznosBezDDV) as IznosBezDDV,
		 SUM(Iznos) as Iznos
        from viewArtikliVoSmetkaKASA where SmetkaID in (Select ID from tblSmetka where DatumPocetok BETWEEN @DateStart and @DateEnd) 
		group by ArtikalID, Sifra, Naziv, CenaBezDDV, DDVProcent, ProdaznaCena
)  