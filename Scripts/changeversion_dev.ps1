param
(

  [Parameter(Mandatory)]
  $Destination


)
$timestamp = Get-Date -Format "dddd MM/dd/yyyy" | ForEach-Object { $_ -replace ":", "." }
(Get-Content $Destination\temp.txt).replace('[Description]', $timestamp + ' Upgrade to version : [ProductVersion] WebSite: http://bssr.mk ').replace('[ProductVersion]', (get-item $Destination\BSS.exe).VersionInfo.ProductVersion).Replace('[Size]', [string](Get-Item $Destination\BSS.exe).length) | Set-Content $Destination\updates.txt
(Get-Content $Destination\updates.txt)
 Write-Output "http://bssr.mk/BSS_DEV//Installer/Setup Files/BSS.exe"