﻿CREATE DATABASE QuanLyQuanCafe
go

USE QuanLyQuanCafe
go


-- BÀN ĐỒ ĂN
CREATE TABLE TABLEFOOD
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'Chưa có bàn',
	STATUS NVARCHAR(100) NOT NULL DEFAULT N'Trống',
)
GO


-- ĐĂNG NHẬP
CREATE TABLE ACCOUNT 
(
	USERNAME NVARCHAR(100) NOT NULL PRIMARY KEY,
	DISPLAYNAME NVARCHAR(100) NOT NULL DEFAULT N'Nhóm chưa có tên',
	PASSWORD NVARCHAR(100) NOT NULL DEFAULT 0,
	TYPE INT NOT NULL DEFAULT 0  --1: là admin
								 --0: là staff
)
GO


-- LOẠI THỨC ĂN
CREATE TABLE FOODCATEGORY
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO


--MÓN ĂN
CREATE TABLE FOOD
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	IDCATEGORY INT NOT NULL,
	PRICE FLOAT NOT NULL,

	FOREIGN KEY (IDCATEGORY) REFERENCES FOODCATEGORY(ID) 
)
GO


CREATE TABLE BILL
(
	ID INT IDENTITY PRIMARY KEY,
	DATECHECKIN DATE NOT NULL DEFAULT GETDATE(),
	DATECHECKOUT DATE,
	IDTABLE INT NOT NULL,
	STATUS INT NOT NULL DEFAULT 0  --1: ĐÃ THANH TOÁN; 0: CHƯA THANH TOÁN 

	FOREIGN KEY (IDTABLE) REFERENCES TABLEFOOD(ID)
)
GO


CREATE TABLE BILLINFO 
(
	ID INT IDENTITY PRIMARY KEY,
	IDBILL INT NOT NULL,
	IDFOOD INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0

	FOREIGN KEY (IDBILL) REFERENCES BILL(ID),
	FOREIGN KEY (IDFOOD) REFERENCES FOOD(ID)
)
GO



