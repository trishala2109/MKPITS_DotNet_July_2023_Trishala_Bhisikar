--Q17
CREATE TABLE Countries
                      (COUNTRY_ID VARCHAR(100),
					   COUNTRY_NAME VARCHAR(100),
					   REGION_ID INT)

INSERT INTO Countries VALUES('AR','Argentina',2),
                            ('AU','Australia',3),
							('BE','Belgium',1),
							('BR','Brazil',2),
							('CA','Canada',2),
							('CH','Switzerland',1),
							('CN','China',3),
							('DE','Germany',1),
							('DK','Denmark',1),
							('EG','Egypt',4),
							('FR','France',1),
							('IL','Israel',4),
							('IN','India',3),
							('IT','Italy',1),
							('JP','Japan',3),
							('KW','Kuwait',4),
							('ML','Malaysia',3),
							('MX','Maxico',2),
							('NG','Nigeria',4),
							('NL','Netherlands',1),
							('SG','Singapore',3),
							('UK','United Kingdom',1),
							('US','United States of America',2),
							('ZM','Zambia',4),
							('ZW','Zimbabwe',4)

SELECT * FROM Countries
SELECT * FROM Locations 
SELECT * FROM Departments

SELECT COUNTRY_NAME ,CITY,DEPARTMENT_NAME FROM Countries
JOIN Locations USING (COUNTRY_ID)
JOIN Departments USING (LOCATION_ID);
---------------------------------