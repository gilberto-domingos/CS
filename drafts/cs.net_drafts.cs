docker build -t app .


dotnet--version
8.0.112

//No Windows, ao abrir o projeto no Visual Studio, vá no Gerenciador de Pacotes NuGet e restaure as dependências com:
dotnet restore


// Docker
docker exec -u root -it sqlserver bash
sqlcmd -S localhost -U SA -P "csharp_database"


docker exec -it sqlserver bash


docker exec -it sqlserver /opt/mssql-tools/bin/sqlcmd -S localhost -U $DB_USER -P $DB_PASSWORD

docker stop sqlserver
docker rm sqlserver
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=csharp_database' -e 'MSSQL_PID=Express' -p 1433:1433--name sqlserver -d mcr.microsoft.com/mssql/server:latest

docker run -e 'ACCEPT_EULA=Y' \
           -e 'SA_PASSWORD=csharp_database' \
           -e 'MSSQL_PID=Express' \
           -p 1433:1433 \
           --name sqlserver \
           -d mcr.microsoft.com/mssql/server:latest


docker run --env-file .env \
           -e 'ACCEPT_EULA=Y' \
           -e 'MSSQL_PID=Express' \
           -p 1433:1433 \
           --name sqlserver \
           -d mcr.microsoft.com/mssql/server:latest



//  React docker node.js 

docker pull node:latest
/* 
docker run -it -d \
  -p 3000:3000 \
  --name react \
  -v $(pwd):/app \
  -w /app \
  node:latest bash 
  */

docker exec -it react /bin/bash

npx create-react-app cs-front
cd cs-front
npm start




