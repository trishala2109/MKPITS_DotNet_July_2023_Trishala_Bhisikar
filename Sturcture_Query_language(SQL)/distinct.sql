Select  distinct customerName from Customer1
---distinct keyword it use the duplicate items are remove

select top 5 * from Product2 ORDER BY product_price DESC --it display all the data of top 5

select top 5 Product_Name,Product_Price from Product2 ORDER BY product_price DESC -- is dipaly the only product name and decreing order depend on the price
--TOP keyword are user to select the top criteria 
--------------------

--ASC and DESC 
select Username,City from Users1 ORDER BY City ASC,Username DESC -----in this situation city will deside the assending oreder name becuuse first referance is city then refer to username
select Username,City from Users1 ORDER BY Username DESC   ---it username is decresing order
select Username,City from Users1 ORDER BY City ASC  ---city is Assending order