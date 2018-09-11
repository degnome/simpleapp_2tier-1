# Simple Demo Code Base for a 2 Tier Deployment

This is a simple 2 Tier Code Sample that connects to a SQL Database and retrieves some records, then displays them on a web page.  The purpose of this code sample is to workload options for running a 2 Tier App.

- Web Tier  (DotNet Core MVC Website)
- DB Tier   (SQL Datatbase with a single table)

## Instructions to run on a Developer Workstation

__Requirements:__

1. [DotNet Core](https://docs.microsoft.com/en-us/dotnet/core/about)

```powershell
dotnet --version

## Result
2.1.400
```

2. [LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2016-express-localdb?view=sql-server-2017)

```powershell
SQLLocalDB

## Result   
Microsoft (R) SQL Server Express LocalDB Command Line Tool
Version 13.0.1601.5
...
```

> Note: SQL can be run in a Container if desired see README.md in Database Folder for Directions

__Installation:__

```powershell
# Clone the Repository
git clone https://github.com/danielscholl/simpleapp_2tier.git simpleapp_2tier
cd simpleapp_2tier

# Restore and Build
dotnet restore
dotnet build

# Initiate a LocalDB Database
cd SimpleApp
dotnet ef database update
cd ..

# Execute Test Cases
cd SimpleApp.Tests
dotnet test
cd ..

# Run the App
dotnet run --project SimpleApp
```

__Containers:__

```powershell
# Build the Containers
docker-compose build

# Launch the Containers
docker-compose up

# Halt the Containers
docker-compose down
```

>Note: Set the Environment Variable for Registry Support ${DOCKER_REGISTRY}