use QLBHSieuThi
Go

create table USERS(
	USERNAME varchar(40) primary key,
	PASS varchar(30),
	HOTEN NVARCHAR(50),
	GIOITINH NVARCHAR(6) CHECK (GIOITINH='Nam' OR GIOITINH='Nữ'), 
	EMAIL varchar(50) UNIQUE,
	QUYEN int check(QUYEN=1 or QUYEN=0),--PHÂN QUYỀN VỚI ADMIN VÀ KHÁCH HÀNG
)
CREATE TABLE DONHANG(
	MADONHANG VARCHAR(8) PRIMARY KEY,
	MASANPHAM VARCHAR(8) references HANGHOA(MASANPHAM),
	USERNAME VARCHAR(40) REFERENCES USERS(USERNAME),
	TENDONHANG NVARCHAR(30),
	MAKHUYENMAI VARCHAR(8) REFERENCES KHUYENMAI(MAKHUYENMAI),
	XACNHAN INT CHECK (XACNHAN>=0 AND XACNHAN<=3) DEFAULT 0, --ĐƠN HÀNG ĐƯỢC ADMIN BAN TAI CHO=1, CHƯA DUYỆT =0, ĐÃ GIAO =2,KHACH TRA = 3
	NGAYDAT DATE,
	NGAYGIAOHANG DATE,
)
CREATE TABLE HANGHOA(
	MASANPHAM VARCHAR(8) PRIMARY KEY,
	TENSANPHAM NVARCHAR(50),
	SOLUONG INT,
	GIANHAPVAO INT,
	GIABANRA INT,
	NGAYNHAP DATE,
	KIEMTRALOI INT CHECK (KIEMTRALOI=0 OR KIEMTRALOI=1),--KIỂM TRA SẢN PHẨM LỖI HAY K
)
CREATE TABLE KHUYENMAI(
	MAKHUYENMAI VARCHAR(8) PRIMARY KEY,
	TENKHUYENMAI NVARCHAR(30),
	PHANTRAM INT CHECK (PHANTRAM>=0 AND PHANTRAM<=100),
	NGAYKHUYENMAI DATE,
)

INSERT INTO USERS VALUES('quanghai142','14020501','Trương Quang Hải','Nam','quanghai14297@gmail.com','0')
INSERT INTO USERS VALUES('admin','1','Trương Quang Hải','Nam','quanghai14@gmail.com','0')
select * from users
insert into HANGHOA VALUES('SP151462','TIVI SAMSUNG',6,'20000','50000','20180207',0)
insert into HANGHOA VALUES('SP151463','TIVI LG',6,'20000','50000','20180207',0)
INSERT INTO KHUYENMAI VALUES('KM152625','NGÀY 8-3','70','20180308')
INSERT INTO DONHANG VALUES('DH162877','SP151462','quanghai142','ĐIỆN TỬ','KM152625',1,'20180330','20180426')
INSERT INTO DONHANG VALUES('DH162877','SP151463','quanghai142','ĐIỆN TỬ','KM152625',1,'20180330','20180426')
INSERT INTO DONHANG VALUES('DH162873','SP151463','quanghai142','ĐIỆN TỬ','KM152625',1,'20180226','20180426')
select madonhang from donhang where NGAYDAT= cast(getdate() as date) group by madonhang
select sum(giabanra) from hanghoa where masanpham in (select masanpham from donhang where NGAYDAT= cast(getdate() as date))
select count(masanpham) from donhang where NGAYDAT= cast(getdate() as date)
select COUNT(XACNHAN) FROM DONHANG WHERE XACNHAN=1
select sum(giabanra) from hanghoa INNER JOIN DONHANG ON HANGHOA.MASANPHAM=DONHANG.MASANPHAM where DONHANG.NGAYDAT= cast(getdate() as date)
select sum(giabanra) from hanghoa inner join donhang on hanghoa.MASANPHAM=DONHANG.MASANPHAM where year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))-1
select sum(giabanra-gianhapvao) from hanghoa inner join donhang on hanghoa.masanpham=donhang.masanpham where year(donhang.NGAYDAT)=year(cast(getdate() as date)) and month(donhang.NGAYDAT)=month(cast(getdate() as date))
select * from donhang

select sum(giabanra*count(donhang.MASANPHAM)) from HANGHOA inner join DONHANG on HANGHOA.MASANPHAM=DONHANG.MASANPHAM group by donhang.MASANPHAM,GIABANRA
select MADONHANG AS N'Mã đơn hàng',TENDONHANG as N'Tên đơn hàng', from DONHANG


select count(masanpham) from hanghoa where month(ngaynhap)=month(cast(GETDATE() as date))-1
select count(masanpham) from hanghoa where soluong=0


create view DONHANG 
select MADONHANG AS N'Mã đơn hàng',TENDONHANG AS N'Tên đơn hàng',

create view HANGHOAFORM AS
select MASANPHAM as N'Mã hàng hóa', TENSANPHAM as N'Tên hàng hóa',SOLUONG as N'Số lượng',gianhapvao as N'Giá nhập',giabanra as N'Giá bán ra',ngaynhap as N'Ngày nhập' from HANGHOA
