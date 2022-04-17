--constraints-meaning set of rules
--not null
--Primary key- Can not have duplicate value and is not null
--Unique key-  Can not have duplicate value and can have one null
--Foriegn key
--Check-condition
--Default
--Identity

create database DLitheBootcamp
use DLitheBootcamp
--create table using all constraints
create table Employees
(
Eid int primary key identity(1,1),
Ename varchar(25) unique not null,
Age int check(Age>21),
Designation varchar(25)default 'Trainee'
)
insert into Employees values('Jancy',22,'HR')
insert into Employees values('Nancy',23,'HR')
insert into Employees values('Peter',22,'HR')
insert into Employees (Ename,Age)values('Sam',22)
insert into Employees values('Paul',22,'IT')

select* from Employees

--working of identity
create table demo
(
id int identity(1,1),
name varchar(25)
)
insert into demo values('Anil')
insert into demo values('Anish')
insert into demo values('Ankit')
insert into demo values(4,'Ankit')--not allowed because of identity(1,1)

select*from demo

--To insert explicit values in your identity column
SET Identity_Insert demo ON;
insert into demo(id,name) values(4,'Ankit')

--Reset the identity column value
DBCC CHECKIDENT(demo,RESEED,0);
insert into demo values('Diana')--do not allow us to insert the value without the explicit value because we have activated the identity_insert as ON

SET Identity_Insert demo Off;-- when the identity_insert is off, it allows us to give the value without the explicit value
insert into demo values('Diana')
insert into demo values('Reha')
insert into demo values('Neha')

select*from demo

--DROP Primary key from Employees table
alter table Employees drop PK__Employee__C1971B53AE09990F
select*from Employees

--ADD A PRIMARY KEY CONSTRAINT WITH OWN CONSTRAINT NAME
alter table Employees add constraint pk_eid PRIMARY KEY(EID)


--string functions
--ASCII
select name, ASCII(name) as NumCodeofFirstChar from demo
select*from demo
select Ename, ASCII(Ename) as NumCodeofFirstChar from Employees
select*from Employees
--CHAR
select char(65) as 'Code To Character'
select char(97) as 'Code To Character'
select char(32) as 'Code To Character'
select char(103) as 'Code To Character'
--CHARINDEX()--Select for the char in the specified string and return it's position
SELECT CHARINDEX('m', 'Name') AS MatchPosition;
--Concat()
SELECT CONCAT('Diana',' ','belongs to',' ','demo');
SELECT 'Diana'+' '+ 'belongs to'+' '+'demo' --concat with +
SELECT CONCAT_WS('.','Diana','belongs to','demo'); --strings will be added using a seperator(.,/';ect..)
SELECT CONCAT_WS('/','Diana','belongs to','demo');
--Datalength()
SELECT DATALENGTH('Diana belongs to demo');
--Difference()
SELECT DIFFERENCE('Jancy','Nancy');
--Left()
SELECT Left('Jancy',4);
--Length()
SELECT len('Jancy');
--Lower()
SELECT lower('JANCY');
--Upper()
SELECT upper('jancy');
--Trim
SELECT ltrim('    Jancy    ');--Trim
SELECT ltrim('    Jancy');--Ltrim
SELECT ltrim('Jancy    ');--Rtrim
--NCHAR()
SELECT nchar(65) as NumberToUnicodeCharacter
--Replace()
SELECT replace('Jancy','J','N');
--Replicate()
SELECT replicate('Jancy',5);
--Reverse()
SELECT reverse('Jancy');
--Right()
SELECT right('Jancy',3);
--Space()
SELECT space(3);
--Unicode()
SELECT unicode('Jancy');

--------------------MATH FUNCTIONS------------------------
--Absolute()
SELECT abs(-12) as absoluteNumber;
--Acos()
select Acos(0.25)
--Asin()
select asin(0.25)
--Atan()
select atan(2.5)
--Cos()
select cos(2)
--sin
select sin(2)
--tan
select tan(2)
--Cot()
select cot(10)
--Exp()
select exp(1)
--ceiling()
select ceiling(32.67)--33
--floor()
select floor(32.67)--32
--log
select log(10)
--log10
select log10(2)
--PI
select pi()
--Power
select power(5,2)
--Radians
select radians(180)
--Round
select round(23.4566,2)
--Sign
select sign(10)
--sqrt
select sqrt(81)
--square
select square(4)

----------------Date Functions--------------
--current_timestamp
select current_timestamp
--dateadd()
select dateadd(month,1,'2022/04/10')
select dateadd(day,1,'2022/04/10')
--datediff()
select datediff(year,'2022/04/10','2020/04/10')
--datename()
select datename(year,'2017/08/2')
--datepart()
SELECT DATEPART(day,'2017/08/2')
--day()
select getdate()
--month
select month('2022/04/11')
--year()
select year('2022/04/11')

--------------------------------------