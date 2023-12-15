create table Vector_Group
                         (Group_ID int primary key identity,
						  Group_Name varchar(50) not null)

select * from Vector_Group

insert into Vector_Group values(101,'HCL')
insert into Vector_Group values(102,'TCS')
insert into Vector_Group values(103,'Tech Mahindra')
insert into Vector_Group values(104,'Hindustan Livar')
insert into Vector_Group values(105,'Emphosis')
----------------------

create table Vectors
                     (Vector_ID int primary key identity,
					  Vector_Name varchar(50) not null,
					  Group_ID int not null
					  constraint fk1 FOREIGN KEY (Group_ID)
					  References Vector_Group(Group_Id))

select * from Vector_Group
select * from Vectors

insert into Vectors values('Nilesh',105)
insert into Vectors values ('Chetan',101)
insert into Vectors values ('Jayant',103)
insert into Vectors values ('Sujit',102)
insert into Vectors values ('Prajwal',104)
insert into Vectors values ('Vrushali',101)
insert into Vectors values ('Nikita',101)
insert into Vectors values ('Snehal',105)
insert into Vectors values ('Priya',102)
insert into Vectors values ('Aayushi',104)

-----FOREIGN KEY is say to relations between two table like there are same ID for two table it will be except using regrence the parent table 



