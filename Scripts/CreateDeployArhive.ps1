param
(
  [Parameter(Mandatory)]
  $ExePath,

  [Parameter(Mandatory)]
  $Destination


)

Add-Type -Path "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\System.IO.Compression.FileSystem.dll"

$dateimeNow = [int][double]::Parse((Get-Date -UFormat %s))
$dateimeNowFormated = $dateimeNow.toString()
$NameWithTimeStampShort = "BS_" + $dateimeNowFormated + ".zip"

echo $dateimeNowFormated

$ExePathFull = $ExePath + "\AppOut\"
$DestPathFull = $Destination + "\" + $NameWithTimeStampShort.ToString()
$DestPathFullSmall = $Destination + "\S_" + $NameWithTimeStampShort.ToString()
$DllCopyPath = $Destination + "\Dll\"

echo $ExePathFull
echo $DestPathFull
echo $DestPathFullSmall
echo $DllCopyPath
echo $Destination

$main = $ExePathFull + "\*.exe"
$MFakturi = $ExePathFull + "\MFakturi.dll"
$MFiskalna = $ExePathFull + "\MFiskalna.dll"
$MKelner = $ExePathFull + "\MKelner.dll"
$MMaterijalno = $ExePathFull + "\MMaterijalno.dll"
$MReport = $ExePathFull + "\MReport.dll"
$BSS = $ExePathFull + "\BSS.dll"


$Path = $Destination
$Daysback = "-10"
$CurrentDate = Get-Date
#$DatetoDelete = $CurrentDate.AddDays($Daysback)
#Get-ChildItem $Path | Where-Object { $_.LastWriteTime -lt $DatetoDelete } | Remove-Item



echo $main
echo $MFakturi
echo $MFiskalna
echo $MKelner
echo $MMaterijalno
echo $MReport
echo $BSS

if (![System.IO.Directory]::Exists($DllCopyPath))
{
     New-Item -ItemType Directory -Force -Path $DllCopyPath
}

echo "-------------------------------------------------1 " + $main + " -> " + $DllCopyPath
Copy-Item -path $main  -destination $DllCopyPath 
echo "-------------------------------------------------2 " + $MFakturi + " -> " + $DllCopyPath
Copy-Item -path $MFakturi  -destination $DllCopyPath
echo "-------------------------------------------------3 " + $MFiskalna + " -> " + $DllCopyPath
Copy-Item -path $MFiskalna  -destination $DllCopyPath
echo "-------------------------------------------------4 " + $MFiskalna + " -> " + $DllCopyPath
Copy-Item -path $MKelner  -destination $DllCopyPath
echo "-------------------------------------------------5 " + $MKelner + " -> " + $DllCopyPath
Copy-Item -path $MMaterijalno  -destination $DllCopyPath
echo "-------------------------------------------------6 " + $MMaterijalno + " -> " + $DllCopyPath
Copy-Item -path $MReport  -destination $DllCopyPath
echo "-------------------------------------------------7 " + $MReport + " -> " + $DllCopyPath
Copy-Item -path $BSS  -destination $DllCopyPath
echo "-------------------------------------------------8 " + $BSS + " -> " + $DllCopyPath

[io.compression.zipfile]::CreateFromDirectory($ExePathFull, $DestPathFull); 
[io.compression.zipfile]::CreateFromDirectory($DllCopyPath, $DestPathFullSmall); 