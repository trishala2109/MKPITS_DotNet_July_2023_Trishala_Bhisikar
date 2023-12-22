CREATE TABLE Sales_Customers
                            (Customer_ID INT PRIMARY KEY IDENTITY(1,1),
							 First_Name VARCHAR(50) NOT NULL,
							 Last_Name VARCHAR(50) NOT NULL,
							 Phone BIGINT,
							 Email VARCHAR(50) NOT NULL,
							 Street VARCHAR(50) NOT NULL,
							 City VARCHAR(50) NOT NULL,
							 States VARCHAR(50) NOT NULL,
							 Zip_Code BIGINT)

CREATE TABLE Sales_Orders
                         (Order_ID INT,
						  Customer_ID INT,
						  Order_Status VARCHAR(50) NOT NULL,
						  Required_date DATE,
						  Shipped_Date DATE,
						  Store_ID INT,
						  Staff_ID INT)

SELECT * FROM Sales_Customers
SELECT * FROM Sales_Orders

INSERT INTO Sales_Customers VALUES('Trish','Bhisikar',7499970761,'bhisi@123gmail.com','Mahal','Nagpur','Maharashta',440002)
INSERT INTO Sales_Customers VALUES('Sayali','Kapse',789654123,'kapsesayli@123gmail.com','Rajvada','Indor','MP',440012)
INSERT INTO Sales_Customers VALUES('Mrunal','Gajbhiye',56321179,'munug@123gmail.com','Sarojini','Delhi','UP',400002)
INSERT INTO Sales_Customers VALUES('Chetan','Rahut',749796322,'rauth@123gmail.com','Pahuni','Bhandara','Maharashta',440492)
INSERT INTO Sales_Customers VALUES('Lucky','Tambe',799612545,'ltambe@123gmail.com','Kamal chowk','Nagpur','Maharashta',440092)
INSERT INTO Sales_Customers VALUES('Sujit','Khangar',74978933211,'skhangar@123gmail.com','Mahal','Dehradhun','UK',440089)
INSERT INTO Sales_Customers VALUES('Bhavika','Rajuput',896513332,'rajputbha@123gmail.com','Mahal','Delhi','UP',400001)

INSERT INTO Sales_Orders VALUES(101,1,'Puches','2020-12-18','2020-12-09',4498,11101)
INSERT INTO Sales_Orders VALUES(102,2,'Not Puches','2019-12-28','2019-12-30',4499,11102)
INSERT INTO Sales_Orders VALUES(103,3,'Puches','2020-09-03','2020-09-03',4500,11103)
INSERT INTO Sales_Orders VALUES(104,4,'Puches','2020-12-18','2020-12-09',4501,11104)
INSERT INTO Sales_Orders VALUES(105,5,'Not Puches','2020-12-18','2020-12-09',4502,11105)
INSERT INTO Sales_Orders VALUES(106,6,'Puches','2023-12-18','2023-12-09',4503,11106)
INSERT INTO Sales_Orders VALUES(107,7,'Not Puches','2020-12-18','2020-12-09',44504,11107)

SELECT * FROM Sales_Customers
SELECT * FROM Sales_Orders


SELECT Order_Id, Required_date ,Customer_ID FROM Sales_Orders
WHERE Customer_ID IN (SELECT Customer_ID FROM Sales_Customers WHERE City = 'Nagpur')
ORDER BY Required_date DESC 


SELECT Order_ID,Customer_ID,Order_Name,Quantity,List_Price FROM Sales_Orders
WHERE Customer_ID IN (SELECT Customer_ID FROM Sales_Customers WHERE City = 'Delhi')
