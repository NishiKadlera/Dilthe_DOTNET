--stored procedures
--These are pre compiled SQL statements
--time saving--no need to write the query again and again

--System-defined
--User-defined

--Advantages- Improves Performance,Reusable,easy to maintain,security,reduced traffic

--No parameters
select * from Employee1
create procedure proc_prjcode
as
begin
    select * from Employee1 where prjcode=103;
end

execute proc_prjcode
exec proc_prjcode

--Input Parameters
create procedure sp_employee1dept (@dept varchar(25))
as
begin
    select * from Employee1 where dept=@dept --IT
end

exec sp_employee1dept 'IT'
--or
exec sp_employee1dept @dept='Dev'

--Output Parameter
create procedure sp_minscore(@minscore int OUTPUT)
as
begin
    select @minscore=min(score) from Employee1 --94
end

Declare @result int
exec sp_minscore @result OUTPUT --94
print @result --94