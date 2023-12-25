CREATE TABLE Employee_Info
                          (NAME VARCHAR(100),
						   OCCUPLATIONS VARCHAR(100),
						   WORKING_DATE DATE,
						   WORKING_HOURS INT,
						   SALARY DECIMAL(10,2))

INSERT INTO Employee_Info VALUES('Jolly Evans','HR', '2020-10-4',9,25000),
                                ('Brayden Simmons','Engineer','2020-10-04',12,65000),
								('Rose Huges','Writer','2020-10-04',13,35000),
								('Lora Paul','Manager','2020-10-04',10,45000),
								('Diego Simmons','Teacher','2020-10-04',12,30000),
								('Antonio Bennet','Writer','2020-10-04',13,35000),
								('Laura Paul','Manager','2020-11-05',10,42000),
								('Antonio Bennet','Writer','2020-11-05',9,38000),
								('Rose Huges','Writer','2020-11-05',12,36000),
								('Jolly Evans','HR','2020-11-05',11,30000)

SELECT * FROM Employee_Info

--AVG() FUNCTION

SELECT OCCUPLATIONS, AVG (WORKING_HOURS) AS "Average Working Hours" FROM Employee_Info
GROUP BY OCCUPLATIONS

--SUM() FUNCTION

SELECT SUM (SALARY) AS "Total Salary" FROM Employee_Info 
WHERE WORKING_HOURS > 9;

SELECT SUM (DISTINCT SALARY) AS "Total Salary" FROM Employee_Info;

SELECT NAME, SUM(WORKING_HOURS) AS "Working Hourse" FROM Employee_Info 
GROUP BY NAME