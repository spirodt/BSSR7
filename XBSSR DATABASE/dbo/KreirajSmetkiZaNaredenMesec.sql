CREATE PROCEDURE [dbo].[KreirajSmetkiZaNaredenMesec]  
 -- Add the parameters for the stored procedure here  
 @dokumentID int ,  
 @broj int ,  
 @TipNaDokument int,  
 @Datum DateTime,  
 @Zabeleska nvarchar(50)  
AS  
BEGIN  
   
  print 'aa'
-- INSERT INTO tblDokumenti  
-- SELECT   
--          @broj
--           ,@TipNaDokument
--           ,@Datum
--           ,[OdObjektID]
--           ,[DoObjektID]
--           ,[tblUserID]
--           ,@Zabeleska
--           ,[tblPartnerID]
--           ,[FirmaID]
--           ,[KodNaDokument]
--           ,[BrojNaDokument] FROM  tblDokumenti  
-- WHERE  Id = @dokumentID  
  
--Declare @DocID int   
  
--select @DocID =  SCOPE_IDENTITY()  
  
  
  
-- INSERT INTO tblDokumentStavki  
-- SELECT  @DocID  
--    ,[tblArtikalID]  
--    ,[tblNormativID]  
--    ,[Cena]  
--    ,[Kolicina]  
--    ,[Iznos]  
--    ,[Rabat1] FROM    tblDokumentStavki  
-- WHERE  tblDokumentID = @dokumentID  
  
--update tblDokumenti set Broj = dbo.NaredeBrojZaTipNaDokument(@TipNaDokument), Zabeleska = @Zabeleska, Datum = @Datum where ID = @DocID  
   
END
