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

## Find guid inside TestResults folder and replace {guid} in command then run to generate html report
```bash
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

## Same command as above but with classfilters to get rid of stuff not tested
```bash
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html -classfilters:"+{serviceName}.Service.*;+{utilities}.API.Utilities.*"
```