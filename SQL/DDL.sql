--create database--
create database DLithe
use DLithe
--create table--
create table StuDetails
(
ID int,
NAME varchar(20),
Branch varchar(10)
)
--alter database--
alter database DLithe Modify Name=DLitheBootcamp
use DLitheBootcamp

--drop database DLitheBootcamp--

--alter table- alter exisiting column
alter table StuDetails alter column NAME varchar(40);

--alter table- add column--
alter table StuDetails add Age int;

--* indicates select all--
select*from StuDetails

--alter table-drop column--
alter table StuDetails drop column Age

--drop table--
drop table StuDetails



