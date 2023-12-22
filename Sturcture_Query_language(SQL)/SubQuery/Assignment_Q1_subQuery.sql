CREATE TABLE Student5
                     (Roll_No INT PRIMARY KEY IDENTITY(1,1),
					  Name VARCHAR(50) NOT NULL,
					  Email VARCHAR(50) NOT NULL,
					  City VARCHAR(50) NOT NULL,
					  Course VARCHAR(50) NOT NULL,
					  Course_ID INT)

CREATE TABLE Fees5
                  (Fess_ID INT,
				   Roll_No INT,
				   Fees_Date DATE,
				   Amount DECIMAL(10,2),
				   Course_ID INT)

SELECT * FROM Student5
SELECT * FROM Fees5

INSERT INTO Student5 VALUES('Trishala','bhisi@gmail.com','Nagpur','Dotnet',11012),
                           ('Mrunal','munu12@gmail.com','Mumabai','Java',11021),
						   ('Sujit','skhangar52@gmail.com','Delhi','Dotnet',11013),
						   ('Chetan','rahut@gmail.com','Mumabai','Dotnet',11014),
						   ('Sayali','sayli@gmail.com','Nagpur','Dotnet',11015),
						   ('Lucky','ltabe45@gmail.com','Delhi','Java',11022),
						   ('Mayuri','mkale60@gmail.com','Delhi','Java',11023),
						   ('Vrushali','vrushm@gmail.com','Nagpur','Dotnet',11016),
						   ('Rita','ritari@gmail.com','Mumabai','Java',11024),
						   ('Sahil','skalwei@gmail.com','Nagpur','Dotnet',11017)

INSERT INTO Fees5 VALUES(101,1,'2020-12-12',15000,11012),
                        (102,2,'2023-12-25',20000,11021),
						(103,3,'2020-02-15',4000,11013),
						(104,4,'2020-09-12',5000,11014),
						(105,5,'2001-01-01',60000,11015),
						(106,6,'2023-12-19',8000,11022),
						(107,7,'2025-12-15',1000,11023),
						(108,8,'2020-12-12',15000,11016),
						(109,9,'2020-12-12',1050,11024),
						(110,10,'2020-12-12',1500,11017)

SELECT * FROM Fees5 
WHERE Course_ID IN (SELECT Course_ID FROM Student5 WHERE city = 'Nagpur');

SELECT * FROM Fees5 
WHERE Course_ID IN (SELECT Course_ID FROM Student5 WHERE city = 'Mumabai');

SELECT * FROM Fees5 
WHERE Course_ID IN (SELECT Course_ID FROM Student5 WHERE city = 'Delhi');