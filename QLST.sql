CREATE DATABASE [QLST]
USE [QLST]
GO
/****** Object:  Table [dbo].[chitietdonhang]    Script Date: 8/30/2022 11:34:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Tạo bảng nhacungcap
CREATE TABLE [dbo].[nhacungcap](
    [mancc] [int] IDENTITY(1,1) NOT NULL,
    [tenncc] [nvarchar](50) NULL,
    [diachi] [nvarchar](50) NULL,
    [sdt] [nvarchar](50) NULL,
    [congno] [int] NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
    [mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng sanpham
CREATE TABLE [dbo].[sanpham](
    [masp] [int] IDENTITY(1000,1) NOT NULL,
    [tensp] [nvarchar](50) NULL,
    [mancc] [int] NULL,
    [gianhap] [int] NULL,
    [giaban] [int] NULL,
    [solg] [int] NULL,
    [hsd] [date] NULL,
    [noisx] [nvarchar](50) NOT NULL,
    [donvitinh] [nvarchar](50) NULL,
    [nguoinhap] [nvarchar](50) NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
    [masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng taikhoan
CREATE TABLE [dbo].[taikhoan](
    [username] [nvarchar](50) NOT NULL,
    [password] [nvarchar](50) NULL,
    [fullname] [nvarchar](50) NULL,
    [datecreate] [nvarchar](25) NULL,
    [isAdmin] [int] NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
    [username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tạo bảng chitietdonhang
CREATE TABLE [dbo].[chitietdonhang](
    [maphieuxuat] [int] IDENTITY(1,1) NOT NULL,
    [sanphamban] [nvarchar](500) NULL,
    [ngayban] [nvarchar](30) NULL,
    [thanhtien] [int] NULL,
    [nguoiban] [nvarchar](50) NULL,
 CONSTRAINT [PK_chitietdonhang] PRIMARY KEY CLUSTERED 
(
    [maphieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Thêm ràng buộc khóa ngoại từ bảng sanpham đến nhacungcap
ALTER TABLE dbo.sanpham
ADD CONSTRAINT FK_sanpham_nhacungcap FOREIGN KEY (mancc)
REFERENCES dbo.nhacungcap(mancc);

-- Thêm ràng buộc khóa ngoại từ bảng chitietdonhang đến taikhoan
ALTER TABLE dbo.chitietdonhang
ADD CONSTRAINT FK_chitietdonhang_taikhoan FOREIGN KEY (nguoiban)
REFERENCES dbo.taikhoan(username);

ALTER TABLE dbo.chitietdonhang
ADD CONSTRAINT FK_chitietdonhang_sanpham FOREIGN KEY (maphieuxuat)
REFERENCES dbo.sanpham(masp);

SET IDENTITY_INSERT [dbo].[chitietdonhang] ON 

INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (9, N'Tuong ot : 1, Dau an : 2, Bot ngot : 2, ', N'2022-44-23 10:44:05 PM', 175000, N'Nguyen Van Teo (Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (10, N'Dau an : 2,  Bot ngot : 1,  Cocacola : 5,  ', N'2022-22-24 08:22:31 PM', 970000, N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (11, N'Dau an : 5,  sua : 4,  kim chi : 3,  ', N'2022-18-26 10:18:08 AM', 642600, N'Nguyen Van Teo (Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (12, N'Cocacola : 1,  kim chi : 1,  Cocacola : 1,  ', N'2022-05-30 09:05:14 PM', 570000, N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (13, N'Tuong ot : 1,  Cocacola : 1,  Tuong ot : 1,  ', N'2022-08-30 09:08:18 PM', 340000, N'Nguyen Van Teo (Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (14, N'B?t gi?t : 5,  Tuong ot : 1,  Nuoc Tuong : 3,  Bot ngot : 2,  ', N'2022-17-30 09:17:57 PM', 315000, N'Nguyen Van Teo (Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (15, N'Cocacola : 3,  kim chi : 2,  Kem Danh Rang : 5,  ', N'2022-08-30 11:08:17 PM', 1240000, N'Nguyen Van Teo (Nhân viên)')
SET IDENTITY_INSERT [dbo].[chitietdonhang] OFF
SET IDENTITY_INSERT [dbo].[nhacungcap] ON 

INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (1, N'VinFast', N'Hà Nội', N'01655888622', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (2, N'GoFood', N'Hà Nội', N'00001356565', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (3, N'ThuanAn', N'Hải Phòng', N'05985231023', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (4, N'Sun', N'hcm', N'123456789', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (5, N'Now', N'HCM', N'0934545', 0)
SET IDENTITY_INSERT [dbo].[nhacungcap] OFF
SET IDENTITY_INSERT [dbo].[sanpham] ON 

INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1000, N'Quat Máy', 1, 300000, 400000, 6, CAST(N'2025-01-01' AS Date), N'Hải Phòng', N'Chiếc', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1001, N'Bột giặt', 2, 150000, 20000, 26, CAST(N'2022-07-21' AS Date), N'Binh Phuoc', N'bịch', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1002, N'Dau an', 2, 50000, 60000, 35, CAST(N'2022-08-20' AS Date), N'HCM', N'Chai', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1003, N'Bot ngot', 1, 20000, 25000, 41, CAST(N'2022-08-20' AS Date), N'HCM', N'bich', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1004, N'Tuong ot', 1, 35000, 45000, 59, CAST(N'2023-11-23' AS Date), N'Hai phong', N'Chai', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1005, N'Cocacola', 1, 170000, 250000, 3, CAST(N'2022-08-20' AS Date), N'HCM', N'Thung', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1007, N'kim chi', 2, 50000, 70000, 94, CAST(N'2022-08-26' AS Date), N'Seoul', N'Bịch', N'Tran Thanh Tam (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1008, N'sua', 3, 20000, 30000, 36, CAST(N'2022-09-28' AS Date), N'hcm', N'hop', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1009, N'Nuoc Tuong', 1, 30000, 40000, 87, CAST(N'2022-09-29' AS Date), N'HCM', N'Chai', N'Nguyen Van Dung (Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1010, N'Kem Danh Rang', 5, 50000, 70000, 85, CAST(N'2022-08-30' AS Date), N'Binh Phuoc', N'Tip', N'Nguyen Van Dung (Quản trị)')
SET IDENTITY_INSERT [dbo].[sanpham] OFF
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'admin', N'123', N'Nguyen Van Dung', N'2022-08-21 20:16:04.51000', 0)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'dung', N'123456', N'Nguyen van Nhan', N'2022-08-21 20:54:33.15000', 0)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'loc', N'123', N'nguyen hoang', N'2022-08-26 09:08:14.00000', 0)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'staff', N'123', N'Nguyen Van Teo', N'2022-08-21 20:16:36.94700', 1)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'test', N'123', N'Nguyen Van Test', N'2022-12-30 09:12:14 PM', 1)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'test1', N'123', N'Nguyen Van Test', N'2022-55-30 10:55:52 PM', 1)
