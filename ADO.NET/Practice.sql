CREATE TABLE TableProductGSTDetails
                                   (Product_Gst_ID INT PRIMARY KEY IDENTITY (601,1),
								    Gst_Detail_Name VARCHAR(500),
									CGST Decimal (10,2),
									SGST Decimal(10,2),
									IGST Decimal(10,2));

INSERT INTO TableProductGSTDetails VALUES('AC and Fridge',14,14,14),
                                         ('Computer',9,9,9),
										 ('Printer',9,9,9),
										 ('Mobiles',6,6,6);
										 
--------------------------------------										 
CREATE TABLE TableProductCategory 
                                 (Product_Category_ID INT PRIMARY KEY IDENTITY (1001,1),
								  Product_Type_Name VARCHAR(500),
								  Product_Gst_ID INT,
								  FOREIGN KEY (Product_Gst_ID) REFERENCES TableProductGSTDetails (Product_Gst_ID));

INSERT INTO TableProductCategory VALUES('Computer',602),
                                       ('Mobile',604),
									   ('Printers',603),
									   ('AC and Fridge',601)
									   
---------------------------------------
CREATE TABLE TableProduct
                         (ProductID INT PRIMARY KEY IDENTITY(201,1),
                          ProductTypeID INT,
						  ProductName VARCHAR(500),
						  ProductPrice Decimal(10,2),
						  FOREIGN KEY (ProductTypeID) REFERENCES TableProductCategory(Product_Category_ID));

INSERT INTO TableProduct VALUES(1001,'Apple',40000),
                               (1001,'Lenovo',25000),
							   (1002,'Nokiya',15000),
							   (1002,'Samsung',30000),
							   (1003,'HP',20000),
							   (1003,'Godreg',35000),
							   (1004,'LG',50000),
							   (1004,'Panasonic',30000)
-----------------------------------------------

CREATE TABLE TableInvoiceDetails
                                (Invoice_Detail_ID INT IDENTITY,
								 Customer_Name VARCHAR(500),
								 Customer_Contact VARCHAR(15),
								 Product_Category_ID INT,
								 Product_ID INT,
								 Residential_Type_ID INT,
								 Invoice_Date DateTime,
								 Quantity Decimal (10,2),
								 Price Decimal(10,2),
								 CGST Decimal(10,2),
								 SGST Decimal(10,2),
								 IGST Decimal(10,2),
								 CGST_Value Decimal(10,2),
								 SGST_Value Decimal(10,2),
								 IGST_Value Decimal(10,2),
								 TotalAmount Decimal(10,2),
								 FOREIGN KEY (Product_Category_ID) REFERENCES TableProductCategory(Product_Category_ID),
								 FOREIGN KEY (Product_ID) REFERENCES TableProduct (ProductID));

-------------------------------------------------------------

SELECT * FROM TableProductCategory
SELECT * FROM TableProduct
SELECT * FROM TableProductGSTDetails
SELECT * FROM TableInvoiceDetails

drop table TableProductCategory
drop table TableProduct
drop table TableProductGSTDetails
drop table TableInvoiceDetails
