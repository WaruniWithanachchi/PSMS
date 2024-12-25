CREATE TABLE Products(

Pr_Code int Primary key not null,
Pr_Name nvarchar(50) not null,
Pr_Type nvarchar(50) not null,
Pr_Quantity float not null,
Pr_Price float not null,
insert_date DATETIME,
update_date DATETIME,
delete_date Datetime
)

SELECT*FROM Products;