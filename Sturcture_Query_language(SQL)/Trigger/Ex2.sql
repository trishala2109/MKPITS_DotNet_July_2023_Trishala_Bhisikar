Create table Employee2
(EmployeeId int,
FirstName varchar(20),
LastName varchar(20),
Email varchar(50),
Phone bigint,
HireDate datetime,
ManagerId int,
Salary int,
DepartmentId int);

Create table EmpLog2
(LogId int identity (1,1),
empid int,
firstname varchar(20),
lastname varchar(20),
Operation varchar(20),
UpdateDate datetime);

select * from Employee2
select * from EmpLog2

create trigger trg2
on Employee2
for insert
as 
insert into EmpLog2 (empid, firstname, lastname,Operation,UpdateDate)
select EmployeeId,FirstName,LastName,'Insert',GETDATE()
from inserted

insert into Employee2 values
(123,'Lucky','Tambe','luckytambe123@gmail.com',1234567890,'2023-12-25',8029,25000,231);

select * from Employee2
select * from EmpLog2
