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
CREATE TABLE Order2
                    (Order_No INT,
				    Purch_Amount FLOAT,
					Order_Date DATE,
					Customer_ID INT,
					Salesman_ID INT)

INSERT INTO Order2 VALUES(70001,150.5,'2012-10-05',3005,5002),
                         (70009,270.65,'2012-09-10',3001,5005),
						 (70002,65.26,'2012-10-05',3002,5001),
						 (70004,110.5,'2012-08-17',3009,5003),
						 (70007,948.5,'2012-09-10',3005,5002),
						 (70005,2400.6,'2012-07-27',3007,5001),
						 (70008,5760,'2012-09-10',3002,5001),
						 (70010,1983.43,'2012-10-10',3004,5006),
						 (70003,2480.4,'2012-10-10',3009,5003),
						 (70012,250.45,'2012-06-27',3008,5002),
						 (70011,75.29,'2012-08-17',3003,5007),
						 (70013,3045.6,'2012-04-25',3002,5001)

SELECT * FROM Salesman1
SELECT * FROM Order2
--------------------------------------------
--Q5
SELECT * FROM Order2
WHERE Salesman_ID = (SELECT Salesman_ID FROM Salesman1 WHERE City='New York');