USE [master]
GO
/****** Object:  Database [QLNhaHang]    Script Date: 30/10/2021 9:50:54 AM ******/
CREATE DATABASE [QLNhaHang]
 
GO
USE [QLNhaHang]
GO
/*ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO*/
USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[MaMon] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
 CONSTRAINT [PK_CTHD_1] PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaKhachHang] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NamSinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMon]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMon](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMon] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[MaLoai] [int] NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NamSinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[TenDangNhap] [varchar](30) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 30/10/2021 9:50:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](30) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[TenHienThi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CTHD] ON 
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 1, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (2, 1, 3, 2, 90000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (3, 5, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (4, 6, 3, 2, 90000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (5, 7, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (6, 8, 3, 12, 540000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (7, 8, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (8, 9, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (9, 13, 4, 2, 80000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (10, 14, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (11, 14, 2, 1, 12000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (12, 15, 5, 2, 40000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (13, 15, 2, 2, 24000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (14, 16, 3, 1, 45000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (15, 16, 6, 1, 15000)
GO
INSERT [dbo].[CTHD] ([MaCTHD], [MaHoaDon], [MaMon], [SoLuong], [ThanhTien]) VALUES (16, 18, 3, 2, 90000)
GO
SET IDENTITY_INSERT [dbo].[CTHD] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (1, CAST(N'2021-10-29T15:54:30.280' AS DateTime), 8, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (5, CAST(N'2021-10-29T16:53:37.980' AS DateTime), 8, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (6, CAST(N'2021-10-29T16:53:37.980' AS DateTime), 8, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (7, CAST(N'2021-10-29T17:36:34.877' AS DateTime), 8, 2)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (8, CAST(N'2021-10-29T17:41:18.850' AS DateTime), 8, 3)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (9, CAST(N'2021-10-29T17:46:47.043' AS DateTime), 8, 2)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (13, CAST(N'2021-10-29T18:16:54.133' AS DateTime), 8, 1)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (14, CAST(N'2021-10-29T20:43:42.030' AS DateTime), 8, 3)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (15, CAST(N'2021-10-29T20:47:50.603' AS DateTime), 8, 2)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (16, CAST(N'2021-10-30T00:10:35.970' AS DateTime), 8, 4)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [MaNhanVien], [MaKhachHang]) VALUES (18, CAST(N'2021-10-30T09:46:16.070' AS DateTime), 8, 1)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [NamSinh], [DiaChi], [Email]) VALUES (1, N'Nguyễn Hồ An', N'Nam', CAST(N'1999-12-20T00:00:00.000' AS DateTime), N'Bình Dương', N'an@gmail.com')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [NamSinh], [DiaChi], [Email]) VALUES (2, N'Hà Thu Thủy', N'Nữ', CAST(N'1998-02-15T00:00:00.000' AS DateTime), N'Bình Định', N'thuy@gmail.com')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [NamSinh], [DiaChi], [Email]) VALUES (3, N'Khánh', N'Nam', CAST(N'2000-10-26T23:05:59.000' AS DateTime), N'bd', N't')
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [NamSinh], [DiaChi], [Email]) VALUES (4, N'Huy', N'Nam', CAST(N'1999-10-30T00:10:07.000' AS DateTime), N'Bình Định', N'huy@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiMon] ON 
GO
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (1, N'Thức ăn')
GO
INSERT [dbo].[LoaiMon] ([MaLoai], [TenLoai]) VALUES (2, N'Đồ uống')
GO
SET IDENTITY_INSERT [dbo].[LoaiMon] OFF
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON 
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (1, N'Bò Húc', 2, 10000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (2, N'String Reddragon', 2, 12000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (3, N'Bún Bò', 1, 45000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (4, N'Cá', 1, 40000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (5, N'Piza', 1, 20000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (6, N'Nuoc Chanh', 2, 15000)
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [MaLoai], [Gia]) VALUES (26, N'Pho', 1, 30000)
GO
SET IDENTITY_INSERT [dbo].[MonAn] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [GioiTinh], [NamSinh], [DiaChi], [Email], [TenDangNhap]) VALUES (8, N'tuyên', N'Nam', CAST(N'2021-10-27T13:24:21.013' AS DateTime), N'cát hưng', N'tuyen', N'tuyen')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenHienThi]) VALUES (N'admin', N'123', N'Ko phai admin')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenHienThi]) VALUES (N'binhan', N'123', N'An')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenHienThi]) VALUES (N'hanhphuc', N'123', N'hanhphuc')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenHienThi]) VALUES (N'hao', N'123', N'hao')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [TenHienThi]) VALUES (N'tuyen', N'123', N'Tuyên')
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_MonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_MonAn]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_LoaiMon] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMon] ([MaLoai])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_LoaiMon]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
USE [master]
GO
ALTER DATABASE [QLNhaHang] SET  READ_WRITE 
GO
