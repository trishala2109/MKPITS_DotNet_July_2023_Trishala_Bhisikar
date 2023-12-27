CREATE TABLE PRODUCT
                    (Product_ID INT PRIMARY KEY IDENTITY(1,1),
					 Product_Name VARCHAR(100),
					 List_Price DECIMAL(10,2),
					 Product_Quntity VARCHAR (100))

INSERT INTO PRODUCT VALUES('Rice',1000,'5 Kg'),
                          ('Oil',500,'2 li'),
						  ('Wheat',6000,'3 kg'),
						  ('Cilli fleks',200,'500 gm'),
						  ('Con-flar',500,'1 Kg')

SELECT * FROM PRODUCT

--Q1
DECLARE 
@Product_ID INT,
@Product_Name VARCHAR(MAX),
@List_Price DECIMAL,
@Product_Quntity VARCHAR(MAX);

DECLARE PRO CURSOR
FOR SELECT * FROM PRODUCT;

OPEN PRO;

FETCH NEXT FROM PRO INTO @Product_ID,@Product_Name,@List_Price,@Product_Quntity;

WHILE @@FETCH_STATUS = 0
BEGIN
PRINT CAST(@Product_ID AS VARCHAR) + ' ' + @Product_Name +' '+ CAST (@List_Price AS VARCHAR) + ' ' + @Product_Quntity 
FETCH NEXT FROM PRO INTO 
@Product_ID,
@Product_Name ,
@List_Price,
@Product_Quntity;
END;

CLOSE PRO;
DEALLOCATE PRO;