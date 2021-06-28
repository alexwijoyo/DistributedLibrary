FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

RUN mkdir -p ./Library.OnPlatform
RUN mkdir -p ./Library.Contracts

COPY ./Library.OnPlatform/Library.OnPlatform.csproj ./Library.OnPlatform/
COPY ./Library.Contracts/Library.Contracts.csproj ./Library.Contracts/
RUN dotnet restore ./Library.OnPlatform/Library.OnPlatform.csproj 

COPY . .
RUN dotnet publish -c Release -o /app --no-restore ./Library.OnPlatform/Library.OnPlatform.csproj 

FROM masstransit/platform
WORKDIR /app
COPY --from=build /app ./