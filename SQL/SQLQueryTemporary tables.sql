--Triggers--
--types-DML, DDL,CLR, LOGON triggers


create table demo_trigger
(
id int,
name varchar(20)
)
insert into demo_trigger values(1,'Jancy')
select * from demo_trigger

--DML triggers--Insert, Update, delete

--Insert
create trigger trigger_insert
on demo_trigger
FOR INSERT
as
BEGIN
    print 'You cannot insert into demo_trigger table'
    ROLLBACK TRANSACTION
END

insert into demo_trigger values(2,'Nancy') --cannot insert into table, gives the above error message

update demo_trigger set name='Nancy' where id=1--update is allowed, coz trigger is for insert and not for update

select * from demo_trigger

--For update
create trigger trigger_update
on demo_trigger
FOR UPDATE
as
BEGIN
    print 'You cannot update into demo_trigger table'
    ROLLBACK TRANSACTION
END

update demo_trigger set name='John' where id=1--cannot update table value

--For delete
create trigger trigger_delete
on demo_trigger
FOR DELETE
as
BEGIN
    print 'You cannot delete from demo_trigger table'
    ROLLBACK TRANSACTION
END

delete from demo_trigger where id=1-- cannot delete, gives the above message

drop trigger trigger_delete
drop trigger trigger_insert
drop trigger trigger_update

--For DML
create trigger trigger_DML
on demo_trigger
FOR INSERT,UPDATE,DELETE
as
BEGIN
    print 'You cannot PERFORM DML OPERATIONS ON demo_trigger table'
    ROLLBACK TRANSACTION
END

--FOR DML (PARTICULAR PERIOD OF TIME)
alter trigger trigger_DML
on demo_trigger
FOR INSERT,UPDATE,DELETE
as
BEGIN
    IF DATEPART(DW,GETDATE())=3
        BEGIN
            PRINT 'DML OPERATIONS CANNOT BE PERFORMED ON TUESDAY'
            ROLLBACK TRANSACTION
        END
END

alter trigger trigger_DML
on demo_trigger
FOR INSERT,UPDATE,DELETE
as
BEGIN
    IF DATEPART(HH,GETDATE())<10
        BEGIN
            PRINT 'DML OPERATIONS CANNOT BE PERFORMED AFTER 11:00AM'
            ROLLBACK TRANSACTION
        END
END

select * from demo_trigger
insert into demo_trigger values(4,'John3')
delete from demo_trigger where id=2
drop trigger trigger_DML

--INSERTED AND DELETED TABLE
create trigger trginsert_demo
ON demo_trigger
FOR INSERT
AS
    BEGIN
        select * from inserted
    END

select * from demo_trigger
insert into demo_trigger values(2,'John')


create trigger trgdelete_demo
ON demo_trigger
FOR DELETE
AS
    BEGIN
        select * from deleted
    END

select * from demo_trigger
delete from demo_trigger where id=1

create trigger trgupdate_demo
ON demo_trigger
FOR UPDATE
AS
    BEGIN
        select * from INSERTED
        select * from DELETED
    END

update demo_trigger set name='John0' where id=2

