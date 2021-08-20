## SQL Design
![screenshot](database_image.png)

# __Bunny Rescue Animal Shelter__
### by [John Blalock](https://github.com/simpledimplejohn) 

### __Description__
This is a database with an API back end that's accessible by POSTMAN or through an API client controller.  It is build with ASP.Net Core and has full CRUD functionality in place.  It follows RESTful conventions.


### __Technologies Used__

* _C#_
* _ASP.Net Core_
* _NuGet_
* _MySQL Database_
* _EF_Core_
* _Migration_
* _API Restful_


### __Setup/Installation__

1. _Download repo from github_
2. _Launch in VS Code_
3. _Navigate to the Factory directory_
4. _add a filed called `appsettings.json`_
5. _include this code in the file:_
    `{`  
`  "ConnectionStrings": {`  
`      "DefaultConnection": "Server=localhost;Port=3306;=john_blalock;uid=root;pwd=[PASSWORD];"`  
`  }`  
`}`  
6. _Open MySQL Workbench_
7. _Log in and connected to the Local instance 3306_
8. _Navigate to the Administration tab_
9. _Select Data Import/Restore_
10. _Now navigate to the Factory directory in the consol._
11. _Download dotnet ef tool by running:_
    `dotnet tool install --global dotnet-ef --version 3.0.0`
12. _Run the initial migration with:_
    `dotnet ef migrations add Initial`
13. _Apply these migrations to the database with:_
    `dotnet ef database update`
14. _run the application with_
    `dotnet run` 
15. _This should run the app on local server 5000_
16. _Navigate to HTTP://localhost:5000_
17. _To Access CRUD functionality download and run [Postman](https://www.postman.com/downloads/)_
18. _Start a new workspace with the Building Blocks of HTTP Request_
19. _To see a list of all animals:_
    Select: `GET` | Address: `http://localhost:5000/api/animals`  
20. _To see details of a specific animal id:_  
    Select: `GET` | Address: `http://localhost:5000/api/animals/{id}`  
21. _To delete an animal:_  
    Select: `DELETE` | Address: `http://localhost:5000/api/animals/{id}`  
22. _To add an animal:_  
    Select: `POST` | Address: `http://localhost:5000/api/animals/{id}`  
    In the body create your animal as follows:  
    `{`   
    `"animalId": 1,`   
    `"species": "Bunny",`   
    `"name": "Very Bitty",`   
    `"age": 1,`   
    `"gender": "Male"`   
    `}`   
22. _To change details of an animal:_  
    Select: `PUT` | Address: `http://localhost:5000/api/animals/{id}`  
    In the body create your animal as follows:  
    `{`   
    `"animalId": 1,`   
    `"species": "Bunny",`   
    `"name": "VERY Very Bitty",`   
    `"age": 1,`   
    `"gender": "Male"`   
    `}`   






### __Known Bugs / Future Goals__
No bugs have been found or reported. Please contact the authors if you experience poor performance.



### __License__
This software is licensed under the [BSD license](license.txt).

[![License](https://img.shields.io/badge/License-BSD%202--Clause-orange.svg)](https://opensource.org/licenses/BSD-2-Clause)

Copyright (c) 2021 

### __Contact Information__
 __John Blalock simpledimplejohn@gmail.com__
