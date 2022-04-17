--Functions: is a set of operations--
--Types of functions: System and user defined function
-- User defined
--Types: Scalar, Inline table valued, Multi statement table value

--Scalar function--is a user defined function that returns a single value
--It can have parameters or not
--returns int,varchar,date etc
--@-table variable

-- SCALAR_CUBE
create function cube_fun(@a int)
returns int
as
begin
    return @a*@a*@a
end

--call the function
select dbo.cube_fun(2) as Result
select dbo.cube_fun(5) as Result

--SCALAR_AGE

create function calc_age(@birthday date)
returns int
as
begin
    Declare @age int  
    set @age=datediff(year,@birthday,getdate()) --01-01-2000 - 11-04-2022
    return @age
end

select dbo.calc_age('01/01/2000') as Age

insert into orders values(1000,'01/01/2018',7,1,100)
insert into orders values(1001,'01/07/2012',7,5,102)
insert into orders values(1002,'01/01/2007',7,2,100)
insert into orders values(1003,'01/01/2000',7,1,101)
insert into orders values(1004,'01/01/2003',7,1,101)
insert into orders values(1005,'01/01/2006',7,1,100)

select * from orders
--User-defined function in the select list
select cno,orderid,orderdate,dbo.calc_age(orderdate) as Orders_YearDiff from orders
--User-defined function in the select list and the where clause
select cno,orderid,orderdate,dbo.calc_age(orderdate) as Orders_YearDiff from orders where dbo.calc_age(orderdate)>15

--TABLE VALUED FUNCTIONS
--INLINE TABLE VALUED - returns table - no begin and end - single query
select * from Employee1
create function fun_getscore(@eid int)
returns table
as
return(select * from employee1 where id=@eid)

--call the inline table valued function
select * from fun_getscore(2)

--MULTI STATEMENT TABLE VALUED
create function fun_getITdept()
returns @table Table (Eid int,Ename varchar(25),EDept varchar(25),Escore int)
as
begin
    insert into @table
    select id,name,Dept,score from Employee1 where dept= 'IT';
    return
end

--call the multi-statement table valued function
select * from fun_getITdept()

--GROUPING SETS -- 2008
--EXTENSION TO GROUP BY

select * from Employee1
   
select sum(score) from Employee1

select dept,COUNT(score) as TotalScore from Employee1 group by dept

select dept,COUNT(score) as TotalScore from Employee1
group by GROUPING SETS
(
(dept,SCORE)
)

select * from Employee1