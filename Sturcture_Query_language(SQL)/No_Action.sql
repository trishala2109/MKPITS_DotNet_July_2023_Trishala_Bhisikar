create table Vector_Group1
                         (Group_ID int identity primary key ,
						  Groupl_Name varchar(50))
create table Vectors1
                     (
					  Vector_Name varchar(50) not null,
					  Group_ID int not null
					  constraint fk1 FOREIGN KEY (Group_ID)
					  References Vector_Group1(Group_Id)
					  on update no action)

select * from Vector_Group1
select * from Vectors1

insert into Vector_Group1 values('HCL')
insert into Vector_Group1 values('TCS')

insert into Vectors1 values('Nilesh',1)
insert into Vectors1 values ('Chetan',2)
insert into Vectors1 values ('Jayant',2)
insert into Vectors1 values ('Sujit',2)
insert into Vectors1 values ('Prajwal',1)

update Vectors1 set Vector_Name = 'Chetan' where Group_ID = 2

drop table Vector_Group1
drop table Vectors1