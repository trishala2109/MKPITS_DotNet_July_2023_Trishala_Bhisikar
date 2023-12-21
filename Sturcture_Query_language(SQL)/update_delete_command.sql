select * from Orders2

UPDATE Orders2 SET Rate = 3000 
WHERE Product_Name = 'Rava' 

insert into Orders2 values(4,'2020-11-10',896,'Bajra',6,485)

UPDATE Orders2 SET Rate = 7000
WHERE Product_Name = 'Rava' AND Rate = 3000;

delete from Orders2
where Product_Name='Chana'