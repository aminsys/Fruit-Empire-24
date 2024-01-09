# Fruit Empire
An ASP.NET Core web application based on the .NET 8. This is a workshop project to learn about Identity framework and how to added it to an existing ASP.NET web application.

## How to add Identity Management Components?
1. Add the .NET Core tool for code scaffolding by typing the command below in the .NET CLI:

   `dotnet tool install dotnet-aspnet-codegenerator --version 8.0.0 --global`

2. Install the following packages that includes code generation templates and dependencies that are used by the scaffolder:

   `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.0`
   
   `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0`
   
   `dotnet add package Microsoft.AspNetCore.Identity.UI --version 8.0.0`
   
   `dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0`
   
   `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0`

3. Run the following command to add the default identity components to the project:
   
   `dotnet aspnet-codegenerator identity --useDefaultUI --dbContext {projectName + Auth}`

4. Install the Entity Framework migration tool:

   `dotnet tool install dotnet-ef --version 8.0.0 --global`

5. Create an EF code migration:

   `dotnet ef migrations add {Name of migration file}`

6. Run the EF migration code to update the database:

   `dotnet ef database update`
