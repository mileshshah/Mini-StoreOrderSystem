CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    ProductID INT NOT NULL,
    OrderDate DATE NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL
);

INSERT INTO Orders (OrderID, ProductID, OrderDate, TotalAmount) VALUES
(1, 1, '2024-01-15', 19.99),
(2, 2, '2024-01-16', 29.99),
(3, 3, '2024-01-17', 9.99);

SELECT * FROM Orders;
