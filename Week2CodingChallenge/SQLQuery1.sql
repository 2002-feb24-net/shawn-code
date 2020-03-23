CREATE TABLE Customers (
    ID int NOT NULL PRIMARY KEY,
	FirstName varchar(255),
    LastName varchar(255),
    CardNumber varchar(255),
);
CREATE TABLE Products (
    ID int NOT NULL PRIMARY KEY,
    Name varchar(255),
    Price decimal(10,2),
);

CREATE TABLE Orders (
    ID int NOT NULL PRIMARY KEY,
    ProductID int FOREIGN KEY REFERENCES Products(ID),
    CustomerID int FOREIGN KEY REFERENCES Customers(ID),
);

INSERT INTO Customers (ID,FirstName, LastName, CardNumber)
VALUES (1,'Shawn','Halcomb','1111-1111-1111-1111'); 

INSERT INTO Customers (ID,FirstName, LastName, CardNumber)
VALUES (2,'Arthur','Fleck','2222-2222-2222-2222'); 

INSERT INTO Customers (ID,FirstName, LastName, CardNumber)
VALUES (3,'Marshall','Law','3333-3333-3333-3333'); 

INSERT INTO Products (ID, Name, Price)
VALUES (1,'BlueBerries', '4.99');

INSERT INTO Products (ID, Name, Price)
VALUES (2,'JumpRope', '9.22');

INSERT INTO Products (ID, Name, Price)
VALUES (3,'RocketLauncher', '9023.11');

INSERT INTO Orders (ID, ProductID, CustomerID)
VALUES (1,3,2);

INSERT INTO Orders (ID, ProductID, CustomerID)
VALUES (2,2,3);

INSERT INTO Orders (ID, ProductID, CustomerID)
VALUES (3,1,1);

INSERT INTO Products (ID, Name, Price)
VALUES (4,'iPhone', '200');

INSERT INTO Customers (ID,FirstName, LastName, CardNumber)
VALUES (4,'Tina','Smith','4444-4444-4444-4444'); 

INSERT INTO Orders (ID, ProductID, CustomerID)
VALUES (4,4,4);
INSERT INTO Orders (ID, ProductID, CustomerID)
VALUES (5,4,4);

SELECT * FROM Orders
WHERE CustomerID=4; 

UPDATE Products
SET Price = '250'
WHERE ID=4; 

SELECT 
(SELECT COUNT(*) FROM Orders WHERE ProductId = 4)
* 
(SELECT Price FROM Products WHERE ID = 4)

SELECT *
FROM Customers

SELECT *
FROM Products

SELECT *
FROM Orders