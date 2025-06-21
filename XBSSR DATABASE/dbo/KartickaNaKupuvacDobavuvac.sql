CREATE  PROCEDURE [dbo].[KartickaNaKupuvacDobavuvac] (
      @DatumPocetok datetime,
   @DatumKraj datetime,
   @FirmaID int = 1,
   @ObjektID int = 1,
   @VlezIzlezSVE int,
   @PartnerID int
)
AS
BEGIN
  
  if(@VlezIzlezSVE = 0) 
  BEGIN
   SELECT 1 as TipNaDokument,SmetkaBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and
    (tipNaKnizenje = 1) and SmetkaBroj is not null and tblPartnerID = @PartnerID
   Group by SmetkaBroj,DatumNaKnizenje,DatumNaPocetok,SmetkaBroj
   UNION ALL
   SELECT 2 as TipNaDokument , fakturaBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 2 ) and fakturaBroj is not null and tblPartnerID = @PartnerID
   Group by fakturaBroj,DatumNaKnizenje,DatumNaPocetok,fakturaBroj
   UNION ALL 
   SELECT 3 as TipNaDokument ,PriemBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) 
   and (tipNaKnizenje = 3) and PriemBroj is not null  and tblPartnerID = @PartnerID
   Group by PriemBroj,DatumNaKnizenje,DatumNaPocetok
   UNION ALL 
   SELECT 4 as TipNaDokument,DokumentBroj ,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM  WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 3) and DokumentBroj is not null and tblPartnerID = @PartnerID
   Group by DokumentBroj,DatumNaKnizenje,DatumNaPocetok
   UNION ALL 
   SELECT 4 as TipNaDokument,DokumentBroj ,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM  WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 2 OR tipNaKnizenje = 1) and DokumentBroj is not null and tblPartnerID = @PartnerID
   Group by DokumentBroj,DatumNaKnizenje,DatumNaPocetok
  END
  
  if(@VlezIzlezSVE = 1) 
  BEGIN
   SELECT 3 as TipNaDokument ,PriemBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) 
   and (tipNaKnizenje = 3) and PriemBroj is not null and tblPartnerID = @PartnerID
   Group by PriemBroj,DatumNaKnizenje,DatumNaPocetok
   UNION ALL 
   SELECT 4 as TipNaDokument,DokumentBroj ,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM  WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 3) and DokumentBroj is not null and tblPartnerID = @PartnerID
   Group by DokumentBroj,DatumNaKnizenje,DatumNaPocetok
  END
  
  if(@VlezIzlezSVE = 2) 
  BEGIN
   SELECT 1 as TipNaDokument,SmetkaBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and
    (tipNaKnizenje = 1) and SmetkaBroj is not null and tblPartnerID = @PartnerID
   Group by SmetkaBroj,DatumNaKnizenje,DatumNaPocetok,SmetkaBroj
   UNION ALL
   SELECT 2 as TipNaDokument , fakturaBroj,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 2 ) and fakturaBroj is not null and tblPartnerID = @PartnerID
   Group by fakturaBroj,DatumNaKnizenje,DatumNaPocetok,fakturaBroj
   UNION ALL 
   SELECT 4 as TipNaDokument,DokumentBroj ,DatumNaKnizenje,DatumNaPocetok, SUM(IznosDDV) as IznosDDV, SUM(IznosSoDDV) as IznosSoDDV, SUM(IznosBezDDV ) as IznosBezDDV FROM viewKnzienjaM  WHERE (DatumNaKnizenje BETWEEN @DatumPocetok AND @DatumKraj) and 
   (tipNaKnizenje = 2 OR tipNaKnizenje = 1) and DokumentBroj is not null and tblPartnerID = @PartnerID
   Group by DokumentBroj,DatumNaKnizenje,DatumNaPocetok
  END

  
END