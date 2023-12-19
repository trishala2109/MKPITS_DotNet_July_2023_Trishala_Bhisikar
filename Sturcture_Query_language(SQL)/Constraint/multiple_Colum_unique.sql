CREATE TABLE Person_skill
                        (ID INT PRIMARY KEY IDENTITY,
						 Person_NAME VARCHAR(50),
						 Person_ID INT,
						 Person_Skill_ID INT,
						 Upated_at_Time DATETIME,
						 UNIQUE(Person_ID,Person_Skill_ID))

INSERT INTO Person_skill VALUES('Trishala',101,10,'2001-12-15') 
INSERT INTO Person_skill VALUES('Sujit',102,10,'2015-10-06') 
INSERT INTO Person_skill VALUES('Chetan',101,8,'2013-12-09')
INSERT INTO Person_skill VALUES('Luckey',101,5,'2012-12-09')

SELECT * FROM Person_skill

--it will except only one at a time insert the data will be same not repeted same thing in one line
---like insert 101,10 are insert but also insert same in next line 101,10 it will accept 
---it will be change some 102,10 it will be execute the data otherwise it will give some error