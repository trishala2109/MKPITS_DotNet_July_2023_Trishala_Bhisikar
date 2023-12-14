create table Bank 
                  (Account_No bigint, 
                   Account_Holder_Name varchar(50), 
                   Account_Type varchar(50), 
                   Transaction_Type varchar(50), 
                   Amount numeric)

				   select * from Bank

insert into Bank values(1001100211,'Trishala Bhisikar', 'Saving', 'Deposite', 2000)
insert into Bank values(1001100211,'Bhavika Bhisikar', 'Current', 'Withdrwal', 5000)
insert into Bank values(1001100211,'Sujit Khangar', 'Saving', 'Withdrwal', 1000)
insert into Bank values(1001100211,'Aniket Rauth', 'Saving', 'Deposite', 10000)
insert into Bank values(1001100211,'Ashish Rajput', 'Current', 'Withdrwal', 4000)
insert into Bank values(1001100321,'Akansha Nimje', 'Saving', 'Deposite', 3000)
insert into Bank values(1001100451,'Nikita Walthare', 'Saving', 'Deposite', 15000)
insert into Bank values(1001100851,'Tanuja Patil', 'Current', 'Withdrwal', 20000)
insert into Bank values(1001100551,'Tanvi Paunikar', 'Current', 'Deposite', 6000)
insert into Bank values(1001100011,'Tejal Shekar', 'Saving', 'Deposite', 9000)
-----------------------------------

select * from Users1 where city='nagpur' and country = 'India' 

select*from Person where First_Name='Sujit'and Last_Name = 'Khangar'

select Gender from Person ORDER BY Gender

--Logical Operation

Select * from Student3 where RollNo <= 5 and Name = 'Trish' --And operator

Select * from Users1 Where city ='Mumabi' or Username ='sujit' --OR operator
