/*
Created		7/10/2021
Modified		10/5/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
Create database ThongTinMN
go 
use ThongTinMN
go


Create table [Lop]
(
	[MaLop] Nvarchar(10) NOT NULL,
	[TenLop] Nvarchar(30) NULL,
	[Siso] Integer NULL,
Primary Key ([MaLop])
) 
go

Create table [PH]
(
	[MaPH] Nvarchar(10) NOT NULL,
	[TenPH] Nvarchar(40) NULL,
	[NgaySinh] Datetime NULL,
	[tuoi] Integer NULL,
	[gioitinh] Nvarchar(5) NULL,
	[dantoc] Nvarchar(15) NULL,
	[tongiao] Nvarchar(15) NULL,
	[SoDTPH] Nvarchar(15) NULL,
	[diachi] Nvarchar(50) NULL,
	[noicongtac] Nvarchar(30) NULL,
	[nghenghiep] Nvarchar(30) NULL,
	[email] Nvarchar(30) NULL,
Primary Key ([MaPH])
) 
go

Create table [GiaoVien]
(
	[MaGV] Nvarchar(10) NOT NULL,
	[TenGV] Nvarchar(40) NULL,
	[gioitinh] Nvarchar(5) NULL,
	[ngaysinh] Datetime NULL,
	[soDTGV] Nvarchar(15) NULL,
	[TrinhDo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(30) NULL,
	[noidaotao] Nvarchar(50) NULL,
	[diachi] Nvarchar(50) NULL,
	[email] Nvarchar(30) NULL,
Primary Key ([MaGV])
) 
go

Create table [CBYT]
(
	[MaCBYT] Nvarchar(10) NOT NULL,
	[tenCBYT] Nvarchar(40) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(20) NULL,
	[diachi] Nvarchar(50) NULL,
	[soDTCB] Nvarchar(15) NULL,
	[email] Nvarchar(30) NULL,
Primary Key ([MaCBYT])
) 
go

Create table [HS]
(
	[MaHS] Nvarchar(10) NOT NULL,
	[TenHS] Nvarchar(40) NULL,
	[Tuoi] Integer NULL,
	[ngaysinh] Datetime NULL,
	[gioitinh] Nvarchar(5) NULL,
	[dantoc] Nvarchar(15) NULL,
	[diachi] Nvarchar(30) NULL,
	[ghichusuckhoe] Nvarchar(50) NULL,
Primary Key ([MaHS])
) 
go

Create table [DonNhapHoc]
(
	[MaDon] Nvarchar(10) NOT NULL,
	[MaCBVP] Nvarchar(10) NOT NULL,
	[MaPH] Nvarchar(10) NOT NULL,
	[NgayDangKy] Datetime NULL,
	[Loptuoi] Nvarchar(10) NULL,
Primary Key ([MaDon])
) 
go

Create table [PhieuXeplop]
(
	[MaPXL] Nvarchar(10) NOT NULL,
	[MaLop] Nvarchar(10) NOT NULL,
	[MaHS] Nvarchar(10) NOT NULL,
	[MaCBVP] Nvarchar(10) NOT NULL,
	[Namhoc] Datetime NULL,
Primary Key ([MaPXL])
) 
go

Create table [Phieudiemdanh]
(
	[MaPDD] Nvarchar(10) NOT NULL,
	[MaLop] Nvarchar(10) NOT NULL,
	[MaHS] Nvarchar(10) NOT NULL,
	[MaGV] Nvarchar(10) NOT NULL,
	[Ngaydiemdanh] Datetime NULL,
	[Tinhtrangvang] Nvarchar(10) NULL,
	[Lydovang] Nvarchar(10) NULL,
Primary Key ([MaPDD])
) 
go

Create table [BienLai]
(
	[MaBL] Nvarchar(10) NOT NULL,
	[MaCBVP] Nvarchar(10) NOT NULL,
	[MaPH] Nvarchar(10) NOT NULL,
	[ngaythu] Datetime NULL,
	[Tienhocphi] Money NULL,
	[Tienan] Money NULL,
	[Tienphuthu] Money NULL,
	[tongtienhocphi] Money NULL,
Primary Key ([MaBL])
) 
go

Create table [PhieuKhamSK]
(
	[MaPK] Nvarchar(10) NOT NULL,
	[MaLop] Nvarchar(10) NOT NULL,
	[MaHS] Nvarchar(10) NOT NULL,
	[ngaykham] Datetime NULL,
	[namhoc] Nvarchar(10) NULL,
	[Chieucao] Nvarchar(10) NULL,
	[Cannang] Nvarchar(10) NULL,
	[Taimuihong] Nvarchar(100) NULL,
	[Mat] Nvarchar(100) NULL,
	[Xuong] Nvarchar(100) NULL,
	[Rang] Nvarchar(100) NULL,
Primary Key ([MaPK])
) 
go

Create table [CBVanPhong]
(
	[MaCBVP] Nvarchar(10) NOT NULL,
	[TenCBVP] Nvarchar(40) NULL,
	[chucvu] Nvarchar(20) NULL,
	[trinhdo] Nvarchar(20) NULL,
	[chuyenmon] Nvarchar(20) NULL,
	[diachi] Nvarchar(50) NULL,
	[email] Nvarchar(30) NULL,
	[sodt] Nvarchar(15) NULL,
Primary Key ([MaCBVP])
) 
go

Create table [CT_Lop]
(
	[MaLop] Nvarchar(10) NOT NULL,
	[MaHS] Nvarchar(10) NOT NULL,
Primary Key ([MaLop],[MaHS])
) 
go

Create table [CT_Kham]
(
	[MaCBYT] Nvarchar(10) NOT NULL,
	[MaPK] Nvarchar(10) NOT NULL,
Primary Key ([MaCBYT],[MaPK])
) 
go

Create table [PhieuBaoAn]
(
	[MaPhieu] Nvarchar(10) NOT NULL,
	[MaGV] Nvarchar(10) NOT NULL,
	[MaCBVP] Nvarchar(10) NOT NULL,
	[MaCBCD] Nvarchar(10) NOT NULL,
	[SoXuatAn] Integer NULL,
	[NgayBaoAn] Datetime NULL,
Primary Key ([MaPhieu])
) 
go

Create table [CBCD]
(
	[MaCBCD] Nvarchar(10) NOT NULL,
	[TenCBCD] Nvarchar(40) NULL,
	[ChucVu] Nvarchar(20) NULL,
	[TrinhDo] Nvarchar(20) NULL,
	[ChuyenMon] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(50) NULL,
	[Email] Nvarchar(3
	0) NULL,
	[SoDT] Nvarchar(15) NULL,
Primary Key ([MaCBCD])
) 
go


Alter table [CT_Lop] add  foreign key([MaLop]) references [Lop] ([MaLop])  on update no action on delete no action 
go
Alter table [DonNhapHoc] add  foreign key([MaPH]) references [PH] ([MaPH])  on update no action on delete no action 
go
Alter table [BienLai] add  foreign key([MaPH]) references [PH] ([MaPH])  on update no action on delete no action 
go
Alter table [Phieudiemdanh] add  foreign key([MaGV]) references [GiaoVien] ([MaGV])  on update no action on delete no action 
go
Alter table [PhieuBaoAn] add  foreign key([MaGV]) references [GiaoVien] ([MaGV])  on update no action on delete no action 
go
Alter table [CT_Kham] add  foreign key([MaCBYT]) references [CBYT] ([MaCBYT])  on update no action on delete no action 
go
Alter table [CT_Lop] add  foreign key([MaHS]) references [HS] ([MaHS])  on update no action on delete no action 
go
Alter table [CT_Kham] add  foreign key([MaPK]) references [PhieuKhamSK] ([MaPK])  on update no action on delete no action 
go
Alter table [PhieuXeplop] add  foreign key([MaCBVP]) references [CBVanPhong] ([MaCBVP])  on update no action on delete no action 
go
Alter table [BienLai] add  foreign key([MaCBVP]) references [CBVanPhong] ([MaCBVP])  on update no action on delete no action 
go
Alter table [DonNhapHoc] add  foreign key([MaCBVP]) references [CBVanPhong] ([MaCBVP])  on update no action on delete no action 
go
Alter table [PhieuBaoAn] add  foreign key([MaCBVP]) references [CBVanPhong] ([MaCBVP])  on update no action on delete no action 
go
Alter table [Phieudiemdanh] add  foreign key([MaLop],[MaHS]) references [CT_Lop] ([MaLop],[MaHS])  on update no action on delete no action 
go
Alter table [PhieuKhamSK] add  foreign key([MaLop],[MaHS]) references [CT_Lop] ([MaLop],[MaHS])  on update no action on delete no action 
go
Alter table [PhieuXeplop] add  foreign key([MaLop],[MaHS]) references [CT_Lop] ([MaLop],[MaHS])  on update no action on delete no action 
go
Alter table [PhieuBaoAn] add  foreign key([MaCBCD]) references [CBCD] ([MaCBCD])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


