create table Students 
                      (Registration_No bigint,
					   Roll_No int, 
                       First_Name varchar(50), 
                       Last_Name varchar(50), 
                       Addmission_Date date, 
                       Section varchar(50), 
                       Fees int)
					   
					   select * from Students

insert into Students values(1021001,101,'Trishala', 'Bhisikar','2020/12/07','A', 15000)
insert into Students values(1021002,112,'Sujit', 'Khangar','2019/12/05','B', 12000)
insert into Students values(1021003,128,'Mrunal', 'Gajbhiye','2020/12/10','A', 20000)
insert into Students values(1021004,124,'Chetan', 'Rauth','2001/01/12','A', 10000)
insert into Students values(1021005,144,'Mayuri', 'Kale','2015/04/05','A', 5000)
insert into Students values(1021006,150,'Vrushali', 'Mohite','2000/12/07','E', 13000)
insert into Students values(1021007,112,'Prachi', 'Dahiwale','2023/10/15','C', 11500)
insert into Students values(1021008,198,'Sayali', 'Kapse','2019/12/20','B', 12000)
insert into Students values(1021001,101,'Luckey', 'Tambe','2020/04/21','C', 15000)
----------------------

select * from Students where Registration_No = 1021001

select*from Students where Last_Name='Kale'

select*from Students where Roll_No > 144

select First_Name from Students ORDER By First_Name DESC    --Decending order
------------------------

select * from Students where Addmission_Date between '2019/12/20' and '2023/10/15';   ---this to this display the data  

select Fees,Addmission_Date from Students where Addmission_Date between '2020/04/21' and '2023/10/15' ---fess and date are show but fess is decalre only ones in time to a starting
-----------------------------