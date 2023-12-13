create table Person(Person_ID int identity(1,1), First_Name varchar(20) not null, Last_Name varchar(20) not null, Gender char(1) not null)

select * from Person

insert into Person values( 'Trishala', 'Bhisikar', 'F')
insert into Person values('Sujit', 'Khangar','M')
insert into Person values('Vishakha', 'Barad','F')

delete from Person where Person_ID = 2;