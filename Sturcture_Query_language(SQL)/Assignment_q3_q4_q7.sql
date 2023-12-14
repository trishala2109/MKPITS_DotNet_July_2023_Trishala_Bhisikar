---Q3
create table ORDERS 
                   (ORDER_NO numeric(18,0),
				    PUCHES_AMOUNT float,
				    ORDER_DATE date,
				    CUSTOMER_ID numeric(18,0),
				    SALESMAN_ID numeric(18,0))
				  select * from ORDERS


insert into ORDERS values(70001,150.5,'2012-10-05',3005,5002)
insert into ORDERS values (70009,270.65,'2012-09-10',3001,5005)
insert into ORDERS values (70002,65.26,'2012-10-05',3002,5001)
insert into ORDERS values (70004,110.5,'2012-08-17',3009,5003)
insert into ORDERS values (70007,948.5,'2012-09-10',3005,5002)
insert into ORDERS values (70005,2400.6,'2012-07-27',3007,5001)
insert into ORDERS values (70008,5760,'2012-09-10',3002,5001)
-------------------------------------------------------------------------
--Q4
select distinct SALESMAN_ID from ORDERS
------------------------------------

--Q7
select order_no,order_date,puches_amount from ORDERS where SALESMAN_ID = 5001