CREATE PROCEDURE [dbo].[SaldoPoDokument] 
    @SamoDolznici bit = 0,
	@DoDatum DateTime
AS
--exec SaldoPoDokument 0, '2023-04-15 00:00:00.000'
---exec SaldoPoDokumentPoPartner '10-092','2023-07-13 00:00:00.000'



BEGIN
DECLARE @ID nvarchar(100)
DECLARE @Sifra nvarchar(100) 
DECLARE @Naziv nvarchar(100)
DECLARE @IznosSoDDV decimal(18,2)
DECLARE @Plateno decimal(18,2)
DECLARE @Saldo decimal(18,2)
DECLARE @TipNaDostava nvarchar(100)
DECLARE @Zabeleski nvarchar(100) = ''

DECLARE @tmpSaldo TABLE  
(
	ID nvarchar(100),
	Sifra nvarchar(100),
	Naziv nvarchar(100),
	VkupnoDolzi nvarchar(100),
	VkupnoPlateno nvarchar(100),
	Saldo nvarchar(100),
	TipNaDostava nvarchar(100),
	SALDO_Dolzi decimal(18,3),
	SALDO_Plateno decimal(18,3),
	SALDO_SVE decimal(18,3),
	TipNaRed int,
	Zabeleski nvarchar(100)
)

DECLARE cPartner 
CURSOR FOR 
select ID,Sifra,Naziv,SUM(IznosSoDDV),SUM(Plateno), SUM(Saldo), TipNaDostava from SaldoNaPartneriSoAnalitka
where convert(date,DatumNaValuta,23) < convert(date,@DoDatum,23)
Group by ID,Sifra,Naziv,TipNaDostava
HAVING (( SUM(Saldo) < 0 ) OR @SamoDolznici = 0 )

	OPEN cPartner  
			FETCH NEXT FROM cPartner INTO @ID,@Sifra,@Naziv,@IznosSoDDV,@Plateno,@Saldo,@TipNaDostava;
			WHILE @@FETCH_STATUS = 0 
			BEGIN
				INSERT INTO @tmpSaldo VALUES(@ID,@Sifra,@Naziv,@IznosSoDDV,@Plateno,@Saldo,@TipNaDostava,
				CAST(@IznosSoDDV as Decimal(18,3)),
				CAST(@Plateno as Decimal(18,3)),
				CAST(@Saldo as Decimal(18,3)),
				1,
				'');
				INSERT INTO @tmpSaldo VALUES('',@sifra,N'Документ',N'Износ',N'Платено',N'',@TipNaDostava,0,0,0,2,@Zabeleski);
				INSERT INTO @tmpSaldo SELECT * FROM [dbo].[SaldoPoPartner] (@ID,@DoDatum)
				FETCH NEXT FROM cPartner INTO @ID,@Sifra,@Naziv,@IznosSoDDV,@Plateno,@Saldo,@TipNaDostava;
			END
			CLOSE cPartner  
			DEALLOCATE cPartner
Select * from @tmpSaldo
END
GO
