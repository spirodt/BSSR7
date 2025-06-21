param
(  

  [Parameter(Mandatory)]
  $Destination,

  [Parameter(Mandatory)]
  $Destination2
)



$Files = Get-ChildItem -Filter *.sql


foreach($dll in $Files){cp $dll.fullname $Destination}

foreach($dll in $Files){cp $dll.fullname $Destination2}


