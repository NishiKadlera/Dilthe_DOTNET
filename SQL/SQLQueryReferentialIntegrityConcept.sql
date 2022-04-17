--Cascading referential integrity constraints
--on delete/on update
--by default on delete/on update no action

create table Parent
(
Pid int primary key,
Pname varchar(30)
)

create table Child
(
Cid int primary key,
Cname varchar(30),
Pid int constraint parentid_fk references Parent(Pid)
)

insert into Parent values(1,'Jancy')
insert into Parent values(2, 'Nancy')
insert into Parent values(3, 'John')

select*from Parent

insert into Child values(11,'Jancy1',2)
insert into Child values(12,'Nancy1',1)
insert into Child values(13,'John1',3)

select*from Child

--delete the records from the parent table
delete from parent where Pid=3 --cannot delete because it's referenced by the child

--To overcome the above on delete cascade
--alter the foreign key in the child table
alter table Child drop constraint parentid_fk

alter table child add constraint parentid_fk foreign key(Pid) references Parent(Pid) on delete set null;

--Delete the records from the parent table
delete from parent where Pid=3
select*from Parent --the row gets deleted from parent table but the corresponding value in the child table sets to null
select*from Child
--To overcome the above null value with a value on delete action
--we alter the foreign key in the child table
alter table Child drop constraint parentid_fk

drop table child

create table Child
(
Cid int primary key,
Cname varchar(30),
Pid int default 3 constraint parentid_fk references Parent(Pid)
)
select*from Parent
select*from Child

insert into Child values(11,'Jancy1',2)
insert into Child values(12,'Nancy1',1)
insert into Child values(13,'John1',3)

--delete the records from the parent table
delete from parent where Pid=3


