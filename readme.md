# Oicar Cloud Backend 
## Instructions for creating local postgres db with docker
1. Install docker(create account, download docker and sign in) [docker](https://www.docker.com/)
2. Open terminal and run next command: 
        "docker run --name cloudcalcdb -e POSTGRES_PASSWORD=postgres -p 5432:5432 -d postgres"
3. Connect to postgres with azure data studio or something else and create database

## Connection string
    "default": "server=localhost;database=databaseNameYouCreated;User ID=postgres;password=postgres;"

## Migrations
1. enable-migrations
2. Add-Migration "naziv migracije"
3. update-database

## Migrations on mac
1. OicarContext comment necesary lines
2. Create migration "dotnet ef migrations add nameOfMigration"
3. Update db "dotnet ef database update"