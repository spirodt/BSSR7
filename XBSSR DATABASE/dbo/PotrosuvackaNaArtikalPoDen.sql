-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[PotrosuvackaNaArtikalPoDen](  
 @startDate DATETIME,   
 @endDate DATETIME  
 )  
AS  
BEGIN  
   
 IF 1=0 BEGIN  
  SET FMTONLY OFF  
 END  
  
BEGIN TRANSACTION Trans1  
DEclare @DatumZaObratotka date  
  
 DEclare @Den date  
 DEclare @ArtikalID int  
 DEclare @Kolicina decimal(18,2)  
 DEclare @Iznos decimal(18,2)  
 Declare @ProdaznaCenaSoRabat  decimal(18,2)  
  
Create table #DnevenPromet (  
 Den date,  
 ArtikalID int,  
 Kolicina decimal(18,2),   
 Iznos decimal(18,2),  
 ProdaznaCenaSoRabat decimal(18,2)  
)  
;WITH Calender AS   
(  
    SELECT @startDate AS CalanderDate  
    UNION ALL  
    SELECT CalanderDate + 1 FROM Calender  
    WHERE CalanderDate + 1 <= @endDate  
)  
SELECT * into #CalendarFromTo FROM Calender   
OPTION (MAXRECURSION 10000)  
DECLARE ET_CURSOS Cursor for select CAST(CalanderDate as DATE) from #CalendarFromTo  
OPEN ET_CURSOS  
FETCH NEXT FROM ET_CURSOS into @DatumZaObratotka  
 WHILE @@FETCH_STATUS = 0  
  BEGIN  
    
     DECLARE KNI_CURSOR Cursor for select tblArtikalID, isnull(SUM(Kolicina),0) as Kolicina, isnull(SUM(IznosSoDDV),0) as Iznos, ProdaznaCenaSoRabat as ProdaznaCenaSoRabat from viewKnzienjaM where CAST(DatumNaPocetok as DATE) = @DatumZaObratotka and ((tipNaKnizenje = 1) OR (tipNaKnizenje = 2)) GROUP BY tblArtikalID , ProdaznaCenaSoRabat   
   OPEN KNI_CURSOR  
   FETCH NEXT FROM KNI_CURSOR into @ArtikalID, @Kolicina, @Iznos,@ProdaznaCenaSoRabat   
    WHILE @@FETCH_STATUS = 0  
     BEGIN  
      INSERT INTO #DnevenPromet VALUES( @DatumZaObratotka, @ArtikalID, @Kolicina, @Iznos, @ProdaznaCenaSoRabat)    
      FETCH NEXT FROM KNI_CURSOR into @ArtikalID, @Kolicina, @Iznos,@ProdaznaCenaSoRabat  
     END  
       
   CLOSE KNI_CURSOR;  
   DEALLOCATE KNI_CURSOR;       
     
     
   FETCH NEXT FROM ET_CURSOS into @DatumZaObratotka  
  END  
CLOSE ET_CURSOS;  
DEALLOCATE ET_CURSOS;   
  
select d.Den,A.Sifra, a.AltSifra, a.Naziv as Artikal, d.ProdaznaCenaSoRabat as ProdaznaCena, d.ArtikalID, d.Kolicina, d.Iznos as Vrednost from #DnevenPromet d  
left outer join tblArtikal a on d.ArtikalID = a.ID  
select * from #CalendarFromTo  
drop table #CalendarFromTo  
drop table #DnevenPromet  
  
  
COMMIT TRANSACTION Trans1  
  
END  