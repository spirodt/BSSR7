CREATE PROCEDURE [dbo].[Porcii] (
	 @DatumPocetok dateTime,
	 @DatumKraj dateTime,
	 @FiskalNa int
)
AS
BEGIN
IF(@FiskalNa = 1 OR @FiskalNa = 2) 
BEGIN

		Select n.Naziv , COUNT(NS.ID) as BrojNaPorcie  from tblNalogStavki NS
		left outer join tblNormativ n on n.ID = NS.tblNomativID and NS.tblArtikalID is null
		left outer join tblNalog nal on nal.ID = NS.tblNalogID
		where (n.Naziv is not null) and (nal.DatumPocetok BETWEEN @DatumPocetok and @DatumKraj) and dbo.DaliImaFiskalna(nal.SmetkaID) = @FiskalNa
		Group by n.Naziv
		order by n.Naziv
END
	ELSE 
	BEGIN
		Select n.Naziv , COUNT(NS.ID) as BrojNaPorcie  from tblNalogStavki NS
		left outer join tblNormativ n on n.ID = NS.tblNomativID and NS.tblArtikalID is null
		left outer join tblNalog nal on nal.ID = NS.tblNalogID
		where (n.Naziv is not null) and (nal.DatumPocetok BETWEEN @DatumPocetok and @DatumKraj)
		Group by n.Naziv
		order by n.Naziv
	END			
END
