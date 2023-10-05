use HandsOn;

create table Employee(
EmployeeID int primary key,
Fname nvarchar(50) not null,
Salary int not null,
Email nvarchar(50));

select * from Employee;

insert into Employee values(01,N'Mitanshu',30000,N'abc@gmail.com');
insert into Employee values(02,N'Swapnil',29000,N'abc1@gmail.com');
insert into Employee values(03,N'Jigar',28000,N'abc2@gmail.com');
insert into Employee values(04,N'Keval',31000,N'abc3@gmail.com');

ALTER TABLE dbo.Employee
Add Dept varchar(100);

EXEC sp_rename 'Employee.Fname', 'Name', 'COLUMN';

Drop table Employee;