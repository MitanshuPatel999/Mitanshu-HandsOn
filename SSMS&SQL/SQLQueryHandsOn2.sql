use HandsOn;

create table Employee
(
	E_ID int primary key,
	Name nvarchar(20) not null,
	Salary money,
	Dept char(15)
);

select * from Employee;

alter table Employee
add PhoneNo varchar(15);

Insert into Employee Values (1,'Mitanshu',30000,'PS','9999999999');

Insert into Employee Values 
(2,'ABC',25000,'PS','9999999979'),
(3,'DEF',26000,'SS','9999999959'),
(4,'GHI',20000,'MS','9999999991'),
(5,'JKL',22000,'MS','9999999992'),
(6,'MNO',28000,'PS','9999999995'),
(7,'PQR',28000,'HR','9999999998')
;

alter table Employee
add Adress varchar(50);

ALTER TABLE Employee
DROP COLUMN Adress,PhoneNo;

create table Department(
DeptID int primary key,
Dept varchar(15),
DName varchar(20)
);

select * from Department;

Insert into Department Values 
(1,'PS','Professional Service'),
(2,'MS','Managed Service'),
(3,'SS','Solution Service'),
(4,'HR','Human Resource');

ALTER TABLE Department
ADD CONSTRAINT PK_DeptID PRIMARY KEY (DeptID);

ALTER TABLE Department 
DROP CONSTRAINT PK_DeptID;

ALTER TABLE Employee
ADD CONSTRAINT CHK_Emp_Salary CHECK(Salary > 10000 AND Salary < 40000);

Insert into Employee Values (7,'XYZ',1000,'PS');--Not acceptable, show below error
/*
Violation of PRIMARY KEY constraint 'PK__Employee__D730AF54F8AFF990'.
Cannot insert duplicate key in object 'dbo.Employee'.
The duplicate key value is (7).
*/

select E_ID,Name,Department.DName,DeptID from Employee inner join Department
ON Employee.Dept=Department.Dept;

Insert into Department Values 
(5,'ES','Extra Service');

Insert into Employee Values (8,'wxy',30000,'QS');


select E_ID,Name,Department.DName,DeptID from Employee left join Department
ON Employee.Dept=Department.Dept order by DeptID;

select E_ID,Name,Department.DName,DeptID from Employee right join Department
ON Employee.Dept=Department.Dept order by DeptID desc;

select E_ID,Name,Department.DName,DeptID from Employee full outer join Department
ON Employee.Dept=Department.Dept;

drop table Employee;
drop table Department;