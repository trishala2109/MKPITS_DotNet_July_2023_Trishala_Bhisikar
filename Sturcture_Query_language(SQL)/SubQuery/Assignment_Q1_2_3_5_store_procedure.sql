--Q1
CREATE PROC S1
AS
BEGIN
SELECT * FROM Student5
End;

EXEC S1
---------------------------
--Q2
CREATE PROC S2 
AS
BEGIN
SELECT * FROM Student5
WHERE City = 'Nagpur'
End;

EXECUTE S2
--------------------

--Q3
CREATE PROC S3
AS 
BEGIN
SELECT * FROM Student5
WHERE Roll_No > 3 AND Roll_No < 20
END;

EXECUTE S3
----------------------------

--Q5
CREATE PROC sp
AS
BEGIN
SELECT * FROM Sales_Orders
WHERE List_Price>1000 AND List_Price<10000
END;

EXECUTE sp
------------------------------
