CREATE TABLE Customers(

Cust_ID int Primary key not null,
F_Name nvarchar(50) not null,
L_Name nvarchar(50) not null,
Cust_Address nvarchar(50)not null,
Cust_Phone float not null,
insert_date DATETIME,
update_date DATETIME,
delete_date Datetime
)

SELECT*FROM Customers;

Alter Table Customers
Alter column Cust_Address Int not null;

Alter Table Customers
Alter column Cust_Phone nvarchar(10) not null;

Alter Table Customers
Alter column Cust_Address nvarchar(50) not null;
