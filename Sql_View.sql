CREATE TABLE Employee (
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    salary DECIMAL(10,2)
);

INSERT INTO Employee (EmpId, EmpName, salary) VALUES 
(1, 'Arjun', 50000),
(2, 'Neha', 60000),
(3, 'Rahul', 70000),
(4, 'Sneha', 80000),
(5, 'Vishnu', 90000);

SELECT * FROM Employee;

CREATE VIEW EmployeeView AS
SELECT EmpName,Department,salary 
FROM Employee WHERE salary>60000;

SELECT * FROM  EmployeeView;

UPDATE EmployeeView
SET salary = salary + 5000
WHERE salary>50000;

-- DROP VIEW EmployeeView;


