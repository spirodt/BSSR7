CREATE PROCEDURE [dbo].[ZatvoriSmetka](  @SmetkaID int, @FirmaID int ,@SoPopust int, @Popust decimal(18,2))  
  
AS  
BEGIN  
BEGIN TRANSACTION zatvoriSmetkaKasa  
if EXISTS( select 1 from tblSmetka where @SmetkaID = ID AND Zatvorena = 0 )
BEGIN
  IF(@SoPopust = 1 AND @SoPopust <> 0 )  
    
  BEGIN  
   UPDATE dbo.tblNalogStavki SET Rabat1 = @Popust WHERE tblNalogID IN (SELECT ID FROM dbo.tblNalog WHERE @SmetkaID = SmetkaID )  
  END  
  
 Declare @nalogID int = 0  
 Declare @Kolicina int = 0  
 Declare @Suma decimal(18,2)  
 DECLARE NALOG_Cursor Cursor for select NalogID from viewArtikliVoSmetkaKASA Where SmetkaID = @SmetkaID Group by NalogID  
 OPEN NALOG_Cursor  
   FETCH NEXT FROM NALOG_Cursor into @nalogID  
   WHILE @@FETCH_STATUS = 0  
   BEGIN  
   set @Kolicina = 0  
   -- Exec dbo.Nalozi 7 @SmetkaID  
   select @Suma = SUM(Iznos) from viewArtikliVoSmetkaKASA Where SmetkaID = @SmetkaID and NalogID = @nalogID Group by NalogID  
   IF @Suma <> 0 BEGIN  
   insert into tblSmetkaStavki ( tblSmetkaID, tblNalogID, Kolicina, Cena)  
      Values ( @SmetkaID, @nalogID, @Kolicina, @Suma)  
      print 'vnesov'  
      print @Suma  
      update tblNalog set Zavrsen = 'true',  DatumKraj = getDate() where ID = @nalogID    
   END  
     
   FETCH NEXT FROM NALOG_Cursor into @nalogID  
   END  
 CLOSE NALOG_Cursor;  
 DEALLOCATE NALOG_Cursor;    
 update tblNalog set Zavrsen = 'True' , DatumKraj = getDate() where SmetkaID = @SmetkaID  
 Update tblSmetka set Zatvorena = 'True', DatumKraj = getDate() Where ID = @SmetkaID and FirmaID = @FirmaID  
 update tblSmetka set ImaPopust = @SoPopust, ProcentNaPopust = @Popust where ID = @SmetkaID and FirmaID = @FirmaID  
 -- ova ovde gi brise tia so nula  
 delete from tblSmetkaStavki where CAST(Cena as decimal) = 0
 COMMIT TRANSACTION zatvoriSmetkaKasa 
 END
 ELSE
 BEGIN
  RAISERROR (15600,-1,-1, 'SmetkataEVekjeZatvorena');  
  ROLLBACK TRANSACTION zatvoriSmetkaKasa  
 END

END
