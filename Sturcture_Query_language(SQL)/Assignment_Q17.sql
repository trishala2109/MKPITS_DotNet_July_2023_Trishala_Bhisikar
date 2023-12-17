create table Noble_Prize_Win
                         (YEARS int,
						 SUBJECTS varchar(50),
						 WINNER varchar(50),
						 COUNTRY varchar(50),
						 CATEGORY varchar(50))

select * from Noble_Prize_Win

insert into Noble_Prize_Win values(1975,'Peace','Hannes Alfven','Sweden','Scientist')
insert into Noble_Prize_Win values(1970,'Physics','Louis Neel','France','Scientist')
insert into Noble_Prize_Win values(1970,'Chemisty','Luis Federico Leloir','France','Scientist')
insert into Noble_Prize_Win values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Noble_Prize_Win values (1960,'Physiology','Bernard Katz','Germany','Scientist')
insert into Noble_Prize_Win values(1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Noble_Prize_Win values(1970,'Economics','Paul Samuelson','USA','Linguist')
 
select years,subjects,winner,country,category from Noble_Prize_Win where (SUBJECTS='Physiology' AND YEARS > 1971) OR (SUBJECTS = 'Pesce' AND YEARS <= 1974) ORDER BY YEARS