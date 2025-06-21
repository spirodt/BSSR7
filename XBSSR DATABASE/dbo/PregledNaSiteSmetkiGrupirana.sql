CREATE FUNCTION [dbo].[PregledNaSiteSmetkiGrupirana]  
(  
  @PresMin NVARCHAR(MAX),  
  @PresMax NVARCHAR(MAX),  
  @PartMin NVARCHAR(MAX),  
  @PartMax NVARCHAR(MAX),  
  @StartDate DATETIME,  
  @EndDate DATETIME,  
  @tblObjektId INT   
)  
RETURNS   
@Table_result TABLE   
(  
 PresmetkovnaEdinica NVARCHAR(MAX),   
 Partner NVARCHAR(MAX),  
 EDB NVARCHAR(MAX),  
 Iznos DECIMAL(18,2),  
 DatumPocetok DATETIME,  
 Rezultat NVARCHAR(50)  
)  
AS  
BEGIN  
  
 --SELECT * FROM dbo.PregledNaSiteSmetki(101,891,01948,99999,'2019-12-25 00:00:00.080','2019-12-25 23:59:59.080',1)  
  
 INSERT INTO @Table_result  
 (  
     PresmetkovnaEdinica,  
     Partner,  
  EDB,  
     Iznos,  
  DatumPocetok,  
  Rezultat  
 )  
   
  SELECT PresmetkovnaEdinica,  
  p.Naziv AS Partner,  
  p.EDB,  
  ISNULL(CAST(ROUND(SUM(Iznos),0) AS DECIMAL(18,2)),0) AS Iznos,  
  @StartDate AS Datum,  
  '' as Rezultat  
  FROM dbo.viewSmetki  
  LEFT JOIN dbo.tblPartneri p ON p.ID = tblPartnerID   
  WHERE  
  dbo.viewSmetki.ObjektID IN (SELECT id FROM dbo.tblObjekti WHERE Id = @tblObjektId) AND  
  (   
   (PresmetkovnaEdinicaId IN ( SELECT ID FROM dbo.tblPresmetkovniEdinici WHERE CAST(Sifra AS int) BETWEEN @PresMin AND @PresMax) )   
   AND   
   (tblPartnerID IN (SELECT ID FROM dbo.tblPartneri WHERE CAST(Sifra AS int) BETWEEN @PartMin AND @PartMax) )  
   AND (DatumPocetok BETWEEN @StartDate AND @EndDate )  
  )  
  AND Iznos IS NOT NULL  
    
   
    
 GROUP BY p.Naziv,PresmetkovnaEdinica,EDB  
 ORDER BY PresmetkovnaEdinica  
  
  
 RETURN   
END