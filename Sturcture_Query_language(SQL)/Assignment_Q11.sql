---Q11
create table Nobel_Prize_Winner
                                (YEARS int,
						        SUBJECTS varchar(50),
						        WINNER varchar(50),
						        COUNTRY varchar(50),
						        CATEGORY varchar(50))

select * from Nobel_Prize_Winner

insert into Nobel_Prize_Winner values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into Nobel_Prize_Winner values(1950,'Physics','Louis Neel','France','Scientist')
insert into Nobel_Prize_Winner values(1970,'Chemisty','Luis Federico Leloir','France','Scientist')
insert into Nobel_Prize_Winner values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Nobel_Prize_Winner values (1970,'Physiology','Bernard Katz','Germany','Scientist')
insert into Nobel_Prize_Winner values(1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Nobel_Prize_Winner values(1970,'Economics','Paul Samuelson','USA','Linguist')

select winner,SUBJECTS from Nobel_Prize_Winner where YEARS = 1950;
