create database DML
use DML
create table StuDetails
(
ID int,
NAME varchar(20),
Branch varchar(10)
)

insert into StuDetails values(1,'Anil','CS')
insert into StuDetails values(2,'Sam','EC')
insert into StuDetails values(3,'Anish','CIVIL')
insert into StuDetails values(4,'Peter','EEE')

select * from StuDetails --* all columns

--inserting any two values alone to the table--
insert into StuDetails(ID,NAme) values(5,'John')
select * from StuDetails
--Selecting columns seperately--
select ID,NAME from StuDetails

select ID as StuID, NAME as StuNAME from StuDEtails -- changing names of the column
select ID as 'Roll Number', NAME as 'Student Name' from StuDEtails -- use single quotes for giving the name as two seperate words

