
CREATE FUNCTION [dbo].[GetPCTimeleft](
	@Hostname nvarchar(50)
)
RETURNS int
AS
BEGIN
	DECLARE @startDT DateTime  
	DECLARE @endDT DateTime  
	DECLARE @Res int
	set @startDT = getdate()
	set @endDT = getdate()
	

	if(@StartDT is null OR @endDT is null)
	BEGIN 
		set @Res = -1
	END
	ELSE
	BEGIN 
		SELECT @startDT = StartTime from tblNetworkPC where @Hostname=HostName OR @Hostname=IPAddres
		SELECT @endDT = EndTime from tblNetworkPC where @Hostname=HostName OR @Hostname=IPAddres
		SELECT @Res =  CONVERT(INT, DATEDIFF ( minute , @startDT , @endDT ))
		
	END
	
	RETURN @Res
END
