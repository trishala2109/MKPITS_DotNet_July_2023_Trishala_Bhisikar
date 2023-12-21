CREATE TABLE Customer
                     (Cust_ID INT PRIMARY KEY,
					  Cust_Name VARCHAR(50),
					  Telephone_No BIGINT)

INSERT INTO Customer VALUES(101,'Sujit',7456318),
                           (102,'Prachi',47963254),
						   (563,'Sayali',7845296)

SELECT * FROM Customer

CREATE TABLE Orders2
                    (Order_ID INT,
					 Order_Date DATE,
					 Cust_ID INT,
					 Product_Name VARCHAR(50),
					 Quantity INT,
					 Rate DEC(10,2))

INSERT INTO Orders2 VALUES(1,'2020-02-15',101,'Oil', 5, 550)
INSERT INTO Orders2 VALUES(2,'2023-09-12',563,'Rice', 5, 1000)
INSERT INTO Orders2 VALUES(3,'2022-12-15',102,'Wheet', 9, 5000)
INSERT INTO Orders2 VALUES(8,'2000-02-13',461,'Rava', 15, 5550)
insert into Orders2 values(3,'2012-12-09',963,'Chana',9,800)

SELECT * FROM Orders2

SELECT customer.Cust_Name, customer.Telephone_No, Orders2.Order_Id, Orders2.Order_Date, Orders2.Cust_ID, Orders2.Product_Name, Orders2.Quantity,Orders2.Rate
FROM Customer 
LEFT OUTER JOIN Orders2
ON customer.Cust_ID = Orders2.Cust_ID;