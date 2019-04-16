$filePath = 'test\\Web\\AspNetCore\\Rest.Test\\appsettings.Test.json'
$connection = 'Server=(local)\SQL2017;Database=Northwind.Test;User ID=sa;Password=Password12!;MultipleActiveResultSets=True;'

$json = (Get-Content -Path $filePath) | ConvertFrom-Json

$json.ConnectionStrings.Northwind = $connection

$json | ConvertTo-Json | Set-Content $filePath