---Q5
create table SalesPeople 
                        (SALESMAN_ID int,
						 NAME varchar(50),
						 CITY varchar(50),
						 COMMISSION float)

						select * from SalesPeople

insert into SalesPeople values(5001,'James Hoog','New York',0.15)
insert into SalesPeople values(5002,'Nail Knite','Paris',0.13)
insert into SalesPeople values(5005,'Pit Alex','London',0.11)
insert into SalesPeople values(5006,'My Lyon','Paris',0.14)
insert into SalesPeople values(5007,'Paul Adam', 'Rome', 0.13)
insert into SalesPeople values (5003,'Lauson Hen', 'San Jose',0.12)

select Name,city from SalesPeople where CITY ='Paris'