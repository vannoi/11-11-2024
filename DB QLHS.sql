Create database QLHS
go
use QLHS
go
Create table NhanVien
(
	TaiKhoan varchar(50) not null primary key,
	MatKhau varbinary(100) not null
) 
go
insert NhanVien (TaiKhoan, MatKhau) values (N'admin', PWDENCRYPT('admin'))
insert NhanVien (TaiKhoan, MatKhau) values (N'cntt', PWDENCRYPT('cntt'))
insert NhanVien (TaiKhoan, MatKhau) values (N'dntu', PWDENCRYPT('dntu'))
insert NhanVien (TaiKhoan, MatKhau) values ( N'hanh', PWDENCRYPT('hanh'))
insert NhanVien (TaiKhoan, MatKhau) values ( N'tien', PWDENCRYPT('tien'))
insert NhanVien (TaiKhoan, MatKhau) values ( N'a', PWDENCRYPT('a'))
go
Create table Lop
(
	MaLop int identity(1,1) not null primary key,
	TenLop nvarchar(30) not null
)
go
Set identity_insert Lop on
insert Lop (MaLop, TenLop) values (1, N'09QT113')
insert Lop (MaLop, TenLop) values (2, N'10KT111')
insert Lop (MaLop, TenLop) values (3, N'08CT111')
insert Lop (MaLop, TenLop) values (4, N'09LU112')
insert Lop (MaLop, TenLop) values (5, N'10CT113')
Set identity_insert Lop off
go
Create table HocSinh
(
	MaHS int identity(1,1) not null primary key,
	HoHS nvarchar(40) not null,
	TenHS nvarchar(10) not null,
	Phai bit not null,
	NgaySinh datetime not null,
	QueQuan nvarchar(100) null,
	MaLop int not null references Lop(MaLop)
)
go
set dateformat dmy
set identity_insert HocSinh on
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (108000432, N'Trần Trung', N'Tiến', 0, '16/4/1989', N'Biên Hòa', 1)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (109000123, N'Nguyễn Hữu', N'Hùng', 0, '5/4/1990', N'Phan Thiết', 2)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (109000333, N'Lưu Gia', N'Hân', 1, '2/3/1991', N'Biên Hòa', 3)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (109000456, N'Trương Hoài', N'Oanh', 1, '10/6/1998', N'Đồng Nai', 4)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (109001465, N'Cao Thủy', N'Tiên', 1,'18/1/1999', N'Bình Dương', 4)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (110000123, N'Lê Gia', N'Bảo', 0, '22/10/1989', N'Đồng Nai', 3)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (110000564, N'Đỗ Minh', N'Thành', 0,'30/3/1988', N'Cà Mau', 2)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (110001431, N'Bùi Quang', N'Hưng', 0,'20/2/1997', N'Phan Thiết', 1)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (110005285, N'Cao Thị', N'Thu', 1,'19/9/1990', N'Biên Hòa', 2)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (309000321, N'Trần Thanh', N'Việt', 0, '16/2/1988', N'Khánh Hòa', 3)
insert HocSinh (MaHS, HoHS, TenHS, Phai, NgaySinh, QueQuan, MaLop) values (309005773, N'Trần Gia', N'Tuệ', 1, '11/10/1991', N'Huế', 4)
Set identity_insert HocSinh off
go
Create table MonHoc
(
	MaMH tinyint not null primary key,
	TenMH nvarchar(50) not null,
	HeSo smallint null check(HeSo > 0)
)
go
insert MonHoc (MaMH, TenMH, HeSo) values (50, N'Lập trình Web', 5)
insert MonHoc (MaMH, TenMH, HeSo) values (68, N'Tin học đại cương', 4)
insert MonHoc (MaMH, TenMH, HeSo) values (99, N'Thương mại điện tử', 3)
insert MonHoc (MaMH, TenMH, HeSo) values (100, N'Tài chính doanh nghiệp', 4)
insert MonHoc (MaMH, TenMH, HeSo) values (111, N'Marketting cơ bản', 3)
insert MonHoc (MaMH, TenMH, HeSo) values (123, N'Tin học quản lý', 2)
go
Create table Diem
(
	MaHS int not null references HocSinh(MaHS),
	MaMH tinyint not null references MonHoc(MaMH),
	Diem float not null check (Diem between 0 and 10),
	primary key(MaHS, MaMH)
)
go
insert Diem (MaHS, MaMH, Diem) values (108000432, 123, 7)
insert Diem (MaHS, MaMH, Diem) values (109000123, 50, 7)
insert Diem (MaHS, MaMH, Diem) values (109000123, 68, 8.5)
insert Diem (MaHS, MaMH, Diem) values (109000123, 99, 3)
insert Diem (MaHS, MaMH, Diem) values (109000123, 123, 5.5)
insert Diem (MaHS, MaMH, Diem) values (109000333, 99, 4)
insert Diem (MaHS, MaMH, Diem) values (109000333, 111, 6.5)
insert Diem (MaHS, MaMH, Diem) values (109001465, 123, 2)
insert Diem (MaHS, MaMH, Diem) values (110000123, 50, 10)
insert Diem (MaHS, MaMH, Diem) values (110001431, 50, 9)
insert Diem (MaHS, MaMH, Diem) values (110001431, 123, 8.5)
insert Diem (MaHS, MaMH, Diem) values (110005285, 50, 4.5)
insert Diem (MaHS, MaMH, Diem) values (309000321, 50, 7.5)
insert Diem (MaHS, MaMH, Diem) values (309000321, 100, 5)
insert Diem (MaHS, MaMH, Diem) values (309000321, 111, 6)
insert Diem (MaHS, MaMH, Diem) values (309005773, 50, 5.5)
insert Diem (MaHS, MaMH, Diem) values (309005773, 123, 6.5)
