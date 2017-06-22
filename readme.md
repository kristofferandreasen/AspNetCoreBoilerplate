![ASP.NET Core Starter](https://github.com/kristofferandreasen/aspnetcore-starter/blob/master/corestartertop.png)

# ASP.NET Core Starter Template

This template is created as a simple starter application for ASP.NET Core. The template uses no specific front end framework and focuses on providing a landing page for projects. It also contains simple backend method examples such as an HttpClient.

## Getting Started

To begin using this template, choose one of the following options to get started:
* [Download the latest release here](https://github.com/kristofferandreasen/aspnetcore-starter/archive/master.zip)
* Clone the repo: `git clone https://github.com/kristofferandreasen/aspnetcore-starter.git`
* Fork the repo

## Project Structure

```
.
 ├── .vscode                        # Visual Studio Code launch settings
 ├── Controllers                    # The Controllers
 ├── Models                         # The Data Models
 ├── Properties                     # General launch settings of the project in launchsettings.json
 ├── Views                          # The Views
 ├── wwwroot                        # The static files of the project - CSS, JS, Images
 ├── .bowerrc                       # Specifies root directory
 ├── .gitignore                     # Specifies file to ignore with version control
 ├── Program.cs                     # The generic Program.cs build file
 ├── Startup.cs                     # The Startup files with middleware and routing
 ├── appsettings.Development.json   # A file to store settings variables for development
 ├── appsettings.json               # A file to store settings variables for production
 ├── aspnetcorestarter.csproj       # csproj file with NuGet references
 ├── bower.json                     # The DevDependencies - JS libraries
 ├── bundleconfig.json              # The project build definition
 └── readme.md                      # Project Readme file
```

## Start the project
The project can be startet with dotnet commands from the command line.

1. Run `dotnet restore` to build dependencies.
2. Run `dotnet build` to build the solution.
3. To run the project in a browser, run `dotnet run` or use Visual Studio/VS Code.

## Bugs and Issues

Have a bug or an issue with this template? [Open a new issue](https://github.com/kristofferandreasen/aspnetcore-starter/issues) here on Github.

## Creator

The template was created by and is maintained by:
*@ **[Kristoffer Andreasen](https://medium.com/@kristoffer_andreasen)**
*@ **[Jakub Svoboda](https://www.linkedin.com/in/jakubsvobodacz/)**

## Copyright and License

Copyright 2017. Code released under the [MIT](https://github.com/kristofferandreasen/aspnetcore-starter/blob/master/LICENSE) license.