CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    StockQuantity INT NOT NULL
);

INSERT INTO Products (ProductID, ProductName, Price, StockQuantity) VALUES
(1, 'Product A', 19.99, 100),
(2, 'Product B', 29.99, 50),
(3, 'Product C', 9.99, 200);

SELECT * FROM Products;