CREATE FUNCTION [dbo].[SiteSmetkiZaPresmetkovnaEdinica]   
(   
 -- Add the parameters for the function here  
 @StartDate DATETIME,   
 @EndDate DATETIME,  
 @PresMin NVARCHAR(MAX),  
 @PresMax NVARCHAR(MAX)    
)  
RETURNS TABLE   
AS  
RETURN   
(   
 SELECT pre.Naziv as PresmetkovnaEdinica, 
 pre.Sifra PresmetkovnaEdicniSifra,
 p.Naziv as Partner,
 p.EDB,
 p.Sifra,
 isnull(SUM(viewArtikliVoSmetkaKASAbezZaokruzuenje.Iznos),0) as Iznos,
 isnull(SUM(viewArtikliVoSmetkaKASAbezZaokruzuenje.IznosBezDDV),0) as IznosBezDDV,
 isnull(SUM(viewArtikliVoSmetkaKASAbezZaokruzuenje.PresmetanDDV),0) as PresmetanDDV,
 viewArtikliVoSmetkaKASAbezZaokruzuenje.DDVprocent,
 viewArtikliVoSmetkaKASAbezZaokruzuenje.Danok
 FROM viewArtikliVoSmetkaKASAbezZaokruzuenje
 LEFT JOIN dbo.tblSmetka s ON viewArtikliVoSmetkaKASAbezZaokruzuenje.SmetkaID = s.ID   
 LEFT JOIN dbo.tblPartneri p ON p.ID = s.tblPartnerID   
 LEFT JOIN dbo.tblPresmetkovniEdinici pre ON pre.ID = p.tblPresmetkovnaEdinicaID
 WHERE (p.tblPresmetkovnaEdinicaID IN ( SELECT ID FROM dbo.tblPresmetkovniEdinici WHERE CAST(Sifra AS int) BETWEEN @PresMin AND @PresMax) )
       AND s.DatumPocetok BETWEEN @StartDate AND @EndDate 
   GROUP BY pre.Naziv, p.Naziv, viewArtikliVoSmetkaKASAbezZaokruzuenje.DDVprocent,viewArtikliVoSmetkaKASAbezZaokruzuenje.Danok,pre.Sifra,p.EDB,p.Sifra
 --ORDER BY pre.Naziv,p.Naziv,  viewArtikliVoSmetkaKASAbezZaokruzuenje.Danok
)