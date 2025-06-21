-- =============================================
-- Author:		Spiro
-- Create date: 02.06.2014
-- Description:	
-- =============================================
create PROCEDURE [dbo].[KopirajArtikal] 
	-- Add the parameters for the stored procedure here
	@ArtikalID int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare	@Naziv nvarchar(50) 
	Declare	@FirmaID int 
	Declare	@Sifra nchar(5) 
	Declare	@PodgrupaID int 
	Declare	@KlucniZborovi nvarchar(300) 
	Declare	@ProdaznaCena decimal(18,2) 
	Declare	@tblDDVStavkaID int 
	Declare	@RedenBroj int
	Declare	@AltNaziv nvarchar(150) 
	Declare	@AltNaziv2 nvarchar(150) 
	Declare	@SePecatiVoKujna bit 
	Declare	@SePacatiNaSank bit
	declare @tblEdinecniMerkiID int 
	declare @AltSifra nvarchar(5) 
	declare @NabavnaCena decimal(18, 2) 
	declare @EDMIzlez int 
    declare @KolicinaT decimal(12,4)
    declare @MinimalnaKolicinaNaZaliha decimal(9,2)
    declare @DenoviZaGarancija int 
    declare @Barkod1  nvarchar(50)
    declare @Barkod2  nvarchar(50)
    
	Select @Naziv = SUBSTRING(Naziv,1,40) + ' Copy', @FirmaID = FirmaID, @Sifra = 'C'+SUBSTRING(Sifra,2,5),@PodgrupaID = PodgrupaID,@KlucniZborovi = KlucniZborovi,
		@ProdaznaCena = ProdaznaCena,@tblDDVStavkaID = tblDDVStavkaID,@RedenBroj = RedenBroj + 1, @AltNaziv = AltNaziv ,@AltNaziv2 = AltNaziv2,@SePecatiVoKujna = SePecatiVoKujna,@SePacatiNaSank = SePacatiNaSank,
		@tblEdinecniMerkiID = tblEdinecniMerkiID, @AltSifra = 'C'+SUBSTRING(AltSifra,2,5), @NabavnaCena = NabavnaCena,@EDMIzlez= EDMIzlez,@KolicinaT = KolicinaT, @MinimalnaKolicinaNaZaliha = @MinimalnaKolicinaNaZaliha,@DenoviZaGarancija = DenoviZaGarancija,@Barkod1 = Barkod1,@Barkod2 = Barkod2
	 from tblArtikal where ID = @ArtikalID
	 
	 --Kreiraj
	 INSERT INTO tblArtikal (Sifra,Naziv,tblDDVStavkaID,PodgrupaID,tblEdinecniMerkiID,AltNaziv,AltSifra,KlucniZborovi,NabavnaCena,ProdaznaCena,FirmaID,Status,EDMIzlez,KolicinaT,MinimalnaKolicinaNaZaliha,RedenBroj,Barkod1,Barkod2,AltNaziv2,Image,SePecatiVoKujna,SePacatiNaSank,DenoviZaGarancija)
	VALUES (@Sifra,@Naziv,@tblDDVStavkaID,@PodgrupaID,@tblEdinecniMerkiID,@AltNaziv,@AltSifra,@KlucniZborovi,@NabavnaCena,@ProdaznaCena,@FirmaID,null,@EDMIzlez,@KolicinaT,@MinimalnaKolicinaNaZaliha,@RedenBroj,@Barkod1,@Barkod2,@AltNaziv2,null,@SePecatiVoKujna,@SePacatiNaSank,@DenoviZaGarancija)
	
END