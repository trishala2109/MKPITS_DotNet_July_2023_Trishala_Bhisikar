---Q1
create table Salesman (
                       Salesman_ID int, 
                       Name varchar(50), 
					   City varchar(50),
					   Commision float)
select * from Salesman 

insert into Salesman values (5001, 'James Hoog','New York',0.15)
insert into Salesman values(5002,'Nail Knite', 'Paris', 0.13)
insert into Salesman values(5005, 'Pit Alex', 'London',0.11)
insert into Salesman values(5006, 'Mc Lyon','Paris',0.14)
insert into Salesman values(5007, 'Paul Adam', 'Rome',0.13)
insert into Salesman values(5003, 'Lauson Hen', 'San Jose',0.12)
---------------------
---Q2
select Name,Commision from Salesman where Name like '%i%';
