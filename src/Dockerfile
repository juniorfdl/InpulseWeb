FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base     
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Inpulse.WebApi/Inpulse.WebApi.csproj", "Inpulse.WebApi/"]
RUN dotnet restore "Inpulse.WebApi/Inpulse.WebApi.csproj"
COPY . .
WORKDIR "/src/Inpulse.WebApi"
RUN dotnet build "Inpulse.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Inpulse.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Inpulse.WebApi.dll"]