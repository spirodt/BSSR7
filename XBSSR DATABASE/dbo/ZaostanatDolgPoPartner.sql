CREATE PROCEDURE [dbo].[ZaostanatDolgPoPartner]   
    @SifraPartner Nvarchar(30)  
AS  
-- exec  [dbo].[ZaostanatDolgPoPartner] '10-092'  
BEGIN  
select isnuLL(SUM((Saldo * -1)),0) as ZaostanatDolg from SaldoNaPartneriSoAnalitka  
where Sifra = @SifraPartner AND  Saldo <0  
AND convert(date,DatumNaValuta,23) < convert(date,getDate(),23)  
AND BrojNaDokument LIKE '1-%'
END