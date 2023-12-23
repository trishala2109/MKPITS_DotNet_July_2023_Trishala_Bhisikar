--Q1.create a sp named s1 to get records from student table
CREATE PROC S1
AS
BEGIN
SELECT * FROM Student5
End;

EXEC S1
------------------
--Q2.create a sp named s2 to get records from student table whose city='nagpur'
CREATE PROC S2 
AS
BEGIN
SELECT * FROM Student5
WHERE City = 'Nagpur'
End;

EXECUTE S2
--------------------

--Q3.create a sp named s3 to get records from student table whose rno >3 and rno<20
CREATE PROC S3
AS 
BEGIN
SELECT * FROM Student5
WHERE Roll_No > 3 AND Roll_No < 20
END;

EXECUTE S3
----------------------------

--Q5.create a sp to get records from sales table whose saleamount >1000 and saleamount<10000
CREATE PROC sp
AS
BEGIN
SELECT * FROM Sales_Orders
WHERE List_Price>1000 AND List_Price<10000
END;

EXECUTE sp
------------------------------

---Q9.create a sp with one parameter @rno to get student records
CREATE PROC S3(@rollno INT)
AS
BEGIN
SELECT * FROM Student5
WHERE Roll_No = @rollno
END;

EXECUTE S3 5
----------------------------
--Q10create a sp with 2 parameters @rno and @sname to get student records
CREATE PROC S3(@rollno INT, @name VARCHAR(50))
AS 
BEGIN
SELECT * FROM Student5 
WHERE Roll_No > @rollno AND Name  LIKE '%'+ @name+'%'
END;

EXECUTE S3 3,'%u%'
--------------------------------
