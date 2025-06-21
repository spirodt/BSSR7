-- =============================================
-- Author:		<Author,,Name>
-- ALTER date: <ALTER Date,,>
-- Description:	<Description,,>
-- exec dbo.BrisiArtikalNormativ 2219,2
-- select * from viewArtikaliNormativi where ID = 54

-- =============================================
CREATE PROCEDURE [dbo].[BrisiArtikalNormativ](
	-- Add the parameters for the stored procedure here
	@NalogID int,
	@artikalID int
)
AS
BEGIN
    
   if (EXISTS( select 1 from tblNalogStavki where tblNalogID = @NalogID AND tblArtikalID = @ArtikalID and  tblNomativID is null ))
			BEGIN
			delete from tblNalogStavki	
			where tblNalogID = @NalogID and tblArtikalID = @artikalID
			print 'artikal'
			END
		ELSE 
			BEGIN 
			delete from tblNalogStavki	
			where tblNalogID = @NalogID and tblNomativID = @artikalID
			print 'normativ'
			END
	
	
END
