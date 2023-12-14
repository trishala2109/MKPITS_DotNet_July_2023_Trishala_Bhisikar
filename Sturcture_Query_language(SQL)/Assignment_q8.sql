----Q8
create table Nobel_Prize
                        (YEARS int,
						 SUBJECTS varchar(50),
						 WINNER varchar(50),
						 COUNTRY varchar(50),
						 CATEGORY varchar(50))

select * from Nobel_Prize

insert into Nobel_Prize values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into Nobel_Prize values(1970,'Physics','Louis Neel','France','Scientist')
insert into Nobel_Prize values(1972,'Chemisty','Luis Federico Leloir','France','Scientist')
insert into Nobel_Prize values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Nobel_Prize values (1973,'Physiology','Bernard Katz','Germany','Scientist')
insert into Nobel_Prize values(1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Nobel_Prize values(1970,'Economics','Paul Samuelson','USA','Linguist')

select years,subjects,winner from Nobel_Prize  