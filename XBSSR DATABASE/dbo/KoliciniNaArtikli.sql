
CREATE VIEW KoliciniNaArtikli AS 
SELECT A.ID,A.Sifra, A.Naziv, SUM(Z.Vlez) AS Vlez ,SUM(Z.Izlez) AS Izlez, SUM(z.Vlez - z.Izlez) AS Saldo,
(A.ProdaznaCena * SUM(z.Vlez - z.Izlez)) AS ZalihaSoVrednost FROM dbo.tblZalihaNaArtikli z
INNER JOIN dbo.tblArtikal a ON a.ID = z.tblArtikalID
GROUP BY A.ID, A.Sifra, A.Naziv,A.ProdaznaCena