FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Inpulse.WebApi/Inpulse.WebApi.csproj", "Inpulse.WebApi/"]
RUN dotnet restore "Inpulse.WebApi/Inpulse.WebApi.csproj"
COPY . .
WORKDIR "/src/Inpulse.WebApi"
RUN dotnet build "Inpulse.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inpulse.WebApi.csproj" -c Release -o out
CMD ASPNETCORE_URLS=http://*:$PORT dotnet out/Inpulse.WebApi.dll