﻿
CREATE FUNCTION [dbo].[StripNonNumerics]
(
  @Temp varchar(255)
)
RETURNS varchar(255)
AS
Begin

    Declare @KeepValues as varchar(50)
    Set @KeepValues = '%[^0-9]%'
    While PatIndex(@KeepValues, @Temp) > 0
        Set @Temp = Stuff(@Temp, PatIndex(@KeepValues, @Temp), 1, '')

    Return @Temp
End