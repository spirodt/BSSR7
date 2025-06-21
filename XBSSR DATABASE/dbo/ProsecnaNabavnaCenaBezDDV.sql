CREATE FUNCTION [dbo].[ProsecnaNabavnaCenaBezDDV]   
(  
 -- Add the parameters for the function here  
 @ID int  
)  
RETURNS decimal(18,2)  
AS  
BEGIN  
 -- Declare the return variable here  
 DECLARE @Result decimal(18,2)  
  
 -- Add the T-SQL statements to compute the return value here  
   
 SELECT @Result = SUM(IznosBezDDV) /  IIF(SUM(Kolicina) = 0,1,SUM(Kolicina)) from viewKnzienjaM where  tblArtikalID = @ID and tipNaKnizenje  = 3 AND IznosBezDDV <> 0 and Kolicina <> 0 

  
 -- Return the result of the function  
 RETURN isnull(@Result,0)  
  
END
