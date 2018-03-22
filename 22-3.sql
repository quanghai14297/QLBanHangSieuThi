﻿use QLBHSieuThi
Go

create table USERS(
	USERNAME varchar(40) primary key,
	PASS varchar(30),
	HOTEN NVARCHAR(50),
	GIOITINH NVARCHAR(6) CHECK (GIOITINH='Nam' OR GIOITINH='Nữ'), 
	EMAIL varchar(50) UNIQUE,
	QUYEN int check(QUYEN=1 or QUYEN=0),
		MADONHANG VARCHAR(8) 
)
CREATE TABLE DONHANG(
	MADONHANG VARCHAR(8) PRIMARY KEY,
	TENDONHANG NVARCHAR(30),
		MASANPHAM VARCHAR(8),
		MAKHUYENMAI VARCHAR(8),
)
CREATE TABLE HANGHOA(
	MASANPHAM VARCHAR(8) PRIMARY KEY,
	TENSANPHAM NVARCHAR(50),
	SOLUONG INT,
	GIANHAPVAO INT,
	GIABANRA INT,
		NGAYNHAP DATE,
)
CREATE TABLE KHUYENMAI(
	MAKHUYENMAI VARCHAR(8) PRIMARY KEY,
	TENKHUYENMAI NVARCHAR(30),
	PHANTRAM INT CHECK (PHANTRAM>=0 AND PHANTRAM<=100),
)