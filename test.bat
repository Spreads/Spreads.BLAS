@echo off
dotnet test test/Spreads.BLAS.Tests/Spreads.BLAS.Tests.csproj -c Debug -v n
dotnet test test/Spreads.BLAS.Tests/Spreads.BLAS.Tests.csproj -c Release -v n