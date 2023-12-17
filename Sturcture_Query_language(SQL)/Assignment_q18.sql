create table Noble_Prize_Win
                         (YEARS int,
						 SUBJECTS varchar(50),
						 WINNER varchar(50),
						 COUNTRY varchar(50),
						 CATEGORY varchar(50))

select * from Noble_Prize_Win

insert into Noble_Prize_Win values(1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into Noble_Prize_Win values(1970,'Physics','Louis Neel','France','Scientist')
insert into Noble_Prize_Win values(1970,'Chemisty','Luis Federico Leloir','France','Scientist')
insert into Noble_Prize_Win values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Noble_Prize_Win values (1970,'Physiology','Bernard Katz','Germany','Scientist')
insert into Noble_Prize_Win values(1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Noble_Prize_Win values(1971,'Economics','Paul Samuelson','USA','Linguist')

SELECT YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM Nobel_Prize_Winner WHERE WINNER='Louis Neel';