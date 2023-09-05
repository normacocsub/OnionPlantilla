FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TiendaOnion/", "TiendaOnion.TiendaOnion/"]
COPY ["Dominio/", "TiendaOnion.Dominio/"]
COPY ["Infraestructura/", "TiendaOnion.Infraestructura/"]
COPY ["Aplicacion/", "TiendaOnion.Aplicacion/"]

RUN dotnet restore "TiendaOnion.TiendaOnion/TiendaOnion.csproj" -r linux-arm64
COPY . .
WORKDIR "/src/TiendaOnion.TiendaOnion"
RUN ls 
RUN dotnet build "TiendaOnion.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/TiendaOnion.TiendaOnion"
RUN dotnet publish "TiendaOnion.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TiendaOnion.dll"]