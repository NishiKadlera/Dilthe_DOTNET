create database Student
use Student
create table StuDetails
(
ID int,
Name varchar(30),
Branch varchar(20),
Marks int
)
insert into StuDetails values(1,'John','CS', 98)
insert into StuDetails values(2,'Katy','EC', 96)
insert into StuDetails values(3,'Peter','Mech', 92)
insert into StuDetails values(4,'Nancy','CS', 100)
insert into StuDetails values(5,'Jancy','EC', 94)
insert into StuDetails values(6,'Anil','Civil', 95)

select*from StuDetails
update StuDetails set Branch='CS' where ID=5
delete from StuDetails where ID=4

TRUNCATE table StuDetails
 --where condition
 select*from StuDetails where Branch='CS'
 --relational operators
 select*from StuDetails where ID<=4
 --logical operators
 select*from StuDetails where ID<4 and Branch='CS'
 select*from StuDetails where ID<4 or Branch='Civil'
 --range operators-between and
  select*from StuDetails where ID between 3 and 6
  --in and not in
select*from StuDetails where Branch IN('CS','EC')
select*from StuDetails where Branch  not IN('CS','EC')

select*from StuDetails
--like operators-%-0 or more characters/ _-1 character
select*from StuDetails where Name like 'J%';
select*from StuDetails where Name like '%R';
select*from StuDetails where Name like 'J%n';
select*from StuDetails where Name like '_a%';
select*from StuDetails where Name like '__n%';
select*from StuDetails where Name like 'J___%';

select*from StuDetails where Name like '[KN]%'; --names starting with J and S
select*from StuDetails where Name like '[A-N]%';-- names having A or N in it
select*from StuDetails where Name NOT like '[KN]%';--all names except those starting with K and N
select*from StuDetails where Name NOT like '[A-N]%';--all names except those having letter A or N in it

--aggregate functions(max,min,count,sum,avg)
select*from StuDetails
select max(Marks) from StuDetails
select max(Marks) as MaxMarks from StuDetails
select min(Marks) as MinMarks from StuDetails
select count(Marks) as 'Marks Count' from StuDetails
select sum(Marks) as 'Total Marks' from StuDetails

--order by(asc by default)
select*from StuDetails order by Marks
select*from StuDetails order by Marks desc
select*from StuDetails order by Name
select*from StuDetails order by Branch,Marks
select*from StuDetails order by Branch,Marks desc

--group by--aggreate function
select max(Marks) from StuDetails
select max(Marks),Branch from StuDetails group by branch
select avg(Marks),branch from StuDetails group by branch

--group by with order by
select avg(Marks),Branch from StuDetails group by branch order by branch desc
select avg(Marks) from StuDetails group by branch order by branch

--group by conditon
select avg(marks),branch from StuDetails group by branch where avg(marks)>95 order by avg(marks)--gives error when used where, so use having instead of where clause
select avg(marks),branch from StuDetails group by branch having avg(marks)>95 order by avg(marks)

--distinct
select marks from StuDetails
select branch from StuDetails
select DISTINCT branch from StuDetails
select DISTINCT Name from StuDetails
select DISTINCT marks from StuDetails
select COUNT(marks) from StuDetails
select COUNT(name) from StuDetails
select COUNT(branch) from StuDetails
select COUNT(DISTINCT branch) from StuDetails
select COUNT(DISTINCT Name) from StuDetails
select COUNT(DISTINCT marks) from StuDetails


