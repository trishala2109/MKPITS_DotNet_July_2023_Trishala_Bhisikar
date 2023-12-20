CREATE TABLE STORES
                   (Store_ID INT PRIMARY KEY IDENTITY,
				    Store_Name VARCHAR(50) NOT NULL,
					Phone BIGINT,
					Email VARCHAR(50) NOT NULL,
					Street VARCHAR(50) NOT NULL,
					City VARCHAR(50) NOT NULL,
					States VARCHAR(50) NOT NULL,
					Zip_Code INT)

INSERT INTO STORES VALUES ('Shirkanat',456321,'shrikant@1gmail.com','Gandhisagar','Nagpur','Maharashtra',440002)
INSERT INTO STORES VALUES ('Lotus',7896541,'lotus@123gmail.com','Gandhisagar','Nagpur','Maharashtra',440018)
INSERT INTO STORES VALUES ('Mahindra',456321,'mahindra@1gmail.com','Chaprunagar','Nagpur','Maharashtra',440052)

SELECT * FROM STORES
----------------------------------------------------------

CREATE TABLE STAFFS
                   (Staff_ID INT PRIMARY KEY IDENTITY(1,1),
				    First_Name VARCHAR(50) NOT NULL,
					Last_Name VARCHAR (50) NOT NULL,
					Email VARCHAR(50) NOT NULL UNIQUE,
					Phone BIGINT,
					Active INT,
					Store_ID INT,
					Manager_ID INT,
					FOREIGN KEY(Store_ID) REFERENCES STORES(Store_ID),
					FOREIGN KEY (Manager_ID) REFERENCES STAFFS(Staff_ID))
					
INSERT INTO STAFFS VALUES('Trishala','Bhisikar','bhisi123@gmail.com',4563214,28,1,1)
INSERT INTO STAFFS VALUES('Sujit','Khangar','sk@gmail.com',89631745,20,1,2)
INSERT INTO STAFFS VALUES('Leela','Shah','leela123@gmail.com',4563214,28,2,3)

SELECT * FROM STAFFS
---------------------------------------------

CREATE TABLE CATEGORYS
                      (Category_ID INT PRIMARY KEY IDENTITY(1,1),
					   Category_Name VARCHAR(50) NOT NULL)

INSERT INTO CATEGORYS VALUES('Car')
INSERT INTO CATEGORYS VALUES('Tractor')
INSERT INTO CATEGORYS VALUES('Mopates')

SELECT * FROM CATEGORYS
----------------------------------------

CREATE TABLE BRANDS
                   (Brand_ID INT PRIMARY KEY IDENTITY(1,1),
				    Brand_Name VARCHAR (50) NOT NULL)

INSERT INTO BRANDS VALUES('TATA')
INSERT INTO BRANDS VALUES('TOYOTA')

SELECT * FROM BRANDS
-------------------------------------------

CREATE TABLE PRODUCTS
                     (Product_ID INT PRIMARY KEY IDENTITY(1,1),
					  Product_Name VARCHAR NOT NULL,
					  Brand_ID INT,
					  Ctegory_ID INT,
					  Model_Year INT,
					  List_Price DECIMAL(10,2),
					  FOREIGN KEY (Ctegory_ID) REFERENCES CATEGORYS(Category_ID),
					  FOREIGN KEY (Brand_ID) REFERENCES BRANDS(Brand_ID))
select * from PRODUCTS
INSERT INTO PRODUCTS VALUES('Tyiers',1,1,2001,20000)
drop table PRODUCTS

------------------------------------------------
CREATE TABLE STOCKS 
                   (Store_ID INT,
				    Product_ID INT,
					Quantity INT)


CREATE TABLE SALES
                  (Customer_ID int,
				   First_Name varchar(50) NOT NULL,
				   Last_Name varchar(50) NOT NULL,
				   Phone bigint,
				   Email VARCHAR(50) NOT NULL,
				   Street VARCHAR(50) NOT NULL,
				   City VARCHAR(50) NOT NULL,
				   States VARCHAR(50) NOT NULL,
				   Zip_Code INT)

CREATE TABLE ORDERES
                    (Order_id INT,
				     Customer_ID INT,
					 Order_Status INT,
					 Order_Date DATE,
					 Required_Date DATE,
					 Shipped_Date DATE,
					 Store_ID INT,
					 Staff_ID INT)

-------------------------------------
SELECT * FROM STORES
SELECT * FROM STAFFS
SELECT * FROM CATEGORYS
SELECT * FROM BRANDS