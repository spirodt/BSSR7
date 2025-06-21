CREATE PROCEDURE [dbo].[Nalozi] (
	 @SmetkaID int
)
AS
BEGIN
	
				Select ID,Broj, Zabeleska, isnull((
						select SUM(IsNull(A.Cena,0)) As SUMA
						 from (select SUM(IsNull((A.ProdaznaCena - (A.ProdaznaCena / 100 * NS.Rabat1)),0) * NS.Kolicina) Cena, NS.tblNalogID 
						from tblNalogStavki NS
						left outer join tblArtikal A on A.ID = NS.tblArtikalID
						Group by NS.tblNalogID
						having NS.tblNalogID = tblNalog.ID
						UNION ALL
						select SUM(IsNull((N.Cena - (N.Cena / 100 * NS.Rabat1)),0) * NS.Kolicina) Cena, NS.tblNalogID
						from tblNalogStavki NS
						left outer join tblNormativ N on N.ID = NS.tblNomativID
						Group by NS.tblNalogID
						having NS.tblNalogID = tblNalog.ID
						 )as A),0) Suma, Status = CASE  WHEN tblNalog.Zavrsen = 'true' THEN 1  ELSE 0 END 

			from tblNalog where SmetkaID = @SmetkaID 
			
			
	--select NalogID as ID,n.Broj,n.Zabeleska, Status = CASE  WHEN n.Zavrsen = 'true' THEN 1  ELSE 0 END,  Iznos as Suma
	-- from viewArtikliVoSmetkaKASA s
	--left outer join tblNalog n on n.ID  = s.NalogID 
	--where s.SmetkaID = @SmetkaID

END
