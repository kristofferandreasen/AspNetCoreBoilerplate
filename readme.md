# ASP.NET Core Boilerplate

[![Dependency Status](https://david-dm.org/boennemann/badges.svg)](https://david-dm.org/boennemann/badges) ![DotBadge](http://rebornix.qiniudn.com/dotbadge.svg)

[PROJECT PAGE](http://aspnetcoreboilerplate.azurewebsites.net/)

This template is created as a simple starter application for ASP.NET Core. The template uses no specific front end framework and focuses on providing a landing page for projects. It is created to allow developers to jumpstart their landing page projects or applications.

![Starter GIF](https://github.com/kristofferandreasen/AspNetCoreBoilerplate/blob/master/corestarter.gif)

## Getting Started

To begin using this template, choose one of the following options to get started:
* [Download the latest release here](https://github.com/kristofferandreasen/AspNetCoreBoilerplate/archive/master.zip)
* Clone the repo: `git clone https://github.com/kristofferandreasen/AspNetCoreBoilerplate.git`
* Fork the repo

## Project Structure

The Web Project folder:
```
.
 ├── .vscode                        # Visual Studio Code launch settings
 ├── Controllers                    # The Controllers
 ├── Models                         # The Data Models
 ├── Properties                     # General launch settings of the project in launchsettings.json
 ├── Views                          # The Views
 ├── wwwroot                        # The static files of the project - CSS, JS, Images
 ├── .bowerrc                       # Specifies root directory
 ├── AspNetCoreBoilerplate.csproj   # csproj file with NuGet references
 ├── Program.cs                     # The generic Program.cs build file
 ├── Startup.cs                     # The Startup files with middleware and routing
 ├── appsettings.Development.json   # A file to store settings variables for development
 ├── appsettings.json               # A file to store settings variables for production
 ├── bower.json                     # The DevDependencies - JS libraries
 └── bundleconfig.json              # The project build definition
```

## Start the project
The project can be startet with dotnet commands from the command line.

1. Run `dotnet restore` to build dependencies.
2. Run `dotnet build` to build the solution.
3. To run the project in a browser, run `dotnet run` or use Visual Studio/VS Code.

## Components
The AspNetCoreBoilerplate does not just contain a simple boilerplate without styling. 
We have included a large number of minimalism components.

These include:
* Forms
* Modals
* Search
* Cards
* Table
* Dropdowns

## Sections
Apart from the individual components, the template additionally include sections.
These combine individual components to showcase elements you can directly implement on your website.

These include:
* Header Section
* Navigation Section
* Card section
* Call to action Section
* FAQ Section
* Feature Section
* Icon Sections
* Image Sections
* Options Section
* Testimonials Section
* Footer Section

## Icons
All icons used in the template are open source. I suggest to support the original authors of the work.
The primary icons used are Icons8, which you can find [here](https://icons8.com/).

## Bugs and Issues

Have a bug or an issue with this template? [Open a new issue](https://github.com/kristofferandreasen/AspNetCoreBoilerplate/issues) here on Github.

## Creator

The template was created by and is maintained by:
* [Kristoffer Andreasen](https://medium.com/@kristoffer_andreasen)
* [Jakub Svoboda](https://www.linkedin.com/in/jakubsvobodacz/)

## Copyright and License

Copyright 2017. Code released under the [MIT](https://github.com/kristofferandreasen/AspNetCoreBoilerplate/blob/master/LICENSE) license.