
CREATE  PROCEDURE [dbo].[PobaruvaDolguvaPartnerOdPocetokDoKraj] (
		 @PartnerID int
)
AS
BEGIN
		Declare @MinDate date
		Select @MinDate = MIN(DatumNaKnizenje) from tblKnizenjeM
		Declare @MaxDate date = CAST(getDate() as Date)
		Select A.tblPartnerID as ID, p.Sifra, p.Naziv ,SUM(A.IznosSoDDV) as Platil, dbo.IznosNaPlacanjaOdPartner(A.tblPartnerID,@MinDate,@MaxDate,0) as Dolzi 
		from (
		SELECT 1 as TipNaDokument,DatumNaKnizenje, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV, tblPartnerID FROM viewKnzienjaM 
			WHERE (tipNaKnizenje = 1) and tblPartnerID is not null and tblPartnerID = @PartnerID
			Group by DatumNaKnizenje,tblPartnerID
			UNION ALL
			SELECT 2 as TipNaDokument,DatumNaKnizenje, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV, tblPartnerID FROM viewKnzienjaM 
			WHERE (tipNaKnizenje = 2 ) and fakturaBroj is not null and  tblPartnerID is not null  and tblPartnerID = @PartnerID
			Group by DatumNaKnizenje,tblPartnerID
			UNION ALL 
			SELECT 3 as TipNaDokument,DatumNaKnizenje, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV, tblPartnerID FROM viewKnzienjaM 
			WHERE (tipNaKnizenje = 3) and PriemBroj is not null and tblPartnerID is not null  and tblPartnerID = @PartnerID
			Group by DatumNaKnizenje,tblPartnerID
			UNION ALL 
			SELECT 4 as TipNaDokument,DatumNaKnizenje, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV, tblPartnerID FROM viewKnzienjaM 
			WHERE (tipNaKnizenje = 3) and DokumentBroj is not null and tblPartnerID is not null  and tblPartnerID = @PartnerID
			Group by DatumNaKnizenje,tblPartnerID )as A
			left outer join tblPartneri p on p.ID = A.tblPartnerID
			Group BY A.tblPartnerID, P.Sifra, P.Naziv

END