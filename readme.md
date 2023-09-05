dotnet ef migrations add PrimeraMigracion --startup-project ../TiendaOnion/TiendaOnion.csproj --context TiendaOnionContext

dotnet ef database update --context TiendaOnionContext --startup-project ../TiendaOnion/TiendaOnion.csproj




docker container run ^
--name sql-server ^
-p 1433:1433 ^
-e ACCEPT_EULA="Y" ^
-e SA_PASSWORD="PruebaBd123*" ^
--volume sql-db:/var/opt/mssql ^
--network onion-app ^
mcr.microsoft.com/mssql/server:2019-latest
