<div align="center">

# National and State Parks Directory

</div>

<div align="center">
<img src="https://github.com/HarrisonStrand.png" width="200px" height="auto" >
</div>
<h3 align="center">National and State Parks Directory 1-22-2021</h3>
<h4 align="center"> By Harrison Strand</h4>

## Description

Parks Client/Api Project

This project was designed to display and update national and state parks using a client side web application and local api with CRUD functionality. Users can view, add, update and delete national and state park entries using the client project server while simultaneously updating the parks api/database.

Model: NationalPark

- Id
- Name
- Location
- DateEstablished
- Acres
- YearlyVisitors
- Description

Model: StatePark

- Id
- Name
- State
- Region
- Camping
- Description

Stretch Goals: 

- Tags
- Authentication
- Admin Abilities
- Search by Property
- Ranged Search

## User Stories

<details>
  <summary>Expand</summary>

| ID   | User Story                                                                                            | Accepted |
| ---- | ----------------------------------------------------------------------------------------------------- | -------- |
| US01 | "As a user, I want to be able to display all National and State Parks by name."                       | True     |
| US02 | "As a user, I want to be able to display a certain National Park or State Parks details."             | True     |
| US03 | "As a user, I want to be able to create National and State Park Entries (admin)."                     | True     |
| US04 | "As a user, I want to be able to update and delete certain National and State Parks."                 | True     |
| US05 | "As a user, I want to be able to search for a specific park by a specific property."                  | True     |
| US06 | "As a user, I want to be able to display information with a different version of the project."        | True     |
| US07 | "As a user, I want to be able to display route information using swagger UI."                         | True     |

</details>
<br>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to the project repository: [Project Repository](https://github.com/HarrisonStrand/NationalParks.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone ` into the directory you would like to clone the repository
- Open in preffered text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the `Parks` folder in the command line
- Use the command `dotnet build` to compile
Next:
- Navigate to the `ParksClient` folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the `Parks` folder in the command line
- Use the command `dotnet restore`
Next:
- Navigate to the `ParksClient` folder in the command line
- Use the command `dotnet restore`
<br>
<details>

  <summary>Expand for Database Installation</summary>

### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=harrison_strand;uid=root;pwd=YourPassword;"
    }
}
```

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to `Parks` directory in terminal
2. Use the command `dotnet ef database update` to generate the database through Entity Framework Core

### Update Database Using Entity Framework Core

1. Write any new code you wish to add to the database. Use the command `dotnet build` to check for any compiling errors. If no errors, proceed to step 2.
2. To update the database with any changes made to the code, use the command `dotnet ef migrations add [MigrationsName]`
3. Use the command `dotnet ef database update` to update the database

### Update Database Using MySQL Workbench

1. Open MySQL Workbench
2. Click on Server > Data Import in the top navigation bar
3. Select `Import from Self-Contained File`
4. Select the `Default Target Schema` or create new schema
5. Select all Schema Objects you would like to import
6. Select `Dump Structure and Data`
7. Click `Start Import`

## **SQL Schema For Manual Entry**
```
-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: harrison_strand
-- ------------------------------------------------------
-- Server version	8.0.15

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `NationalParks`
--

DROP TABLE IF EXISTS `NationalParks`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `NationalParks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Location` longtext,
  `DateEstablished` longtext,
  `Acres` longtext,
  `YearlyVisitors` longtext,
  `Description` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `StateParks`
--

DROP TABLE IF EXISTS `StateParks`;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `StateParks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `State` longtext,
  `Region` longtext,
  `Camping` longtext,
  `Description` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- Dump completed on 2021-01-22 15:32:10

```

</details>
<br>

## View In Browser

- To have access to the browser or Postman routes, navigate to `Parks` folder in the command line
- Use the command `dotnet run` to execute the compiled code and start http://localhost:5001
- In a second command line window, navigate to `ParksClient` folder
- Use the command `dotnet run` to execute the compiled code and start http://localhost:5000
- Use `command+leftclick` to open the host in a browser, or copy/paste http://localhost:5000 into your browser URL

## API Documentation
Explore the API endpoints in Postman or a browser. [Download Postman](https://www.postman.com/downloads/)

### Using Swagger Documentation 
- To explore the Parks API with Swashbuckle, launch the project using `dotnet run` with the command line, and input the following URL into your browser: `http://localhost:5001/swagger`
- To display raw json formatted api information, input the folling URL into your browser: `http://localhost:5001/swagger/v1/swagger.json`

Once you navigate to the Swagger UI, you will have the ability to see displayed routes with cooresponding crud functionality. click on a specific route and follow the prompt to manipulate the database entries of the api.

#### Example Query

To search for a specific park entry use the following format in Postman or your browser:

```
https://localhost:5001/api/nationalparksv2/?location=Minnesota&name=Voyageurs
```

To use default full list, _don't include_ `location` and `name` or set them equal to zero.
To use different versions of query, _add_ `api-version=[versionhere]` after the `?`.
To search for state parks instead, replace `nationalparksv2` with `stateparksv2`.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5001`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5001/api/nationalparksv2/6
```

#### Sample JSON Response
```
{
  Id = 5,
  Name = "Acadia",
  Location = "Maine",
  DateEstablished = "February 26, 1919",
  Acres = "49,076.63 acres",
  YearlyVisitors = "3,437,286",
  Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats."
}
```

..........................................................................................

### National Parks
Access information on National Parks around the country.

#### HTTP Request
```
GET /api/nationalparksv2
POST /api/nationalparksv2
GET /api/nationalparksv2/{id}
PUT /api/nationalparksv2/{id}
DELETE /api/nationalparksv2/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Id | int | none | false | Return matches by park Id.
| name | string | none | false | Return matches by park name.
| location | string | none | false | Return matches by location in the United States |
| dateestablished | string | none | false | Return matches by the date the park was established.
| acres | string | none | false | Return matches by number of acres for the park.
| yearlyvisitors | string | none | false | Return matches by the number of yearly visitors.

#### Example Query
```
https://localhost:5001/api/nationalparksv2/?location=Minnesota
```

#### Sample JSON Response
```
{
  Id = 6,
  Name = "Voyageurs",
  Location = "Minnesota",
  DateEstablished = "April 8, 1975",
  Acres = "218,222.35 acres",
  YearlyVisitors = "232,974",
  Description = "This park protecting four lakes near the Canada–US border is a site for canoeing, kayaking, and fishing. The park also preserves a history populated by Ojibwe Native Americans, French fur traders called voyageurs, and gold miners. Formed by glaciers, the region features tall bluffs, rock gardens, islands, bays, and several historic buildings."
}
```

..........................................................................................

### State Parks
Access information on State Parks around the country.

#### HTTP Request
```
GET /api/stateparksv2
POST /api/stateparksv2
GET /api/stateparksv2/{id}
PUT /api/stateparksv2/{id}
DELETE /api/stateparksv2/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| Id | int | none | false | Return matches by park Id.
| name | string | none | false | Return matches by park name.
| State | string | none | false | Return matches by State in the United States |
| Region | string | none | false | Return matches by the region of the State.
| camping | string | none | false | Return matches by whether you can or cannot camp.

#### Example Query
```
https://localhost:5001/api/stateparksv2/?location=Oregon
```

#### Sample JSON Response
```
{
  Id = 2,
  Name = "Smith Rock State Park",
  State = "Oregon",
  Region = "Central Oregon",
  Camping = "Yes",
  Description = "Smith Rock State Park is a state park located in central Oregon's High Desert near the communities of Redmond and Terrebonne. The day-use area of the park is open daily from dawn to dusk. The park also has a camping area as well that accommodates tent camping only. Its sheer cliffs of tuff and basalt are ideal for rock climbing of all difficulty levels. Smith Rock is generally considered the birthplace of modern American sport climbing, and is host to cutting-edge climbing routes. It is popular for sport climbing, traditional climbing, multi-pitch climbing, and bouldering."
}
```

------------------------------


## Known Bugs
No known bugs...

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <harrisonstrand@gmail.com>.

## Technologies Used

- .NET Core 2.2.0
- ASP.NET Core MVC
- ASP.NET Core Razor Pages
- Bootstrap
- C# 7.3
- CSS
- Entity Framework Core
- GitHub
- HTML
- MySQL
- MySQL Workbench
- Postman
- Swagger/Open API
- Swashbuckle
- Versioning API
- VS Code

## 👥 Contributors

| Author | Email |
|--------|:-----:|
| [Harrison Strand](https://www.linkedin.com/in/harrisonstrand/) | [harrisonstrand@gmail.com](mailto:harrisonstrand@gmail.com) |
------------------------------

### 📝 Legal

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 Harrison Strand<img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8Q_3EVY7j95tTyemJwWxMR7jwvUK7gPe0_w&usqp=CAU" width="2%" height="auto">

<center><a href="#">Return to Top</a></center>