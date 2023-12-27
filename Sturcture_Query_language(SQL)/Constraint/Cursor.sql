CREATE TABLE PRODUCT
                    (Product_ID INT PRIMARY KEY IDENTITY(1,1),
					 Product_Name VARCHAR(100),
					 List_Price DECIMAL(10,2),
					 Product_Quntity VARCHAR (100))

INSERT INTO PRODUCT VALUES('Rice',10000,'5 Kg'),
                          ('Oil',500,'2 li'),
						  ('Wheat',6000,'3 kg'),
						  ('Cilli fleks',200,'500 gm'),
						  ('Con-flar',500,'1 Kg')

SELECT * FROM PRODUCT

DECLARE 
@Product_Name VARCHAR(MAX),
@List_Price DECIMAL;

DECLARE product1 CURSOR
FOR SELECT Product_Name,List_Price FROM PRODUCT;

OPEN product1

FETCH NEXT FROM product1 INTO @Product_Name, @List_Price;

WHILE @@FETCH_STATUS = 0
BEGIN 
PRINT @Product_Name +' '+ CAST (@List_Price AS VARCHAR);
FETCH NEXT FROM product1 INTO 
@Product_Name ,
@List_Price;
END;

CLOSE product1;

DEALLOCATE product1;