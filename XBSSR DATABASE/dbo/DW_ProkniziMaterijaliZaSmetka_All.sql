CREATE PROCEDURE [dbo].[DW_ProkniziMaterijaliZaSmetka_All] 
	   (
	     
		 @FirmaID INT = 1,
		 @ObjektID INT = 1,
		 @UserID INT = 1		 
		 )
AS
BEGIN
SET NOCOUNT ON
					INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,
						  tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,
						  DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblFakturaID,tblPriemID,tblDokumentID,
						  OtpecatenaFiskalna,Rabat,IznosNaRabat,ProdaznaCenaSoRabat )
				    SELECT
						  ( CASE  WHEN K.Tip = 0 THEN NULL ELSE K.ArtikalID END ) AS tblNormativID,
						  ( CASE  WHEN K.Tip = 1 THEN NULL ELSE K.ArtikalID END ) AS tblArtikalID,
						  K.Tip AS tipNaArtikal,
						  K.ProdaznaCena AS ProdaznaCena,
						  K.Kolicina,
						  K.Sifra,
						  ( CASE  WHEN K.Tip = 0 
								  THEN (SELECT tblEdinecniMerkiID from tblArtikal WHERE ID = K.ArtikalID)
						          ELSE (SELECT TOP 1 ID from dbo.tblEdinecniMerki WHERE Naziv LIKE '%KOM%')
						   END ) AS tblEdinecnaMerka,
						  K.Danok AS tblDDVID,
						  1 AS tipNaKnizenje,
						  dbo.ProsecnaNabavnaCena(K.ArtikalID) AS NabavnaCena,
						  (SELECT ISNULL(AVG(NabavnaCenaSoDDV),0) from tblPriemStavki where tblArtikalID = K.ArtikalID) AS EdinecnaCena,
						  K.Iznos AS IznosSoDDV,
						  k.IznosBezDDV AS IznosBezDDV,
						  K.PresmetanDDV AS IznosDDV,
						  GETDATE() AS DatumNaKnizenje,
						  smetka.tblUserID,
						  smetka.ObjektID,
						  smetka.DatumPocetok,
						  smetka.DatumKraj,
						  smetka.ID AS tblSmetkaID,
						  NULL AS tblFakturaID,
						  NULL AS tblPriemID,
						  NULL AS tblDokumentID,
						  ISNULL( (SELECT 1 from tblFiskalniSmetki where tblSmetkaID = smetka.ID),0) AS OtpecatenaFiskalna,
						  K.Rabat,
						  ( (ProdaznaCena * Kolicina) - (CenaSoRabatIddv * Kolicina) ) AS IznosRabat,
						   CenaSoRabatIddv AS ProdaznaCenaSoRabat
						  FROM dbo.viewArtikliVoSmetkaKASA  K
						  INNER JOIN dbo.tblSmetka smetka ON smetka.ID = K.SmetkaID
				      WHERE  smetka.ID NOT IN (SELECT DISTINCT tblSmetkaID FROM dbo.tblKnizenjeM WHERE tblSmetkaID = K.SmetkaID) AND smetka.DatumKraj IS NOT NULL

	

END