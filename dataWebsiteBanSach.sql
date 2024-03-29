USE [master]
GO
/****** Object:  Database [dataMeBook]    Script Date: 11/6/2018 3:29:34 PM ******/
CREATE DATABASE [dataMeBook]
GO
ALTER DATABASE [dataMeBook] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dataMeBook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dataMeBook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dataMeBook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dataMeBook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dataMeBook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dataMeBook] SET ARITHABORT OFF 
GO
ALTER DATABASE [dataMeBook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dataMeBook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dataMeBook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dataMeBook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dataMeBook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dataMeBook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dataMeBook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dataMeBook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dataMeBook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dataMeBook] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dataMeBook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dataMeBook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dataMeBook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dataMeBook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dataMeBook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dataMeBook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dataMeBook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dataMeBook] SET RECOVERY FULL 
GO
ALTER DATABASE [dataMeBook] SET  MULTI_USER 
GO
ALTER DATABASE [dataMeBook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dataMeBook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dataMeBook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dataMeBook] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dataMeBook] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dataMeBook', N'ON'
GO
ALTER DATABASE [dataMeBook] SET QUERY_STORE = OFF
GO
USE [dataMeBook]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [dataMeBook]
GO
/****** Object:  Table [dbo].[ChuDe]    Script Date: 11/6/2018 3:29:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDe](
	[Ma_CD] [int] IDENTITY(1,1) NOT NULL,
	[TenCD] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_CD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDATHANG]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDATHANG](
	[SoHD] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](9, 2) NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK__CTDATHAN__254FD4EDD89CABFD] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATHANG]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATHANG](
	[SoHD] [int] IDENTITY(1,1) NOT NULL,
	[Ma_KhachHang] [int] NULL,
	[NgayDatHang] [date] NULL,
	[TriGia] [float] NULL,
	[NgayGiaoHang] [date] NULL,
	[DaGiao] [bit] NULL,
	[TenNguoiNhan] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](12) NULL,
	[DiaChiNhan] [nvarchar](100) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[HinhThucGiaoHang] [nvarchar](50) NULL,
 CONSTRAINT [PK__DATHANG__BC3CAB572F5742C0] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[Ma_Khach_Hang] [int] IDENTITY(1,1) NOT NULL,
	[HoKH] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[TenDangNhap] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[Gioi_tinh] [nvarchar](5) NULL,
	[Email] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DaDuyet] [bit] NULL,
 CONSTRAINT [PK__Khach_Ha__37BB3C424B1F7C2D] PRIMARY KEY CLUSTERED 
(
	[Ma_Khach_Hang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NSX]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NSX](
	[Ma_NSX] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NSX] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_NSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[Ma_NXB] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [PK__NXB__C235FDA8FEEE2A54] PRIMARY KEY CLUSTERED 
(
	[Ma_NXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuangCao]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuangCao](
	[MaQC] [int] IDENTITY(1,1) NOT NULL,
	[TieuDeQC] [nvarchar](500) NULL,
	[HinhQC] [nvarchar](500) NULL,
	[NgayThem] [date] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MaQC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTriVien]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriVien](
	[Ma_QTV] [int] IDENTITY(1,1) NOT NULL,
	[HoQTV] [nvarchar](10) NULL,
	[TenQTV] [nvarchar](10) NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TenDagNhapQTV] [nvarchar](10) NULL,
	[MatKhauQTV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Email] [nvarchar](200) NULL,
	[Avatar] [int] NULL,
	[QuyenQTV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_QTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 11/6/2018 3:29:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Ma_Sach] [int] IDENTITY(1,1) NOT NULL,
	[Ten_Sach] [nvarchar](60) NULL,
	[Tac_Gia] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[GiaCuaHang] [float] NULL,
	[Don_Vi_Tinh] [nvarchar](10) NULL,
	[Ma_NXB] [int] NULL,
	[NgayCapNhat] [date] NULL,
	[Ma_CD] [int] NULL,
	[Mota] [ntext] NULL,
	[SoLuongTon] [int] NULL,
	[SoLuongBan] [int] NULL,
	[SoLanXem] [int] NULL,
	[HinhAnh] [nvarchar](200) NULL,
	[Loai] [nvarchar](100) NULL,
	[LoaiBia] [nvarchar](20) NULL,
	[SoTrang] [int] NULL,
	[NhaPhanPhoi] [nvarchar](100) NULL,
	[Tieude] [nvarchar](500) NULL,
 CONSTRAINT [PK__Sach__31B8FDA07D2F1040] PRIMARY KEY CLUSTERED 
(
	[Ma_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VanPhongPham]    Script Date: 11/6/2018 3:29:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanPhongPham](
	[Ma_VPP] [int] IDENTITY(1,1) NOT NULL,
	[Ten_VPP] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[Don_Vi_Tinh] [nvarchar](10) NULL,
	[Ma_NSX] [int] NULL,
	[NgayCapNhat] [date] NULL,
	[Mota] [nvarchar](4000) NULL,
	[SoLuongBan] [int] NULL,
	[SoLanXem] [int] NULL,
	[Anh] [nvarchar](100) NULL,
	[PhanLoai] [nvarchar](100) NULL,
	[Tieude] [nvarchar](500) NULL,
 CONSTRAINT [PK__VanPhong__C025C5B840E5C78B] PRIMARY KEY CLUSTERED 
(
	[Ma_VPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChuDe] ON 

INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (1, N'Chính Trị-Pháp Luật')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (2, N'Khoa Học Công Nghệ -Kinh Tế')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (3, N'Văn Học Nghệ Thuật')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (4, N'Giáo Trình')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (5, N'Truyện Tiểu Thuyết')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (6, N'Tâm Lý, Tâm Linh, Tôn Giáo')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (7, N'Sách Thiếu Nhi')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (8, N'Truyện Tranh, Maga,Comic')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (9, N'Kỹ Năng Sống')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (10, N'Từ Điển')
INSERT [dbo].[ChuDe] ([Ma_CD], [TenCD]) VALUES (11, N'Giáo Khoa')
SET IDENTITY_INSERT [dbo].[ChuDe] OFF
SET IDENTITY_INSERT [dbo].[Khach_Hang] ON 

INSERT [dbo].[Khach_Hang] ([Ma_Khach_Hang], [HoKH], [TenKH], [TenDangNhap], [MatKhau], [NgaySinh], [Gioi_tinh], [Email], [DienThoai], [DiaChi], [DaDuyet]) VALUES (1007, N'Nguyễn', N'Văn Hiệp', N'NguyenHiep', N'202cb962ac59075b964b07152d234b70', CAST(N'2018-11-03' AS Date), N'1', N'vanhiep1998@gmail.com', N'1242288200', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Khach_Hang] OFF
SET IDENTITY_INSERT [dbo].[NSX] ON 

INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (1, N'Stabilo', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (2, N'Milan', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (3, N'MarVy Uchida', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (4, N'Alpha', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (5, N'Thiên Long', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (6, N'Bantex', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (7, N'Artline', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (8, N'Apli', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (9, N'Flexoffice', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (10, N'Espp', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (11, N'Double A', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (12, N'Hải Tiến', NULL, NULL)
INSERT [dbo].[NSX] ([Ma_NSX], [Ten_NSX], [DiaChi], [DienThoai]) VALUES (13, N'Hòa Bình', NULL, NULL)
SET IDENTITY_INSERT [dbo].[NSX] OFF
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (1, N'Nhà Xuất Bản Trẻ', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (2, N'AZ Việt Nam', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (3, N'Kim Đồng', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (4, N'AlphaBook', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (5, N'Minh Long', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (6, N'Đinh Tị', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (7, N'Nhã Nam', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (8, N'IPM', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (9, N'Trí Việt-Fist News', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (10, N'Thái Hà Book', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (11, N'Bách Việt', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (12, N'Hoa Học Trò', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (13, N'Hachette Publishing 
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (14, N'Usborne 
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (15, N'HarperCollins 
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (16, N'Parragon
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (17, N' Kinokuniya
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (18, N'Oxford University Press 
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (19, N'Cambridge University Press 
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (20, N'Macmilan Education
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (21, N' Cengage Learning
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (22, N' Pearson Longman
', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (23, N' Penguin Books', N'Nước Ngoài')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (24, N'Nhà Xuất Bản Văn Học', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (25, N'Nhà Xuất Bản Phụ Nữ', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (26, N'	Nhà Xuất Bản Dân Trí, Alphabooks', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (27, N'NXB Văn Hóa - Văn Nghệ', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (28, N'NXB Thế Giới', N'Việt Nam')
INSERT [dbo].[NXB] ([Ma_NXB], [TenNXB], [DiaChi]) VALUES (29, N'NXB Tổng Hợp TPHCM', NULL)
SET IDENTITY_INSERT [dbo].[NXB] OFF
SET IDENTITY_INSERT [dbo].[QuangCao] ON 

INSERT [dbo].[QuangCao] ([MaQC], [TieuDeQC], [HinhQC], [NgayThem]) VALUES (1, N'Back to school giảm 50% tất cả sách giáo khoa', N'banner_web_business_1170x260.jpg', CAST(N'0001-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[QuangCao] OFF
SET IDENTITY_INSERT [dbo].[QuanTriVien] ON 

INSERT [dbo].[QuanTriVien] ([Ma_QTV], [HoQTV], [TenQTV], [GioiTinh], [DiaChi], [TenDagNhapQTV], [MatKhauQTV], [NgaySinh], [Email], [Avatar], [QuyenQTV]) VALUES (1, N'Nguyễn', N'Văn Hiệp', 1, N'Bình Dương', N'Admin', N'202cb962ac59075b964b07152d234b70', NULL, N'Vanhiep1998@gmail.com', NULL, 1)
SET IDENTITY_INSERT [dbo].[QuanTriVien] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1062, N'Nhà', N'Nguyễn Bảo Trung', 85000, 52000, N'VNĐ', 27, CAST(N'2018-10-27' AS Date), 1, N'', 215, NULL, 0, N'nha_-_doc_thu-page-001.jpg', N'Việt Nam', N'Bìa Mềm', 215, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1063, N'Anh Không Muốn Để Em Một Mình', N'Diệp Lạc Vô Tâm- Hà Giang', 89000, 67850, N'VNĐ', 1, CAST(N'2018-11-06' AS Date), 1, N'Cuộc đời con người ngắn ngủi, chúng ta luôn cố gắng tiến về phía trước, hy vọng phía cuối con đường nhìn thấy phong cảnh đẹp. Nhưng khi chúng ta thực sự đến điểm cuối đó, chờ đợi chúng ta lại là phong cảnh nào? Tôi không thể nghĩ ra nên nói chuyện với một vài người... là những người bước lên “chuyến tàu cuối” của cuộc đời. Đối với họ, hành trình sinh mệnh chỉ còn lại trạm cuối cùng, họ muốn dừng chân, ngắm thật nhiều phong cảnh hai bên đường, cho dù chỉ là một bông hoa nở, một chiếc lá rơi…  Thì ra, câu chuyện của cuộc đời không giống như tiểu thuyết, câu chuyện của cuộc đời luôn không biết lúc nào thì đột nhiên dừng lại, chỉ còn lại là bông pháo hoa rực rỡ và ngắn ngủi trong ký ức mỗi người.  Tôi viết cuốn sách này là muốn ghi lại những bông pháo hoa xán lạn, rực rỡ nhất ấy.   Diệp Lạc Vô Tâm', 1998, 1, NULL, N'3d_anh_khong_muon_de_em_mot_minh_master.jpg', N'Việt Nam', N'Bìa Cứng', NULL, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1064, N'Tư Duy Nhanh Và Chậm', N'Daniel Kahneman', 239000, 143400, N'VNĐ', 9, CAST(N'2018-10-27' AS Date), 9, NULL, NULL, NULL, NULL, N'8935251405972.jpg', N'Việt Nam', NULL, NULL, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1065, N'Lớp Học Mật Ngữ-Tập 1', N'Nhóm BRO', 20000, 16000, N'VNĐ', 1, CAST(N'2018-10-27' AS Date), 8, N'Lớp Học Mật Ngữ - Tập 1  Những bí mật thưở còn thò lò mũi xanh của 12 cung Hoàng đạo.  Một bộ truyện đặc biệt về cung Hoàng đạo  Từng gây “sốt” với các “đặc sản” truyện tranh đình đám, nhóm tác giả truyện tranh dành cho thanh thiếu niên B.R.O nay đã chính thức “ghé thăm” tổng hành dinh Hoa Học Trò - Thiên Thần nhỏ và mang đến cho tween một siêu phẩm hoàn toàn mới: Lớp học mật ngữ. Bạn là một Bạch Dương trẻ con nhưng nhiệt tình với bạn bè, hay là một Kim Ngưu có “tình yêu bất diệt” với… đồ ăn? Hay thậm chí là một cô nàng Thiên Yết lạnh lùng, khó hiểu nhưng nội tâm cực kì? Hãy khám phá tính cách của chính mình thông qua những nhân vật trong truyện, những tình huống nhắng nhít thôi rồi trong lớp học, đảm bảo bất kì teen nào cũng đã từng trải qua.  Đọc truyện tranh có quà!  Bên cạnh nội dung siêu dễ thương, bạn còn được tặng kèm “giáo trình dạy vẽ” 12 cung Hoàng đạo với những hướng dẫn đơn giản mà cực “chất”, bảo đảm ai cũng có thể trở thành họa sĩ chỉ trong nháy mắt. Khoái hơn nữa là phụ kiện gồm đề can 12 cung Hoàng đạo xinh khỏi nói.', 2000, NULL, 0, N'lop-hoc-mat-ngu.jpg', N'Việt Nam', N'Bìa Mềm', 100, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1066, N'Us Against You', N'Fredrik Backman', 298000, 268200, N'VNĐ', 1, CAST(N'2018-10-27' AS Date), 3, N'Us Against You tells the story of the months after the terrible events that shook Beartown last spring. Best friends Maya and Ana spend the summer on a hidden island, trying to leave the world behind, but nothing goes as they hope. Beartown and neighbouring Hed''s rivalry grows into a furious struggle for money, power, and survival that explodes as their hockey teams meet. When a player''s most closely guarded secret is revealed, a whole community is forced to show what it really wants to stand for. They will say that violence came to Beartown that year, but it will be a lie. The violence was already there. Fredrik Backman''s Us Against You, the stand alone sequel to Beartown, is a powerful depiction of the poignant and striking relationships of a small town. It''s a story about loyalty, friendship, and a love that challenges everything.', 2000, NULL, 0, N'image_180164_1_43_1_57_1_4_1_2_1_136.jpg', N'Nước Ngoài', N'Bìa Mềm', 336, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1067, N'At The Water''s Edge', N'Sara Gruen', 234000, 210600, N'VNĐ', 1, CAST(N'2018-10-27' AS Date), 3, N'"NEW YORK TIMES" BESTSELLER In this thrilling new novel from the author of "Water for Elephants, " Sara Gruen again demonstrates her talent for creating spellbinding period pieces. "At the Water s Edge "is a gripping and poignant love story about a privileged young woman s awakening as she experiences the devastation of World War II in a tiny village in the Scottish Highlands. After disgracing themselves at a high society New Year s Eve party in Philadelphia in 1944, Madeline Hyde and her husband, Ellis, are cut off financially by his father, a former army colonel who is already ashamed of his son s inability to serve in the war. When Ellis and his best friend, Hank, decide that the only way to regain the Colonel s favor is to succeed where the Colonel very publicly failed by hunting down the famous Loch Ness monster Maddie reluctantly follows them across the Atlantic, leaving her sheltered world behind. The trio find themselves in a remote village in the Scottish Highlands, where the locals have nothing but contempt for the privileged interlopers. Maddie is left on her own at the isolated inn, where food is rationed, fuel is scarce, and a knock from the postman can bring tragic news.', 2000, NULL, 0, N'image_81938.jpg', N'Nước Ngoài', N'Bìa Mềm', 416, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1068, N'Everland', N'Rebecca Hunt', 222000, 199800, N'VNĐ', 1, CAST(N'2018-10-27' AS Date), 3, N'"Nothing short of stunning...something very powerful and unusual indeed." (Guardian). "Part-thriller, part adventure story, part social drama and utterly absorbing." (Daily Mail). "Hunt is a talented writer. On my watch this novel would win the Booker." (The Times). 1913: Dinners, Millet-Bass, and Napps - three men bound not by friendship, but by an intense dependence founded on survival - will be immortalised by their decision to volunteer to scout out a series of uncharted and unknown islands in the Antarctic, a big, indifferent kingdom. 2013: Brix, Jess, and Decker - three researchers with their own reasons for being far from home - set out on a field trip to the same ancient lumps of rock and snow, home to nothing but colonies of penguins and seals. Under the harsh ultraviolet light, as all colours bleach out, and the world of simple everyday pleasures recedes, they unknowingly begin to mirror the expedition of 100 years ago. "Hunt delivers a story that manages to be both surreally absurd and grimly captivating." (Independent on Sunday). "Thought-provoking and affecting...a gripping story." (Sunday Telegraph). Rebecca Hunt graduated from Central Saint Martins College with a first class honours degree in fine art. She lives and works in London. Her first novel, Mr Chartwell, was longlisted for the Guardian First Book Award and shortlisted for the Galaxy National Book Awards New Writer of the Year.', 2000, NULL, 0, N'image_50743.jpg', N'Nước Ngoài', N'Bìa Mềm', 215, NULL, NULL)
INSERT [dbo].[Sach] ([Ma_Sach], [Ten_Sach], [Tac_Gia], [Gia], [GiaCuaHang], [Don_Vi_Tinh], [Ma_NXB], [NgayCapNhat], [Ma_CD], [Mota], [SoLuongTon], [SoLuongBan], [SoLanXem], [HinhAnh], [Loai], [LoaiBia], [SoTrang], [NhaPhanPhoi], [Tieude]) VALUES (1069, N'Some Luck ', N'Jane Smiley', 15100, 135900, N'VNĐ', 1, CAST(N'2018-10-27' AS Date), 1, N'The first novel in a dazzling new epic trilogy from the winner of the Pulitzer Prize; a literary adventure that will span a century in America. 1920. After his return from the battlefields in France, Walter Langdon and his wife Rosanna begin their life together on a remote farm in Iowa. As time passes, their little family will grow: from Frank, the handsome, willful first-born, to Joe, whose love of animals and the land sustains him; from Lillian, beloved by her mother, to Henry who craves only the world of his books; and Claire, the surprise baby, who earns a special place in her father''s heart.  As Walter and Rosanna struggle to keep their family through good years and hard years - to years more desperate than they ever could have imagined, the world around their little farm will turn, and life for their children will be unrecognizable from what came before. Some will fall in love, some will have families of their own, some will go to war and some will not survive. All will mark history in their own way. Tender, compelling and moving from the 1920s to the 1950s, told in multiple voices as rich as the Iowan soil, Some Luck is an astonishing feat of storytelling by a prize-winning author writing at the height of her powers.', 2000, NULL, 0, N'image_48115.jpg', N'Nước Ngoài', N'Bìa Mềm', 640, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
ALTER TABLE [dbo].[CTDATHANG]  WITH CHECK ADD  CONSTRAINT [fk_MaHangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[Sach] ([Ma_Sach])
GO
ALTER TABLE [dbo].[CTDATHANG] CHECK CONSTRAINT [fk_MaHangHoa]
GO
ALTER TABLE [dbo].[CTDATHANG]  WITH CHECK ADD  CONSTRAINT [fk_SoHD] FOREIGN KEY([SoHD])
REFERENCES [dbo].[DATHANG] ([SoHD])
GO
ALTER TABLE [dbo].[CTDATHANG] CHECK CONSTRAINT [fk_SoHD]
GO
ALTER TABLE [dbo].[DATHANG]  WITH CHECK ADD  CONSTRAINT [fk_Ma_Khach_Hang] FOREIGN KEY([Ma_KhachHang])
REFERENCES [dbo].[Khach_Hang] ([Ma_Khach_Hang])
GO
ALTER TABLE [dbo].[DATHANG] CHECK CONSTRAINT [fk_Ma_Khach_Hang]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [fk_MaCD] FOREIGN KEY([Ma_CD])
REFERENCES [dbo].[ChuDe] ([Ma_CD])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [fk_MaCD]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [fk_MaNXB] FOREIGN KEY([Ma_NXB])
REFERENCES [dbo].[NXB] ([Ma_NXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [fk_MaNXB]
GO
ALTER TABLE [dbo].[VanPhongPham]  WITH CHECK ADD  CONSTRAINT [fk_VPPNSX] FOREIGN KEY([Ma_NSX])
REFERENCES [dbo].[NSX] ([Ma_NSX])
GO
ALTER TABLE [dbo].[VanPhongPham] CHECK CONSTRAINT [fk_VPPNSX]
GO
USE [master]
GO
ALTER DATABASE [dataMeBook] SET  READ_WRITE 
GO
