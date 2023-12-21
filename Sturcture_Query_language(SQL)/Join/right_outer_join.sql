CREATE TABLE STUDENTS2 
                      (Admission_No INT PRIMARY KEY,
					   First_Name VARCHAR(50) NOT NULL,
					   Last_Name VARCHAR(50) NOT NULL,
					   Age INT,
					   City VARCHAR(50)NOT NULL)

INSERT INTO STUDENTS2 VALUES(14785,'Amit','Shah',20,'Mumbai'),
                            (89653,'Sonu','Tripati',25,'Pune'),
						    (1555,'Sunit','Deshmukh',20,'Nagpur'),
							(14445,'Anil','Rahut',22,'Jaipur'),
							(18951,'Sumit','Bar',28,'Mumbai')

CREATE TABLE FEE
                 (Admission_No INT,
				  Course VARCHAR(50)NOT NULL,
				  Amount_Pain DEC(10,2))

INSERT INTO FEE VALUES(1555,'DOTNET',20000),
                      (14445,'JAVA',41000),
					  (74563,'PAYTHON',50000),
					  (78963,'ANDROID',55000),
					  (14785,'PHP',21500),
					  (1555,'FULLSTACK',10000),
					  (18951,'SQL',2000),
					  (89653,'C SHAR',5000)

SELECT * FROM STUDENTS2
SELECT * FROM FEES
					 
SELECT STUDENTS2.Admission_No, STUDENTS2.First_Name, STUDENTS2.Last_Name, fee.Course,fee.Amount_Pain
FROM STUDENTS2
RIGHT OUTER JOIN FEE
ON STUDENTS2.Admission_No = fee.Admission_No
-----THIS WILL FILL THE NULL IN RIGHT SIDE DATA WHERE NOT PRESENT