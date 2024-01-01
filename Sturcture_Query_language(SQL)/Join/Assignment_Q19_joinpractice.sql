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

--Q19
SELECT * FROM Jobs 

SELECT JOB_TITLE,AVG(SALARY) FROM EMPLOYEES 
NATURAL JOIN Jobs GROUP BY JOB_TITLE
----------------------------------------