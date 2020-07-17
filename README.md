# The Bakery

### By Noel Kirkland

## Description

This is a console application built using C#. The application will allow a user to place an order for baked goods and return to them a total price for that order.

## Specifications

1. The application will create an object instance of Bread with an argument of _quantity_

| Input | Output |
| :--- | :--- |
| 12 | Bread { Quantity=12 } |
|||

2. The application will create an object instance of Pastry with an argument of _quantity_

| Input | Output |
| :--- | :--- |
| 9 | Pastry { Quantity=1 } |
|||

3. The application will return a _total price_ based on the quantity of Bread if a single loaf is $5.00

| Input | Output |
| :--- | :--- |
| 12 | 60 |
|||

4. The application will return a _total price_ based on the quantity of Pastry if one pastry is $2.00

| Input | Output |
| :--- | :--- |
| 9 | 18 |
|||

5. The application will return a _total price_ based on the quantity of Bread if bread is buy-2-get-1-free

| Input | Output |
| :--- | :--- |
| 12 | 40 |
|||

6. The application will return a _total price_ based on the quantity of Pastry if pastries are buy-3-for-$5.00

| Input | Output |
| :--- | :--- |
| 9 | 15 |
|||

## Setup/Installation Requirements

* _Install the framework_
  1. This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)

* _Download this application from HitHub_
  1. _Open the following web address in your browser: `https://github.com/NoelKirkland`_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the `Project-repo` repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Open and run the application_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+` in V.S. Code) and run command **cd Bakery**_
  3. _Now that we are in the Bakery directory you will run the command **dotnet restore**_
  4. _Once the "obj" folder has initialized you can now run **dotnet run** to use the application in your terminal_

* _Optional testing_
  1. _To run the test suite included with this project you will first need to navigate back to the root directory by running **cd ..** in your terminal._
  2. _Move to the to the Bakery.Tests directory by running the command **cd Bakery.Tests**_
  3. _Now that we are in the Bakery.Tests directory you will run the command **dotnet restore**_
  4. _Once the "obj" folder has initialized you can now run **dotnet test** to run all of the tests written in that directory_


## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please contact us through our GitHub accounts.

## Technologies Used

*  Visual Studio Code
*  Markdown
*  C#/.NET


### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Noel Kirkland LLC_**