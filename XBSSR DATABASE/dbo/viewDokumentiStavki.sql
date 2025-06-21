
CREATE       view [dbo].[viewDokumentiStavki]        
as        
select S.ID,s.tblDokumentID,A.AltSifra as AltSifra,n.Sifra as NormativSifra ,      
d.Broj as BrojNaDokument, t.Naziv as TipNadokument,        
a.Naziv as ArikalNaziv, a.ID as ArtikalID, stinfo.NotesText, stinfo.NotesBroj, stinfo.NotesREF, n.Naziv as NormativNaziv, n.ID as NormativID,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then 1 ELSE 0 END)as isNormativ,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then n.Naziv ELSE a.Naziv END) as NazivNaProdukt,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then ddvNor.Procent ELSE ddvART.Procent END) as DDVStapka,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then 'KOM' ELSE e.Kratenka END) as EdinecnaMerka,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then (        
 CAST(ISNULL(s.Iznos - s.Iznos / (ddvNor.Procent / 100 + 1), 0) AS decimal(18, 4)))         
 ELSE         
 CAST(ISNULL(s.Iznos - s.Iznos / (ddvART.Procent / 100 + 1), 0) AS decimal(18, 4))         
 END ) as DDVIznos,        
(CASE WHEN isnull(s.tblArtikalID,0) = 0 then (        
 CAST(ISNULL(S.Iznos / (ddvNor.Procent / 100 + 1), 0) AS decimal(18, 4)))         
 ELSE         
 CAST(ISNULL(S.Iznos / (ddvART.Procent / 100 + 1), 0) AS decimal(18, 4))         
 END ) as IznosBezDDV,
 CAST(ISNULL(S.Cena / (ddvART.Procent / 100 + 1), 0) AS decimal(18, 4))  as CenaBezDDV,
 CAST( ((s.Cena - (s.Cena / 100 * s.Rabat1)) ) as decimal(18,4) )AS CenaSoRabatIddv, 
s.Kolicina,( CAST( (s.Cena) as decimal(18,4))) as Cena,s.Rabat1 , s.Iznos , d.TipNaDokument as TipNaDokumentID, d.Datum as DatumNaDokument,        
dbo.ProsecnaNabavnaCena(s.tblArtikalID) as ProsecnaNabavnaCena,        
dbo.ProsecnaNabavnaCenaBezDDV(s.tblArtikalID) as ProsecnaNabavnaCenaBezDDV,        
(dbo.ProsecnaNabavnaCenaBezDDV(s.tblArtikalID) * S.Kolicina) NabavnaVrednostBezDDVIznos,        
 isnull(A.PlanskaCena,0) as PlanskaCena, isnull( A.PlanskaCena * Kolicina ,0) as PlanskaVrednost,        
 A.ProdaznaCena as ProdaznaCena, iSnull(s.Kolicina * A.ProdaznaCena,0) as ProdaznaVrednostSoDDV        
 from tblDokumentStavki s        
left outer join tblDokumenti d on d.ID = s.tblDokumentID        
left outer join tblTipNaDokument t on t.ID = d.TipNaDokument        
left outer join viewArtikalInfo a on a.ID = s.tblArtikalID        
left outer join tblNormativ n on n.ID = s.tblNormativID        
left outer join tblEdinecniMerki e on e.ID = a.tblEdinecniMerkiID        
left outer join tblDDVStavka ddvART on ddvART.ID = a.tblDDVStavkaID        
left outer join tblDDVStavka ddvNor on ddvNor.ID = n.tblDDVStavkaID  
left outer join tblDokumentStavkiDetailsInfo stinfo on stinfo.tblDokumentStavkiId = s.ID