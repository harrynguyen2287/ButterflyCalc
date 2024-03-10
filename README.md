# Butterfly Calculator

## Prerequisite

- Visual Studio Code: https://code.visualstudio.com/download
- .net 8 sdk:https://dotnet.microsoft.com/en-us/download

## Run project

- Go to the root folder
- Run the below commnad:

      dotnet run --project src/Api/ButterflyCalc.Api.csproj

## Run unit test
### Test the Core project
- Go to the Core project folder:

      cd test/Core.UnitTest/
- Run the below command:

      dotnet test

### Test the API project
- Go to the Core project folder:

      cd test/Api.UnitTest/
- Run the below command:

      dotnet test