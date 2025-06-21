create  PROCEDURE [dbo].[PotroseniPorciiPeriod] (
	     @DatumPocetok datetime,
		 @DatumKraj datetime,
		 @FirmaID int = 1,
		 @ObjektID int = 1
)
AS
BEGIN
  
  truncate table  dbo.mat
   --ALTER table mat (
   --   Naziv nvarchar(100),
   --   Kolicina decimal(18,2),
   --   Iznos decimal(18,2),
   --   ProdaznaCena decimal (18,2),
   --   Sifra nvarchar(10),
   --   NalogID int,
   --   Artikal int,
   --   Tip int
   --)

      Declare @SmetkaID int = -1
      DECLARE Smetka_Cursor Cursor for select ID From tblSmetka where DatumPocetok BETWEEN @DatumPocetok and @DatumKraj
      and Zatvorena = 1 and FirmaID = @FirmaID and ObjektID = @ObjektID
      
		    OPEN Smetka_Cursor
			FETCH NEXT FROM Smetka_Cursor into @SmetkaID
			WHILE @@FETCH_STATUS = 0
			BEGIN
			    INSERT INTO dbo.mat ( Naziv, Kolicina, Iznos, ProdaznaCena, Sifra, NalogID, Artikal, Tip)
				Select ArtikliNalog.Naziv, ArtikliNalog.Kolicina, ArtikliNalog.Iznos, ArtikliNalog.ProdaznaCena, ArtikliNalog.Sifra, ArtikliNalog.NalogID, ArtikliNalog.Artikal,ArtikliNalog.Tip
		        from (select NS.tblNalogID as NalogID ,SUM(NS.Kolicina) as Kolicina ,A.ID as Artikal, a.Sifra ,A.Naziv,A.ProdaznaCena ,A.ProdaznaCena * SUM(NS.Kolicina) as Iznos, 0 as Tip from tblNalogStavki NS
				left outer join tblArtikal A on A.ID = NS.tblArtikalID
				left outer join tblNalog NA on NA.ID = NS.tblNalogID
				Where NA.SmetkaID = @SmetkaID and NS.tblArtikalID is not null
				Group by NS.tblNalogID,A.ID, a.Sifra ,A.Naziv, A.ProdaznaCena
				UNION 
				select NS.tblNalogID as NalogID, SUM(NS.Kolicina) as Kolicina ,N.ID as Artikal,N.Sifra,N.Naziv,N.Cena,N.Cena * SUM(NS.Kolicina) as Iznos, 1 as Tip from tblNalogStavki NS
				left outer join tblNormativ N on N.ID = NS.tblNomativID
				left outer join tblNalog NA on NA.ID = NS.tblNalogID
				Where NA.SmetkaID = @SmetkaID and NS.tblNomativID is not null
				Group by NS.tblNalogID ,N.ID, N.Sifra ,N.Naziv, N.Cena) as ArtikliNalog
				FETCH NEXT FROM Smetka_Cursor into @SmetkaID
	        END		
	        
	    
	   CLOSE Smetka_Cursor;
	   DEALLOCATE Smetka_Cursor; 
	   
	   select COUNT(Naziv) as BrojNaPorcii ,Artikal as ID,Sifra,Naziv as Artikal,ProdaznaCena,  SUM(Kolicina) as Kolicina, SUM(Iznos) as Iznos, Tip from dbo.mat
	   group by Artikal,Sifra,Naziv, ProdaznaCena, Tip
	   Order by Naziv
	   
	   --drop table mat
			
END
