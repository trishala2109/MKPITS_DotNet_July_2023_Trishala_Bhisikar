CREATE TABLE EMPLOYEES
                      (EMPLOYEE_ID INT,
					   FIRST_NAME VARCHAR(100),
					   LAST_NAME VARCHAR(100),
					   EMAIL VARCHAR(100),
					   PHONE_NO VARCHAR(100),
					   HIRE_DATE DATE,
					   JOB_ID VARCHAR(100),
					   SALARY DECIMAL(10,2),
					   COMMISSION_PCT DECIMAL(10,2),
					   MANAGER_ID INT,
					   DEPARTMENT_ID INT)

INSERT INTO EMPLOYEES VALUES(100,'Steven','King','SKING','515.123.4567','2003-06-17','AD_PRES',24000,0,0,90)
INSERT INTO EMPLOYEES VALUES(101,'Neena','Kochhar','NKOCHHAR','515.123.4568','2005-09-21','AD_VP',17000,0,100,90),
                            (102,'Lex','De Haan','LDEHAAN','515.123.4569','2001-01-13','AD_VP',17000,0,100,90),
							(103,'Alexander','Hunold','AHUNOLD','590.423.4567','2006-01-03','IT_PROG',9000,0,102,60),
							(104,'Bruce','Ernst','BERNST','590.423.4568','2007-05-21','IT_PROG',6000,0,103,60),
							(105,'David','Austin','DAUSTIN','590.423.4569','2005-06-25','IT_PROG',4800,0,103,60),
							(106,'Valli','Pataballa','VPATABAL','590.423.4560','2006-02-05','IT_PROG',4800,0,103,60)
SELECT * FROM EMPLOYEES

CREATE TABLE Job_History
                        (EMPLOYEE_ID INT,
						 START_DATES DATE,
						 END_DATE DATE,
						 JOB_ID VARCHAR(100),
						 DEPARTMENT_ID INT)

INSERT INTO Job_History VALUES (102,'2001-02-13','2006-07-24','IT_PROG',60),
                               (101,'1997-09-21','2001-10-27 ','AC_ACCOUNT',110 ),
							   (101,'2001-10-28','2005-03-15','AC_MGR',110),
							   (201,'2004-02-17','2007-12-19', 'MK_REP',20),
							   (114,'2006-03-24','2007-12-31','ST_CLERK',50),
							   (122,'2007-01-01','2007-12-31','ST_CLERK',50),
							   (200,'1995-09-17','2001-06-17','AD_ASST',90),
							   (176,'2006-03-24','2006-12-31','SA_REP',80),
							   (176,'2007-01-01','2007-12-31','SA_MAN',80),
							   (200,'2002-07-01','2006-12-31','AC_ACCOUNT',90)

SELECT * FROM Job_History

--Q20
SELECT * FROM EMPLOYEES 
SELECT * FROM Job_History
 
SELECT a.* FROM Job_History a
JOIN EMPLOYEES m
ON (a.EMPLOYEE_ID = m.EMPLOYEE_ID) WHERE SALARY >= 12000;
