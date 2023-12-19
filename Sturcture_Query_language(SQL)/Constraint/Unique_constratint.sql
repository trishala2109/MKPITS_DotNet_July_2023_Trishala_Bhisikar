CREATE TABLE PERSONS
                   (Person_ID INT PRIMARY KEY,
				    Person_Name VARCHAR(20) NOT NULL,
					Person_Lastname VARCHAR(20) NOT NULL,
					Email VARCHAR (50),
					Phone_No INT)

					ALTER TABLE PERSONS ADD CONSTRAINT valid UNIQUE(Email) ---- it will do the unique email not repeted email also give the name of constraint

					INSERT INTO PERSONS VALUES(101,'Trishala','Bhisikar','trish2109@gmail.com',12365)
					INSERT INTO PERSONS VALUES(102,'Trish', 'Bhisikar','trish29@gmail.com',5632)
					INSERT INTO PERSONS VALUES(103,'Shila', 'Shah','trish29@gmail.com',79652)---error
					INSERT INTO PERSONS VALUES(103,'Shila', 'Shah','shila29@gmail.com',79652)

					SELECT * FROM PERSONS