-- =============================================
-- Author:		Spiro
-- Create date: 02.06.2014
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[KopirajNormativ] 
	-- Add the parameters for the stored procedure here
	@NormativID int = 0 
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
	Declare	@Cena decimal(9, 3) 
	Declare	@tblDDVStavkaID int 
	Declare	@RedenBroj int
	Declare	@AltNaziv nvarchar(150) 
	Declare	@AltNaziv2 nvarchar(150) 
	Declare	@SePecatiVoKujna bit 
	Declare	@SePacatiNaSank bit 
	
    
	Select @Naziv = SUBSTRING(Naziv,1,40) + ' Copy', @FirmaID = FirmaID, @Sifra = 'C'+SUBSTRING(Sifra,2,5),@PodgrupaID = PodgrupaID,@KlucniZborovi = KlucniZborovi,@Cena = Cena,@tblDDVStavkaID = tblDDVStavkaID,@RedenBroj = RedenBroj + 1, @AltNaziv = AltNaziv ,@AltNaziv2 = AltNaziv2,@SePecatiVoKujna = SePecatiVoKujna,@SePacatiNaSank = SePacatiNaSank
	 from tblNormativ where ID = @NormativID
	 
	 --Kreiraj
	INSERT INTO tblNormativ (Naziv, FirmaID,Sifra,PodgrupaID,KlucniZborovi,Cena,tblDDVStavkaID,RedenBroj,AltNaziv,AltNaziv2,SePecatiVoKujna,SePacatiNaSank)
	VALUES(@Naziv, @FirmaID,@Sifra,@PodgrupaID,@KlucniZborovi,@Cena,@tblDDVStavkaID,@RedenBroj,@AltNaziv,@AltNaziv2,@SePecatiVoKujna,@SePacatiNaSank)
	Declare @Posleden int = SCOPE_IDENTITY()
	exec dbo.PrefrliNormativ @NormativID, @Posleden
END
