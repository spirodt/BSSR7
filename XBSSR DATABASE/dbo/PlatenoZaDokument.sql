
-- =============================================  
-- Author:  spiro  
-- Create date:   
-- Description:   
-- =============================================  
CREATE FUNCTION [dbo].[PlatenoZaDokument]   
(  
 -- Add the parameters for the function here  
 @PartnerID int,  
 @DokumentID int,  
 @BrojNaDokument int  
)  
RETURNS decimal(18,2)  
AS  
BEGIN  
 -- Declare the return variable here  
 DECLARE @Result decimal(18,2)  
  
 -- Add the T-SQL statements to compute the return value here  
 SELECT @Result = sum(Pobaruva) from viewIzvodiStavki where PartnerID =  @PartnerID and DokumentID = @DokumentID 
  
 -- Return the result of the function  
 RETURN round(@Result, 0)  
END