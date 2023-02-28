FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY bin/Release/net6.0 app/
WORKDIR /app
ENTRYPOINT ["dotnet", "WebApplication4.dll"]

#docker network create asp-net

#docker image build --tag asp-web .

#docker run --network asp-net --domainname=my-sql-server -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Sql@2023" -p 1433:1433 -d mcr.microsoft.com/mssql/server

#docker container run --publish 6000:80 --name web-app --network asp-net --env CONNECTION_STRING="Data Source=my-sql-server,1433; Initial Catalog=PersonDb; User Id=sa; Password=Sql@2023; TrustServerCertificate=true" asp-web
