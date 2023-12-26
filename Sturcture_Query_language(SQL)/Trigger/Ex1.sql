create table Employee1
(EmpId int primary key,EmpName varchar(20));

create table EmpLog1
(LogId int identity(1,1),
empid int,
Operation varchar(20),
UpdatedDate datetime);

select * from Employee1
select * from EmpLog1

create trigger trg1
on Employee1
for insert 
as
insert into EmpLog1(empid,Operation,UpdatedDate)	
select EmpId,'Insert',GETDATE()
from inserted;

insert into Employee1 values
(123,'Lucky')

insert into Employee1 values
(12,'Sujit')

select * from Employee1
select * from EmpLog1

delete Employee1 where EmpId = 12;

select * from Employee1
select * from EmpLog1