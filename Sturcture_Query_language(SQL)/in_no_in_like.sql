create table Product2 (Product_ID int primary key, Product_Name varchar(50), Product_Price int, Product_Quantity int)

select * from Product2

insert into Product2 values(1, 'Washing Machine', 15000, 2)
insert into Product2 values(2, 'Microwave Oven', 20000, 5)
insert into Product2 values(3, 'Refrigertor', 25000, 1)
insert into Product2 values (4,'Home thetor', 5000,10)
insert into Product2 values (5,'Juicer',2000,20)
insert into Product2 values (6, 'Mixer', 1500,25)
insert into Product2 values(7, 'Vacum Clener', 5000, 50)
insert into Product2 values (8, 'Induction', 2000,10)
insert into Product2 values(9, 'Computer',35000,40)
insert into Product2 values (10, 'Printer', 4000, 8)
------------------------------------------------------------------------------------------

create table Product3 (Product_ID int , Product_Name varchar(50), Product_Price int, Product_Quantity int)

select * from Product3

insert into Product3 values(1, 'Washing Machine', 15000, 2)
insert into Product3 values(2, 'Microwave Oven', 20000, 5)
insert into Product3 values(3, 'Refrigertor', 25000, 1)
insert into Product3 values (4,'Home thetor', 5000,10)
insert into Product3 values (5,'Juicer',2000,20)
insert into Product3 values (6, 'Mixer', 1500,25)
insert into Product3 values(7, 'Vacum Clener', 5000, 50)
insert into Product3 values (8, 'Induction', 2000,10)
insert into Product3 values(9, 'Computer',35000,40)
insert into Product3 values (10, 'Printer', 4000, 8)
--------------------------

--in and not in

select * from Product3 Product_ID  where Product_ID in(5,8,9)   --In only display this product

select * from Product3 Product_ID  where Product_ID not in (5,8,9) -- Not display this product
-------------------------------

-- like operator

select * from Product3 where Product_Name like '%v%'
select * from Product3 where Product_Name like 'v%' 
select * from Product3 where Product_Name like '%r'
select * from Product3 where Product_Name like 'R%R'
--it is display if some lateers are missing it find the data when data is enter like this
-----------------------------