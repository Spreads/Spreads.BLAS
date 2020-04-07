FROM mcr.microsoft.com/dotnet/core-nightly/runtime:3.0.0-preview4-stretch-slim  AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core-nightly/sdk:3.0.0-preview4-stretch-slim AS build
WORKDIR /src
COPY build/common.props build/
COPY test/Spreads.BLAS.Tests.Run/Spreads.BLAS.Tests.Run.csproj test/Spreads.BLAS.Tests.Run/
COPY test/Spreads.BLAS.Tests/Spreads.BLAS.Tests.csproj test/Spreads.BLAS.Tests/
COPY src/Spreads.BLAS/Spreads.BLAS.csproj src/Spreads.BLAS/
RUN dotnet restore test/Spreads.BLAS.Tests.Run/Spreads.BLAS.Tests.Run.csproj
COPY . .
WORKDIR /src/test/Spreads.BLAS.Tests.Run
RUN dotnet build Spreads.BLAS.Tests.Run.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Spreads.BLAS.Tests.Run.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Spreads.BLAS.Tests.Run.dll"]
