create database UASVisprog
use UASVisprog

--Run ini dulu kalo udah kebuat--
DROP Database UASVisprog

--CREATE TABLE--
create table Position
(
	PositionID char(10) primary key not null,
	PositionName varchar(50) not null
);

create table Employee 
(
	EmployeeID char(10) primary key not null,
	EmployeeName varchar(50) not null,
	PositionID char(10), foreign key (PositionID) references Position,
	Address varchar(100) NOT NULL,
	PhoneNumber char(20) NOT NULL,
	Password varchar(100) NOT NULL,
	IsNotEmployee varchar(20) NOT NULL
);

create table DataItem
(
	ItemID char(10) primary key not null,
	ItemName varchar(50) not null,
	Cost int not null,
	SalesPrice int not null,
	Stock int not null,
	Descriptions varchar(50) not null,
	IsDiscontinued varchar(20) NOT NULL
);

create table Supplier
(
    SupplierID char(10) primary key not null,
    SupplierName varchar(50) not null,
    SupplierAddress varchar(50) not null,
    SupplierPhone varchar(50) not null,
	IsActive varchar(20) not null
);

CREATE TABLE Sales(
    SalesID CHAR(10) PRIMARY KEY NOT NULL,
    TransactionDate DATETIME NOT NULL,
    EmployeeID CHAR(10) FOREIGN KEY REFERENCES Employee(EmployeeID) NOT NULL,
)

CREATE TABLE SalesDetail(
    SalesID CHAR(10) FOREIGN KEY REFERENCES Sales(SalesID) NOT NULL,
    ItemID CHAR(10) FOREIGN KEY REFERENCES DataItem(ItemID) NOT NULL,
    Quantity INT NOT NULL,
	salePrice INT NOT NULL
);

CREATE TABLE PurchaseOrder(
    PurchaseOrderID CHAR(10) PRIMARY KEY NOT NULL,
    SupplierID CHAR(10) FOREIGN KEY REFERENCES Supplier(SupplierID) NOT NULL,
    OrderDate DATE NOT NULL,
    EmployeeID CHAR(10) FOREIGN KEY REFERENCES Employee(EmployeeID) NOT NULL,
	OrderStatus VARCHAR(30) NOT NULL,
	WarehouseNote VARCHAR(100)
);


CREATE TABLE PurchaseOrderDetail(
    PurchaseOrderID CHAR(10) FOREIGN KEY REFERENCES PurchaseOrder(PurchaseOrderID) NOT NULL,
    ItemID CHAR(10) FOREIGN KEY REFERENCES DataItem(ItemID) NOT NULL,
    Quantity INT NOT NULL
)

--INSERT--
insert into Position 
	(PositionID, PositionName) 
	values 
	('CC001', 'Cashier'),
	('MM001', 'Manager'),
	('WH001', 'Warehouse');

insert into Employee 
	(EmployeeID, EmployeeName, PositionID, Address, PhoneNumber, Password, IsNotEmployee) 
	values 
	('E0001', 'Agustinus Budiman', 'WH001','Jl. pagi sore sore juga boleh', '082269696969', '123', 'false'),
	('E0002', 'Calvin Hartanto', 'MM001','Jl. pagi sore sore juga boleh', '082269696969', '123', 'false'),
	('E0003', 'David Sihombing', 'CC001','Jl. pagi sore sore juga boleh', '082269696969', '123', 'false'),
	('E0004', 'Tsucipto Purnomo', 'CC001','Jl. pagi sore sore juga boleh', '082269696969', '123', 'false');

insert into DataItem
	(ItemID, ItemName, Cost, SalesPrice, Stock, Descriptions, IsDiscontinued)
	values
	('MK0123', 'Sosis So Nice', 69000, 75000, 15, 'Sosis', 'false'),
	('MK0124', 'Kiko', 20000, 25000, 20, 'Dodol Keras', 'false'),
	('MK0125', 'Lifegurl', 15000, 20000, 3000, 'Sabun', 'false'),
	('MK0126', 'Sarimie', 30000, 35000, 4000, 'Mie Instan', 'false'),
	('MK0127', 'Sabun', 20000, 25000, 30, 'Sabun Mandi', 'false');

insert into Supplier
    (SupplierID, SupplierName, SupplierAddress, SupplierPhone, IsActive)
    values
    ('SS001','PT. Japfa','Jl. Sudirman','021-5524371', 'true'),
    ('SS002','PT. Bucin','Jl. Rasuna Said','021-5524372', 'true'),
    ('SS003','PT. Alfa','Jl. Merdeka','021-5524373', 'true'),
    ('SS004','PT. JayaEsport','Jl.Grogol','021-5524374', 'true'),
    ('SS005','PT. Bersinar ','Jl. Hasyim Ashari','021-5524375', 'true');

INSERT INTO Sales (SalesID,TransactionDate,EmployeeID)
VALUES
    ('S0001', '1/2/2022 09:00:00', 'E0004'),
    ('S0002', '1/2/2022 10:00:00', 'E0004'),
    ('S0003', '1/2/2022 11:00:00', 'E0004'),
    ('S0004', '1/2/2022 12:00:00', 'E0004'),
    ('S0005', '1/2/2022 08:00:00', 'E0004');

INSERT INTO SalesDetail (SalesID,ItemID,Quantity, salePrice)
VALUES
    ('S0001', 'MK0123', '1', 12000),
    ('S0002', 'MK0124', '2', 12000),
    ('S0003', 'MK0125', '3', 12000),
    ('S0005', 'MK0126', '4', 12000),
    ('S0005', 'MK0127', '5', 12000);

INSERT INTO PurchaseOrder (PurchaseOrderID,SupplierID,OrderDate,EmployeeID, OrderStatus, WarehouseNote)
VALUES
    ('P0001', 'SS001', '2021-10-15', 'E0002', 'Not Done', null),
    ('P0002', 'SS002', '2022-10-18', 'E0002', 'Not Done', null),
    ('P0003', 'SS003', '2022-08-13', 'E0002', 'Not Done', null),
    ('P0004', 'SS004', '2022-05-12', 'E0002', 'Not Done', null),
    ('P0005', 'SS005', '2022-07-23', 'E0002', 'Not Done', null);


INSERT INTO PurchaseorderDetail (PurchaseOrderID,ItemID,Quantity)
VALUES
    ('P0001', 'MK0123', '15'),
    ('P0002', 'MK0124', '20'),
    ('P0003', 'MK0125', '25'),
    ('P0004', 'MK0126', '30'),
    ('P0005', 'MK0127', '20');

select * from Position
select * from Employee
select * from DataItem
select * from Supplier
select * from Sales
select * from SalesDetail
select * from PurchaseOrder
select * from PurchaseOrderDetail
