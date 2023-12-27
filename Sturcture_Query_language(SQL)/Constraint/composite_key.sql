CREATE TABLE STUDENT
                   (ROLL_NO INT,
				    NAME VARCHAR(100),
					CLASS VARCHAR(100),
					SECTION VARCHAR(100),
					EMAIL VARCHAR(100),
					CITY VARCHAR(100),
					MOBILE_NO BIGINT,
					PRIMARY KEY (ROLL_NO,MOBILE_NO))

INSERT INTO STUDENT VALUES(1,'TRISHALA','10th','A','bhisi@gmail.com','Nagpur','7499970761'),
                          (2,'VISHAKHA','9th','B','vish@gmail.com','Mumabi','7896541235'),
						  (3,'NILA','5th','B','n@gmail.com','BhopaL','1236547896'),
						  (4,'NOBITA','10th','C','nobih@gmail.com','Mumabi','9037286716'),
						  (5,'DOREMON','9th','B','dd@gmail.com','Nagpur','7896511185')  

INSERT INTO STUDENT VALUES(1,'TRISHALA','10th','A','bhisi@gmail.com','Nagpur','74999470761')
						  
SELECT  * FROM STUDENT 
