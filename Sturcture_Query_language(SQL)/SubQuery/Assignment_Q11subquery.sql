CREATE TABLE Salesman1
                      (Salesman_ID INT,
					   Name VARCHAR(100),
					   City VARCHAR(100),
					   Commision FLOAT)
					  
INSERT INTO Salesman1 VALUES(5001,'james Hoog','New York',0.15),
                            (5002,'Nail Knite','Paris',0.13),
							(5005,'Pit Alex','London',0.11),
							(5006,'Mc Lyon','Paris',0.14),
							(5003,'Lauson Hen','San Jose', 0.12),
							(5007,'Paul Adam','Rome',0.13)

SELECT * FROM Salesman1
-----------------------------------------
CREATE TABLE Customers1
                      (Customer_ID INT,
					  Customer_Name VARCHAR(100),
					  City VARCHAR(100),
					  Grade INT,
					  Salesman_ID INT)

INSERT INTO Customers1 VALUES(3002,'Nick Rimando','New York',100,5001),
                             (3007,'Brad Davis','New York',200,5001),
                             (3005,'Graham Zusi','California',200,5002),
                             (3008,'Julian Green','London',300,5002),
                             (3004,'Fabian Johnson','Paris',300,5006),
                             (3009,'Geoff Cameron','Berlin',100,5003),
                             (3003,'Jozy Altidor','Moscow',200,5007),
                             (3001,'Brad Guzan','London',NULL,5005)

SELECT * FROM Customers1
---------------------------------
--Q11
SELECT Salesman_ID,Name FROM Salesman1 a
WHERE 1 < (SELECT COUNT (*) FROM Customers1 WHERE Salesman_ID = a.Salesman_ID);