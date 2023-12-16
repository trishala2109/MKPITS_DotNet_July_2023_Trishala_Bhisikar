create table vendors_groups
                          (Groups_id int primary key identity,
						   Group_name varchar(50))

create table vendors
                    (vendors_id int,
					 vendors_name varchar(50),
					 group_id int,
					 constraint fk foreign key (group_id)
					 references vendors_groups(Groups_id)
					 on delete set null)

select * from vendors_groups
select * from vendors

insert into vendors_groups values('TCS')
insert into vendors_groups values('HCL')
insert into vendors_groups values('Madindra Tech')

insert into vendors values(101,'Chetan',1)
insert into vendors values(102,'Vish',2)
insert into vendors values(103,'Amisha',1)
insert into vendors values(104,'Shahu',3)
insert into vendors values(105,'Amit',2)

select * from vendors_groups
select * from vendors

delete from vendors_groups where Groups_id = 3

drop table vendors_groups
drop table vendors