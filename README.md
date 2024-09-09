This is a simple Cafe shop WebAPi project.
Deploy your WebApi in Azure WebApp - follow below steps.
1) Create a WebApp and sql database in azure portal. Copy the the connection string and set it into environment variable connection string of your WebApp(**dont forget to update connectionstring password).
2) Go to Sql server networking and add your client ip address and also tick the exceptions to all azure services to use the sql server.
3) create a web api project in visual studio(should use same framework version as azure webapp).
4) Create your model classes. Then Create your DbContext class(install required entityframework nuget packages) and also register the DbContext in Program.cs file to get the connection string. Also create your controller classes.
5) then go to package manager console and give to command "Add-Migration first" and check all details for the database columns and constraints. Then give command "Update-Database" to create all the tables and columns in Azure SQL Database.
6) Now update the Menu & SubMenu database by your own.
7) Now test your controller APIs.
