# Instructions to use Docker for the Database

SQL can be run from within a container if desired.

__Requirements:__

1. [Docker](https://www.docker.com/get-started)

    ```powershell
    docker --version
    docker-compose --version


    ## Result
    Docker version 18.06.1-ce, build e68fc7a
    docker-compose version 1.22.0, build f46880fe
    ```

## Start and Stop the Database

```powershell
# Set an Environment Variable To Specify the Connection String
$env:CONNECTIONSTRING="Data Source=$env:computername,9433;Initial Catalog=SimpleAppDB;User ID=sa;Password=PasswordAzure@123!"

# Bring up the Database
docker-compose up -d

# Bring down the Database
docker-compose down
```