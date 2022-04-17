--synonym--is nothing but alias for table
select *from Employee
select *from Employee1
create synonym Emp2 for dbo.Employee
select *from Employee
select*from Emp2

--choose()
select choose(5,'HTML','JAVA','CSS','C#','BOOTSTRAP','JQUERY') as result
select * from orders

select orderdate,choose(day([orderdate]),'Sun','Mon','Tue','Wed','Thur','Fri','Sat') as ordermonth from orders

select orderdate,choose(month([orderdate]),'Jan','Feb','Mar','April',
'May') as OrderMonth from orders

--CASE
select * from Employee1
--Searched Case
select Name,Score,
CASE
    WHEN SCORE=95 THEN 'MERIT'
    WHEN SCORE=98 THEN 'DISTINCTION'
    ELSE 'GOOD'
END AS REMARKS from Employee1

--Simple Case
select Name,Dept,
CASE Dept    
    WHEN 'IT' THEN 'INFORMATION TECHNOLOGY'
    WHEN 'DEV' THEN 'DEVELOPER'
	WHEN 'FINANCE' THEN 'FINANCE'
	WHEN 'HR' THEN 'HUMAN RESOURCES'
    ELSE 'DESIGNER'
END AS 'DEPARTMENT DETAILS'
FROM Employee1