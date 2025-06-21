-- =============================================  
-- Author:  <Author,,Name>  
-- ALTER date: <ALTER Date,,>  
-- Description: <Description,,>  
--Declare @DatumPocetok datetime = CONVERT(datetime,'2022-08-01')  
--Declare @DatumKraj datetime =  CONVERT(datetime,'2022-08-27')  
--Declare @FirmaID int = 1  
--Declare @ObjektID int = 1  
--exec PotroseniMaterijaliZaPeriodGrupirani @DatumPocetok, @DatumKraj,@FirmaID,@ObjektID ,0  
-- =============================================  
Create PROCEDURE [dbo].[PotroseniMaterijaliZaPeriodGrupirani] (  
   @DatumPocetok datetime,  
   @DatumKraj datetime,  
   @FirmaID int = 1,  
   @ObjektID int = 1,  
   @SamoFiskalNa bit   
)  
AS  
BEGIN  
  if(@SamoFiskalNa = 1)   
  BEGIN  
   SELECT  
   Naziv,
   SUM(KolicinaIzlez) KolicinaIzlez,
   EdinecnaMerkaIzlez,
   AVG(NabavnaCena) NabavnaCena,
    SUM(IznosBezDDV) IznosBezDDV,
	SUM(IznosDDV) IznosDDV,
	SUM(IznosSoDDV) IznosSoDDV,
	DDVStapka,
	Kratenka,
	AVG(ProdaznaCena) ProdaznaCena
	FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2)  and OtpecatenaFiskalna = 1 and NormativNaziv is null  
	 Group by Naziv, EdinecnaMerkaIzlez, DDVStapka,Kratenka, tipNaKnizenje
  END  
  ELSE  
  BEGIN  
   SELECT 
   Naziv,
   SUM(KolicinaIzlez) KolicinaIzlez,
   EdinecnaMerkaIzlez,
   AVG(NabavnaCena) NabavnaCena,
    SUM(IznosBezDDV) IznosBezDDV,
	SUM(IznosDDV) IznosDDV,
	SUM(IznosSoDDV) IznosSoDDV,
	DDVStapka,
	Kratenka,
	AVG(ProdaznaCena) ProdaznaCena
 FROM viewZaliha WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and (tipNaKnizenje = 1 or tipNaKnizenje = 2) and NormativNaziv is null
 Group by Naziv, EdinecnaMerkaIzlez, DDVStapka,Kratenka, tipNaKnizenje

  END  
END  
  
  
