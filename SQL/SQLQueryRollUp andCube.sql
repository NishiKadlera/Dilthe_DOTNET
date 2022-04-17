--Roll up and cube function--extesion of group --
select*from Employee1

Select dept,sum(score) from Employee1 group by dept;
Select dept,sum(score) from Employee1 group by rollup(dept);

Select dept as Employee1_Dept,sum(score) as TotalScore from Employee1 group by rollup(dept);

--coalesce(replaces the NULL with an Actual Value)
Select coalesce(dept,'Overall_TotalScore') as Employee1_Dept,sum(score) as TotalScore from Employee1 group by rollup(dept);

--coalesce(replaces the NULL with an Actual Value)
Select coalesce(dept,'Overall_TotalScore') as Employee1_Dept,sum(score) as TotalScore from Employee1 group by cube(dept);

select * from Employee1

alter table Employee1 add prjcode int

update Employee1 set prjcode =103 where score<94
update Employee1 set prjcode =100 where score>95
update Employee1 set prjcode =102 where score=95
update Employee1 set prjcode =101 where score=94

Select coalesce(dept,'Overall_TotalScore') as Employee1_Dept,sum(score) as TotalScore,Prjcode
from Employee1 group by rollup(dept,prjcode) order by dept,prjcode

Select coalesce(dept,'Overall_TotalScore') as Employee1_Dept,sum(score) as TotalScore,Prjcode
from Employee1 group by cube(dept,prjcode) order by dept,prjcode

select * from Employee1 order by dept
