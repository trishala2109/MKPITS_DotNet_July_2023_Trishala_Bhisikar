CREATE TABLE Employee_Details
                            (Emp_ID INT PRIMARY KEY IDENTITY(1,1),
							 Emp_Name VARCHAR(100),
							 Emp_Contact BIGINT,
							 Emp_Email VARCHAR(100),
							 Emp_Department VARCHAR(100),
							 Emp_City VARCHAR(100),
							 Salary DECIMAL(10,2))

INSERT INTO Employee_Details VALUES('Rakesh',9924194054,'rakesh404@gamil.com','Computer','Ahmedabad',20000),
                                   ('Karan',9874563217,'kk@gmail.com','Account','Mumbai',19000),
								   ('Trishala',749970761,'bhisi@gmail.com','Managment','Mumbai',17000),
								   ('Mrunal',913028616,'munu@gmail.com','Account','Ahmedabad',25000),
								   ('Rahul', 9632587415,'rahul707@gmail.com','Account','Vishakhapatnam',15000),
								   ('Rohan',8523697415,'rohan123@gmail.com','Computer','Vishakhaptnam',10000),
								   ('Ketan',753951864,'ketan09@gmail.com','Computer','Mumbai',16000),
								   ('Aman',9638527415,'aman@gmail.com','Managment','Ahmedabad',23000)

SELECT * FROM Employee_Details

--------------SCALER VALUED FUNCTION--------------------

CREATE FUNCTION F1
(
  @Emp_Contact VARCHAR (100),
  @Emp_Email VARCHAR(100),
  @Emp_City VARCHAR(100)
)
RETURNS VARCHAR(100)
AS
BEGIN RETURN(SELECT @Emp_Contact + ' ' + @Emp_Email + ' ' + @Emp_City)
End

SELECT dbo.F1 (Emp_Contact,Emp_Email,Emp_City) AS Details From Employee_Details