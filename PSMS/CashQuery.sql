CREATE TABLE Cash (
    Trans_ID int PRIMARY KEY NOT NULL,
    Cust_ID int,
    Emp_ID int,
    Amount float NOT NULL,
    Trans_Date DATETIME NOT NULL,
    Payment_meth nvarchar(50) NOT NULL,
    Insert_date DATETIME,
    Update_date DATETIME,
    Delete_date DATETIME,
    CONSTRAINT fk_Cash_Customers FOREIGN KEY (Cust_ID) REFERENCES Customers(Cust_ID),
    CONSTRAINT fk_Cash_Employees FOREIGN KEY (Emp_ID) REFERENCES Employees(Emp_ID)
)

SELECT*FROM Cash;

-- Step 1: Drop the foreign key constraint
ALTER TABLE Cash
DROP CONSTRAINT fk_Cash_Employees;

-- Step 2: Alter the data type of the Emp_ID column
ALTER TABLE Cash
ALTER COLUMN Emp_ID nvarchar(50);

select * from Cash;

ALTER TABLE Cash
DROP COLUMN Emp_ID;



