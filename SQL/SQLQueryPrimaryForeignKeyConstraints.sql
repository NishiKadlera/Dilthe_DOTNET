--Primary and Foreign concepts---
--Department table(Parent) and Emplyoee table(child)

--Parent table(Dept)
create table Dept
(
Dno int primary key,
Dname varchar(25)
)
insert into Dept values(1,'HR')
insert into Dept values(2,'IT')
insert into Dept values(3,'Admin')
insert into Dept values(4,'Testing')

select*from dept

--Child Table(Emp)
create table Emp
(
Eid int primary key,
Ename varchar(25),
Did int foreign key references Dept(Dno)
)

insert into Emp values(101,'John',1)
insert into Emp values(102,'John1',2)
insert into Emp values(103,'John2',3)
insert into Emp values(104,'John3',4)
insert into Emp values(105,'John4',4)

select*from Emp

--Primary and foriegn key relation b/w multiple tables--Customer,Products,Orders

--Customers table--Parent 1
create table Customer
(
Cid int primary key,
Cname varchar(25)
)
insert into customer values(1,'John')
insert into customer values(2,'Peter')
insert into customer values(3,'Jancy')
insert into customer values(4,'Nancy')
insert into customer values(5,'Sam')

Select*from customer

--Product table--parent 2
create table Product
(
Pid int primary key,
Pname varchar(25),
Price money
)

insert into product values(100,'Laptop',50000)
insert into product values(101,'TV',25000)
insert into product values(102,'Tab',15000)

select*from product

--Orders table-child
create table orders
(
Orderid int primary key,
Orderdate date,
Quantity int,
Cno int foreign key references customer(Cid),
Pno int foreign key references product(Pid)
)

insert into orders values(200,'2022/04/07',2,5,101)
insert into orders values(201,'2022/04/07',2,5,102)
insert into orders values(206,'2022/04/08',5,4,102)

select*from orders

