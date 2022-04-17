--index--
--speed up the retrival process
--used on large or frequently used columns
--users cannot see the indexes

create table employee
(
id int,
name varchar(25),
Dept varchar(25),
Score int
)
insert into employee values(2, 'Sam', 'IT', 98)
insert into employee values(1, 'Sarah', 'HR', 94)
insert into employee values(3, 'Paul', 'Dev', 99)
insert into employee values(5, 'Peter', 'Finance', 95)
insert into employee values(4, 'Anil', 'Des', 96)
select*from employee

drop table employee
create table employee
(
id int,
name varchar(25),
Dept varchar(25),
Score int
)
insert into employee values(1, 'Sam', 'IT', 98)
insert into employee values(2, 'Sarah', 'HR', 94)
insert into employee values(3, 'Paul', 'Dev', 99)
insert into employee values(4, 'Peter', 'Finance', 95)
insert into employee values(5, 'Anil', 'Des', 96)

select*from employee

--clustered index-- index created within the table and sorting also takes places within the same table
--a table can have only one clustered index
--when a primary key is created, a clusted index will be created by default

create clustered index ind_employeeid on employee(id)
select*from employee --sorting is done in ascending order by default
drop table employee

create table employee
(
id int primary key,
name varchar(25),
Dept varchar(25),
Score int
)
insert into employee values(2, 'Sam', 'IT', 98)
insert into employee values(1, 'Sarah', 'HR', 94)
insert into employee values(3, 'Paul', 'Dev', 99)
insert into employee values(5, 'Peter', 'Finance', 95)
insert into employee values(4, 'Anil', 'Des', 96)
select*from employee

--non clustered index-- creation of index and the sorting takes place outside the table
--a table can have more than one non clustered index
create nonclustered index ind_employeescore on employee(score asc)
create index ind_employeename on employee(name asc)

sp_helpindex employee

--filtered index
create index ind_score on employee(score)where score>95
drop table employee

create table employee
(
id int,
name varchar(25),
Dept varchar(25),
Score int
)
insert into employee values(1, 'Sam', 'IT', 98)
insert into employee values(2, 'Sarah', 'HR', 94)
insert into employee values(3, 'Paul', 'Dev', 99)
insert into employee values(4, 'Peter', 'Finance', 95)
insert into employee values(5, 'Anil', 'Des', 96)
select*from employee

create index ind_score on employee(score asc)
create clustered index ind_name on employee(name)
create nonclustered index ind_score on employee(score asc)
--filtered index
create index ind_filter_score on employee(score) where score>96

drop index employee.ind_name


