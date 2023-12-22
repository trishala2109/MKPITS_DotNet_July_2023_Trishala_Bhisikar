CREATE TABLE Sales_Orders
                         (Order_ID INT,
						  Customer_ID INT,
						  Order_Status VARCHAR(50) NOT NULL,
						  Required_date DATE,
						  Shipped_Date DATE,
						  Store_ID INT,
						  Staff_ID INT)

 INSERT INTO Sales_Orders VALUES(101,1,'Puches','2020-12-18','2020-12-09',4498,11101)
INSERT INTO Sales_Orders VALUES(102,2,'Not Puches','2019-12-28','2019-12-30',4499,11102)
INSERT INTO Sales_Orders VALUES(103,3,'Puches','2020-09-03','2020-09-03',4500,11103)
INSERT INTO Sales_Orders VALUES(104,4,'Puches','2020-12-18','2020-12-09',4501,11104)
INSERT INTO Sales_Orders VALUES(105,5,'Not Puches','2020-12-18','2020-12-09',4502,11105)
INSERT INTO Sales_Orders VALUES(106,6,'Puches','2023-12-18','2023-12-09',4503,11106)
INSERT INTO Sales_Orders VALUES(107,7,'Not Puches','2020-12-18','2020-12-09',44504,11107)

SELECT * FROM Sales_Orders     

--creating simple storde procedure
CREATE PROC Prodct
AS
BEGIN
SELECT * FROM Sales_Orders 
END;

EXEC Prodct
-----------------------------------

CREATE PROC Prodct1
AS
BEGIN
SELECT * FROM Sales_Orders WHERE Quantity = 10
END;

EXEC Prodct1
-------------------------

CREATE PROC Prodct2
AS
BEGIN
SELECT * FROM Sales_Orders WHERE Order_Status = 'Purches'
END;

EXEC Prodct2
--------------------------
---Modifying stored procedure

ALTER PROC Prodct1
AS 
BEGIN
SELECT Order_Name,List_Price FROM Sales_Orders
Order by List_Price
End;

EXEC Prodct1
--------------------------
ALTER PROC Prodct1
AS 
BEGIN
INSERT INTO Sales_Orders VALUES(108,8,'Alexa',5,20000,'Puches','2020-12-12','2020-12-10',44501,11108)
select* from Sales_Orders
End;

EXEC Prodct1
-------------------------------