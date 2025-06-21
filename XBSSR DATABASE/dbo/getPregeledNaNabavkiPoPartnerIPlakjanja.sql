  
-- =============================================    
-- Author:  Spiro    
-- Create date:     
-- Description:     
  
-- exec getPregeledNaNabavkiPoPartnerIPlakjanja 164,'2016-07-22 19:29:50.457','2017-07-22 19:29:50.457'  
-- =============================================    
CREATE PROCEDURE [dbo].[getPregeledNaNabavkiPoPartnerIPlakjanja]     
 -- Add the parameters for the stored procedure here    
 @tblPartnerID INT,    
 @DatumOd DATE,    
 @DatumDO DATE    
AS    
BEGIN    
 -- SET NOCOUNT ON added to prevent extra result sets from    
 -- interfering with SELECT statements.    
 SET NOCOUNT ON;    
    
 ;WITH PartnerCTE(  TipNaDokument,ID, RedenBroj, DatumNaDokument, BrojNaDokument,IznosNaDokument,PlatenoZaDokument, PartnerID )    
 AS (    
   SELECT A.TipNaDokument,A.ID,a.RedenBroj,a.Datum,A.BrojNaDokument,a.IznosSoDDV,    
  ISNULL((CASE WHEN Izv.TipNaDokument = 1 THEN ISNULL(izv.Pobaruva,0)    
     WHEN Izv.TipNaDokument = 3 THEN ISNULL(izv.Dolzi,0)    
     END),0) AS Plateno, A.tblPartnerID    
   FROM     
  (    
   SELECT 3 AS TipNaDokument ,ID, 'PRIEM ' + CAST(PriemBroj AS NVARCHAR(10)) AS RedenBroj,CAST( DatumNaKreiranjeNaPriem AS DATE) AS Datum, ISNULL(IspratnicaFakturaBroj,'N/A') AS BrojNaDokument, IznosSoDDV,tblPartnerID FROM dbo.viewPriemi   
  WHERE tblPartnerID = @tblPartnerID AND DatumNaKreiranjeNaPriem BETWEEN @DatumOd AND @DatumDO    
   UNION ALL    
   SELECT 3 AS TipNaDokument,ID,  'DOC ' + CAST(Broj AS NVARCHAR(10)) AS RedenBroj, Datum, ISNULL(BrojNaDokument,'N/A') AS BrojNaDokument, IznosSoDDV,tblPartnerID FROM dbo.viewDokumenti   
   WHERE tblPartnerID = @tblPartnerID AND Datum BETWEEN @DatumOd AND @DatumDO    
  ) AS A    
    
  left  JOIN dbo.viewIzvodiStavki izv ON izv.DokumentID = A.ID AND a.TipNaDokument = izv.TipNaDokument AND izv.PartnerID = A.tblPartnerID  )    
    
SELECT A. *,(CASE WHEN ROUND(A.IznosNaDokument,0) <> ROUND(A.PlatenoZaDokument,0) THEN '0' ELSE '1' END) AS ZatvorenDokument  FROM  
 (SELECT PartnerCTE.ID,PartnerCTE.RedenBroj,PartnerCTE.DatumNaDokument,PartnerCTE.BrojNaDokument,ROUND(PartnerCTE.IznosNaDokument,0) AS IznosNaDokument,  
 ROUND(SUM(PartnerCTE.PlatenoZaDokument),0) AS  PlatenoZaDokument FROM PartnerCTE  
 GROUP BY PartnerCTE.ID,PartnerCTE.RedenBroj,PartnerCTE.DatumNaDokument,PartnerCTE.BrojNaDokument,PartnerCTE.IznosNaDokument) AS A  
  
 ORDER BY A.RedenBroj  
  
      
    
    
    
    
    
END