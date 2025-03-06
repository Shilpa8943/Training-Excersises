
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

/* groupby having */

SELECT Department, SUM(salary) AS total_salary   
FROM Employee
GROUP BY Department
HAVING SUM(salary) > 70000;

/* case */

SELECT EmpName, Department, salary,
    CASE 
        WHEN salary > 80000 THEN 'High Salary'
        WHEN salary BETWEEN 60000 AND 80000 THEN 'Medium Salary'
        ELSE 'Low Salary'
    END AS salary_category
FROM Employee;
