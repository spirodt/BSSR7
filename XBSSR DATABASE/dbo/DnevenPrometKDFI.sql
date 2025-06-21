-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- exec DnevenPrometKDFI '2015-02-21 13:28:37.403' , '2015-02-26 13:28:37.403'
-- =============================================
CREATE PROCEDURE [dbo].[DnevenPrometKDFI](
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

	Declare @Den date
	
	Declare @MKIznos decimal (18,2) -- Vkupen promet od makedonski proizvodi
	Declare @MKDDVIznos decimal(18,2) -- Iznos na danok vo tekovniot den od MK
	Declare @MKDDVIznos0 decimal(18,2) -- Iznos na danok vo tekovniot den od MK 0% 
	Declare @MKDDVIznos5 decimal(18,2) -- Iznos na danok vo tekovniot den od MK 5%
	Declare @MKDDVIznos18 decimal(18,2) -- Iznos na danok vo tekovniot den od MK 18%
	Declare @Iznos decimal (18,2)-- Vkupen promet vo tekovniot den
	Declare @Iznos0 decimal(18,2) -- Vkupen promet vo tekovniot den 0%
	Declare @Iznos5 decimal(18,2) -- Vkupen promet vo tekovniot den 5%
	Declare @Iznos18 decimal(18,2) -- Vkupen promet vo tekovniot den 18%
	Declare @DDVIznos decimal(18,2) -- Iznos na danok vo tekovniot den
	Declare @DDVIznos0 decimal(18,2) -- Iznos na danok vo tekovniot den 0% 
	Declare @DDVIznos5 decimal(18,2) -- Iznos na danok vo tekovniot den 5%
	Declare @DDVIznos18 decimal(18,2) -- Iznos na danok vo tekovniot den 18%
	
	Declare @tblSmetkaID int

Create table #DnevenPromet (
	Den date,
	MKIznos decimal (18,2),
	MKDDVIznos decimal (18,2),
	MKDDVIznos0 decimal (18,2),
	MKDDVIznos5 decimal (18,2),
	MKDDVIznos18 decimal (18,2),	
	Iznos decimal (18,2),
	Iznos0 decimal (18,2),
	Iznos5 decimal (18,2),
	Iznos18 decimal (18,2),
	DDVIznos decimal (18,2),
	DDVIznos0 decimal (18,2),
	DDVIznos5 decimal (18,2),
	DDVIznos18 decimal (18,2),
	tblSmetkaID int
	
	
	
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
		DECLARE DDV_CURSOS Cursor for select  s.tblSmetkaID from tblFiskalniSmetki s
			where CAST (s.Datum as DATE) = @DatumZaObratotka and s.Stornirana = 0
			Group by s.Datum, s.tblSmetkaID
			
			OPEN DDV_CURSOS
			FETCH NEXT FROM DDV_CURSOS into @tblSmetkaID 
			WHILE @@FETCH_STATUS = 0
			BEGIN
			--select * from viewArtikliVoSmetkaKASA order by 1 desc
			select @MKIznos = sum (isnull (Iznos, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and MkProizvod = 1
			select @MKDDVIznos = sum (isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and MkProizvod = 1
			select @MKDDVIznos0 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 0 and MkProizvod = 1
			select @MKDDVIznos5 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 5 and MkProizvod = 1
			select @MKDDVIznos18 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 18 and MkProizvod = 1
			select @Iznos = sum (isnull (Iznos, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID
			select @DDVIznos = sum (isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID
			select @Iznos0 = sum(isnull (Iznos, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 0
			select @DDVIznos0 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 0
			select @Iznos5 = sum(isnull (Iznos, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 5
			select @DDVIznos5 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 5
			select @Iznos18 = sum(isnull (Iznos, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 18
			select @DDVIznos18 = sum(isnull (PresmetanDDV * Kolicina, 0)) from viewArtikliVoSmetkaKASA where SmetkaID = @tblSmetkaID and DDVProcent = 18
			
			INSERT INTO #DnevenPromet VALUES( @DatumZaObratotka, @MKIznos, @MKDDVIznos, @MKDDVIznos0, @MKDDVIznos5, @MKDDVIznos18, @Iznos, @Iznos0, @Iznos5, @Iznos18, @DDVIznos, @DDVIznos0, @DDVIznos5, @DDVIznos18, @tblSmetkaID )
			
			FETCH NEXT FROM DDV_CURSOS into @tblSmetkaID 
			END
		CLOSE DDV_CURSOS;
		DEALLOCATE DDV_CURSOS; 
						
			
			
			FETCH NEXT FROM ET_CURSOS into @DatumZaObratotka
		END
CLOSE ET_CURSOS;
DEALLOCATE ET_CURSOS; 

SELECT ROW_NUMBER() 
        OVER (ORDER BY Den) AS Rbr, Den, isnull(SUM(MKIznos),0) as MKIznos,isnull(SUM(MKDDVIznos),0) as MKDDVIznos,isnull(SUM(MKDDVIznos0),0) as MKDDVIznos0,isnull(SUM(MKDDVIznos5),0) as MKDDVIznos5,isnull(SUM(MKDDVIznos18),0) as MKDDVIznos18, isnull(SUM(Iznos),0) as Iznos, isnull(SUM(Iznos0),0) as Iznos0, isnull(SUM(Iznos5),0) as Iznos5, isnull(SUM(Iznos18),0) as Iznos18, isnull(SUM(DDVIznos),0) as DDVIznos, isnull(SUM(DDVIznos0),0) as DDVIznos0, isnull(SUM(DDVIznos5),0) as DDVIznos5, isnull(SUM(DDVIznos18),0) as DDVIznos18 from #DnevenPromet
group by Den
--select * from #CalendarFromTo
drop table #CalendarFromTo
drop table #DnevenPromet


COMMIT TRANSACTION Trans1

END
