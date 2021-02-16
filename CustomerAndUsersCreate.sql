CREATE TABLE Users
(
Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
FirstName varchar(30) ,
LastName varchar(30),
Email varchar(30),
Passwordd varchar(30)
);
CREATE TABLE Customers
(
Id int  NOT NULL PRIMARY KEY,
CompanyName varchar(30) ,
UserId int
CONSTRAINT fkCustomerId Foreign Key (UserId) References Users(Id)
);