This is to run the docker container 

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=NotPassword123!" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

This is the connection string to connect to our MSSQL server

```bash
Server=localhost;User Id=sa;Password=NotPassword123!;TrustServerCertificate=true;
```