CREATE TABLE Hospital
                     (Hospital_No int primary key identity,
					  Hospital_Name varchar(50),
					  City varchar(50))

CREATE TABLE Patient_Details
					  (Hospital_ID int,
					   Patient_Name varchar(50),
					   Patient_ID int,
					   City varchar(50),
					   CONSTRAINT fk FOREIGN KEY(Hospital_ID)
					   REFERENCES Hospital (Hospital_No))

SELECT * FROM Hospital
SELECT * FROM Patient_Details

INSERT INTO Hospital VALUES('Lata Manheshkar','Nagpur')
INSERT INTO Hospital VALUES('Nurons','Mumbai')
INSERT INTO Hospital VALUES('Chandak', 'Pune')

INSERT INTO Patient_Details VALUES(2,'Lata',101,'Bhopal')
INSERT INTO Patient_Details VALUES(1,'Himashi',156,'Mumabi')
INSERT INTO Patient_Details VALUES(2,'Raj',893,'Pune')
INSERT INTO Patient_Details VALUES(3,'Robin',742,'banglore')
INSERT INTO Patient_Details VALUES(1,'Leela',102,'Nagpur')
INSERT INTO Patient_Details VALUES(3,'Loki',896,'Jaipur')
INSERT INTO Patient_Details VALUES(3,'Gedam',741,'Pune')
INSERT INTO Patient_Details VALUES(1,'Komal',159,'Pune')

SELECT * FROM Hospital
SELECT * FROM Patient_Details
