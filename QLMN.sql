Create database ThongTinMN
go
use ThongTinMN
go
Create table [Lop]
(
	[MaLop] Char(5) NOT NULL,
	[TenLop] Nvarchar(10) NULL,
	[soluong] Integer NULL,
	[Namhoc] Char(9) NULL,
Primary Key ([MaLop])
) 
go

Create table [PH]
(
	[MaPH] Char(5) NOT NULL,
	[TenPH] Nvarchar(30) NULL,
	[NgaySinh] Datetime NULL,
	[gioitinh] Nvarchar(5) NULL,
	[dantoc] Nvarchar(15) NULL,
	[SoDTPH1] Char(10) NULL,
	[SoDTPH2] Char(10) NULL,
	[diachi] Nvarchar(70) NULL,
	[noicongtac] Nvarchar(30) NULL,
	[nghenghiep] Nvarchar(30) NULL,
	[email] Char(40) NULL,
Primary Key ([MaPH])
) 
go

Create table [GiaoVien]
(
	[MaGV] Char(5) NOT NULL,
	[TenGV] Nvarchar(30) NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Datetime NULL,
	[soDTGV] Char(10) NULL,
	[TrinhDo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(30) NULL,
	[diachi] Nvarchar(70) NULL,
	[email] Nvarchar(40) NULL,
Primary Key ([MaGV])
) 
go

Create table [CBYT]
(
	[MaCBYT] Char(5) NOT NULL,
	[tenCBYT] Nvarchar(30) NULL,
	[ngaysinh] Datetime NULL,
	[gioitinh] Nvarchar(5) NULL,
	[soDTCB] Char(10) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(20) NULL,
	[diachi] Nvarchar(70) NULL,	
	[email] Char(40) NULL
		
Primary Key ([MaCBYT])
) 
go

Create table [HS]
(
	[MaHS] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[TenHS] Nvarchar(30) NULL,
	[MaLop] Char(5) NOT NULL,	
	[ngaysinh] Date NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ghichu] Nvarchar(50) NULL,
Primary Key ([MaHS])
) 
go

Create table [DonNhapHoc]
(
	[MaDon] Char(5) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[NgayDangKy] Datetime NULL,
	[Loptuoi] Nvarchar(10) NULL,
Primary Key ([MaDon])
) 
go

Create table [Phieudiemdanh]
(
	[MaPDD] Char(5) NOT NULL,
	[MaGV] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[Ngaydiemdanh] Datetime NULL,
	[Tinhtrangvang] Nvarchar(10) NULL,
	[Lydo] Nvarchar(20) NULL,
Primary Key ([MaPDD])
) 
go

Create table [BienLai]
(
	[MaBL] Char(10) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[ngaythu] Datetime NULL,
	[Tienhocphi] int NULL,
	[Tienan] int NULL,
	[Tienphuthu] int NULL,
	[tongtienhocphi] int NULL,
Primary Key ([MaBL])
) 
go

Create table [PhieuKhamSK]
(
	[MaPK] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[ngaykham] Datetime NULL,
	[namhoc] Integer NULL,
	[Chieucao] Char(10) NULL,
	[Cannang] Char(10) NULL,
	[Taimuihong] Nvarchar(100) NULL,
	[Mat] Nvarchar(100) NULL,
	[Xuong] Nvarchar(100) NULL,
	[Rang] Nvarchar(100) NULL,
Primary Key ([MaPK])
) 
go

Create table [NV]
(
	[MaNV] Char(5) NOT NULL,
	[TenNV] Nvarchar(30) NULL,
	[Gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Date NULL,
	[chucvu] Nvarchar(20) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[diachi] Nvarchar(70) NULL,
	[email] Nchar(40) NULL,
	[sodt] Char(10) NULL,
Primary Key ([MaNV])
) 
go

Create table [CT_Kham]
(
	[MaCBYT] Char(5) NOT NULL,
	[MaPK] Char(5) NOT NULL,
	[SoLuongKham] Integer NULL,
Primary Key ([MaCBYT],[MaPK])
) 
go

Create table [PhieuBaoAn]
(
	[MaPhieu] Char(5) NOT NULL,
	[MaGV] Char(5) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[NgayBaoAn] datetime NULL,
	[SoXuatAn] Integer NULL,
	
Primary Key ([MaPhieu])
) 
go

Create table [tbUser]
(
	[UserName] Varchar(50) NOT NULL,
	[Pass] Nvarchar(20) NOT NULL,
	[HoTen] Nvarchar(30) NULL,
	[Quyen] Nvarchar(10) NULL,
Primary Key ([UserName])
) 
go
Create table [NVCU]
(
	[MaNV] Char(5) NOT NULL,
	[TenNV] Nvarchar(30) NULL,
	[Gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Date NULL,
	[chucvu] Nvarchar(20) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[diachi] Nvarchar(70) NULL,
	[email] Nchar(40) NULL,
	[sodt] Char(10) NULL
) 
go
Create table [GiaoVienCU]
(
	[MaGV] Char(5) NOT NULL,
	[TenGV] Nvarchar(30) NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Datetime NULL,
	[soDTGV] Char(10) NULL,
	[TrinhDo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(30) NULL,
	[diachi] Nvarchar(70) NULL,
	[email] Nvarchar(40) NULL
) 
go
Create table [CBYTcu]
(
	[MaCBYT] Char(5) NOT NULL,
	[tenCBYT] Nvarchar(30) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(20) NULL,
	[diachi] Nvarchar(70) NULL,
	[soDTCB] Char(10) NULL,
	[email] Char(40) NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Datetime NULL
) 
go
Create table [PhieuBaoAnCu]
(
	[MaPhieu] Char(5) NOT NULL,
	[MaGV] Char(5) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[NgayBaoAn] char NULL
	[SoXuatAn] Integer NULL,
) 
go
Create table [BienLaiCu]
(
	[MaBL] Char(10) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[ngaythu] Datetime NULL,
	[Tienhocphi] int NULL,
	[Tienan] int NULL,
	[Tienphuthu] int NULL,
	[tongtienhocphi] int NULL
) 
go
Create table [DonNhapHocCu]
(
	[MaDon] Char(5) NOT NULL,
	[MaNV] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[NgayDangKy] Datetime NULL,
	[Loptuoi] Nvarchar(10) NULL
) 
go
Create table [PhieuKhamSKCu]
(
	[MaPK] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[ngaykham] Datetime NULL,
	[namhoc] Integer NULL,
	[Chieucao] Char(10) NULL,
	[Cannang] Char(10) NULL,
	[Taimuihong] Nvarchar(100) NULL,
	[Mat] Nvarchar(100) NULL,
	[Xuong] Nvarchar(100) NULL,
	[Rang] Nvarchar(100) NULL
)
go
Create table [PhieudiemdanhCu]
(
	[MaPDD] Char(5) NOT NULL,
	[MaGV] Char(5) NOT NULL,
	[MaHS] Char(5) NOT NULL,
	[Ngaydiemdanh] Datetime NULL,
	[Tinhtrangvang] Nvarchar(10) NULL,
	[Lydo] Nvarchar(20) NULL
) 
go
Create table [HSCu]
(
	[MaHS] Char(5) NOT NULL,
	[MaPH] Char(5) NOT NULL,
	[MaLop] Char(5) NOT NULL,
	[TenHS] Nvarchar(30) NULL,
	[ngaysinh] Date NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ghichu] Nvarchar(50) NULL
) 
go
Create table [PHCu]
(
	[MaPH] Char(5) NOT NULL,
	[TenPH] Nvarchar(30) NULL,
	[NgaySinh] Datetime NULL,
	[gioitinh] Nvarchar(5) NULL,
	[dantoc] Nvarchar(15) NULL,
	[SoDTPH1] Char(10) NULL,
	[SoDTPH2] Char(10) NULL,
	[diachi] Nvarchar(70) NULL,
	[noicongtac] Nvarchar(30) NULL,
	[nghenghiep] Nvarchar(30) NULL,
	[email] Char(40) NULL
) 
go
Alter table [HS] add  foreign key([MaLop]) references [Lop] ([MaLop])  on update no action on delete no action 
go
Alter table [DonNhapHoc] add  foreign key([MaPH]) references [PH] ([MaPH])  on update no action on delete no action 
go
Alter table [BienLai] add  foreign key([MaPH]) references [PH] ([MaPH])  on update no action on delete no action 
go
Alter table [HS] add  foreign key([MaPH]) references [PH] ([MaPH])  on update no action on delete no action 
go
Alter table [Phieudiemdanh] add  foreign key([MaGV]) references [GiaoVien] ([MaGV])  on update no action on delete no action 
go
Alter table [PhieuBaoAn] add  foreign key([MaGV]) references [GiaoVien] ([MaGV])  on update no action on delete no action 
go
Alter table [CT_Kham] add  foreign key([MaCBYT]) references [CBYT] ([MaCBYT])  on update no action on delete no action 
go
Alter table [PhieuKhamSK] add  foreign key([MaHS]) references [HS] ([MaHS])  on update no action on delete no action 
go
Alter table [DonNhapHoc] add  foreign key([MaHS]) references [HS] ([MaHS])  on update no action on delete no action 
go
Alter table [Phieudiemdanh] add  foreign key([MaHS]) references [HS] ([MaHS])  on update no action on delete no action 
go
Alter table [CT_Kham] add  foreign key([MaPK]) references [PhieuKhamSK] ([MaPK])  on update no action on delete no action 
go
Alter table [BienLai] add  foreign key([MaNV]) references [NV] ([MaNV])  on update no action on delete no action 
go
Alter table [DonNhapHoc] add  foreign key([MaNV]) references [NV] ([MaNV])  on update no action on delete no action 
go
Alter table [PhieuBaoAn] add  foreign key([MaNV]) references [NV] ([MaNV])  on update no action on delete no action 
go


Set quoted_identifier on
go
Set quoted_identifier off
go
select * from BienLaiCu
Insert Into BienLaiCu select * from BienLai where MaNV = 'NV008'
Insert into PhieuBaoAnCu(MaPhieu,MaGV,MaNV,NgayBaoAn ,SoXuatAn ) select *  from  PhieuBaoAn where MaNV = 'NV008'
Delete from PhieuBaoAn where MaNV = 'NV008'
go
select * from BienLai where MONTH (ngaythu) = '11'

