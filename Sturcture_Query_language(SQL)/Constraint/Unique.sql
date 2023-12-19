CREATE TABLE PERSONS
                   (Person_ID INT PRIMARY KEY,
				    Person_Name VARCHAR(20) NOT NULL,
					Person_Lastname VARCHAR(20) NOT NULL,
					Email VARCHAR (50) UNIQUE NOT NULL)
                    
INSERT INTO PERSONS VALUES(101,'Trishala','Bhisikar','trish2109@gmail.com')
INSERT INTO PERSONS VALUES(102,'Trish', 'Bhisikar','trish2109@gmail.com') ---IT WILL GIVE ERREOR BECAUSE IT MEANS THE EMAIL WANT TO UNIQUE NOT REPETED

SELECT * FROM PERSONS
------------------------

CREATE TABLE PERSONS
                   (Person_ID INT PRIMARY KEY,
				    Person_Name VARCHAR(20) NOT NULL,
					Person_Lastname VARCHAR(20) NOT NULL,
					Email VARCHAR (50) NOT NULL
                    UNIQUE (Email))
    ---it will also define like this
    