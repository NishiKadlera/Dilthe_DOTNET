--Sequences--is a unique number used to auto increment a column
--creating a sequence--
create sequence dbo.sequence
as int
start with 1
increment by 1

create table sequence_1
(
id int primary key,
name varchar(20)
)
select next value for dbo.sequence
select*from sequence_1
insert into sequence_1 values( next value for dbo.sequence, 'Sam')
insert into sequence_1 values( next value for dbo.sequence, 'John')
--delete a sequence
delete from sequence_1
select*from sequence_1

--reset the sequence
alter sequence sequene_1 restart with 1
--drop sequence table
drop sequence sequence