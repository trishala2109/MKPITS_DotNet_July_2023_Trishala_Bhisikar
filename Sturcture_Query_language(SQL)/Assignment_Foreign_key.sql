create table Student
                    (Roll_No int primary key identity,
					 Name varchar(50),
					 Address varchar(50))

create table Fees
                 (Fess_ID int primary key,
				  Roll_No int,
				  Amount int,
				  Dates date,
				  Constraint fk2 FOREIGN KEY (Roll_No)
				  References Student(Roll_No))

select * from Student
select * from Fees

insert into Student values('Trishala','Nagpure')
insert into Student values('Aayushi','Amravti')
insert into Student values ('Mrunali','Pune')

insert into Fees values(1056,2,5000,'2020-12-15')
insert into Fees values(1022,1,2000,'2015-10-02')
insert into Fees values(1059,3,500,'2023-12-15')
insert into Fees values(1060,2,2000,'2015-10-12')
insert into Fees values(1096,1,5000,'2020-10-05')
insert into Fees values(1045,2,9000,'2005-01-29')

select * from Student
select * from Fees
