Within a project directory.
 
Create a new project. Append <.APP> so you know this is the app for the project.

```bash
dotnet new console -n MyApp.APP --use-program-main
```

Create testing project. Append <.Tests> so you know these are the tests to this project.

```bash 
dotnet new xunit -o MyApp.Tests
```

If a solution (sln) file does not exist, create one.

```bash 
dotnet new sln -n MyAppSLN
```

Add the csproj for both the APP and Test projects into the solution file.

```bash
dotnet sln add ./MyApp.APP/MyApp.APP.csproj
dotnet sln add ./MyApp.Tests/MyApp.Tests.csproj
```

Add the APP as a dependency into the Test csproj so the Test project can call classes/methods from the App.

```bash
dotnet add ./MyApp.Tests/MyApp.Tests.csproj reference ./MyApp.APP/MyApp.APP.csproj
```
