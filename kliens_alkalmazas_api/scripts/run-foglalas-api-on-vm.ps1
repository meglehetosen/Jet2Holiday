param(
    [string]$ApiFolder = ".",
    [string]$Urls = "http://0.0.0.0:5127",
    [string]$ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=Jet2HolidaySQLdb;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Trust Server Certificate=True"
)

$ErrorActionPreference = "Stop"
$env:JET2HOLIDAY_CONNECTION_STRING = $ConnectionString

Write-Host "Starting FoglalasApi on $Urls"
Write-Host "Using API folder: $ApiFolder"

dotnet (Join-Path $ApiFolder "FoglalasApi.dll") --urls $Urls
