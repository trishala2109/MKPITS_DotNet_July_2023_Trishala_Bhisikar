*Que - Create a scalar function named CalculateTax that takes an income as a 
parameter and returns the calculated tax based on a predefined tax rate.

*sol - 

create table TAX
(TaxId int primary key , 
CustName varchar(50),
Income decimal(10,2));

select * from Tax


insert into Tax values
(12,'Lucky',25000),
(34,'Chetan',50000),
(56,'Sujit',1000000)

create function CalculateTax 
(@Income decimal(10,2))

returns decimal(10,2)
as
begin 
return (select (@Income / 18))
end


select  dbo.CalculateTax (Income) as 'TotalTax' from TAX