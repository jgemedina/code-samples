Param(
    [Parameter(Mandatory = $true)] [string] $PlanKey
)

$planMap = @{
    "hig" = "Avaktiverade tidsinst. (Pres.)";
    "bal" = "Balanserat"
}

function WriteHeader() {
    Write-Host "PowerPlan Control"  -ForegroundColor Cyan
    Write-Host ("=" * 4) -ForegroundColor Cyan
}
function ListPowerPlans() {
    Write-Host "`n"
    Write-Host "List of Power Plans in " -NoNewline
    Write-Host "$env:COMPUTERNAME" -ForegroundColor Yellow
    "=" * 4
    
    Get-WmiObject -NS root\cimv2\power -Class Win32_PowerPlan |
        Select-Object -Property ElementName, IsActive |
        Format-Table -AutoSize
    
    Write-Host "`n"
}

function ActivatePowerPlan([string] $planKey) {
    $planName = $planMap[$planKey]
    $planObject =   Get-WmiObject -NS root\cimv2\power -Class Win32_PowerPlan -Filter "ElementName='$planName'"
    if ($null -eq $planObject) {
        Write-Host "Power Plan not found, verify the Plan Key given is correct" -ForegroundColor Red
        Exit -1
    }

    Write-Host "Activating Plan: " -NoNewline
    Write-Host $planName -ForegroundColor Yellow

    $planObject.Activate()
}

WriteHeader
ActivatePowerPlan $PlanKey
ListPowerPlans
