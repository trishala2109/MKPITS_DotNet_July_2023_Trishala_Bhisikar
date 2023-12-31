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

CREATE TABLE Jobs
                 (JOB_ID VARCHAR(100),
				  JOB_TITLE VARCHAR(100), 
				  MIN_SALARY DECIMAL(10,2),
				  MAX_SALARY DECIMAL(10,2))

INSERT INTO Jobs VALUES('AD_PRES','President',20080,40000),
                       ('AD_VP','Administration Vice President',15000,30000),
					   ('AD_ASST','Administration Assistant',3000,6000),
					   ('FI_MGR','Finance Manager',8200,16000),
					   ('FI_ACCOUNT','Accountant',4200,9000),
					   ('AC_MGR','Accounting Manager',8200,16000),
					   ('AC_ACCOUNT','Public Accountant',4200,9000),
					   ('SA_MAN','Sales Manager',10000,20080),
					   ('SA_REP','Sales Reprentative',6000,12008),
					   ('PU_MAN','Purchasing Manager',8000,15000),
					   ('PU_CLERK','Purchasing Clerk',2500,5500),
					   ('ST_MAN','Stock Manager',5500,8500),
					   ('ST_CLERK','Stock Clerk',5500,8500),
					   ('SH_CLERK','Shipping Clerk',2500,5500),
					   ('IT_PROG','ProgrammeR',4000,10000),
					   ('MK_MAN','Marketing Manager',9000,15000),
					   ('MK_REP','Marketing Representative',4000,9000),
					   ('HR_REP','Human Resources Representative',4000,9000),
					   ('PR_REP','Public Relations Representative',4500,10500)

SELECT * FROM Jobs

--Q14
SELECT * FROM EMPLOYEES
SELECT * FROM Jobs

SELECT JOB_TITLE,FIRST_NAME |''| LAST_NAME AS EMPLOYEE_NAME, MAX_SALARY-SALARY AS SALARY_DIFFERENCE FROM EMPLOYEES
NATURAL JOIN Jobs;
-------------------------------------------