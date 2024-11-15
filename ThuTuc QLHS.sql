use QLHS

go
create proc sp_Login 
@taikhoan varchar(30),
@matkhau varchar(30)
as
	if exists(Select * from NhanVien where TaiKhoan =@taikhoan)
		if exists(Select * from NhanVien where TaiKhoan =@taikhoan and PWDCOMPARE(@matkhau,MatKhau)=1)
			select Errcode=1, ErrMsg=N'Đăng nhập thành công'
		else
			select Errcode=2, ErrMsg=N'Mật khẩu không đúng'
		else
			select Errcode=3, ErrMsg=N'Tài khoản không tồn tại'
			
go
--drop proc sp_Login
Create proc sp_XemHocSinh
as
	Select ROW_NUMBER() over (order by MaHS) as STT, * From HocSinh
go

create proc sp_DSLop
as
	Select * from Lop
go

Create proc sp_DSHocSinhTheoLop
@malop int
as
	select ROW_NUMBER() OVER (order by MaHS) STT, MaHS, HoHS, TenHS, NgaySinh,
	case when Phai = 1 then N'Nữ' else 'Nam' end Phai, QueQuan, MaLop
	from HocSinh
	where MaLop = @malop
go




CREATE PROCEDURE sp_ThemHocSinh
    @HoHS NVARCHAR(50),
    @TenHS NVARCHAR(50),
	@Phai bit,
    @NgaySinh datetime,
    @QueQuan NVARCHAR(100),
    @MaLop int
AS
BEGIN
	
    INSERT INTO HocSinh (HoHS, TenHS, Phai,NgaySinh, QueQuan, MaLop)
    VALUES (@HoHS, @TenHS,@Phai, @NgaySinh, @QueQuan, @MaLop)
END
go

CREATE PROCEDURE sp_CapNhatHocSinh
    @MaHS int,
    @HoHS NVARCHAR(50),
    @TenHS NVARCHAR(50),
	@Phai bit,
    @NgaySinh datetime,
    @QueQuan NVARCHAR(100),
    @MaLop int
AS
BEGIN
    UPDATE HocSinh
    SET HoHS = @HoHS,
        TenHS = @TenHS,
		Phai = @Phai,
        NgaySinh = @NgaySinh,
        QueQuan = @QueQuan,
        MaLop = @MaLop
    WHERE MaHS = @MaHS
END
go

CREATE PROCEDURE sp_XoaHocSinh
    @MaHS int
AS
BEGIN
    DELETE FROM HocSinh WHERE MaHS = @MaHS
END
go