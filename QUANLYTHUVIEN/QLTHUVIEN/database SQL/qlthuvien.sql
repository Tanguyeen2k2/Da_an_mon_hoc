USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 14/05/2023 4:26:06 SA ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'D:\Program File 1\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'D:\Program File 1\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV', N'ON'
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[ChiTietMuon]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMuon](
	[MaPM] [char](10) NOT NULL,
	[MaCS] [char](15) NOT NULL,
	[TinhTrang] [nvarchar](20) NULL,
 CONSTRAINT [PK_ChiTietMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[MaPN] [char](10) NOT NULL,
	[MaTS] [varchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[MaCS] [char](15) NOT NULL,
	[MaTS] [varchar](10) NOT NULL,
 CONSTRAINT [PK__CuonSach__B235742D9CA18FE1] PRIMARY KEY CLUSTERED 
(
	[MaCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [char](10) NOT NULL,
	[TenDG] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NULL,
	[Email] [nchar](40) NULL,
 CONSTRAINT [PK__NCC__3A185DEB79758A68] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [char](10) NOT NULL,
	[TenNXB] [nchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[Email] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [char](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
	[MaDG] [char](10) NOT NULL,
	[MaTT] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[MaTT] [char](10) NOT NULL,
	[MaNCC] [char](10) NOT NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [char](10) NOT NULL,
	[TenTG] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](5) NULL,
	[QueQuan] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuThu](
	[MaTT] [char](10) NOT NULL,
	[TenTT] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
	[Chucvu] [nvarchar](30) NULL,
	[username] [nchar](10) NULL,
	[password] [int] NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuaSach](
	[MaTS] [varchar](10) NOT NULL,
	[TenTS] [nvarchar](50) NOT NULL,
	[NamXB] [int] NULL,
	[MaNXB] [char](10) NULL,
	[MaLoai] [char](10) NULL,
	[MaTG] [char](10) NULL,
	[SoLuong] [int] NULL,
	[SoTrang][int]NULL,
 CONSTRAINT [PK__TuaSach__27250078A777EB3F] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_CuonSach_MaSach] FOREIGN KEY([MaCS])
REFERENCES [dbo].[CuonSach] ([MaCS])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_CuonSach_MaSach]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_PhieuMuon_MaPM] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_PhieuMuon_MaPM]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_PhieuNhap_MaPN] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_PhieuNhap_MaPN]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_TuaSach_MaTS] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TuaSach] ([MaTS])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_TuaSach_MaTS]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_TuaSach_MaTS] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TuaSach] ([MaTS])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_TuaSach_MaTS]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia_MaDG] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia_MaDG]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_ThuThu_MaTT] FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThuThu] ([MaTT])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_ThuThu_MaTT]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NCC_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NCC_MaNCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_ThuThu_MaTT] FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThuThu] ([MaTT])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_ThuThu_MaTT]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_TheLoai_MaKe] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[TheLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_TheLoai_MaKe]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_NXB_MaNXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_TacGia_MaTG] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_NXB_MaNXB]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [CK__ChiTietMu__TinhT__35BCFE0A] CHECK  (([TinhTrang]=N'Cũ' OR [TinhTrang]=N'Tốt'))
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [CK__ChiTietMu__TinhT__35BCFE0A]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[TacGia]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[ThuThu]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
/****** Object:  StoredProcedure [dbo].[Delete_CS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_CS](@macs char(10))
as
begin
delete CuonSach
where MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_CTM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Delete_CTM](@mapm char(10),@macs char(10))
as
begin
	delete ChiTietMuon
	where MaPM=@mapm and MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_CTN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_CTN](@MaPN char(10))
as
begin
delete ChiTietNhap
where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_DG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_DG](@madg char(10))
as
begin
	delete DocGia
	where maDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_TheLoai]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[Delete_TheLoai](@make char(10))
 as
 delete TheLoai
 where MaLoai=@make
---------------NXB--------------------------
GO
/****** Object:  StoredProcedure [dbo].[Delete_NCC]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_NCC](@mancc char(10))
as
begin
delete NCC
where maNCC=@mancc
end		
GO
/****** Object:  StoredProcedure [dbo].[Delete_NXB]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_NXB](@manxb char(10))
as
begin
delete NXB
where maNXB=@manxb
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_PM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Delete_PM](@mapm char(10))
as
begin
	delete PhieuMuon
	where MaPM=@mapm
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_PN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_PN](@MaPN char(10))
as
begin
delete PhieuNhap
where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_SCN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_SCN](@tensach nvarchar(50))
as
begin
delete SachCN
where tenSach=@tensach
end        	
GO
/****** Object:  StoredProcedure [dbo].[Delete_TG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_TG](@matg char(10))
as
begin
delete TacGia
where maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_TS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_TS](@mats char(10))
as
begin
delete TuaSach
where maTS=@mats
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_TT]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Delete_TT](@matt char(10))
as
begin
	delete ThuThu
	where maTT=@matt
end
GO
/****** Object:  StoredProcedure [dbo].[Delete_V]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_V](@mats char(10),@matg char(10))
as
begin
delete Viet
where maTS=@mats and maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Get_TS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Get_TS]
as
begin
declare @i  int
declare @ts varchar(10)
declare @j  int =1
declare @k int
declare @mats varchar(5)
declare @mm	varchar(15)
set @i=10
select @mats= MaTS from TuaSach where MaTS='TS002'
select @ts= MaCS from (select top 1 MaCS from CuonSach where MaTS = 'TS001' order by MaCS DESC ) as A
set @k=	convert( int,substring(@ts,7,3))
while (@j<=@i)
	begin
	if((@j+@k)<10)
			set  @mm=@mats+'_00'+CONVERT(char(5),(@j+@k))
		else if ((@j+@k)<100)
			set @mm=@mats+'_0'+CONVERT(char(5),(@j+@k))
		else 
			set @mm=@mats+'_'+CONVERT(char(5),(@j+@k))
		print @mm
		set @j=@j+1

	end;
--insert into CuonSach values(@mats+'_0'+CONVERT(char(5),@i),@mats)
end;


--Get_TS



--select TuaSach.MaTS,TenTS,NamXB,TheLoai,SoTrang, MaKe,TenNXB,TenTG,SoLuong from TuaSach,TacGia,NXB,Viet
 --where TuaSach.MaTS=Viet.MaTS and Viet.MaTG=TacGia.MaTG and TuaSach.MaNXB=NXB.MaNXB
 --and TuaSach.MaTS=@mats
GO
/****** Object:  StoredProcedure [dbo].[Insert_CS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
				

CREATE proc [dbo].[Insert_CS](@macs char(10),@mats char(10))
as
begin
if exists(select MaCS from CuonSach where MaCS=@macs) print('Khong the Insert')
else
insert into CuonSach values(@macs,@mats)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_CTM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		


--3. Chi tiet muon
CREATE proc [dbo].[Insert_CTM](@mapm char(10),@macs char(10),@tinhtrang nvarchar(30) )
as
begin
	if exists(select MaPM, MaCS from ChiTietMuon where MaPM=@mapm and MaCS=@macs) print(N'Đã tồn tại!!!')
	else
	insert into ChiTietMuon values(@mapm ,@macs ,@tinhtrang )
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_CTN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
				
				
CREATE proc [dbo].[Insert_CTN](@mapn char(10),@mats varchar(10),@soluong int,@dongia int)
as
begin
if exists(select MaPN,MaTS from ChiTietNhap where MaPN=@mapn and MaTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into ChiTietNhap values(@mapn,@mats,@soluong,@dongia)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_DG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------Doc gia-------------------
CREATE proc [dbo].[Insert_DG](@madg char(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13))
as
begin
	if exists(select maDG from DocGia where maDG=@madg) print(N'Đã tồn tại!!!')
	else 
	insert into DocGia values (@madg,@tendg,@ngaysinhdg,@gioitinhdg,@diachidg,@sdtdg)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_TheLoai]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_TheLoai](@maloai char(10),@tenloai nvarchar(30))
as
begin
if exists (select MaLoai from TheLoai where MaLoai=@maloai)
print N'Đã tồn tại!!!'
else 
insert into TheLoai values (@maloai, @tenloai)
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_NCC]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		
CREATE proc [dbo].[Insert_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@email nchar(40))
as
begin
if exists(select maNCC from NCC where maNCC=@mancc)  print(N'Đã tồn tại!!!')
else
insert into NCC values (@mancc,@tenncc,@diachincc,@sdtncc,@email)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_NXB]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
CREATE proc [dbo].[Insert_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
if exists(select maNXB from NXB where maNXB=@manxb)
	print(N'Đã tồn tại!!!')
else
insert into NXB(MaNXB,TenNXB,DiaChi,SDT,Email) values(@manxb,@tennxb,@diachinxb,@sdtnxb,@emailnxb)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------2.Phieu Muon-------------------
CREATE proc [dbo].[Insert_PM](@mapm char(10),@ngaymuon date,@ngaytra date, @madg char(10),@matt char(10))
as
begin
if exists(select MaPM from PhieuMuon where MaPM=@mapm) print(N'Đã tồn tại!!!')
	else
	insert into PhieuMuon values(@mapm,@ngaymuon,@ngaytra,@madg,@matt)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		

CREATE proc [dbo].[Insert_PN](@mapn char(10),@ngaylap date,@matt char(10),@mancc char(10))
as
begin
if exists(select MaPN from PhieuNhap where MaPN=@mapn) print('Khong The Insert')
else
insert into PhieuNhap(MaPN,NgayLap,MaTT,MaNCC) values(@mapn,@ngaylap,@matt,@mancc)
end		
GO
/****** Object:  StoredProcedure [dbo].[Insert_SCN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		
create proc [dbo].[Insert_SCN](@tensach nvarchar(50),@tacgia ntext,@theloai nvarchar(20),@matt char(10),@mancc char(10))
as
begin
if exists(select tenSach from SachCN where tenSach=@tensach) print(N'Đã tồn tại!!!')
else
insert into SachCN values(@tensach,@tacgia,@theloai,@matt,@mancc)
end  
GO
/****** Object:  StoredProcedure [dbo].[Insert_TG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		

create proc [dbo].[Insert_TG](@matg char(10),@tentg nvarchar(50),@gioitinhtg nvarchar(3),@ngaysinhtg date,@quequantg nvarchar(50))
as
begin
if exists(select maTG from TacGia where maTG=@matg) print(N'Đã tồn tại!!!')
else
insert into TacGia(maTG,tenTG,gioiTinh,ngaySinh,queQuan) values(@matg,@tentg,@gioitinhtg,@ngaysinhtg,@quequantg)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_TS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_TS](@mats char(10),@tents nvarchar(50),@namxb int,@manxb char(10),@maloai char(10),@matg char(10),@soluong int,@sotrang int)
as
begin
if exists(select maTS from TuaSach where maTS=@mats) print(N'Đã tồn tại!!!')
else 
insert into TuaSach values(@mats,@tents,@namxb,@manxb,@maloai,@matg,@soluong,@sotrang)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_TT]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--5. Thu Thu
CREATE proc [dbo].[Insert_TT](@matt char(10),@tentt nvarchar(30),@ngaysinhtt date,@gioitinhtt nvarchar(3),@diachitt nvarchar(50),@sdttt char(13),@Chucvu nvarchar(30),@username nchar(10),@password int)
as
begin
if exists(select maTT from ThuThu where maTT=@matt) print(N'Đã tồn tại!!!')
else
	insert into ThuThu values(@matt,@tentt,@ngaysinhtt,@gioitinhtt,@diachitt,@sdttt,@Chucvu,@username,@password)
end
GO

/****** Object:  StoredProcedure [dbo].[Insert_V]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		

CREATE proc [dbo].[Insert_V](@mats char(10),@matg char(10),@sotrang int)
as
begin
if exists(select maTS,maTG from Viet where MaTS=@mats and MaTG=@matg) print('Khong the Insert')
else
insert into Viet values(@mats,@matg,@sotrang)
end
GO
/****** Object:  StoredProcedure [dbo].[Select_CS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------Cuon sach-------------------------------
CREATE proc [dbo].[Select_CS]
as
begin
select MaCS, CuonSach.MaTS,TenTS from CuonSach, TuaSach
where CuonSach.MaTS=TuaSach.MaTS
end
 
GO
/****** Object:  StoredProcedure [dbo].[Select_CTM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Select_CTM]
as
begin
select MaPM as[Số Phiếu Mượn Trả],MaCS as[Mã Cuốn Sách],TinhTrang as[Tình trạng]  from ChiTietMuon
end
GO
/****** Object:  StoredProcedure [dbo].[Select_CTN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_CTN]
as
begin
select MaPN  ,ChiTietNhap.maTS ,tenTS ,ChiTietNhap.SoLuong ,donGia  
from ChiTietNhap,TuaSach 
where ChiTietNhap.maTS=TuaSach.maTS
end
GO
/****** Object:  StoredProcedure [dbo].[Select_DG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_DG]
as
begin
select *from DocGia
end
GO
/****** Object:  StoredProcedure [dbo].[Select_TheLoai]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------Ke Sach----------
CREATE proc [dbo].[Select_TheLoai]
as
select TheLoai.MaLoai,TenLoai SL from TheLoai full join(select MaLoai,count( MaCS) as SL from TuaSach,CuonSach where CuonSach.MaTS=TuaSach.MaTS
 group by MaLoai)as temp on temp.MaLoai=TheLoai.MaLoai

GO
/****** Object:  StoredProcedure [dbo].[Select_NCC]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------Nha cung cap--------------------------
CREATE proc [dbo].[Select_NCC]
as
begin
select * from NCC
end									
GO
/****** Object:  StoredProcedure [dbo].[Select_NXB]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Select_NXB]
as
select* from NXB
GO
/****** Object:  StoredProcedure [dbo].[Select_PM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Select_PM]
as
begin
	select PhieuMuon.MaPM,NgayMuon,NgayTra,PhieuMuon.MaDG,TenDG,PhieuMuon.MaTT, TenTT,ChiTietMuon.MaCS,TuaSach.MaTS,TenTS,TinhTrang
	from PhieuMuon, DocGia, ThuThu, ChiTietMuon, TuaSach,CuonSach
	where PhieuMuon.MaDG= DocGia.MaDG and PhieuMuon.MaTT=ThuThu.MaTT and PhieuMuon.MaPM=ChiTietMuon.MaPM
		and TuaSach.MaTS= CuonSach.MaTS and CuonSach.MaCS=ChiTietMuon.MaCS
end
GO
/****** Object:  StoredProcedure [dbo].[Select_PN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------------------------Phieu Nhap---------------------------------
CREATE proc [dbo].[Select_PN]
as
begin
select PhieuNhap.MaPN, NgayLap,PhieuNhap.MaTT,TenTT,TenNCC,ChiTietNhap.MaTS, TenTS,ChiTietNhap.SoLuong,DonGia, ChiTietNhap.SoLuong*DonGia as TT,TongTien
 from PhieuNhap, NCC, ThuThu,Chitietnhap, TuaSach
where PhieuNhap.MaNCC=NCC.MaNCC and PhieuNhap.MaTT=ThuThu.MaTT and ChiTietNhap.MaTS=TuaSach.MaTS and ChiTietNhap.MaPN=PhieuNhap.MaPN

end
GO
/****** Object:  StoredProcedure [dbo].[Select_SCN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--------------------------Sach can nhap	---------------------
create proc [dbo].[Select_SCN]
as
begin
select tenSach as[Tên Sách],tacGia as[Tác Giả],theLoai as[Thể Loại],maTT as[Mã Thủ Thư],maNCC as[Mã Nhà Cung Cấp]  from SachCN
end          
GO
/****** Object:  StoredProcedure [dbo].[Select_TG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------Tac Gia-----------------------
CREATE proc [dbo].[Select_TG]
as
begin
select *from TacGia
end
GO
/****** Object:  StoredProcedure [dbo].[Select_TS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


				----------------------------Tua Sach------------------------
CREATE proc [dbo].[Select_TS]
as
begin
select TuaSach.MaTS,TenTS,NamXB,TheLoai,SoTrang, MaKe,TenNXB,TenTG,SoLuong from TuaSach,TacGia,NXB,Viet
 where TuaSach.MaTS=Viet.MaTS and Viet.MaTG=TacGia.MaTG and TuaSach.MaNXB=NXB.MaNXB
end
GO
/****** Object:  StoredProcedure [dbo].[Select_TT]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_TT]
as
select *from ThuThu
GO
/****** Object:  StoredProcedure [dbo].[Select_V]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------Viet------------------
create proc [dbo].[Select_V]
as
begin
select maTS as[Mã Tựa Sách],maTG as[Mã Tác Giả],soTrang as[Số Trang] from Viet
end		
GO
/****** Object:  StoredProcedure [dbo].[ThongKe]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKe]
as
begin
select CuonSach.MaCS as DM from CuonSach, ChiTietMuon where CuonSach.MaCS=ChiTietMuon.MaCS
select CuonSach.MaCS as CM from CuonSach except select MaCS from ChiTietMuon
end
GO
/****** Object:  StoredProcedure [dbo].[Update_CTM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_CTM](@mapm char(10),@macs char(10),@tinhtrang nvarchar(30) )
as
begin
	update ChiTietMuon
	set 
	TinhTrang=@tinhtrang
	where MaPM=@mapm and MaCS=@macs
end
GO
/****** Object:  StoredProcedure [dbo].[Update_CTN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_CTN](@mapn char(10),@mats char(10),@soluong int,@dongia money)
as
begin
update ChiTietNhap
set
MaTS=@mats,
SoLuong=@soluong,
DonGia=@dongia
where MaPN=@mapn
end
GO
/****** Object:  StoredProcedure [dbo].[Update_DG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_DG](@madg char(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13))
as
begin
	update DocGia
	set tenDG=@tendg,
		gioiTinh=@gioitinhdg,
		ngaySinh=@ngaysinhdg,
		diaChi=@diachidg,
		SDT=@sdtdg
	where maDG=@madg
end
GO
/****** Object:  StoredProcedure [dbo].[Update_TheLoai]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_TheLoai](@maloai char(10),@tenloai nvarchar(30))
as
begin
update TheLoai
set 
	TenLoai=@tenloai	
where MaLoai=@maloai
end

GO
/****** Object:  StoredProcedure [dbo].[Update_NCC]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@email char(40))
as
begin 
update NCC
set tenNCC=@tenncc,
diaChi=@diachincc,
SDT=@sdtncc,
Email=@email
where maNCC=@mancc
end		
GO
/****** Object:  StoredProcedure [dbo].[Update_NXB]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
update NXB
set tenNXB=@tennxb,
	diaChi=@diachinxb,
	SDT=@sdtnxb,
	email=@emailnxb
	where maNXB=@manxb
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PM]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Update_PM](@mapm char(10),@ngaymuon date,@ngaytra date,  @madg char(10),@matt char(10))
as
begin
	update PhieuMuon
	set NgayMuon=@ngaymuon,
		NgayTra =@ngaytra,
		MaDG = @madg,
		MaTT = @matt
	where MaPM = @mapm
end
GO
/****** Object:  StoredProcedure [dbo].[Update_PN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_PN](@MaPN char(10),@ngaylap date,@matt char(10),@mancc char(10))
as
begin
update PhieuNhap
set ngayLap=@ngaylap,
maTT=@matt,
maNCC=@mancc
where MaPN=@MaPN
end		
GO
/****** Object:  StoredProcedure [dbo].[Update_SCN]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_SCN](@tensach nvarchar(50),@tacgia ntext,@theloai nvarchar(20),@loainhap nvarchar(9),@matt char(10),@mancc char(10))
as
begin
update SachCN
set tacGia=@tacgia,
	theLoai=@theloai,
	maTT=@matt,
	maNCC=@mancc
where tenSach=@tensach
end	   
GO
/****** Object:  StoredProcedure [dbo].[Update_TG]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Update_TG](@matg char(10),@tentg nvarchar(50),@gioitinhtg nvarchar(3),@ngaysinhtg date,@quequantg nvarchar(50))
as
begin
update TacGia
set tenTG=@tentg,
gioiTinh=@gioitinhtg,
ngaySinh=@ngaysinhtg,
queQuan=@quequantg
where maTG=@matg
end
GO
/****** Object:  StoredProcedure [dbo].[Update_TS]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[Update_TS](@mats char(10),@tents nvarchar(50),@namxb int,@manxb char(10),@maloai char(10),@matg char(10), @soluong int, @sotrang int)
as
begin
update TuaSach
set tenTS=@tents,
	namXB=@namxb,	
	maNXB = @manxb,
	MaLoai=@maloai,
	MaTG=@matg,
	SoLuong=@soluong,
	SoTrang=@sotrang
where maTS=@mats
end
GO
/****** Object:  StoredProcedure [dbo].[Update_TT]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_TT](@matt char(10),@tentt nvarchar(30),@gioitinhtt nvarchar(3),@ngaysinhtt date,@diachitt nvarchar(50),@sdttt char(13),@Chucvu nvarchar(30))
as
begin
	update ThuThu
	set TenTT = @tentt,
		gioiTinh=@gioitinhtt,
		ngaySinh=@ngaysinhtt,
		diaChi=@diachitt,
		SDT=@sdttt,
		Chucvu=@Chucvu
	where maTT=@matt
end
GO
/****** Object:  StoredProcedure [dbo].[Update_V]    Script Date: 14/05/2023 4:26:06 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Update_V](@mats char(10),@matg char(10),@sotrang int)
as
begin
update Viet
set soTrang=@sotrang
where maTS=@mats and maTG=@matg
end
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
Go

INSERT INTO ThuThu(MaTT,TenTT,NgaySinh,GioiTinh,DiaChi,SDT,Chucvu,username,password) VALUES ('1',N'truong anh nguyen ',CAST(N'02/02/2002' AS Date),'Nam',N'tphcm','35254','Quản lý','nguyen','123')
INSERT INTO ThuThu(MaTT,TenTT,NgaySinh,GioiTinh,DiaChi,SDT,Chucvu,username,password) VALUES ('2',N'ky ',CAST(N'02/02/2002' AS Date),'Nam',N'tphcm','35254','Nhân viên','ky','123')
INSERT INTO ThuThu(MaTT,TenTT,NgaySinh,GioiTinh,DiaChi,SDT,Chucvu,username,password) VALUES ('3',N'hau',CAST(N'02/02/2002' AS Date),'Nam',N'tphcm','35254','Nhân viên','hau','123')
INSERT INTO ThuThu(MaTT,TenTT,NgaySinh,GioiTinh,DiaChi,SDT,Chucvu,username,password) VALUES ('4',N'loi ',CAST(N'02/02/2002' AS Date),'Nam',N'tphcm','35254','Nhân viên','loi','123')



INSERT INTO TacGia VALUES ('1',N'nguyên',CAST(N'02/02/2002' AS Date),'Nam',N'Bình Định')
INSERT INTO TacGia VALUES ('2',N'Luu Quang Vu',CAST(N'02/02/2002' AS Date),'Nam',N'Bình Định')
INSERT INTO TacGia VALUES ('3',N'NoName',CAST(N'02/02/2002' AS Date),'Nam',N'Bình Định')
INSERT INTO TacGia VALUES ('4',N'Head',CAST(N'02/02/2002' AS Date),'Nam',N'Bình Định')
INSERT INTO TacGia VALUES ('5',N'Man',CAST(N'02/02/2002' AS Date),'Nam',N'Bình Định')

INSERT INTO TheLoai VALUES ('1',N'Tho')
INSERT INTO TheLoai VALUES ('2',N'Vam')
INSERT INTO TheLoai VALUES ('3',N'SGK')
INSERT INTO TheLoai VALUES ('4',N'Chieu')

INSERT INTO NXB VALUES ('1',N'Chieu',N'tphcm','3545456','chieu@gmail.com')
INSERT INTO NXB VALUES ('2',N'Chieu1',N'tphcm','3545456','chieu11@gmail.com')
INSERT INTO NXB VALUES ('3',N'Chieu1',N'tphcm','3545456','chieu1@gmail.com')
INSERT INTO NXB VALUES ('4',N'Chieu1',N'tphcm','3545456','chieu1@gmail.com')

INSERT INTO DocGia VALUES ('1',N'Nguyen',CAST(N'02/02/2002' AS Date),N'Nam',N'tphcm','3542546')
INSERT INTO DocGia VALUES ('2',N'LY',CAST(N'02/02/2002' AS Date),N'Nữ',N'tphcm','3542546')
INSERT INTO DocGia VALUES ('3',N'HUY',CAST(N'02/02/2002' AS Date),N'Nam',N'tphcm','3542546')
INSERT INTO DocGia VALUES ('4',N'HOA',CAST(N'02/02/2002' AS Date),N'Nữ',N'tphcm','3542546')
INSERT INTO DocGia VALUES ('5',N'KI',CAST(N'02/02/2002' AS Date),'Nam',N'tphcm','3542546')