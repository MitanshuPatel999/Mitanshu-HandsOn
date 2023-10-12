USE HandsOn;

CREATE TABLE Departments (
    DepartmentID INT,
    DepartmentName NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Department PRIMARY KEY(DepartmentID)
);
GO

CREATE TABLE Employees (
    EmployeeID INT,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DepartmentID INT,
    DateOfBirth DATE,
    Salary DECIMAL(10, 2),
    CONSTRAINT FK_Department FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    CONSTRAINT PK_Employees PRIMARY Key (EmployeeID)
);
GO

-- Insert data into the Departments table
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
    (1, 'HR'),
    (2, 'Finance'),
    (3, 'Marketing'),
    (4, 'IT');

-- Insert data into the Employees table
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, DateOfBirth, Salary)
VALUES
    (1, 'John', 'Doe', 1, '1990-05-15', 60000.00),
    (2, 'Jane', 'Smith', 2, '1985-08-20', 65000.00),
    (3, 'David', 'Johnson', 1, '1995-02-10', 55000.00),
    (4, 'Emily', 'Wilson', 3, '1988-11-30', 62000.00),
    (5, 'Michael', 'Brown', 4, '1992-04-25', 70000.00),
    (6, 'Sarah', 'Clark', 3, '1991-07-18', 58000.00),
    (7, 'Ryan', 'Lee', 2, '1987-09-05', 63000.00),
    (8, 'Olivia', 'Garcia', 4, '1993-03-12', 68000.00),
    (9, 'William', 'Taylor', 3, '1986-06-22', 59000.00),
    (10, 'Ava', 'Lopez', 1, '1994-01-08', 61000.00);

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, DateOfBirth, Salary)
VALUES
    (11, 'John', 'Doe',null , '1990-05-15', 60000.00)

DELETE FROM Employees
WHERE EmployeeID = 11;

-- INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, DateOfBirth, Salary)
-- VALUES
--     (11, 'John', 'Doe', 5, '1990-05-15', 60000.00)

ALTER TABLE Employees
ADD Bonus int;

update Employees set
Bonus=1000 where EmployeeID=1;

update Employees set
Bonus=1500 where EmployeeID>5;

UPDATE Employees
SET Bonus = 1250.00
WHERE Bonus IS NULL;

CREATE FUNCTION dbo.AddNumbers
(
    @Num1 INT,
    @Num2 INT
)
RETURNS INT
AS
BEGIN
    DECLARE @Sum INT;
    SET @Sum = @Num1 + @Num2;
    RETURN @Sum;
END;

select dbo.AddNumbers(10,20);

IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetFullName'
)
DROP FUNCTION dbo.GetFullName
GO
CREATE FUNCTION dbo.GetFullName(@EmployeeID INT)
RETURNS NVARCHAR(100)
AS
BEGIN
    DECLARE @FullName NVARCHAR(100);
    
    SELECT @FullName = FirstName + ' ' + LastName
    FROM Employees
    WHERE EmployeeID = @EmployeeID;
    
    RETURN @FullName;
END;

select dbo.GetFullName(1);

select * from Departments;
select * from Employees;

