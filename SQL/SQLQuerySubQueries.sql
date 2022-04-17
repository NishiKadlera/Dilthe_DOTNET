--Sub Queries--A query within a query is called sub query--A query within a SQL statement
--Types--select,insert,update,delete

--correlated sub query
--non correlated sub query

select * from Customer
select * from orders
select * from product

--1. where IN(ONE TABLE)
select * from Customer where cid in --MAIN QUERY/OUTER QUERY
(select cid from Customer where cname='Sam') --SUB QUERY/INNER QUERY

--2. where IN(ONE TABLE)
select * from Customer where cid in --MAIN QUERY/OUTER QUERY
(select cid from Customer where cname LIKE '_o%') --SUB QUERY/INNER QUERY

--3. where IN(TWO TABLES)
select * from Orders where pno in --MAIN QUERY/OUTER QUERY
(select pid from Product) --SUB QUERY/INNER QUERY (100,101,102)

--4. where IN(TWO TABLES)
--select * from tablename where column in subquery
--select * from orders where pno in(100,101)
select * from Orders where pno in --MAIN QUERY/OUTER QUERY
(select pid from Product where price>20000) --SUB QUERY/INNER QUERY (100,101)--only 101 values will be displayed from orders table

--5. SELECT SUBQUERY
--select column,column,subquery from tablename
select orderid,orderdate,
(select cid from customer where customer.cid=orders.cno)Customer_No from orders

insert into orders values(202,'2022-04-09',4,1,100)
select * from Customer
select * from orders
select * from product

--6. FROM SUBQUERY
select c.cid,c.cname from
(select count(cno) as Count_CustomerID from orders) as o,Customer as c
where c.CID > o.Count_CustomerID --Count_CustomerID=3

--7. INSERT SUBQUERY
--Matching columns
select * from Customer
create table Customers_backup
(
c_no int,
c_name varchar(25))

select * from Customers_backup
--where subquery in the insert statement
insert into Customers_backup select * from customer where cid in--(3,4,5)
(select cid from customer where cname like '_a%');--(3,4,5)

--8. UPDATE SUBQUERY
select * from Customer
select * from orders

update orders set quantity=10 where cno in
(select cid from customer where cname='Nancy')

update orders set quantity=5 where cno in --(1,5)
(select cid from customer where cname in('John','Sam'))

--9. DELETE SUBQUERY
delete from orders where cno in --(1,5)
(select cid from customer where cname in('John','Jancy'))

--ANY AND ALL OPERATOR

select * from emp
select * from dept

--10. ANY
select eid,ename,did from emp where did=ANY(select dno from dept) --(1,2,3,4)
select eid,ename,did from emp where did=ANY(select AVG(DNO) from dept) --(2)

--11. ALL
select eid,ename,did from emp where did=ALL(select dno from dept) --(1,2,3,4)
select eid,ename,did from emp where did=ALL(SELECT dno from dept where dno<3) --1,2

--12. EXISTS
Select * from emp where
exists(select dno from dept where dept.dno=emp.did and dname='IT')

select * from emp
select * from dept