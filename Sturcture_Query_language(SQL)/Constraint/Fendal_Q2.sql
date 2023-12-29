CREATE TABLE TableProductGSTDetails
                                   (Product_Gst_ID INT PRIMARY KEY,
								    Gst_Detail_Name VARCHAR(500),
									CGST Decimal (10,2),
									SGST Decimal(10,2),
									IGST Decimal(10,2))

INSERT INTO TableProductGSTDetails VALUES(101,'Monitor',50,100,110),
                                         (102,'Printer',50,100,110),
										 (103,'Keybord',50,100,110),
										 (104,'Mouse',50,100,110),
										 (105,'CPU',50,100,110)
--------------------------------------										 
CREATE TABLE TableProductCategory 
                                 (Product_Category_ID INT PRIMARY KEY,
								  Product_Type_Name VARCHAR(500),
								  Product_Gst_ID INT,
								  FOREIGN KEY (Product_Gst_ID) REFERENCES TableProductGSTDetails (Product_Gst_ID));

INSERT INTO TableProductCategory VALUES(1,'Monitor',101),
                                       (2,'Printer',102),
									   (3,'Keybord',103),
									   (4,'Mounse',104),
									   (5,'CPU',105)
---------------------------------------
CREATE TABLE TableProduct
                         (ProductID INT PRIMARY KEY,
                          ProductTypeID INT,
						  ProductName VARCHAR(500));

INSERT INTO TableProduct VALUES(201,11,'Monitor'),
                               (202,12,'Printer'),
							   (203,13,'Keybord'),
							   (204,14,'Mouse'),
							   (205,15,'CPU')
-----------------------------------------------

CREATE TABLE TableInvoiceDetails
                                (Invoice_Detail_ID INT,
								 Customer_Name VARCHAR(500),
								 Customer_Contact VARCHAR(15),
								 Product_Category_ID INT,
								 Product_ID INT,
								 Residential_Type_ID INT,
								 Invoice_Date DateTime,
								 Quantity Decimal (10,2),
								 Price Decimal(10,2),
								 CGST Decimal(10,2),
								 IGST Decimal(10,2),
								 CGST_Value Decimal(10,2),
								 SGST_Value Decimal(10,2),
								 IGST_Value Decimal(10,2),
								 TotalAmount Decimal(10,2),
								 FOREIGN KEY (Product_Category_ID) REFERENCES TableProductCategory(Product_Category_ID),
								 FOREIGN KEY (Product_ID) REFERENCES TableProduct (ProductID));

INSERT INTO TableInvoiceDetails VALUES(1001,'Trishala Bhisikar','7499970761',1,201,999,'2021-12-12',4,4000,100,110,4050,4100,4110,4160),
                                      (1002,'Mrunal Gajbhiye','632147891',2,202,888,'2022-12-14',2,2000,100,110,2050,2100,2110,2160),
									  (1003,'Vishakha Barad','7896541235',3,203,777,'2022-12-18',5,1000,100,110,1050,1100,1110,1160)
-----------------------------------------------
SELECT * FROM TableProductGSTDetails
SELECT * FROM TableProductCategory
SELECT * FROM TableProduct
SELECT * FROM TableInvoiceDetails