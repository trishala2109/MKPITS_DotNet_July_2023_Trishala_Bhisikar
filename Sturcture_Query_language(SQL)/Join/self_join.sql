CREATE TABLE STUDENTS2 
                      (Admission_No INT PRIMARY KEY,
					   First_Name VARCHAR(50) NOT NULL,
					   Last_Name VARCHAR(50) NOT NULL,
					   Age INT,
					   City VARCHAR(50)NOT NULL)

INSERT INTO STUDENTS2 VALUES(14785,'Amit','Shah',20,'Mumbai'),
                            (89653,'Sonu','Tripati',25,'Pune'),
						    (1555,'Sunit','Deshmukh',20,'Nagpur'),
							(14445,'Anil','Rahut',22,'Pune'),
							(18951,'Sumit','Bar',28,'Mumbai')

SELECT * FROM STUDENTS2

SELECT s1.first_name,s2.last_name,s2.city
FROM STUDENTS2 s1,STUDENTS2 s2
WHERE s1.Admission_No <> s2.Admission_No 
AND s1.city=s2.city
ORDER BY s2.city
