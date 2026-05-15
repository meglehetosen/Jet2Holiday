param(
    [string]$Configuration = "Release",
    [string]$OutputPath = "..\publish\FoglalasApi"
)

$ErrorActionPreference = "Stop"
$scriptRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
$solutionRoot = Resolve-Path (Join-Path $scriptRoot "..")
$project = Join-Path $solutionRoot "FoglalasApi\FoglalasApi.csproj"
$output = Join-Path $solutionRoot $OutputPath

dotnet publish $project -c $Configuration -o $output

Write-Host ""
Write-Host "Published FoglalasApi to:"
Write-Host $output
Write-Host ""
Write-Host "Copy this folder to the VM, then run scripts\run-foglalas-api-on-vm.ps1 on the VM."
