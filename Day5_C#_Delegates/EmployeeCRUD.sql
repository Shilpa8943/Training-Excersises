CREATE TABLE Employeee (
    EmployeeId INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
	Department VARCHAR(30),
    salary INT
);

CREATE PROC spEmployeeCrud
 @Action VARCHAR(30) =NULL,
 @EmployeeId INT =NULL ,
 @EmployeeName varchar(30)= NULL,
 @Department VARCHAR(30)= NULL,
 @salary INT =NULL

 AS 

 SET NOCOUNT ON;
 BEGIN
  
  IF @Action='INSERT'
   BEGIN
    INSERT INTO Employeee(EmployeeId,EmployeeName,Department,salary )
		VALUES( @EmployeeId ,@EmployeeName,@Department,@salary );
   END
  
  ELSE IF @Action='SELECT'

    BEGIN

	  IF @EmployeeId IS NULL
	   
	   
		SELECT * FROM Employeee;
      
	  ELSE
	    SELECT * FROM Employeee WHERE EmployeeId=@EmployeeId;
      
	END

ELSE IF @Action='UPDATE'
   
   BEGIN

    UPDATE Employeee
        SET EmployeeName = @EmployeeName,
            Department = @Department,
            Salary = @Salary
        WHERE EmployeeId = @EmployeeId;
   END

   ELSE IF @Action='DELETE'

     BEGIN
	   
	   DELETE FROM Employeee WHERE EmployeeId=@EmployeeId;

	END

	ELSE 
	 BEGIN

	   PRINT  'INVALID EXECUTION';
	END

END;



EXEC  spEmployeeCrud 'INSERT',1,'Jhon','HR',80000;
EXEC  spEmployeeCrud 'INSERT',2,'Smith','Sales',30000;
EXEC  spEmployeeCrud 'INSERT',3,'Shilpa','Manager',70000;
EXEC  spEmployeeCrud 'INSERT',4,'Alex','IT',60000;

EXEC  spEmployeeCrud 'SELECT';

EXEC  spEmployeeCrud 'SELECT',1;

EXEC  spEmployeeCrud 'UPDATE' ,2,'Smith','Marketing',40000;

EXEC  spEmployeeCrud 'SELECT',2;

EXEC  spEmployeeCrud 'DELETE',4;

