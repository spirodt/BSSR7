-- PrefrliNormativ 388,405
create PROCEDURE [dbo].[PrefrliNormativ] 
	-- Add the parameters for the stored procedure here
	@IdOd int, 
	@IdVo int
AS
BEGIN
	  Declare @tblArtikal int
	  Declare @Kolicina decimal(12,4)
	  DECLARE Smetka_Cursor Cursor for Select tblArtikalID, Kolicina from tblNormativStavki where tblNormativID = @IdOd
		    OPEN Smetka_Cursor 
				FETCH NEXT FROM Smetka_Cursor into @tblArtikal, @Kolicina
				WHILE @@FETCH_STATUS = 0
					BEGIN
						insert into tblNormativStavki (tblNormativID, tblArtikalID, Kolicina) values (@IdVo, @tblArtikal, @Kolicina)
						FETCH NEXT FROM Smetka_Cursor into @tblArtikal, @Kolicina
					END
			CLOSE Smetka_Cursor;
			DEALLOCATE Smetka_Cursor; 
END


/****** Object:  StoredProcedure [dbo].[KopirajNormativ]    Script Date: 09/09/2017 2:29:21 PM ******/
SET ANSI_NULLS ON
