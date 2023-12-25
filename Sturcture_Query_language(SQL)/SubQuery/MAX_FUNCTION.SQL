SELECT * FROM Product1

SELECT Product_Name ,Product_Price,Product_Quantity FROM Product1
WHERE Product_Quantity = (SELECT MAX (Product_Quantity) AS "MAXIMUM QUENTITY" FROM Product1); --- MAX () FUNCTION IT select maximum quantity product

SELECT Product_Name , MAX (Product_Price)  AS "MAXIMUM PRICE" FROM Product1
GROUP BY Product_Name
HAVING MAX (Product_Price) > 3000;