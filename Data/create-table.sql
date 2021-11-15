DROP TABLE OrderLines
DROP TABLE Orders
DROP TABLE UserAddresses
DROP TABLE UserHashes
DROP TABLE Users
DROP TABLE Addresses
DROP TABLE BillingAddresses
DROP TABLE DeliveryTypes
DROP TABLE Products
GO



CREATE TABLE Products (
Id int not null identity primary key,
Name nvarchar(150) not null,
Description nvarchar(max) not null,
Size varchar(15) not null,
ListPrice money not null,
InStock bit not null
)

CREATE TABLE DeliveryTypes (
Id int not null identity primary key,
Name nvarchar(50) not null unique
)


CREATE TABLE Addresses (
Id int not null identity primary key,
AddressLine nvarchar(100) not null,
AdditionalAddressLine nvarchar(100) not null,
HouseNr smallint,
AdditionalHouseNr smallint,
ZipCode char(5) not null,
Country nvarchar(74) not null,
City nvarchar(50) not null
)

CREATE TABLE BillingAddresses (
Id int not null identity primary key,
AddressLine nvarchar(100) not null,
HouseNr bigint,
ZipCode char(5) not null,
Country nvarchar(74) not null,
City nvarchar(50) not null
)



CREATE TABLE Users (
Id int not null identity primary key,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
PhoneNumber varchar(15) not null,
Email varchar(50) not null unique,
Password nvarchar(100) not null,
Business varchar(160) not null,
Private nvarchar(50) not null
)

GO

CREATE TABLE UserHashes (
UserId int not null references Users(Id) primary key,
UserHash varchar(max) not null,
UserSalt varchar(max) not null
)

CREATE TABLE UserAddresses (
Id int not null identity primary key,
UserId int not null references Users(Id),
BillingAddressId int not null references BillingAddresses(Id),
AddressId int not null references Addresses(Id)
)

CREATE TABLE Orders (
Id int not null identity primary key,
UserId int not null references Users(Id),
OrderDate datetimeoffset not null,
OurReference nvarchar(100) null,
TrackingNumber varchar(40) not null unique,
DeliveryCompany varchar(15) not null,
EstimatedShippingTime datetimeoffset not null,
status nvarchar(50) not null,
DeliveryTypeId int not null references DeliveryTypes(Id),
BillingAddressId int not null references UserAddresses(Id),
AddressId int not null references UserAddresses(Id)
)

GO

CREATE TABLE OrderLines (
OrderId int not null references Orders(Id),
ProductId int not null references Products(Id),
ElapsedTime TIME not null,
UnitPrice money not null default 0,


primary key (OrderId, ProductId)
)

GO