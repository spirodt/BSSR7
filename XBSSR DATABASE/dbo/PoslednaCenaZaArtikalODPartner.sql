CREATE FUNCTION [dbo].[PoslednaCenaZaArtikalODPartner]   
(  
 -- Add the parameters for the function here  
 @tblArtikalID int,  
 @tblPartnerID int  
)  
RETURNS int  
AS  
BEGIN  
 -- Declare the return variable here  
 DECLARE @Result int  
  
select TOP 1 @Result =  isnull(CAST( (IznosSoDDV / Kolicina) as decimal(18,2)),( Select ProdaznaCena from tblArtikal where ID = @tblArtikalID )) from viewKnzienjaM where  tblArtikalID = @tblArtikalID and tblPartnerID = @tblPartnerID   
order by ID DESC
  
  IF(@Result = 0 OR @Result IS NULL) BEGIN
	select TOP 1 @Result =  isnull(CAST( (IznosSoDDV / Kolicina) as decimal(18,2)),( Select ProdaznaCena from tblArtikal where ID = @tblArtikalID )) from viewKnzienjaM where  tblArtikalID = @tblArtikalID and tblPartnerID IS NULL    
	order by ID desc 
	 RETURN @Result  
	END
  

 -- Return the result of the function  
 RETURN @Result  
  
END
