
/* date calculations */


 
SELECT GETDATE();     -- Returns current date and time


SELECT DATEADD(DAY,5,GETDATE()) AS NEW_DATE;  -- ADD FIVE DAYS

SELECT DATEADD(DAY,-2,GETDATE()) AS NEW_DATE;  -- SUBTRACT 2 DAYS...

SELECT YEAR(GETDATE()) AS YEAR , MONTH(GETDATE()) AS MONTH ;  -- YEAR AND MONTH..

SELECT DATEDIFF(YEAR, '2002-06-15', GETDATE());  --GET AGE FROM DATE....


/* text calculations */

SELECT LEN('HELLO WORLD') AS length;   -- find the length of text...

SELECT UPPER('hello world') as upper;  -- Converts to uppercase..

SELECT LOWER('HELLO WORLD') as  lower;  -- Converts to  lowercase..

SELECT 'Hello' + ' ' + 'World';        -- concat two strings..

SELECT SUBSTRING('HELLO WORLD', 2,5);   -- print substring..

SELECT CHARINDEX('WORLD' ,'HELLO WORLD');  -- find the position of substring..

SELECT REPLACE('Hello World', 'World', 'Good Morning');  -- replace string..

SELECT REPLICATE('Hello World ', 3);  --repeat string..

SELECT REVERSE('Hello');  -- reverse string..
