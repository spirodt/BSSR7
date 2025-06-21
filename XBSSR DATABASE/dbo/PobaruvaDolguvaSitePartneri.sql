--exec PobaruvaDolguvaSitePartneri '2023-01-27 18:12:44.083', '2023-05-27 18:12:44.083'
CREATE  PROCEDURE [dbo].[PobaruvaDolguvaSitePartneri] (  
      @DatumPocetok datetime,  
   @DatumKraj datetime  
     
)  
AS  
BEGIN  
  Declare @Sifra nvarchar(5)   
  Declare @Naziv nvarchar(100)  
 --TBL PLACANJA OD PARTNER  
SELECT P.Sifra, P.Naziv, SUM(C.Dolzi) as Dolzi,SUM(C.Pobaruva) as Pobaruva, C.PartnerID, SUM(Pobaruva-Dolzi) as Saldo   
from (  
		SELECT SUM(A.Dolzi) as Dolzi, SUM(A.Pobaruva) as Pobaruva, A.PartnerID FROM  
		( SELECT SUM(Dolzi) as Dolzi, SUM(Pobaruva) as Pobaruva, PartnerID FROM viewIzvodiStavki   
		 WHERE  Dolzi > 0 and DatumNaIzvod Between @DatumPocetok and @DatumKraj  
		 GROUP BY PartnerID  
		 UNION ALL  
		 SELECT ROUND(SUM(Dolzi),0) as Dolzi, ROUND(SUM(Pobaruva),0) as Pobaruva, PartnerID FROM viewIzvodiStavki   
		 WHERE  Pobaruva > 0  and DatumNaIzvod Between @DatumPocetok and @DatumKraj  
		 GROUP BY PartnerID)  as A GROUP BY A.PartnerID  
		UNION ALL  
		SELECT ROUND(SUM(B.Dolzi),0) As Dolzi, ROUND(SUM(B.Pobaruva),0) as Pobaruva, B.tblPartnerID FROM  
		(SELECT 0 as Dolzi, SUM(IznosSoDDV) as Pobaruva, tblPartnerID FROM viewKnzienjaM   
		WHERE (tipNaKnizenje = 2 ) and fakturaBroj is not null and  tblPartnerID is not null and DatumNaKnizenje Between @DatumPocetok and @DatumKraj  
		Group by tblPartnerID  
		UNION ALL   
		SELECT ROUND(SUM(IznosSoDDV),0) as Dolzi,  0 as Pobaruva, tblPartnerID  FROM viewKnzienjaM   
		WHERE (tipNaKnizenje = 2 OR tipNaKnizenje = 1) and DokumentBroj is not null and tblPartnerID is not null and DatumNaKnizenje Between @DatumPocetok and @DatumKraj  
		Group by DatumNaKnizenje,tblPartnerID  
		UNION ALL   
		SELECT ROUND(SUM(IznosSoDDV),0) as Dolzi, 0 as Pobaruva, tblPartnerID  FROM viewKnzienjaM  
		WHERE (tipNaKnizenje = 3) and tblPartnerID is not null and DatumNaKnizenje Between @DatumPocetok and @DatumKraj  
		Group by DatumNaKnizenje,tblPartnerID  
		UNION ALL   
		SELECT ROUND(SUM(IznosSoDDV),0) as Dolzi, 0 as Pobaruva, tblPartnerID  FROM viewKnzienjaM  
		WHERE (tipNaKnizenje = 3) and DokumentBroj is not null and tblPartnerID is not null and DatumNaKnizenje Between @DatumPocetok and @DatumKraj  
		Group by DatumNaKnizenje,tblPartnerID) as B group by B.tblPartnerID 
		) as C
		
left outer join tblPartneri P on C.PartnerID = P.ID
Group By c.PartnerID, p.Sifra, P.Naziv
Order by c.PartnerID

  
END
