CREATE TABLE Employees(

Emp_ID int Primary key not null,
Emp_Name nvarchar(50) not null,
Position nvarchar(50) not null,
DOB DATE not null,
Emp_Phone int not null,
insert_date DATETIME,
update_date DATETIME,
delete_date Datetime
)

SELECT*FROM Employees;

ALTER TABLE Employees
Alter column Emp_Phone nvarchar(50) not null;