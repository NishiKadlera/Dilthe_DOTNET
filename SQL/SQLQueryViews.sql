--Views--Virtual tables
--Two types- System defined--User defined
--User defined--simple view(single table) and complex view(multiple table)

--1. Simple view
select * from Employee1
create view View_Employee1
as
select id, name, score, iif(score>95,'Disctinction','Merit') as Remark from Employee1

select * from View_Employee1

--2. Complex View
select*from product
select*from orders
select*from customer
create view View_ShoppingCart
as
select c.cid,c.cname,o.orderid,o.pno,p.pname,p.price
from customer as c full join orders as o on c.cid=o.cno
full join product as p on o.pno=p.pid

select*from View_ShoppingCart