create table Orders1
                    (Orders_ID int identity primary key,
				    Orders_Date date,
                    Orders_Name varchar(50),
					Customer_ID int)

create table Orders_Details
                           (Order_ID int ,
						    Product_Name varchar(50) not null,
							Quantity int,
							Prize int,
							Constraint fk3 FOREIGN KEY (Order_ID)
                            references Orders1(Orders_ID)
							on delete cascade)


insert into Orders1 values('2023-12-15','TV',121)
insert into Orders1 values('2023-12-15','Refrigerator',122)

insert into Orders_Details values(1,'TV',5,8000)
insert into Orders_Details values(1,'Hair Drayer',5,8000)
insert into Orders_Details values(2,'Microwave Oven',5,123)
insert into Orders_Details values(1,'Air Condition',8,124)
insert into Orders_Details values(2,'Hair Dryer',6,125)

select * from Orders1
select * from Orders_Details

delete from Orders1 where Orders_ID = 1

select * from Orders1
select * from Orders_Details

drop table Orders1
drop table Orders_Details
