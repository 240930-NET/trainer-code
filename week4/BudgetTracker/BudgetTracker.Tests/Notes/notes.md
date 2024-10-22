## Add moq to test project
```bash
dotnet add package moq
```
## Run to install report generator tool (installs globaly, so only needed once)
```bash
dotnet tool install -g dotnet-reportgenerator-globaltool
```

## Run to generate test coverage
```bash
dotnet test --collect:"XPlat Code Coverage"
```

## Find guid inside test result folder and run to generate html report
```bash
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html -classfilters:"+{serviceName}.Service.*;+{utilities}.API.Utilities.*"
```