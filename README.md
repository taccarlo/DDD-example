Clean architecture in order to free architecture from the implementation of the DB

 Clean Architecture Rules
 1 - Model all business rules and entities in the Core project
 2 - All dependencies flow towards the Core project
 3 - Inner projects define interfaces; outer projects implement them

 What belongs in the Core project

- Interfaces
- Aggregates
- Entities 
- Value: Objects to check data
- Domain Services
- Domain Exceptions

- Domain Events
- Event Handlers

- Specifications: query logic 
- Validators
- Enums
- Custom Guards


Following this tutorial https://learn.microsoft.com/en-us/shows/dotnetconf-2021/clean-architecture-with-aspnet-core-6
Code from https://github.com/ardalis/CleanArchitecture

To install the template
dotnet new --install Ardalis.CleanArchitecture.Template::6.0.4

To check installed templates
dotnet new list

To get the proj inside of the directory
dotnet new clean-arch -o NimblePros.DotNetConf
