-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[brisiArtikal](
   @NalogID int,
   @ArtikalID int,
   @smetka int
)	
AS
BEGIN
	          if (EXISTS( select 1 from tblNalogStavki where tblNalogID = @NalogID AND tblArtikalID = @ArtikalID and  tblNomativID is null ))
				 begin
					print 'aaa'
					delete from tblNalogStavki where tblNalogID = @NalogID and tblArtikalID = @ArtikalID
				 END
				 ELSE
				 begin
					print 'bb'
				   delete from tblNalogStavki where tblNalogID = @NalogID and tblNomativID = @ArtikalID
				 END;
					delete from tblSmetkaStavki where tblSmetkaID = @smetka
					update tblSmetka set Zatvorena = 'false', DatumKraj = null where ID = @smetka;
END
