# Oicar Cloud Backend 
## Instructions for creating local postgres db with docker
1. Install docker(create account, download docker and sign in) [docker](https://www.docker.com/)
2. Open terminal and run next command: 
        "docker run --name cloudcalcdb -e POSTGRES_PASSWORD=postgres -p 5432:5432 -d postgres"
3. Next open terminal in root of project and run following commands:
    1. "npm install sequelize-cli -g"
    2. "sequelize init"
    3. In your .env file write following:
        DB_USERNAME=postgres
        DB_PASSWORD=postgres
        DB_DATABASE=cloudcalcdb
        DB_HOST=localhost
        DB_DIALECT=postgres
    4. Run command "npm run migration"
    5. Run project with "npm run start"
