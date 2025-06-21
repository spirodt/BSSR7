
CREATE view  [dbo].[ETobrazec]
as
SELECT ROW_NUMBER() OVER ( order by PriemBroj ) as Rbr,
( select m.DatumNaKnizenje from viewKnzienjaM m  where m.PriemBroj = p.PriemBroj group by m.PriemBroj, DatumNaKnizenje )  as DatumNaKnizenje
, 'Priemen broj :' + Cast(p.PriemBroj as Nvarchar(20)) as "Naziv i brojNaDokument",
p.PriemDatum as DatumNaDokument, IznosSoDDV as NabavnaVrednost,
(select SUM([Iznos Prodazba]) from PLTobrazec where BrojNaPriem = p.PriemBroj ) as ProdaznaVrednost, dbo.DnevenPrometFiskalna(p.PriemDatum) as DnevenPromet
FROM viewPriemi p
