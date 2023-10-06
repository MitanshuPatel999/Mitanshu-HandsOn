USE HandsOn;

Alter table Employees
add LMD date;

SELECT * from Employees;

create TRIGGER LMDTrigger on Employees
after UPDATE
as 
begin 
update Employees
set LMD=GETDATE()
from Employees as e inner JOIN
inserted as i on e.EmployeeID=i.EmployeeID;
end;

update Employees set Salary=64000 where EmployeeID=6;
update Employees set Bonus=1100 where EmployeeID=2;

drop TRIGGER LMDTrigger;

CREATE TABLE EmployeeAudit (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    Action NVARCHAR(10),
    UpdatedColumn NVARCHAR(50),
    OldValue NVARCHAR(100),
    NewValue NVARCHAR(100),
    UpdateDate DATETIME
);

-- Create a trigger to audit changes in the Employees table
CREATE TRIGGER EmployeeAuditTrigger
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, Action, UpdatedColumn, OldValue, NewValue, UpdateDate)
    SELECT
        i.EmployeeID,
        'UPDATE',
        'Salary', -- You can customize this to track specific columns
        d.Salary,   -- Old value
        i.Salary,   -- New value
        GETDATE()      -- Timestamp
    FROM inserted i
    inner JOIN deleted d ON i.EmployeeID = d.EmployeeID;
END;

update Employees set Salary=66500 where EmployeeID=6;
update Employees set Salary=61250 where EmployeeID=2;

select * from EmployeeAudit;

drop TRIGGER EmployeeAuditTrigger;
drop table EmployeeAudit;
