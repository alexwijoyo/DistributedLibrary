FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

COPY ./Library.OnPlatform/Library.OnPlatform.csproj ./Library.OnPlatform/
COPY ./Library.Contracts/Library.Contracts.csproj ./Library.Contracts/
RUN dotnet restore ./Library.OnPlatform/Library.OnPlatform.csproj 

COPY . .
RUN dotnet publish -c Release -o /app --no-restore ./Library.OnPlatform/Library.OnPlatform.csproj 

FROM masstransit/platform:7
WORKDIR /app
COPY --from=build /app ./