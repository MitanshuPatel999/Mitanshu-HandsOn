USE HandsOn;


CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY identity(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    BirthDate DATE,
    Nationality VARCHAR(50)
);

-- Books table
CREATE TABLE Books (
    BookID INT PRIMARY KEY identity(100,1),
    Title VARCHAR(100),
    AuthorID INT,
    PublicationDate DATE,
    Price DECIMAL(10, 2),
    StockQuantity INT
);

-- Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY identity(1000,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100)
);

-- Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY identity(2525,1),
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2)
);

-- OrderDetails table (Many-to-Many relationship between Books and Orders)
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY identity(2222,1),
    OrderID INT,
    BookID INT,
    Quantity INT,
    Price DECIMAL(10, 2)
);

-- Create some sample data
INSERT INTO Authors (FirstName, LastName, BirthDate, Nationality) VALUES
    ('John', 'Doe', '1980-01-15', 'American'),
    ('Jane', 'Smith', '1975-03-20', 'British'),
    ('David', 'Johnson', '1990-07-10', 'Canadian');

INSERT INTO Books (Title, AuthorID, PublicationDate, Price, StockQuantity) VALUES
    ('The Art of SQL', 1, '2008-05-15', 39.99, 100),
    ('Database Design for Dummies', 2, '2015-09-22', 29.99, 75),
    ('SQL Mastery', 3, '2013-03-01', 49.99, 120);

INSERT INTO Customers (FirstName, LastName, Email) VALUES
    ('Alice', 'Johnson', 'alice@email.com'),
    ('Bob', 'Smith', 'bob@email.com'),
    ('Charlie', 'Brown', 'charlie@email.com');

INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES
    (1, '2023-01-10', 89.97),
    (2, '2023-02-15', 29.99),
    (3, '2023-03-20', 49.99);

INSERT INTO OrderDetails (OrderID, BookID, Quantity, Price) VALUES
    (1, 1, 2, 79.98),
    (2, 2, 1, 29.99),
    (3, 3, 1, 49.99);

SELECT * FROM Authors;
SELECT * FROM Books;
SELECT * FROM Customers;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;

UPDATE Orders SET CustomerID=1011 WHERE OrderID=2525;
UPDATE Orders SET CustomerID=1001 WHERE CustomerID=222;
UPDATE Orders SET CustomerID=1002 WHERE TotalAmount>30 AND TotalAmount<80;

UPDATE OrderDetails SET OrderID=2526,BookID=101 WHERE OrderDetailID=2223;
UPDATE OrderDetails SET OrderID=2527,BookID=102 WHERE OrderDetailID=2224;
UPDATE OrderDetails SET OrderID=2524,BookID=100 WHERE OrderDetailID=2222;

select OrderID,OrderDate,TotalAmount,c.CustomerID,FirstName,Email
    from Orders as o
    inner join Customers as c on 
    o.CustomerID=c.CustomerID

select OrderID,OrderDate,TotalAmount,c.CustomerID,FirstName,Email
    from Orders as o
    right join Customers as c on 
    o.CustomerID=c.CustomerID

select OrderID,OrderDate,TotalAmount,c.CustomerID,FirstName,Email
    from Orders as o
    left join Customers as c on 
    o.CustomerID=c.CustomerID

select OrderID,OrderDate,TotalAmount,c.CustomerID,FirstName,Email
    from Orders as o
    full outer join Customers as c on 
    o.CustomerID=c.CustomerID

IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetBookInfoByTitle'
)
DROP PROCEDURE dbo.GetBookInfoByTitle
GO

CREATE PROCEDURE GetBookInfoByTitle
    @Title VARCHAR(100)
AS
BEGIN
    SELECT b.Title, a.FirstName, a.LastName, b.PublicationDate, b.Price
    FROM Books AS b
    INNER JOIN Authors AS a ON b.AuthorID = a.AuthorID
    WHERE b.Title = @Title;
END;

EXEC GetBookInfoByTitle null;
EXEC GetBookInfoByTitle 'SQL Book';
EXEC GetBookInfoByTitle 'The Art of SQL';

IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetPrice'
)
DROP PROCEDURE dbo.GetPrice
GO

create procedure GetPrice
    @id int
AS
BEGIN
select o.OrderDate,od.Price

from Orders as o right join OrderDetails as od
on o.OrderID=od.OrderID
where od.OrderDetailID=@id;

End
exec GetPrice 2223;
exec GetPrice 2222;
exec GetPrice 2220;

-- Create a new view called 'ViewName' in schema 'SchemaName'
-- Drop the view if it already exists
IF EXISTS (
SELECT *
    FROM sys.views
    JOIN sys.schemas
    ON sys.views.schema_id = sys.schemas.schema_id
    WHERE sys.schemas.name = N'dbo'
    AND sys.views.name = N'View1'
)
DROP VIEW SchemaName.View1
GO
-- Create the view in the specified schema
CREATE VIEW dbo.View1
AS
    -- body of the view
    SELECT FirstName,LastName,Email,OrderID,OrderDate,TotalAmount
    FROM dbo.Orders inner join dbo.Customers ON
    dbo.Orders.CustomerID=dbo.Customers.CustomerID
GO

select * from View1;