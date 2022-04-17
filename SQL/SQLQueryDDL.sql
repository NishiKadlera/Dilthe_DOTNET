SQL
-------
--Create Database->Collection of tables
create database DLithe2
use DLithe2
--Create Table->rows and columns
create table Trainees
(
ID int,
NAME varchar(20),
Designation varchar(10)
)
--SQL->Structured Query Language
--VARIOUS STATEMENTS
--1)DDL-DATA DEFINITION LANGUAGE-CREATE,ALTER,DROP(STRUCTURE)
--2)DML-DATA MANIPULATION LANGUAGE-INSERT,UPDATE,DELETE,TRUNCATE
--3)DQL-DATA QUERY LANGUAGE-SELECT
--4)TCL-TRANSACTION CONTROL LANGUAGE-COMMIT,ROLLBACK,SAVEPOINT
--5)DCL-DATA CONTROL LANGUAGE-GRANT,DENY,REVOKE

--ALTER DATABASE
alter database DLithe2 Modify Name=DLithe_Batch2
use DLithe_Batch2
--drop database DLithe_Batch2

--ALTER TABLE--alter existing column
alter table Trainees alter column NAME varchar(30);

--ALTER TABLE--Add Column
alter table Trainees ADD AGE int;
--* all the columns
select * from Trainees
--ALTER TABLE--drop column
alter table Trainees drop column AGE

--DROP TABLE
drop table Trainees

--INSERT
insert into Trainees values(1,'John','HR')
insert into Trainees values(2,'Jancy','IT')
insert into Trainees values(3,'Peter','Trainer')
insert into Trainees values(4,'Sam','IT')
insert into Trainees values(5,'Nancy','HR')
insert into Trainees values(6,'Shaun','HR')
select * from Trainees --* all columns
select ID,NAME from Trainees -- selected columns
select ID as TraineeID,NAME as 'Trainee Name' from Trainees -- selected columns with column alias

--UPDATE
update Trainee set Designation='HR' where ID=5

--Delete
delete from Trainees where ID=4

--TRUNCATE
TRUNCATE table Trainees


--SCHEMA--database objects- tables,views,triggers, procedures, function ect
--default schema dbo

create schema DT

create table DT.EMP
(
ID INT,
NAME VARCHAR(20)
)

--why schema--> ABC company(IT based client)-departments: designers(empdetails(100),projetc, salary,bonus,tax)
--dev,hr,testing,admin,non staff etc

--drop schema--
drop schema if exists DT
drop table DT.EMP

--select-operators- use where(condition) while 

--Desination IT
select*from Trainees where Designation='IT'

--relational operators
select*from Trainees where id<4

--logical operators and or not
select*from Trainees where id<4 and designation ='IT'
select*from Trainees where id<4 or designation ='HR'

--range operator(between and)
select*from Trainees where id between 2 and 4

--in and not in
select*from Trainees where Designation IN('IT','Trainer')
select*from Trainees where Designation not IN('IT','Trainer')
select*from Trainees where id IN(1,4)

--Role-Manager,project lead,team lead,employee

--like operators-%-0 or more characters/ _-1 character
select*from Trainees where Name like 'J%';
select*from Trainees where Name like '%y';
select*from Trainees where Name like '%a%';
select*from Trainees where Name like '_a%';
select*from Trainees where Name like 'S__';
select*from Trainees where Name like 'S__%';--atleast 3 char an starts with S

select*from Trainees where Name like '[JS]%'; --names starting with J and S
select*from Trainees where Name like '[A-N]%';
select*from Trainees where Name NOT like '[JS]%';
select*from Trainees where Name NOT like '[A-N]%';

--aggregate functions(max,min,count,sum,avg)
create table student
(
ID int,
Name varchar(30),
Department varchar(25),
Score int
)

insert into student values(1, 'Deepak','IT',98)
insert into student values(2, 'Veeresh','Dev',95)
insert into student values(3, 'Sridhar','IT',94)
insert into student values(4, 'Shashank','Des',96)
insert into student values(5, 'Rohan','IT',95)
insert into student values(6, 'John','Dev',93)
insert into student values(7, 'Peter','IT',92)
insert into student values(8, 'Sam','Dev',91)
insert into student values(9, 'Jancy','IT',95)
insert into student values(10, 'Nancy','Dev',94)

select*from student
select max(score) as 'Maximum Score' from student
select min(score) as 'Minimum Score' from student
select count(score) as 'Count Score' from student
select avg(score) as 'Average Score' from student
select sum(score) as 'Sum Score' from student

--order by(asc by default)
select*from student order by score
select*from student order by score desc
select*from student order by Name
select*from student order by department,score
select*from student order by department,score desc

--group by--aggreate function
select max(score) from student
select max(score),department from student group by Department
select avg(score),department from student group by Department

--group by with order by
select avg(score),department from student group by Department order by department desc

--group by conditon-where is not allowed instead use having clause
select avg(score),department from student group by Department where avg(score)>95 order by avg(score)
select avg(score),department from student group by Department having avg(score)>95 order by avg(score)

--distinct
select department from student
select DISTINCT department from student
select COUNT(department) from student
select COUNT(DISTINCT department) from student