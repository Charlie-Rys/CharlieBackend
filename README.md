
Clean Architecture Boilerplate - ASP.NET Core 5.0 WebApi
Clean Architecture Solution Template for ASP.NET Core 5.0. Built with Onion/Hexagonal Architecture and incorporates the most essential Packages your projects will ever need.
Clean Architecture Solution Template
.NET Core
Installing the tools
####dotnet ef dotnet tool install --global dotnet-ef
Migration Commands for identity
dotnet ef migrations add "Initial" --project CharlieBackend.Infrastructure --startup-project CharlieBackend.Api --output-dir Migrations --context IdentityContext
dotnet ef database update --project CharlieBackend.Infrastructure --startup-project CharlieBackend.Api --context IdentityContext
Migration Commands for application
dotnet ef migrations add "Initial" --project CharlieBackend.Infrastructure --startup-project CharlieBackend.Api --output-dir Migrations\ApplicationDb --context ApplicationDbContext
dotnet ef database update --project CharlieBackend.Infrastructure --startup-project CharlieBackend.Api --context ApplicationDbContext
Guide to work on this template
Entity - Domain.Entities
Configuration - Infrastructure.Configuration
Seeds - Infrastructure.Seeds
Interface Repository - Application.Interface.Repositories
Class Repository - Infrastructure.Repositories
Register Repository in Service Collection - Infrastructure.Extensions
CQRS (Commands and Queries) - Application.Features
Mappings - Application.Mappings
Controller - API.Controllers
Api testing using Postman - ./Postman/SIDC-MMS.postman_collection.json
Technologies Used
ASP.NET Core 5.0 WebAPI
ASP.NET Core 5.0 MVC
Entity Framework Core 5.0
Features Included
ASP.NET Core 5.0 MVC Project
Slim Controllers using MediatR Library
Permissions Management based on Role Claims
Toast Notification (includes support for AJAX Calls too)
Serilog
ASP.NET Core Identity
AdminLTE Bootstrap Template (Clean & SuperFast UI/UX)
AJAX for CRUD (Blazing Fast load times)
jQuery Datatables
Select2
Image Optimization
Includes Sample CRUD Controllers / Views
Active Route Tag Helper for UI
RTL Support
Complete Localization Support / Multilingual
Clean Areas Implementation
Dark Mode!
Default Users / Roles Seeding at Startup
Supports Audit Logging / Activity Logging for Entity Framework Core
Automapper
ASP.NET Core 5.0 WebAPI
JWT & Refresh Tokens
Swagger
About the Authors
Mukesh Murugan
Blogs at codewithmukesh.com
Facebook - codewithmukesh
Twitter - Mukesh Murugan
Twitter - codewithmukesh
Linkedin - Mukesh Murugan