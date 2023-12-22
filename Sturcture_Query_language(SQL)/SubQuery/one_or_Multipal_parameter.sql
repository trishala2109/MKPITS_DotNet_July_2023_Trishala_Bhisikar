--Creating a store procedure with one parameter
CREATE PROC Pro (@minPrice AS DECIMAL)
AS 
BEGIN
SELECT * FROM Sales_Orders
WHERE List_Price > @minPrice
END;

EXEC pro 10000

---Creating a store procedure with Two parameter
CREATE PROC Pro (@name AS VARCHAR (50), @minPrice AS DECIMAL)
AS 
BEGIN
SELECT * FROM Sales_Orders
WHERE Order_Name = @name AND List_Price >= @minPrice
END;

EXEC Pro 'TV', 10000
EXEC Pro 'Alexa', 15000

--Creating a store procedure with multipal parameter
CREATE PROC Pro1 (@minprice AS DECIMAL, @maxprice AS DECIMAL, @name AS VARCHAR(50))
AS
BEGIN
SELECT * FROM Sales_Orders
WHERE List_Price > @minPrice AND List_Price < @maxprice AND Order_Name LIKE '%'+@name+'%'
END;

EXECUTE Pro1 1200 ,20000,'v'
EXECUTE Pro1 1500,8000,'i'