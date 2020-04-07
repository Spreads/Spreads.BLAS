@echo off

dotnet restore ..\src\Spreads.BLAS
dotnet pack ..\src\Spreads.BLAS -c Debug -o C:\transient\LocalNuget  -p:AutoSuffix=True

pause