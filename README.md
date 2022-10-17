# _Hair Salon_

#### By _**Trevor Hunter**_

#### _An application for The Hunter's Salon to keep track of Stylists and their customers._

## Technologies Used

* _C#_
* _.NET 5_
* _HTML_
* _ASP.NET Core_
* _MySQL Workbench_
* _Entity Framework Core_

## Description

_This application will allow the managers of The Hunter's Salon to add new stylists with their specialties, as well as add clients specifically for each stylist. Application will also let user edit and delete new stylists and customers as well._

## Setup/Installation Requirements

* _Clone project from repo: https://github.com/TrevorH08/HairSalon ._
* _Import trevor_hunter.sql into MySQL Workbench as new schema, using the same name._
* _Create a file in the main project folder /HairSalon called appsettings.json_
* _Enter this code into the file: 
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=trevor_hunter;uid=[ENTER YOUR USERNAME];pwd=[ENTER YOUR PASSWORD];"
  }
}_
* _From there run the following commands in the terminal:_
* _$ dotnet restore_
* _$ dotnet build_
* _$ dotnet run_

## Known Bugs

* _No Known Bugs_

## License

MIT

If you have any questions or issues, head over to this projects GitHub Repository, and navigate to the "Issues" tab to leave feedback! If you have any suggestions or would like to contribute to this project, reach out and let me know!

Copyright (c) 10/16/22 Trevor Hunter

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.