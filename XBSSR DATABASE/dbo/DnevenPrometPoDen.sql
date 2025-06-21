-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
CREATE PROCEDURE [dbo].[DnevenPrometPoDen](  
 @startDate DATETIME,   
 @endDate DATETIME  
 )  
AS  
BEGIN  
  

;WITH Calender AS   
(  
    SELECT @startDate AS CalanderDate  
    UNION ALL  
    SELECT CalanderDate + 1 FROM Calender  
    WHERE CalanderDate + 1 <= @endDate  
)
SELECT * into #CalendarFromTo FROM Calender   

select CAST(CalanderDate as DATE) AS Den,
  ISNULL((select  isnull(SUM(Iznos),0) from viewArtikliVoSmetkaKASA s 
		LEFT outer join tblSmetka sm on sm.ID = s.SmetkaID  
		WHERE CAST(sm.DatumPocetok as DATE) = CAST(CalanderDate as DATE) ),0) AS IznosFiskalna ,
   ISNULL((SELECT ISNULL(SUM(Iznos),0) from tblFiskalniSmetki  where CAST( Datum as Date) = CAST(CalanderDate as DATE) and Stornirana = 0 ),0) AS IznosSocuvana
    from #CalendarFromTo  
  
END
