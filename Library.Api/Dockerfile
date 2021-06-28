FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

RUN mkdir -p ./Library.Api
RUN mkdir -p ./Library.Contracts

COPY ./Library.Api/Library.Api.csproj ./Library.Api/
COPY ./Library.Contracts/Library.Contracts.csproj ./Library.Contracts/
RUN dotnet restore ./Library.Api/Library.Api.csproj 

COPY . .
RUN dotnet publish -c Release -o /app --no-restore ./Library.Api/Library.Api.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000
ENTRYPOINT ["dotnet", "Library.Api.dll"]
