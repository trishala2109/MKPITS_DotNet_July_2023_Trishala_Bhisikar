SELECT * FROM Product1

SELECT Product_Name ,Product_Price,Product_Quantity FROM Product1
WHERE Product_Quantity = (SELECT MIN (Product_Quantity) AS "MINIMUM QUENTITY" FROM Product1); --- MIN () FUNCTION IT select minimum quantity product

SELECT Product_Name , MIN (Product_Price)  AS "MINIMUM PRICE" FROM Product1
GROUP BY Product_Name
HAVING MIN (Product_Price) > 3000;