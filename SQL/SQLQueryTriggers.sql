--DDL Triggers
--create alter drop-database
--Database scope- 

--restricts creating table
create trigger tg_restrictcreatetable
ON DATABASE
FOR CREATE_TABLE
AS
    BEGIN
        PRINT 'CANNOT CREATE TABLE IN THIS DATABASE'
        ROLLBACK TRANSACTION
    END
	
create table democheck
	(
	id int
	)
	select * from democheck
	alter table democheck add score int
	drop trigger tg_restrictcreatetable

--restrict alter table

create trigger tg_restrictaltertable
ON DATABASE
FOR ALTER_TABLE
AS
    BEGIN
        PRINT 'CANNOT ALTER TABLE IN THIS DATABASE'
        ROLLBACK TRANSACTION
    END

alter table democheck add AGE int
drop table democheck

--Restrict Drop Table
create trigger tg_restrictdroptable
ON DATABASE
FOR DROP_TABLE
AS
    BEGIN
        PRINT 'CANNOT DROP TABLE IN THIS DATABASE'
        ROLLBACK TRANSACTION
    END

drop table Employee

DISABLE TRIGGER tg_restrictdroptable ON DATABASE

ENABLE TRIGGER tg_restrictdroptable ON DATABASE

--Restrict Rename
create trigger tg_restrictrename
ON DATABASE
FOR RENAME
AS
    BEGIN
        PRINT 'CANNOT RENAME THE TABLE IN THIS DATABASE'
        ROLLBACK TRANSACTION
    END

select * from demo_trigger

sp_rename 'demo_trigger','d_trg'

alter trigger tg_restrictrename
ON DATABASE
FOR RENAME
AS
    BEGIN
        PRINT 'An Object has been renamed in this database'
    END

sp_rename 'demo_trigger','d_trg'

select * from d_trg

use DLitheBootcamp

--SERVER SCOPED DDL TRIGGERS

create trigger trg_ServerDDL
ON ALL SERVER
FOR CREATE_TABLE,ALTER_TABLE,DROP_TABLE
AS
    BEGIN
        PRINT 'CANNOT PERFORM DDL IN THIS SERVER'
        ROLLBACK TRANSACTION
    END

create table democheck(id int)

--INSTEAD OF TRIGGER
create trigger trg_insteadof
ON d_trg
INSTEAD OF INSERT
AS
SELECT * FROM d_trg

insert into d_trg values(4,'John5')

alter trigger trg_insteadof
ON d_trg
INSTEAD OF INSERT
AS
SELECT name FROM d_trg

