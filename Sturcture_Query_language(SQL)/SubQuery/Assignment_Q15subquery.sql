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
--Q15
SELECT Customer_ID, Customer_Name, City FROM Customers1
WHERE EXISTS (SELECT * FROM Customers1 WHERE City = 'London');
