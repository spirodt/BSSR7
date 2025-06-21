
CREATE VIEW [dbo].[viewSmetki]  
AS  
SELECT a.*,  
       (   SELECT SUM(k.IznosBezDDV)  
             FROM viewArtikliVoSmetkaKASA k  
            WHERE k.SmetkaID = a.ID) AS IznosBezDDV,  
       (   SELECT SUM(k.Iznos)  
             FROM viewArtikliVoSmetkaKASA k  
            WHERE k.SmetkaID = a.ID) AS Iznos,  
       (   SELECT SUM(k.PresmetanDDV * k.Kolicina)  
             FROM viewArtikliVoSmetkaKASA k  
            WHERE k.SmetkaID = a.ID) AS PresmetanDDV  
  FROM (   SELECT s.*,  
                  u.FullName,  
                  p.Sifra + ' - ' + p.Naziv AS Partner,  
      e.ID AS PresmetkovnaEdinicaId,  
      e.Sifra + ' - ' + e.Naziv AS PresmetkovnaEdinica  FROM tblSmetka s  
             LEFT OUTER JOIN tblUsers u   ON s.tblUserID    = u.ID  
			 LEFT OUTER JOIN tblPartneri p  ON s.tblPartnerID = p.ID  
			 LEFT OUTER JOIN tblPresmetkovniEdinici e ON e.ID = p.tblPresmetkovnaEdinicaID   
      ) AS a;