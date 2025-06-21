

--select * from W_Insert_viewKnzienjaM

CREATE VIEW [dbo].[DW_Insert_viewKnzienjaM] AS
SELECT     K.ID, K.DatumNaKnizenje, K.DatumNaPocetok, K.DatumNaKraj, K.Sifra, A.Naziv, K.tipNaArtikal, K.ProdaznaCena, K.Kolicina, M.Kratenka, D.Procent, K.tipNaKnizenje, K.NabavnaCena, 
                      K.EdinecnaCena, K.IznosBezDDV, K.IznosDDV, K.IznosSoDDV, K.OtpecatenaFiskalna, P.PriemBroj ,P.Id AS tblPriemID, S.Broj AS SmetkaBroj, F.Broj AS fakturaBroj, K.tblArtikalID, K.tblNormativID, 
                      USR.FullName AS VrabotenKojJaIzdalSmetkata,K.KodNaDokument, K.Rabat, K.IznosNaRabat, K.ProdaznaCenaSoRabat, K.tblDokumentID, K.tblObjektiIDOD, K.tblObjektiIDDO,
                      DOC.Broj AS DokumentBroj,k.tblSmetkaID,k.tblDDVID,
                      O_OD.Naziv AS odObjekt, O_DO.Naziv AS doObjekt, (
					CASE
						 WHEN S.Broj IS NOT NULL THEN dbo.PartnerIDOdDokument(S.Broj, 1)
						 WHEN F.Broj IS NOT NULL THEN dbo.PartnerIDOdDokument(F.Broj, 2)
						 WHEN P.PriemBroj IS NOT NULL THEN dbo.PartnerIDOdDokument(P.PriemBroj, 3) 
						 WHEN DOC.Broj IS NOT NULL THEN dbo.PartnerIDOdDokument(DOC.Broj, 4) 
						END  
                      ) AS tblPartnerID, A.AltSifra AS AltSifraArtikal 
                      
FROM         dbo.tblKnizenjeM AS K LEFT OUTER JOIN
                      dbo.tblEdinecniMerki AS M ON M.ID = K.tblEdinecnaMerka LEFT OUTER JOIN
                      dbo.tblDDVStavka AS D ON D.ID = K.tblDDVID LEFT OUTER JOIN
                      dbo.tblUsers AS U ON U.ID = K.tblUserID LEFT OUTER JOIN
                      dbo.tblObjekti AS O ON O.ID = K.tblObjektiID LEFT OUTER JOIN
                      dbo.tblObjekti AS O_OD ON O_OD.ID = K.tblObjektiIDOD LEFT OUTER JOIN
                      dbo.tblObjekti AS O_DO ON O_DO.ID = K.tblObjektiIDDO LEFT OUTER JOIN
                      dbo.tblSmetka AS S ON S.ID = K.tblSmetkaID LEFT OUTER JOIN
                      dbo.tblFaktura AS F ON F.ID = K.tblFakturaID LEFT OUTER JOIN
                      dbo.tblPriem AS P ON P.ID = K.tblPriemID LEFT OUTER JOIN
                      dbo.tblDokumenti AS DOC ON DOC.ID = K.tblDokumentID LEFT OUTER JOIN
                      dbo.tblArtikal AS A ON A.ID = K.tblArtikalID LEFT OUTER JOIN
                      dbo.tblArtikal AS N ON N.ID = K.tblNormativID LEFT OUTER JOIN
                      dbo.tblUsers AS USR ON USR.ID = S.tblUserID