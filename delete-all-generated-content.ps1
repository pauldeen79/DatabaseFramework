Get-ChildItem *.template.generated.cs -Recurse | foreach { Remove-Item -Path $_.FullName }