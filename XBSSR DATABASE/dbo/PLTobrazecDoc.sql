--select * from viewKnzienjaM 

CREATE VIEW [dbo].[PLTobrazecDoc] AS
SELECT     ROW_NUMBER() OVER (ORDER BY  m.DokumentBroj) AS Rbr,
m.Naziv AS [Naziv na stokata], m.Kratenka AS [EdM],
 m.Kolicina AS [Kolicina], m.NabavnaCena AS [Cena], m.IznosSoDDV AS [Iznos], 
m.IznosDDV AS [DDV pri nabavka], m.Procent AS [Stapka na DDV propis], a.ProdaznaCena AS [Cena Prodazba], m.Kolicina * a.ProdaznaCena AS [Iznos Prodazba],
  (m.Kolicina * a.ProdaznaCena) -( (m.Kolicina * a.ProdaznaCena) / ( 1 + m.Procent / 100 )) AS [VkupnoDDV prodazna vrednost], 
m.DatumNaPocetok AS DatumNaPriem , m.DokumentBroj as BrojNaPriem
FROM         viewKnzienjaM m 
left outer join tblArtikal a on a.ID = m.tblArtikalID
WHERE tipNaKnizenje = 3
