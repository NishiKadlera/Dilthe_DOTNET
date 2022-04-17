--Transactions

--ACID properties
--Atomicity-success/fail
--Consistency
--Isolation
--Durability

--TRANSACTION MODES
--AUTO-COMMIT
--EXPLICIT-BEGIN AND END,COMMIT,ROLLBACK,SAVEPOINT
--IMPLICIT

--EXPLICIT TRANSACTION
select * from Employee1

--COMMIT

BEGIN TRANSACTION
--SQL STATEMENTS
    insert into Employee1 values(7,'Paul','Des',97,103);
   update Employee1 set dept='IT' where id=5;
--commit
COMMIT TRANSACTION

--ROLLBACK

BEGIN TRANSACTION
--SQL STATEMENTS
    insert into Employee1 values(8,'Mary','Des',97,105);
    update Employee1 set dept='Dev' where id=7;
--Undo changes
ROLLBACK TRANSACTION

select * from Employee1

--SAVEPOINT

BEGIN TRANSACTION
--SQL STATEMENTS
    insert into Employee1 values(8,'Mary','HR',97,108);
    --Savepoint is applied to your insert statement
    SAVE TRANSACTION Insert_Student
    update Employee1 set dept='Dev' where id=7;
    select * from Employee1;
    ROLLBACK TRANSACTION Insert_Student
--Commit
COMMIT TRANSACTION

SELECT * FROM Employee1

--IMPLICIT TRANSACTION = 2
SET IMPLICIT_TRANSACTIONS ON
--@@-global variable
Select iif(@@options & 2=2,'Implicit Transaction Mode ON',
        'Implicit Transaction Mode OFF') AS Transaction_Mode