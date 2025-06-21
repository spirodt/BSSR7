-- =============================================  
-- Author:  spiro  
-- Create date:   
-- Description:   
-- =============================================  
CREATE FUNCTION [dbo].[SaldoPoPartner]   
(   
 -- Add the parameters for the function here  
 @tblPartnerID int,
 @DoDatum DateTime
)  
RETURNS TABLE   
AS  
RETURN   
(  
 Select top 10000000  
 ROW_NUMBER() OVER(ORDER BY doc.ID asc) AS ID,  
 doc.SifraPartner as Sifra,  
 doc.BrojNaDokument + N' oд датум: '+ FORMAT(doc.Datum,'dd.MM.yyyy') + N' со валута ' + FORMAT(doc.DatumNaValuta,'dd.MM.yyyy') as Datum,
 ROUND(IznosSoDDV,0) as IznosSoDDV,  
 ROUND(isnull(dbo.PlatenoZaDokument(@tblPartnerID,doc.ID,doc.broj),0),0) as Plateno,  
 (ROUND(isnull(dbo.PlatenoZaDokument(@tblPartnerID,doc.ID,doc.broj),0),0) - ROUND(IznosSoDDV,0)) as Saldo,  
 '' as TipNaDostava,  
 0 as SaldoDolzi,  
 0 as SaldoPobaruva,  
 0 AS SaldoSve,
 3 as TipNaRed,
 CASE WHEN LEN(doc.Notes) > 0 THEN ' - ' + doc.Notes ELSE '' END as Zabeleski  
 from viewDokumenti doc  
 left join tblPartneri p on doc.tblPartnerID = p.ID  
 where doc.tblPartnerID = @tblPartnerID  and convert(date,DatumNaValuta,23) < convert(date,@DoDatum,23)
   
 order by doc.ID  
)
GO
