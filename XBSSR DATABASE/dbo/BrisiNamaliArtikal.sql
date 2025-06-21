CREATE PROCEDURE [dbo].[BrisiNamaliArtikal](  
 -- Add the parameters for the stored procedure here  
 @NalogID int,  
 @artikalID int  
)  
AS  
BEGIN  
      
   if (EXISTS( select 1 from tblNalogStavki where tblNalogID = @NalogID AND tblArtikalID = @ArtikalID and  tblNomativID is null ))  
   BEGIN  
   update tblNalogStavki set Kolicina = Kolicina - 1  
   where tblNalogID = @NalogID and tblArtikalID = @artikalID and ID = (select top (1) ID from tblNalogStavki ns  
   where ns.tblNalogID = @NalogID and ns.tblArtikalID = @artikalID and Kolicina > 0  
   order by Kolicina desc)  
   print 'artikal'  
   END  
  ELSE   
   BEGIN   
   update tblNalogStavki set Kolicina = Kolicina - 1  
   where tblNalogID = @NalogID and tblNomativID = @artikalID and ID = (select top (1) ID from tblNalogStavki ns  
   where ns.tblNalogID = @NalogID and ns.tblNomativID = @artikalID and Kolicina > 0  
   order by Kolicina desc)  
   print 'normativ'  
   END  
 delete from tblNalogStavki  
 --select * from tblNalogStavki  
 where tblNalogID = @NalogID and Kolicina = 0  
   
END
