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

--Q6
SELECT Commision FROM Salesman1 
WHERE Salesman_ID IN (SELECT Salesman_ID FROM Customers1 WHERE City = 'Paris');