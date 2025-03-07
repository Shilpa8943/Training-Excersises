CREATE TABLE Products (
    ProductID INT PRIMARY KEY ,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price INT
   
);


INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 850),
(2, 'Smartphone', 'Electronics', 499),
(3, 'Headphones', 'Accessories', 99),
(4, 'Refrigerator', 'Appliances', 1200),
(5, 'Washing Machine', 'Appliances', 750),
(6, 'Chair', 'Furniture', 150),
(7, 'Desk Lamp', 'Furniture', 35),
(8, 'Shoes', 'Footwear', 80),
(9, 'Backpack', 'Accessories', 55),
(10, 'Coffee Maker', 'Appliances', 99);

CREATE PROCEDURE spProducts_CRUD 
AS 

BEGIN

 INSERT INTO Products (ProductID,ProductName,Category,Price) VALUES (11,'Smartphnone','Electronics',200);
 END
BEGIN
 SELECT* FROM Products;
 END

 BEGIN
  UPDATE  Products SET ProductName= 'keyboard' WHERE ProductID=11;
          
  END

  BEGIN
   DELETE FROM Products WHERE ProductID= 12;
   END

   EXEC spProducts_CRUD;