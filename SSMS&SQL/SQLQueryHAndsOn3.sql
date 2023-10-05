use HandsOn;

-- Create the Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DepartmentID INT,
    DateOfBirth DATE,
    Salary DECIMAL(10, 2),
    CONSTRAINT FK_Department FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
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

select * from Employees; 

select * from Departments; 

select d.DepartmentID,COUNT(d.DepartmentName) as Dcount,Avg(e.salary) as AverageSalary
from Employees e inner join Departments d on e.DepartmentID=d.DepartmentID
group by d.DepartmentID;

select d.DepartmentID,Max(e.salary) as MaxSalary
from Employees e inner join Departments d on e.DepartmentID=d.DepartmentID
group by d.DepartmentID;

select d.DepartmentID,STDEV(e.salary) as StandardDevaitionSalary
from Employees e inner join Departments d on e.DepartmentID=d.DepartmentID
group by d.DepartmentID;

select STRING_AGG(FirstName,', ') as ConcatenatingFirstName from Employees;

select d.DepartmentID,COUNT(d.DepartmentName) as Dcount,Avg(e.salary) as AverageSalary
from Employees e inner join Departments d on e.DepartmentID=d.DepartmentID
group by d.DepartmentID
Having Avg(e.Salary)>62000;

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'J%';

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE '%e';

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE '%E';

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE '_a%';

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE '%r%';


--starting transaction
Begin Transaction;

update Employees
set Salary=Salary*1.1
where EmployeeID=2;

If @@ERROR=0
begin	
commit transaction;
Print 'Transaction commited successfully'
end
else
begin
rollback transaction;
print 'Transaction rolled back'
end

select * from Employees;

Begin Transaction
update Employees 
set Salary=70000 
where EmployeeID=3;
update Employees 
set Salary=72000 
where EmployeeID=2;
commit transaction;

Begin Transaction
update Employees 
set Salary=68000 
where EmployeeID=1;
update Employees 
set Salary=73000 
where EmployeeID=2;
checkpoint;
commit transaction;

Begin Transaction;

update Employees
set Salary=75500
where EmployeeID=2;

update Employees
set Salary='Hello'
where EmployeeID=3;

If @@ERROR=0
begin	
commit transaction;
Print 'Transaction commited successfully'
end
else
begin
rollback transaction;
print 'Transaction rolled back'
end