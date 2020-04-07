del ..\artifacts\*.nupkg

dotnet restore ..\src\Spreads.BLAS
dotnet pack ..\src\Spreads.BLAS -c Release -o ..\artifacts -p:AutoSuffix=True

pause