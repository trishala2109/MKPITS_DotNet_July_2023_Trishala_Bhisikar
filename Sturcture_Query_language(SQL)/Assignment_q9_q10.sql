---Q9
create table Nobel_Prize_Winner
                        (YEARS int,
						 SUBJECTS varchar(50),
						 WINNER varchar(50),
						 COUNTRY varchar(50),
						 CATEGORY varchar(50))

select * from Nobel_Prize_Winner

insert into Nobel_Prize_Winner values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into Nobel_Prize_Winner values(1970,'Physics','Louis Neel','France','Scientist')
insert into Nobel_Prize_Winner values(1970,'Chemisty','Luis Federico Leloir','France','Scientist')
insert into Nobel_Prize_Winner values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Nobel_Prize_Winner values (1970,'Physiology','Bernard Katz','Germany','Scientist')
insert into Nobel_Prize_Winner values(1971,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Nobel_Prize_Winner values(1970,'Economics','Paul Samuelson','USA','Linguist')


select subjects,winner from Nobel_Prize_Winner where YEARS = 1971
--------------------
----Q10
select winner,years,subjects from Nobel_Prize_Winner where winner like 'B%z';