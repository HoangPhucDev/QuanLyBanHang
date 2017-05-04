USE [master]
GO
/****** Object:  Database [QUANLYBANHANG]    Script Date: 01/11/2016 3:20:10 CH ******/
CREATE DATABASE [QUANLYBANHANG] ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'D:\database\QuanLyBanHang.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'D:\database\QuanLyBanHang_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYBANHANG] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYBANHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYBANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYBANHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYBANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYBANHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYBANHANG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYBANHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYBANHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYBANHANG] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYBANHANG', N'ON'
GO
USE [QUANLYBANHANG]
GO
/****** Object:  Table [dbo].[Dat_Hang]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dat_Hang](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[SoLuong] [float] NULL,
	[GiaBan] [float] NULL,
	[ThanhTien] [float] NULL,
	[NgayDat] [datetime] NULL,
	[ThanhToan] [bit] NULL,
	[MaLoaiTien] [varchar](10) NULL,
	[MaLoaiGiaoDich] [varchar](10) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_Dat_Hang_1] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[MaKH] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](20) NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Loai_Giao_Dich]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Loai_Giao_Dich](
	[MaLoaiGiaoDich] [varchar](10) NOT NULL,
	[TenLoaiGiaoDich] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Loai_Giao_Dich] PRIMARY KEY CLUSTERED 
(
	[MaLoaiGiaoDich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Loai_Tien]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Loai_Tien](
	[MaLoaiTien] [varchar](10) NOT NULL,
	[LoaiTien] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Loai_Tien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mat_Hang]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mat_Hang](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SoLuong] [float] NOT NULL,
	[DonGia] [float] NOT NULL,
	[GiaBan] [float] NULL,
	[MaNCC] [varchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[MaLoaiTien] [varchar](10) NULL,
	[MaLoaiGiaoDich] [varchar](10) NULL,
 CONSTRAINT [PK_Mat_Hang_1] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nha_Cung_Cap]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nha_Cung_Cap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](20) NULL,
	[Fax] [varchar](30) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_Nha_Cung_Cap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhan_Vien]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhan_Vien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](20) NULL,
	[MaQuayGiaoDich] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Nhan_Vien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhom_Nguoi_Dung]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhom_Nguoi_Dung](
	[MaNhomNguoiDung] [varchar](10) NOT NULL,
	[TenNhomNguoiDung] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Nhom_Nguoi_Dung] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phan_Nhom]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phan_Nhom](
	[MaNV] [varchar](10) NOT NULL,
	[MaNhomNguoiDung] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Phan_Nhom] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phan_Quyen]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phan_Quyen](
	[MaQuyen] [varchar](10) NOT NULL,
	[MaNhomNguoiDung] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Phan_Quyen_1] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quay_Giao_Dich]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quay_Giao_Dich](
	[MaQuayGiaoDich] [varchar](10) NOT NULL,
	[TenQuayGiaoDich] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Quay_Giao_Dich] PRIMARY KEY CLUSTERED 
(
	[MaQuayGiaoDich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [varchar](10) NOT NULL,
	[TenQuyen] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Xuat_Hang]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Xuat_Hang](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[SoLuong] [float] NULL,
	[GiaBan] [float] NULL,
	[ThanhTien] [float] NULL,
	[NgayXuat] [datetime] NULL,
	[MaLoaiTien] [varchar](10) NULL,
	[MaLoaiGiaoDich] [varchar](10) NULL,
 CONSTRAINT [PK_Xuat_Hang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[DoanhThu]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DoanhThu]
AS
SELECT     dbo.Mat_Hang.MaMH AS [Mã Mặt Hàng], dbo.Mat_Hang.TenMH AS [Tên Mặt Hàng], MONTH(dbo.Mat_Hang.NgayNhap) AS Tháng, YEAR(dbo.Mat_Hang.NgayNhap) 
                      AS Năm, SUM(dbo.Mat_Hang.SoLuong * dbo.Mat_Hang.DonGia) AS [Tổng Nhập], SUM(dbo.Xuat_Hang.SoLuong * dbo.Xuat_Hang.GiaBan) AS [Tổng Xuất]
FROM         dbo.Xuat_Hang INNER JOIN
                      dbo.Mat_Hang ON dbo.Mat_Hang.MaMH = dbo.Xuat_Hang.MaMH AND MONTH(dbo.Mat_Hang.NgayNhap) = MONTH(dbo.Xuat_Hang.NgayXuat) AND 
                      YEAR(dbo.Mat_Hang.NgayNhap) = YEAR(dbo.Xuat_Hang.NgayXuat)
GROUP BY dbo.Mat_Hang.NgayNhap, dbo.Mat_Hang.MaMH, dbo.Mat_Hang.TenMH

GO
/****** Object:  View [dbo].[NhapHang]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NhapHang]
AS
SELECT     dbo.Mat_Hang.MaMH, dbo.Mat_Hang.TenMH, dbo.Mat_Hang.SoLuong, dbo.Mat_Hang.DonGia, SUM(dbo.Mat_Hang.DonGia * dbo.Mat_Hang.SoLuong) AS [Tổng Nhập], 
                      dbo.Mat_Hang.GiaBan, dbo.Mat_Hang.NgayNhap, MONTH(dbo.Mat_Hang.NgayNhap) AS Tháng, YEAR(dbo.Mat_Hang.NgayNhap) AS Năm, 
                      dbo.Nha_Cung_Cap.TenNCC, dbo.Loai_Giao_Dich.TenLoaiGiaoDich, dbo.Loai_Tien.LoaiTien
FROM         dbo.Mat_Hang INNER JOIN
                      dbo.Nha_Cung_Cap ON dbo.Mat_Hang.MaNCC = dbo.Nha_Cung_Cap.MaNCC INNER JOIN
                      dbo.Loai_Giao_Dich ON dbo.Mat_Hang.MaLoaiGiaoDich = dbo.Loai_Giao_Dich.MaLoaiGiaoDich INNER JOIN
                      dbo.Loai_Tien ON dbo.Mat_Hang.MaLoaiTien = dbo.Loai_Tien.MaLoaiTien
GROUP BY dbo.Mat_Hang.MaMH, dbo.Mat_Hang.TenMH, dbo.Nha_Cung_Cap.TenNCC, dbo.Mat_Hang.SoLuong, dbo.Mat_Hang.GiaBan, dbo.Mat_Hang.NgayNhap, 
                      dbo.Mat_Hang.DonGia, dbo.Loai_Giao_Dich.TenLoaiGiaoDich, dbo.Loai_Tien.LoaiTien

GO
/****** Object:  View [dbo].[TonKho]    Script Date: 01/11/2016 3:20:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TonKho]
AS
SELECT     dbo.Mat_Hang.MaMH AS [Mã Mặt Hàng], dbo.Mat_Hang.TenMH AS [Tên Mặt Hàng], MONTH(dbo.Mat_Hang.NgayNhap) AS Tháng, YEAR(dbo.Mat_Hang.NgayNhap) 
                      AS Năm, dbo.Mat_Hang.SoLuong - SUM(dbo.Xuat_Hang.SoLuong) AS [Tồn Kho]
FROM         dbo.Mat_Hang INNER JOIN
                      dbo.Xuat_Hang ON dbo.Mat_Hang.MaMH = dbo.Xuat_Hang.MaMH AND MONTH(dbo.Mat_Hang.NgayNhap) = MONTH(dbo.Xuat_Hang.NgayXuat) AND 
                      YEAR(dbo.Mat_Hang.NgayNhap) = YEAR(dbo.Xuat_Hang.NgayXuat)
GROUP BY dbo.Mat_Hang.NgayNhap, dbo.Mat_Hang.MaMH, dbo.Mat_Hang.SoLuong, dbo.Xuat_Hang.SoLuong, dbo.Mat_Hang.TenMH

GO
INSERT [dbo].[Dat_Hang] ([MaPhieu], [MaMH], [MaKH], [SoLuong], [GiaBan], [ThanhTien], [NgayDat], [ThanhToan], [MaLoaiTien], [MaLoaiGiaoDich], [GhiChu]) VALUES (N'DH000001', N'MH000001', N'KH000001', 1, 21000000, 21000000, CAST(N'2011-11-03 00:00:00.000' AS DateTime), 1, N'0001', N'GD0001', N'')
INSERT [dbo].[Dat_Hang] ([MaPhieu], [MaMH], [MaKH], [SoLuong], [GiaBan], [ThanhTien], [NgayDat], [ThanhToan], [MaLoaiTien], [MaLoaiGiaoDich], [GhiChu]) VALUES (N'DH000002', N'MH000002', N'KH000002', 1, 13900000, 13900000, CAST(N'2011-12-08 00:00:00.000' AS DateTime), 1, N'0001', N'GD0001', N'')
INSERT [dbo].[Dat_Hang] ([MaPhieu], [MaMH], [MaKH], [SoLuong], [GiaBan], [ThanhTien], [NgayDat], [ThanhToan], [MaLoaiTien], [MaLoaiGiaoDich], [GhiChu]) VALUES (N'DH000003', N'MH000003', N'KH000003', 1, 1700000, 1700000, CAST(N'2011-12-08 00:00:00.000' AS DateTime), 1, N'0001', N'GD0002', N'')
INSERT [dbo].[Dat_Hang] ([MaPhieu], [MaMH], [MaKH], [SoLuong], [GiaBan], [ThanhTien], [NgayDat], [ThanhToan], [MaLoaiTien], [MaLoaiGiaoDich], [GhiChu]) VALUES (N'DH000004', N'MH000006', N'KH000004', 1, 18900000, 18900000, CAST(N'2011-12-14 00:00:00.000' AS DateTime), 0, N'0001', N'GD0002', N'')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000001', N'Nguyễn Ngọc Hân', N'3 Tháng 2 - Cần Thơ', N'01689920065')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000002', N'Nguyễn Tuấn Anh', N'Nguyễn Văn Cừ -  Cần Thơ', N'0986353234')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000003', N'Phạm Tiến Dũng', N'Nguyễn Văn Cừ -  Cần Thơ', N'0912583734')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000004', N'Nguyễn Mạnh Tuân', N'Cách Mạng Tháng 8 -  Cần Thơ', N'0978765785')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000005', N'Nguyễn Mạnh Hùng', N'Hùng Vương -  Cần Thơ', N'0978276789')
INSERT [dbo].[Khach_Hang] ([MaKH], [HoTen], [DiaChi], [DienThoai]) VALUES (N'KH000006', N'Nguyễn Thị Hiên', N'Mậu Thân -  Cần Thơ', N'0934789876')
INSERT [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich], [TenLoaiGiaoDich]) VALUES (N'GD0001', N'Tiền Mặt')
INSERT [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich], [TenLoaiGiaoDich]) VALUES (N'GD0002', N'Chuyển Khoản')
INSERT [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich], [TenLoaiGiaoDich]) VALUES (N'GD0003', N'Thẻ Thanh Toán')
INSERT [dbo].[Loai_Tien] ([MaLoaiTien], [LoaiTien]) VALUES (N'0001', N'VND')
INSERT [dbo].[Loai_Tien] ([MaLoaiTien], [LoaiTien]) VALUES (N'0002', N'EUR')
INSERT [dbo].[Loai_Tien] ([MaLoaiTien], [LoaiTien]) VALUES (N'0003', N'USD')
INSERT [dbo].[Loai_Tien] ([MaLoaiTien], [LoaiTien]) VALUES (N'0004', N'HKD')
INSERT [dbo].[Loai_Tien] ([MaLoaiTien], [LoaiTien]) VALUES (N'0005', N'GBP')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000001', N'MH000001', N'Laptop Vaio', 50, 20000000, 21000000, N'NCC000001', CAST(N'2011-11-01 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000002', N'MH000002', N'Điện thoại N9', 10, 12000000, 13900000, N'NCC000002', CAST(N'2011-11-07 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000003', N'MH000003', N'Đầu DVD', 50, 1500000, 1700000, N'NCC000001', CAST(N'2011-11-23 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000004', N'MH000004', N'SamSung Galaxy tab X2', 10, 13200000, 13900000, N'NCC000003', CAST(N'2011-12-03 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000005', N'MH000005', N'nokia X6', 15, 6000000, 6500000, N'NCC000002', CAST(N'2011-12-07 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000006', N'MH000006', N'IPhone 4 32 Gb', 2, 17900000, 18900000, N'NCC000004', CAST(N'2011-12-14 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Mat_Hang] ([MaPhieu], [MaMH], [TenMH], [SoLuong], [DonGia], [GiaBan], [MaNCC], [NgayNhap], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'NH000007', N'MH000007', N'IPhone 4 16gb', 2, 15000000, 16900000, N'NCC000004', CAST(N'2011-12-14 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DienThoai], [Fax], [Email], [DiaChi], [GhiChu]) VALUES (N'NCC000001', N'Sony', N'0463789876', N'0463789889', N'sonyvietnam@gmail.com', N'Thái Hà - Hà Nội', N'')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DienThoai], [Fax], [Email], [DiaChi], [GhiChu]) VALUES (N'NCC000002', N'Nokia', N'0887778888', N'0887778889', N'nokia@gmail,com', N'Bình Thạnh - Hồ Chí Minh', N'')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DienThoai], [Fax], [Email], [DiaChi], [GhiChu]) VALUES (N'NCC000003', N'Sam Sung', N'087766554', N'088878775', N'samsung@gmail.com', N'Thủ Đức - Hồ Chí Minh', N'')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DienThoai], [Fax], [Email], [DiaChi], [GhiChu]) VALUES (N'NCC000004', N'IPhone', N'0437766554', N'0433388776', N'applestone@yahoo.com', N'Ba Đình - Hà Nội', N'')
INSERT [dbo].[Nha_Cung_Cap] ([MaNCC], [TenNCC], [DienThoai], [Fax], [Email], [DiaChi], [GhiChu]) VALUES (N'NCC000005', N'TOSHIBA', N'0463789877', N'0463789876', N'toshiba@gmail.com', N'Hai Bà Trưng - Hà Nội', N'')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000001', N'Nguyễn Hoàng Phúc', CAST(N'1990-09-09 00:00:00.000' AS DateTime), N'Cần Thơ', N'0979389350', N'MT01')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000002', N'Ngô Xuân Hiệp', CAST(N'1989-07-08 00:00:00.000' AS DateTime), N'Cần Thơ', N'0973302655', N'DT01')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000003', N'Nguyễn Thị Ngọc', CAST(N'1990-03-06 00:00:00.000' AS DateTime), N'Cần Thơ', N'0988692854', N'QA01')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000004', N'Nguyễn Thanh Phụng', CAST(N'1990-12-20 00:00:00.000' AS DateTime), N'Cần Thơ', N'0988767656', N'KTS01')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000005', N'Nguyễn Thị Oanh', CAST(N'1990-10-05 00:00:00.000' AS DateTime), N'Cần Thơ', N'01663736342', N'DT02')
INSERT [dbo].[Nhan_Vien] ([MaNV], [HoTenNV], [NgaySinh], [DiaChi], [DienThoai], [MaQuayGiaoDich]) VALUES (N'NV000006', N'Phạm Trung Dũng', CAST(N'1987-12-04 00:00:00.000' AS DateTime), N'Cần Thơ', N'0912897287', N'HS01')
INSERT [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'PGHTC', N'Phòng Tài Chính')
INSERT [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'PHGCC', N'Phòng Điều Hành')
INSERT [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'PHGKH', N'Phòng Khách Hàng')
INSERT [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'PHGKT', N'Phòng Kế Toán')
INSERT [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (N'PHGTT', N'Phòng Thông Tin')
INSERT [dbo].[Phan_Nhom] ([MaNV], [MaNhomNguoiDung]) VALUES (N'NV000001', N'PHGCC')
INSERT [dbo].[Phan_Nhom] ([MaNV], [MaNhomNguoiDung]) VALUES (N'NV000002', N'PHGTT')
INSERT [dbo].[Phan_Nhom] ([MaNV], [MaNhomNguoiDung]) VALUES (N'NV000003', N'PHGKH')
INSERT [dbo].[Phan_Nhom] ([MaNV], [MaNhomNguoiDung]) VALUES (N'NV000004', N'PHGKH')
INSERT [dbo].[Phan_Quyen] ([MaQuyen], [MaNhomNguoiDung], [MaNV], [MatKhau], [TenDangNhap]) VALUES (N'MQ001', N'PHGCC', N'NV000001', N'admin', N'admin')
INSERT [dbo].[Phan_Quyen] ([MaQuyen], [MaNhomNguoiDung], [MaNV], [MatKhau], [TenDangNhap]) VALUES (N'MQ001', N'PHGKH', N'NV000004', N'phung', N'phung')
INSERT [dbo].[Phan_Quyen] ([MaQuyen], [MaNhomNguoiDung], [MaNV], [MatKhau], [TenDangNhap]) VALUES (N'MQ002', N'PHGTT', N'NV000002', N'hiep', N'hiep')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'DT01', N'Điện tử')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'DT02', N'Điện Thoại')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'GD01', N'Giầy Dép')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'HS01', N'Đồ Dùng Học Sinh')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'KTS01', N'Máy ảnh, máy quay kỹ thuật số')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'MP01', N'Mỹ Phẩm')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'MT01', N'Máy Tính')
INSERT [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich], [TenQuayGiaoDich]) VALUES (N'QA01', N'Quần Áo')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ001', N'Admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'MQ002', N'Users')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000001', N'MH000001', N'KH000001', N'NV000001', 1, 21000000, 21000000, CAST(N'2011-11-08 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000002', N'MH000002', N'KH000002', N'NV000005', 1, 13900000, 13900000, CAST(N'2011-11-08 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000003', N'MH000003', N'KH000003', N'NV000002', 1, 1700000, 1700000, CAST(N'2011-11-08 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000004', N'MH000004', N'KH000004', N'NV000005', 1, 13900000, 13900000, CAST(N'2011-12-16 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000005', N'MH000005', N'KH000005', N'NV000005', 2, 13000000, 13000000, CAST(N'2011-12-16 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000006', N'MH000006', N'KH000003', N'NV000001', 1, 18900000, 18900000, CAST(N'2011-12-16 00:00:00.000' AS DateTime), N'0001', N'GD0001')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000008', N'MH000006', N'KH000004', N'NV000003', 1, 18900000, 18900000, CAST(N'2011-12-14 00:00:00.000' AS DateTime), N'0001', N'GD0002')
INSERT [dbo].[Xuat_Hang] ([MaPhieu], [MaMH], [MaKH], [MaNV], [SoLuong], [GiaBan], [ThanhTien], [NgayXuat], [MaLoaiTien], [MaLoaiGiaoDich]) VALUES (N'XH000007', N'MH000007', N'KH000001', N'NV000005', 1, 16900000, 16900000, CAST(N'2011-12-16 00:00:00.000' AS DateTime), N'0001', N'GD0003')
ALTER TABLE [dbo].[Dat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Dat_Hang_Khach_Hang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khach_Hang] ([MaKH])
GO
ALTER TABLE [dbo].[Dat_Hang] CHECK CONSTRAINT [FK_Dat_Hang_Khach_Hang]
GO
ALTER TABLE [dbo].[Dat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Dat_Hang_Loai_Giao_Dich] FOREIGN KEY([MaLoaiGiaoDich])
REFERENCES [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich])
GO
ALTER TABLE [dbo].[Dat_Hang] CHECK CONSTRAINT [FK_Dat_Hang_Loai_Giao_Dich]
GO
ALTER TABLE [dbo].[Dat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Dat_Hang_Loai_Tien] FOREIGN KEY([MaLoaiTien])
REFERENCES [dbo].[Loai_Tien] ([MaLoaiTien])
GO
ALTER TABLE [dbo].[Dat_Hang] CHECK CONSTRAINT [FK_Dat_Hang_Loai_Tien]
GO
ALTER TABLE [dbo].[Dat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Dat_Hang_Mat_Hang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Mat_Hang] ([MaMH])
GO
ALTER TABLE [dbo].[Dat_Hang] CHECK CONSTRAINT [FK_Dat_Hang_Mat_Hang]
GO
ALTER TABLE [dbo].[Mat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Mat_Hang_Loai_Giao_Dich] FOREIGN KEY([MaLoaiGiaoDich])
REFERENCES [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich])
GO
ALTER TABLE [dbo].[Mat_Hang] CHECK CONSTRAINT [FK_Mat_Hang_Loai_Giao_Dich]
GO
ALTER TABLE [dbo].[Mat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Mat_Hang_Loai_Tien] FOREIGN KEY([MaLoaiTien])
REFERENCES [dbo].[Loai_Tien] ([MaLoaiTien])
GO
ALTER TABLE [dbo].[Mat_Hang] CHECK CONSTRAINT [FK_Mat_Hang_Loai_Tien]
GO
ALTER TABLE [dbo].[Mat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Mat_Hang_Nha_Cung_Cap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[Nha_Cung_Cap] ([MaNCC])
GO
ALTER TABLE [dbo].[Mat_Hang] CHECK CONSTRAINT [FK_Mat_Hang_Nha_Cung_Cap]
GO
ALTER TABLE [dbo].[Nhan_Vien]  WITH CHECK ADD  CONSTRAINT [FK_Nhan_Vien_Quay_Giao_Dich] FOREIGN KEY([MaQuayGiaoDich])
REFERENCES [dbo].[Quay_Giao_Dich] ([MaQuayGiaoDich])
GO
ALTER TABLE [dbo].[Nhan_Vien] CHECK CONSTRAINT [FK_Nhan_Vien_Quay_Giao_Dich]
GO
ALTER TABLE [dbo].[Phan_Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Phan_Nhom_Nhan_Vien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhan_Vien] ([MaNV])
GO
ALTER TABLE [dbo].[Phan_Nhom] CHECK CONSTRAINT [FK_Phan_Nhom_Nhan_Vien]
GO
ALTER TABLE [dbo].[Phan_Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Phan_Nhom_Nhom_Nguoi_Dung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[Phan_Nhom] CHECK CONSTRAINT [FK_Phan_Nhom_Nhom_Nguoi_Dung]
GO
ALTER TABLE [dbo].[Phan_Quyen]  WITH CHECK ADD  CONSTRAINT [FK_Phan_Quyen_Nhan_Vien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhan_Vien] ([MaNV])
GO
ALTER TABLE [dbo].[Phan_Quyen] CHECK CONSTRAINT [FK_Phan_Quyen_Nhan_Vien]
GO
ALTER TABLE [dbo].[Phan_Quyen]  WITH CHECK ADD  CONSTRAINT [FK_Phan_Quyen_Nhom_Nguoi_Dung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[Nhom_Nguoi_Dung] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[Phan_Quyen] CHECK CONSTRAINT [FK_Phan_Quyen_Nhom_Nguoi_Dung]
GO
ALTER TABLE [dbo].[Phan_Quyen]  WITH CHECK ADD  CONSTRAINT [FK_Phan_Quyen_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[Phan_Quyen] CHECK CONSTRAINT [FK_Phan_Quyen_Quyen]
GO
ALTER TABLE [dbo].[Xuat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Xuat_Hang_Khach_Hang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khach_Hang] ([MaKH])
GO
ALTER TABLE [dbo].[Xuat_Hang] CHECK CONSTRAINT [FK_Xuat_Hang_Khach_Hang]
GO
ALTER TABLE [dbo].[Xuat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Xuat_Hang_Loai_Giao_Dich] FOREIGN KEY([MaLoaiGiaoDich])
REFERENCES [dbo].[Loai_Giao_Dich] ([MaLoaiGiaoDich])
GO
ALTER TABLE [dbo].[Xuat_Hang] CHECK CONSTRAINT [FK_Xuat_Hang_Loai_Giao_Dich]
GO
ALTER TABLE [dbo].[Xuat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Xuat_Hang_Loai_Tien] FOREIGN KEY([MaLoaiTien])
REFERENCES [dbo].[Loai_Tien] ([MaLoaiTien])
GO
ALTER TABLE [dbo].[Xuat_Hang] CHECK CONSTRAINT [FK_Xuat_Hang_Loai_Tien]
GO
ALTER TABLE [dbo].[Xuat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Xuat_Hang_Mat_Hang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Mat_Hang] ([MaMH])
GO
ALTER TABLE [dbo].[Xuat_Hang] CHECK CONSTRAINT [FK_Xuat_Hang_Mat_Hang]
GO
ALTER TABLE [dbo].[Xuat_Hang]  WITH CHECK ADD  CONSTRAINT [FK_Xuat_Hang_Nhan_Vien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhan_Vien] ([MaNV])
GO
ALTER TABLE [dbo].[Xuat_Hang] CHECK CONSTRAINT [FK_Xuat_Hang_Nhan_Vien]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Xuat_Hang"
            Begin Extent = 
               Top = 6
               Left = 239
               Bottom = 125
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Mat_Hang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Mat_Hang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Xuat_Hang"
            Begin Extent = 
               Top = 6
               Left = 239
               Bottom = 125
               Right = 402
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TonKho'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TonKho'
GO
USE [master]
GO
ALTER DATABASE [QUANLYBANHANG] SET  READ_WRITE 
GO
