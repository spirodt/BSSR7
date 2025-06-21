CREATE PROCEDURE [dbo].[ProkniziMaterijaliOdInterni_Dokumenti_Novo] (    
      @tblDokumentiID INT,    
   @FirmaID int = 1,    
   @ObjektID int = 4,    
   @UserID int = 31       
   )    
AS    
BEGIN    
if( Exists(Select tblDokumentID from tblKnizenjeM where tblDokumentID = @tblDokumentiID))    
 BEGIN    
  return    
 END    
   Declare @tblNormativID int = null, @tblArtikalID int =null ,@Tip int    
   declare @Artikal int = null    
   declare @Kolicina decimal(18,4)    
   declare @Iznos decimal(18,2)  
   declare @Rabat decimal(18,2)    
   declare @ProdaznaCena decimal(18,2)    
   declare @Sifra nvarchar(20)    
   declare @SmetkaID int = null    
   Declare @DatumNaPocetokNaSmetka datetime    
   Declare @DatumNaKrajNaSmetka datetime    
       
   declare @tblArtikalID_N int    
   declare @Kolicina_N decimal(18,4)    
   Declare @tblEdinecnaMerka int    
   Declare @tblDDVID int    
   DECLARE @OdObjekt int    
   DECLARE @DoObjekt int    
   DECLARE @tipNaKnizenje int     
       
   DEclare @NabavnaCena decimal(18,2),@EdinecnaCena decimal(18,2),@IznosSoDDV decimal(18,2),@IznosBezDDV decimal(18,2),@IznosDDV decimal(18,2)    
       
   DECLARE @TipNaDokumentID INT    
   select @DatumNaPocetokNaSmetka = Datum ,@UserID = tblUserID, @OdObjekt =  OdObjektID, @DoObjekt = DoObjektID from tblDokumenti where ID = @tblDokumentiID    
   DECLARE @TipNaDokumentText NVARCHAR(max)    
   SELECT @tipNaKnizenje = TipNaKnizenje, @TipNaDokumentID = TipDokumentID,    
   @TipNaDokumentText = TipNaDokument    
    from viewDokumenti where ID = @tblDokumentiID    
   Declare @OtpecatenaFiskalna bit = null     
       
       
 IF(@TipNaDokumentID = 12 OR @TipNaDokumentID = 14 OR @TipNaDokumentID = 15) BEGIN    
    
    INSERT INTO [dbo].[tblZalihaNaArtikli]    
      ([tblArtikalID]    
      ,[Vlez]    
      ,[Izlez]    
      ,[IDNaDokument]    
      ,[TIpDokument])    
   SELECT ArtikalID,SUM(Kolicina) AS Vlez, 0 AS Izlez, tblDokumentID, @TipNaDokumentID     
   FROM dbo.viewDokumentiStavki     
   WHERE tblDokumentID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID ) AND   tblDokumentID = @tblDokumentiID    
   GROUP BY ArtikalID, tblDokumentID    
  END    
    
  IF(@TipNaDokumentID = 13 OR @TipNaDokumentID = 131 OR @TipNaDokumentID = 132)    
   BEGIN     
    INSERT INTO [dbo].[tblZalihaNaArtikli]    
      ([tblArtikalID]    
      ,[Vlez]    
      ,[Izlez]    
      ,[IDNaDokument]    
      ,[TIpDokument])    
   SELECT ArtikalID,0 AS Vlez,SUM(Kolicina) AS Izlez, tblDokumentID, @TipNaDokumentID     
   FROM dbo.viewDokumentiStavki     
   WHERE tblDokumentID NOT IN ( SELECT IDNaDokument FROM dbo.tblZalihaNaArtikli WHERE TIpDokument = @TipNaDokumentID ) AND  tblDokumentID = @tblDokumentiID    
   GROUP BY ArtikalID, tblDokumentID    
  END    
    
    
   declare @DDVProcent decimal(18,2)    
   DECLARE Dokument_Cursor Cursor for select ArtikalID,  Kolicina, DDVStapka ,DDVIznos, Iznos, IznosBezDDV, Rabat1  from viewDokumentiStavki where tblDokumentID = @tblDokumentiID    
      OPEN Dokument_Cursor    
    FETCH NEXT FROM Dokument_Cursor into @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV ,@Rabat   
   WHILE @@FETCH_STATUS = 0    
   BEGIN    
    BEGIN    
     set @tblNormativID = null    
     Select @tblEdinecnaMerka  = tblEdinecniMerkiID, @tblDDVID = tblDDVStavkaID, @NabavnaCena = NabavnaCena,    
     @ProdaznaCena = ProdaznaCena, @Sifra = Sifra from tblArtikal where ID = @tblArtikalID     
         
     select @EdinecnaCena = NabavnaCenaBezDDV from tblPriemStavki where tblArtikalID = @tblArtikalID     
     if(@ProdaznaCena is not null) and (@tipNaKnizenje <> 0)    
     BEGIN    
      INSERT INTO tblKnizenjeM (tblNormativID,tblArtikalID,tipNaArtikal,ProdaznaCena,Kolicina,Sifra,    
        tblEdinecnaMerka,tblDDVID,tipNaKnizenje,NabavnaCena,EdinecnaCena,IznosSoDDV,IznosBezDDV,IznosDDV,    
        DatumNaKnizenje,tblUserID,tblObjektiID,DatumNaPocetok,DatumNaKraj,tblSmetkaID,tblDokumentID,tblPriemID,    
        OtpecatenaFiskalna,tblObjektiIDOD,tblObjektiIDDO,Rabat)    
        values(@tblNormativID,@tblArtikalID,0,isnull(@ProdaznaCena,0),@Kolicina,@Sifra,    
        isnull(@tblEdinecnaMerka,0),@tblDDVID,@tipNaKnizenje,@NabavnaCena,@EdinecnaCena,@IznosSoDDV,@IznosBezDDV,@IznosDDV,    
        @DatumNaPocetokNaSmetka,@UserID,@ObjektID,@DatumNaPocetokNaSmetka,@DatumNaPocetokNaSmetka,null,@tblDokumentiID,null,    
        @OtpecatenaFiskalna,@OdObjekt, @DoObjekt, @Rabat)    
     END    
     IF(@tipNaKnizenje = -1) AND @TipNaDokumentText LIKE '����������%'    
     BEGIN    
      DECLARE @brojNaIzvod int    
      DECLARE @brojNaDokumentId INT    
          
      SELECT @brojNaDokumentId = ID FROM dbo.viewDokumenti WHERE    
       ID = (SELECT  BrojNaDokument FROM dbo.tblDokumenti WHERE Id = @tblDokumentiID)    
      INSERT INTO dbo.tblIzvodi    
      (    
          BrojNaIzvod,    
          Zabeleska,    
          Smetka,    
          DatumNaIzvod    
      )    
      (SELECT Broj,TipNaDokument + ' �� ' + NazivPartner ,N'��������� ��������',Datum FROM dbo.viewDokumenti WHERE @tblDokumentiID = ID)    
          
      SELECT @brojNaIzvod = MAX(dbo.tblIzvodi.ID) + 1 FROM dbo.tblIzvodi     
      INSERT INTO dbo.tblIzvodiStavki    
      (    
          tblIzvodiID,    
          PartnerID,    
          Dolzi,    
          Pobaruva,    
          DokumentID,    
          FakturaID,    
          PriemID,    
          TipNaDokument,    
          BrojNaDokument    
      )    
      VALUES    
      (   (SELECT TOP 1 @@IDENTITY FROM dbo.tblIzvodi),    -- tblIzvodiID - int    
          (SELECT TOP 1 tblPartnerID FROM dbo.viewDokumenti WHERE @tblDokumentiID = ID),    -- PartnerID - int    
          (SELECT SUM(IznosSoDDV) FROM dbo.viewDokumenti WHERE ID = @tblDokumentiID),     
       0,    
          (SELECT TOP 1 ID FROM dbo.tblDokumenti WHERE (TipNaDokument = 12 OR  TipNaDokument = 15) AND ID = (SELECT TOP 1 BrojNaDokument FROM dbo.tblDokumenti WHERE ID = @tblDokumentiID)),    -- DokumentID - int    
          NULL,    -- FakturaID - int    
          NULL,    -- PriemID - int    
          13,    -- TipNaDokument - int    
          (SELECT TOP 1 Broj FROM dbo.viewDokumenti WHERE @tblDokumentiID = ID)    
          )    
     END    
    
     IF(@tipNaKnizenje = 1)     
     AND @TipNaDokumentText LIKE '����������'     
     AND EXISTS(SELECT TOP(1) txIDFirma FROM dbo.tblFirma WHERE txIDFirma LIKE 'SYNC_root')    
     AND @DoObjekt = 3    
     BEGIN    
      EXEC dbo.prenesiDokumentVoObjektdb_Picerija @tblDokumentiID, -- int    
                                         @TipNaDokumentID,     -- int    
                                         @DoObjekt        -- int    
          
     END       
    END     
                
   FETCH NEXT FROM Dokument_Cursor into @tblArtikalID, @Kolicina, @DDVProcent,@IznosDDV,@IznosSoDDV, @IznosBezDDV ,@Rabat   
         END     
    CLOSE Dokument_Cursor;    
    DEALLOCATE Dokument_Cursor;     
    
END