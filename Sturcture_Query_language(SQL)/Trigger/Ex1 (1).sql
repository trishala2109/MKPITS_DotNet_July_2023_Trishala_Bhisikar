create table Employee3
(EmpId int primary key,EmpName varchar(20));

create table EmpLog3
(LogId int identity(1,1),
empid int,
Updated varchar(20),
Operation varchar(20),
UpdatedDate datetime);

select * from Employee3
select * from EmpLog3

create trigger trg3
on Employee3
AFTER UPDATE
as
insert into EmpLog3 (empid, Updated, Operation, UpdatedDate)
select EmpId,EmpName,'Update',GETDATE()
from deleted

insert into Employee3 values
(123,'Sujit'),
(456,'Lucky'),
(789,'Chetan');

select * from Employee3
select * from EmpLog3

update Employee3 set EmpName = 'David' where EmpId = 789

select * from Employee3
select * from EmpLog3


