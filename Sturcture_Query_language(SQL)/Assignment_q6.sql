--Q6
create table Customers
                      (CUSTOMER_ID int,
					   CUSTOMER_NAME varchar(50),
					   CITY varchar(50),
					   GRADE int,
					   SALESMAN_ID int)

					   select * from Customers

insert into Customers values(3002,'Nick Rimando','New York',100,5001)
insert into Customers values(3007,'Brad Davis','New York',200,5001)
insert into Customers values(3005,'Graham Zusi','California',200,5002)
insert into Customers values(3008,'Julian Green','London',300,5002)
insert into Customers values(3004,'Fabian Johnson', 'Paris',300,5006)
insert into Customers values(3009,'Geoff Cameron','Berlin',100, 5003)
insert into Customers values(3003,'Jozy Altidor','Moscow',200,5007)

select * from Customers where grade=200;

