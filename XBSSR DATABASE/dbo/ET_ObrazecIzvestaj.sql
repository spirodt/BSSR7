CREATE PROCEDURE [dbo].[ET_ObrazecIzvestaj](    
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
CREATE TABLE #temptable 
( 
	[Rbr] nvarchar(20),
	[DatumNaKnizenje] Date,
	[Naziv i brojNaDokument] nvarchar(100), 
	[DatumNaDokument] datetime,
	[NabavnaVrednost] decimal(18,2), 
	[ProdaznaVrednost] decimal(18,2), 
	[DnevenPromet] decimal(18,2)
)

DECLARE @DatumNADen datetime
DECLARE @redenrboj int = 1
DECLARE ET_CURSOS Cursor for select CAST(CalanderDate as DATE) from #CalendarFromTo
OPEN ET_CURSOS
FETCH NEXT FROM ET_CURSOS into @DatumNADen
	WHILE @@FETCH_STATUS = 0
		BEGIN
			
		INSERT INTO #temptable 
		SELECT 
			 CAST(@redenrboj as nvarchar(20)),
			( select @DatumNADen from viewKnzienjaM m  
			where m.PriemBroj = p.PriemBroj group by m.PriemBroj, DatumNaKnizenje )  as DatumNaKnizenje, 
			'ПЛТ Број : ' + Cast(p.PriemBroj as Nvarchar(20) ) as "Naziv i brojNaDokument",  
			--p.PriemDatum 
			@DatumNADen as DatumNaDokument
			, IznosSoDDV as NabavnaVrednost,
			(select SUM([Iznos Prodazba]) from PLTobrazec where BrojNaPriem = p.PriemBroj ) as ProdaznaVrednost,
			NULL DnevenPromet
			FROM viewPriemi p   where PriemDatum BETWEEN CAST(@DatumNADen as DateTime) and  DATEADD(HOUR,23,DATEADD(MINUTE,59,@DatumNADen))
			--UNION
			set @redenrboj = @redenrboj + 1
			INSERT INTO #temptable VALUES
			( 
			CAST(@redenrboj as nvarchar(20)),
			CAST(@DatumNADen as DATE),
			N'ДФИ број : ' + CAST(@redenrboj as nvarchar(20)),CAST(@DatumNADen as DATE), NULL, NULL, dbo.DnevenPrometFiskalna(@DatumNADen))
			FETCH NEXT FROM ET_CURSOS into @DatumNADen
		END
CLOSE ET_CURSOS;
DEALLOCATE ET_CURSOS;		
select 
	ROW_NUMBER() OVER ( order by [DatumNaKnizenje] ) as Rbr,
	[DatumNaKnizenje],
	[Naziv i brojNaDokument], 
	[DatumNaDokument],
	[NabavnaVrednost], 
	[ProdaznaVrednost] , 
	[DnevenPromet]

from #temptable
order by [DatumNaKnizenje] asc
drop table #temptable


END