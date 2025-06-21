CREATE view [dbo].[RabatPoDatum]  as
Select A.* from(select SmetkaBroj as Broj,CAST(DatumNaKnizenje as DATE) as Datum,SUM(IznosNaRabat) Rabat, 0 as TipNaDokument ,tblDDVID from viewKnzienjaM 
 where tipNaKnizenje <> 3 and SmetkaBroj is not null 
group by SmetkaBroj,DatumNaKnizenje ,tblDDVID
having SUM(IznosNaRabat) > 0
UNION ALL
select FakturaBroj as Broj,CAST(DatumNaKnizenje as DATE) as Datum,SUM(IznosNaRabat) Rabat, 2 as TipNaDokument,tblDDVID from viewKnzienjaM 
 where tipNaKnizenje <> 3 and FakturaBroj is not null
group by FakturaBroj,DatumNaKnizenje,tblDDVID
having SUM(IznosNaRabat) > 0
UNION ALL
select DokumentBroj as Broj, CAST(DatumNaKnizenje as DATE) as Datum,SUM(IznosNaRabat) Rabat, 1 as TipNaDokument ,tblDDVID from viewKnzienjaM 
 where tipNaKnizenje <> 3 and DokumentBroj is not null 
group by DokumentBroj ,DatumNaKnizenje,tblDDVID
having SUM(IznosNaRabat) > 0) as A
