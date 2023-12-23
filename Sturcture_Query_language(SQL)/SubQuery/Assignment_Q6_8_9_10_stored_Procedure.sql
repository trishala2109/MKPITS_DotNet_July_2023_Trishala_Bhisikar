CREATE TABLE EMPLOYEE
                     (EMPLOYEE_ID INT PRIMARY KEY IDENTITY(1,1),
                      EMPLOYEE_NAME VARCHAR(50),
                      DESIGNATION VARCHAR(50),
                      SALARY DECIMAL(10,2))

SELECT * FROM EMPLOYEE

INSERT INTO EMPLOYEE VALUES('Sujit','Manager',50000),
                           ('Trishala','Clerk',25000),
						   ('Mayuri','Peon',15000),
						   ('Ashwin','Manager',60000),
						   ('Vishakha','HR',22000),
						   ('Lalita','EX.HR',18000),
						   ('Shila','Clerk',20000)

--Q6.create a sp to get records from emp table whose designation is 'manager' and salary >20000
CREATE PROC emp
AS 
BEGIN
SELECT * FROM EMPLOYEE
WHERE DESIGNATION = 'Manager' AND SALARY >20000
END;

EXECUTE emp
-------------------------------------------

--Q8.create a sp to get records from emp table whose salary is greater than 20000 and salary is less than 50000
CREATE PROC emp
AS
BEGIN
SELECT * FROM EMPLOYEE
WHERE SALARY > 20000 AND SALARY < 50000
END;

EXECUTE emp
----------------------------------------
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
