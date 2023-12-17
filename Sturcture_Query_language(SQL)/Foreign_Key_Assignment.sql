CREATE TABLE Department
                       (Department_ID int primary key,
					    Department_Name varchar(50) not null);

 CREATE TABLE Employe
                    (Employe_ID int primary key,
					 Employe_Name varchar(50) not null,
					 Department_ID int,
					 CONSTRAINT FK FOREIGN KEY (Department_ID)
					 REFERENCES Department (Department_ID));

select * from Department
select * from Employe

insert into Department values(1,'Egineering')
insert into Department values(2, 'Marketing')
insert into Department values(3,'Sales')

insert into Employe values(1, 'John Doe', 1)
insert into Employe values(2, 'Jane Smith', 2)
insert into Employe values(3, 'Bob Johnson', 1)
insert into Employe values(4, 'Alice Brown', 3)

select * from Department
select * from Employe

SELECT e.Employe_ID,e.Employe_Name,d.Department_Name from Employe e,Department d WHERE e.Department_ID =d.Department_ID;

insert into Employe values(5, 'Sam Wilson', 4)

UPDATE Employe SET Department_ID = 3 WHERE Employe_ID = 1;

SELECT e.Employe_ID,e.Employe_Name,d.Department_Name from Employe e,Department d WHERE e.Department_ID=d.Department_ID;
