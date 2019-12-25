CREATE DATABASE QLNH
GO

USE QLNH
GO

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(50) NOT NULL DEFAULT N'Còn trống'
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(50) NOT NULL DEFAULT 'admin',
	DisplayName NVARCHAR(50) PRIMARY KEY NOT NULL ,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT '1',
	Type INT NOT NULL DEFAULT 0
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(50) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0,
	totalPrice FLOAT,
	discount INT,
	finalPrice FLOAT

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account
(
UserName,
DisplayName,
PassWord,
Type
) 
VALUES 
(
	N'admin',
	N'ADMIN',
	N'admin',
	1
)
GO

CREATE PROC USP_GetAccountByUserName
@UserName NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @UserName
END
GO


CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO


CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT INTO	dbo.Bill
	(
	    DateCheckIn,
	    DateCheckOut,
	    idTable,
	    status,
		discount
	)
	VALUES
	(   GETDATE(), -- DateCheckIn - date
	    NULL, -- DateCheckOut - date
	    @idTable,         -- idTable - int
	    0,         -- status - int
		0
	   )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT INTO dbo.BillInfo
	(
	    idBill,
	    idFood,
	    count
	)
	VALUES
	(   @idBill, -- idBill - int
	    @idFood, -- idFood - int
	    @count  -- count - int
	    )
END
GO

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @existedBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @existedBillinfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b WHERE idBill = @idBill AND idFood = @idFood
	IF(@existedBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount - @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
    BEGIN
        INSERT INTO dbo.BillInfo
	(
	    idBill,
	    idFood,
	    count
	)
	VALUES
	(   @idBill, -- idBill - int
	    @idFood, -- idFood - int
	    @count  -- count - int
	    )
    END
END
GO

ALTER PROC USP_InsertBillInfo
@idBill int, @idFood int, @count int
AS
BEGIN
 DECLARE @isExitBillInfo int
 DECLARE @foodCount int = 1
 SELECT @isExitBillInfo = id, @foodCount = count FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood
 IF(@isExitBillInfo > 0)
 BEGIN
  DECLARE @newCount int = @foodcount + @count
  IF(@newCount > 0)
  BEGIN
    UPDATE BillInfo SET count = @newCount Where id = @isExitBillInfo
  END
  ELSE
  BEGIN
    DELETE BillInfo Where id = @isExitBillInfo 
  END
 END
 ELSE
 BEGIN
  IF(@count <= 0)
  BEGIN
   return 1;
  END
  ELSE
  BEGIN
   INSERT INTO BillInfo (idBill,idFood,count)
   VALUES(@idBill,@idFood,@count)
  END
 END
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	UPDATE dbo.TableFood SET status = N'Có người'  WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0 
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Còn trống' WHERE id = @idTable
END
GO

CREATE PROC USP_AddTable
@numOfTable INT
AS
DECLARE @i INT = 1
WHILE @i <= @numOfTable
BEGIN
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn ' + CAST(@i AS NVARCHAR(50)), -- name - nvarchar(50)
    N'Còn trống'  -- status - nvarchar(50)
    )
SET @i = @i + 1
END
GO


insert FoodCategory(name) values (N'Cà phê')
insert FoodCategory(name) values (N'Nước ép')
insert FoodCategory(name) values (N'Sinh tố')

insert Food(name,idCategory,price) values(N'Đen đá không đường',1,15000)
insert Food(name,idCategory,price) values(N'Bạc xỉu',1,18000)
insert Food(name,idCategory,price) values(N'Nước ép táo',2,25000)
insert Food(name,idCategory,price) values(N'Nước ép cam',2,25000)
insert Food(name,idCategory,price) values(N'Sinh tố bơ',3,30000)
insert Food(name,idCategory,price) values(N'Sinh tố dâu',3,30000)
