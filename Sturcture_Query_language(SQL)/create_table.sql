create table sample (ID int)
-----------------------------
create table Student (RollNo int, Name varchar (20), class varchar(10))

insert into Student values(11 , 'Trish','A')
insert into Student values(11 , 'Trish','A')

select * from Student

drop table Student

create table Student (RollNo int, Name varchar (20), class varchar(10))

insert into Student values(11 , 'Trish','A')
insert into Student values(12 , 'Trish','A')

insert into Student values(13, 'vishakha' , 'B')
----------------------------

create table Product (productID int,productName varchar (20), productprice int , productQuantity int )

select * from Product 

insert into Product values (1, 'TV',15000,5)
insert into Product values (2, 'Oven', 25000, 2)
insert into Product values (3,'Washing Machine',15000,10)
--------------------------------

create table Customer (customerID int primary key , customerName varchar(20))

select * from Customer

insert into Customer values (1, 'Trish')
insert into Customer values(2, 'Bjaj')
insert into Customer values (3, 'Sujit')