USE [qlsv]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[tk] [nvarchar](50) NOT NULL,
	[mk] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chinhsach]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chinhsach](
	[macs] [varchar](10) NOT NULL,
	[tencs] [nvarchar](50) NULL,
	[chedo] [nvarchar](50) NULL,
 CONSTRAINT [PK_chinhsach] PRIMARY KEY CLUSTERED 
(
	[macs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diem]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diem](
	[id] [int] NOT NULL,
	[masv] [varchar](10) NULL,
	[mamh] [varchar](10) NULL,
	[diem] [float] NULL,
 CONSTRAINT [PK_diem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giaovien](
	[magv] [varchar](10) NOT NULL,
	[tengv] [nvarchar](30) NULL,
	[gioitinh] [nvarchar](5) NULL,
	[ngaysinh] [date] NULL,
	[sdt] [nvarchar](11) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_giaovien] PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gv]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gv](
	[tk] [nvarchar](50) NOT NULL,
	[mk] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_gv] PRIMARY KEY CLUSTERED 
(
	[tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[makhoa] [varchar](10) NOT NULL,
	[tenkhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [varchar](10) NOT NULL,
	[tenlop] [nvarchar](50) NULL,
	[makhoa] [varchar](10) NOT NULL,
 CONSTRAINT [PK_lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monhoc](
	[mamh] [varchar](10) NOT NULL,
	[tenmh] [nvarchar](50) NULL,
	[sotiet] [int] NULL,
	[magv] [varchar](10) NOT NULL,
 CONSTRAINT [PK_monhoc] PRIMARY KEY CLUSTERED 
(
	[mamh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nguoidung]    Script Date: 12/4/2023 3:25:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nguoidung](
	[tk] [nvarchar](50) NOT NULL,
	[mk] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nguoidung] PRIMARY KEY CLUSTERED 
(
	[tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [varchar](10) NOT NULL,
	[tensv] [nvarchar](30) NULL,
	[gioitinh] [nvarchar](5) NOT NULL,
	[ngaysinh] [date] NULL,
	[sdt] [nvarchar](11) NULL,
	[diachi] [nvarchar](50) NULL,
	[macs] [varchar](10) NOT NULL,
	[malop] [varchar](10) NOT NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[truongkhoa](
	[tk] [nvarchar](50) NOT NULL,
	[mk] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_truongkhoa] PRIMARY KEY CLUSTERED 
(
	[tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[admin] ([tk], [mk]) VALUES (N'a1', N'123456')
INSERT [dbo].[admin] ([tk], [mk]) VALUES (N'admin', N'admin')
INSERT [dbo].[admin] ([tk], [mk]) VALUES (N'admin1', N'admin1')
INSERT [dbo].[admin] ([tk], [mk]) VALUES (N'admin2', N'111333')
INSERT [dbo].[admin] ([tk], [mk]) VALUES (N'admin4', N'111222')
GO
INSERT [dbo].[chinhsach] ([macs], [tencs], [chedo]) VALUES (N'cs1', N'giam luong', N'toi thieu')
INSERT [dbo].[chinhsach] ([macs], [tencs], [chedo]) VALUES (N'cs2', N'ho tro sinh vien', N'toi thieu')
INSERT [dbo].[chinhsach] ([macs], [tencs], [chedo]) VALUES (N'cs3', N'cung cap ', N'toi da')
INSERT [dbo].[chinhsach] ([macs], [tencs], [chedo]) VALUES (N'cs4', N'hoc bong', N'toi da')
INSERT [dbo].[chinhsach] ([macs], [tencs], [chedo]) VALUES (N'cs5', N'tang luong', N'toi thieu')
GO
INSERT [dbo].[diem] ([id], [masv], [mamh], [diem]) VALUES (1, N'sv1', N'1', 9)
INSERT [dbo].[diem] ([id], [masv], [mamh], [diem]) VALUES (2, N'sv2', N'2', 9.6)
INSERT [dbo].[diem] ([id], [masv], [mamh], [diem]) VALUES (3, N'sv3', N'3', 9)
INSERT [dbo].[diem] ([id], [masv], [mamh], [diem]) VALUES (4, N'sv4', N'4', 8)
INSERT [dbo].[diem] ([id], [masv], [mamh], [diem]) VALUES (5, N'sv5', N'5', 8)
GO
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'1', N'Thao', N'Nữ', CAST(N'2023-07-01' AS Date), N'096124621', N'ha noi')
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'2 ', N'Toan', N'Nam', CAST(N'1997-02-02' AS Date), N'095621825', N'Quang Ninh')
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'3', N'Son', N'Nam', CAST(N'1994-03-01' AS Date), N'093661451', N'Quang Nam')
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'4', N'Tung', N'Nam', CAST(N'1994-01-05' AS Date), N'097546261', N'Hai Phong')
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'5', N'Linh', N'Nu', CAST(N'1992-04-01' AS Date), N'097246128', N'Bac Ninh')
INSERT [dbo].[giaovien] ([magv], [tengv], [gioitinh], [ngaysinh], [sdt], [diachi]) VALUES (N'6', N'Long', N'Nam', CAST(N'1991-01-03' AS Date), N'094154862', N'Thanh Hoa')
GO
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv', N'gv')
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv1', N'123456')
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv2', N'111111')
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv3', N'222222')
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv4', N'333333')
INSERT [dbo].[gv] ([tk], [mk]) VALUES (N'gv5', N'444444')
GO
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k1        ', N'khoa1')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k2', N'cntt')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k3', N'kinhte')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k4', N'cokhi')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k5', N'dientu')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k6', N'thuongmai')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'k7', N'ketoan')
GO
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l1        ', N'dhti14a1cl', N'k1        ')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l2', N'dhti13a2', N'k1')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l3', N'dhti14a4', N'k3')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l4', N'dhmt14a2', N'k4')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l5', N'dhna15a1', N'k5')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'l6', N'dhti16a2cl', N'k1')
GO
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'1', N'toan', 90, N'1')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'2', N'van', 90, N'2')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'3', N'anh', 90, N'3')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'4 ', N'lich su', 75, N'4')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'5', N'hoa hoc', 100, N'5')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'6', N'dia', 60, N'6')
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotiet], [magv]) VALUES (N'7', N'the duc', 70, N'2')
GO
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'cuongnk', N'cuongnk')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'test', N'test')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'u1', N'123456')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'u11', N'123456')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'u12', N'123456')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'user', N'user')
INSERT [dbo].[nguoidung] ([tk], [mk]) VALUES (N'user1', N'user1')
GO
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv1       ', N'Nguyen Kim Cuong', N'Nam', CAST(N'2002-02-18' AS Date), N'0763341778', N'Quang Ninh', N'cs1', N'l1        ')
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv2', N'Ha Thanh Tung', N'Nam', CAST(N'2002-01-01' AS Date), N'0987146831', N'Ha Noi', N'cs2', N'l2')
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv3', N'Nguyen Duc Toan', N'Nam', CAST(N'2002-04-04' AS Date), N'0974716254', N'Ninh Binh', N'cs3', N'l3')
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv4', N'Nguyen Van Duc', N'Nam', CAST(N'2002-06-06' AS Date), N'0845741274', N'Thanh Hoa', N'cs4', N'l4')
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv5', N'Nguyen Thuy Linh', N'Nu', CAST(N'2002-11-04' AS Date), N'0974556164', N'Ha Noi', N'cs5', N'l5')
INSERT [dbo].[sinhvien] ([masv], [tensv], [gioitinh], [ngaysinh], [sdt], [diachi], [macs], [malop]) VALUES (N'sv6', N'Nguyen Duc Thinh', N'Nam ', CAST(N'2002-09-09' AS Date), N'0924878241', N'Ca maU', N'cs1', N'l1')
GO
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truong', N'123456')
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truong1', N'123456')
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truong2', N'777424')
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truong3', N'123455')
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truong4', N'111111')
INSERT [dbo].[truongkhoa] ([tk], [mk]) VALUES (N'truongkhoa', N'truongkhoa')
GO
ALTER TABLE [dbo].[diem]  WITH CHECK ADD  CONSTRAINT [FK_diem_monhoc] FOREIGN KEY([mamh])
REFERENCES [dbo].[monhoc] ([mamh])
GO
ALTER TABLE [dbo].[diem] CHECK CONSTRAINT [FK_diem_monhoc]
GO
ALTER TABLE [dbo].[diem]  WITH CHECK ADD  CONSTRAINT [FK_diem_sinhvien] FOREIGN KEY([masv])
REFERENCES [dbo].[sinhvien] ([masv])
GO
ALTER TABLE [dbo].[diem] CHECK CONSTRAINT [FK_diem_sinhvien]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK_lop_khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[khoa] ([makhoa])
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK_lop_khoa]
GO
ALTER TABLE [dbo].[monhoc]  WITH CHECK ADD  CONSTRAINT [FK_monhoc_giaovien] FOREIGN KEY([magv])
REFERENCES [dbo].[giaovien] ([magv])
GO
ALTER TABLE [dbo].[monhoc] CHECK CONSTRAINT [FK_monhoc_giaovien]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_chinhsach] FOREIGN KEY([macs])
REFERENCES [dbo].[chinhsach] ([macs])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_chinhsach]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_lop] FOREIGN KEY([malop])
REFERENCES [dbo].[lop] ([malop])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_lop]
GO
