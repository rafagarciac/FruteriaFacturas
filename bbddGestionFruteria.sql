USE [master]
GO
/****** Object:  Database [gestionFacturas]    Script Date: 25/12/2017 23:37:20 ******/
CREATE DATABASE [gestionFacturas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestionFacturas', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\gestionFacturas.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gestionFacturas_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\gestionFacturas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gestionFacturas] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestionFacturas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestionFacturas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestionFacturas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestionFacturas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestionFacturas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestionFacturas] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestionFacturas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gestionFacturas] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [gestionFacturas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestionFacturas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestionFacturas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestionFacturas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestionFacturas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestionFacturas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestionFacturas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestionFacturas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestionFacturas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gestionFacturas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestionFacturas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestionFacturas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestionFacturas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestionFacturas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestionFacturas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestionFacturas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestionFacturas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gestionFacturas] SET  MULTI_USER 
GO
ALTER DATABASE [gestionFacturas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestionFacturas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestionFacturas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestionFacturas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [gestionFacturas]
GO
/****** Object:  Table [dbo].[Albaranes]    Script Date: 25/12/2017 23:37:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Albaranes](
	[idAlbaran] [int] NOT NULL,
	[fechaAlbaran] [date] NULL,
	[idFactura] [int] NOT NULL,
	[dni_cif] [varchar](50) NOT NULL,
	[subtotal] [float] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Albaranes] PRIMARY KEY CLUSTERED 
(
	[idAlbaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 25/12/2017 23:37:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[dni_cif] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[poblacion] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[dni_cif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 25/12/2017 23:37:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[idFactura] [int] NOT NULL,
	[fechaFactura] [date] NULL,
	[subtotal] [float] NULL,
	[total] [float] NULL,
	[dni_cif] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lineas]    Script Date: 25/12/2017 23:37:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lineas](
	[cantidad] [float] NULL,
	[unidad] [varchar](50) NULL,
	[descripcion_producto] [varchar](50) NULL,
	[precio_unitario] [float] NULL,
	[importe] [float] NULL,
	[idAlbaran] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Albaranes] ([idAlbaran], [fechaAlbaran], [idFactura], [dni_cif], [subtotal], [total]) VALUES (1, CAST(0xAB3C0B00 AS Date), 1, N'5435543J', 30.34, 50)
INSERT [dbo].[Albaranes] ([idAlbaran], [fechaAlbaran], [idFactura], [dni_cif], [subtotal], [total]) VALUES (2, CAST(0x873C0B00 AS Date), 1, N'5435543J', 56.43, 80)
INSERT [dbo].[Albaranes] ([idAlbaran], [fechaAlbaran], [idFactura], [dni_cif], [subtotal], [total]) VALUES (3, CAST(0x6D3C0B00 AS Date), 1, N'5435543J', 34.56, 40)
INSERT [dbo].[Clientes] ([dni_cif], [nombre], [domicilio], [poblacion]) VALUES (N'0022515F', N'GATO VERDE', N'C/SAN PON', N'ALCALA DE HENARES')
INSERT [dbo].[Clientes] ([dni_cif], [nombre], [domicilio], [poblacion]) VALUES (N'518541KD', N'LA CARTUJANA', N'C/SAN ANSELMO', N'ALCALA DE HENARES')
INSERT [dbo].[Clientes] ([dni_cif], [nombre], [domicilio], [poblacion]) VALUES (N'5435543J', N'BAR CANTAOR', N'C/PENDULO', N'MECO')
INSERT [dbo].[Clientes] ([dni_cif], [nombre], [domicilio], [poblacion]) VALUES (N'6541968G', N'BAR ESTANBUL', N'C/ETUNMAD', N'ALCALA DE HENARES')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (1, CAST(0xFB390B00 AS Date), 345.5, 400, N'5435543J')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (2, CAST(0x773B0B00 AS Date), 324.54, 500.32, N'0022515F')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (3, CAST(0x1F3B0B00 AS Date), 245.65, 340.43, N'0022515F')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (4, CAST(0x3D3D0B00 AS Date), 435.56, 432.54, N'0022515F')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (5, CAST(0xA73C0B00 AS Date), 324.56, 567.43, N'518541KD')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (6, CAST(0x443D0B00 AS Date), 65.45, 78.5, N'5435543J')
INSERT [dbo].[Facturas] ([idFactura], [fechaFactura], [subtotal], [total], [dni_cif]) VALUES (7, CAST(0x883C0B00 AS Date), 434.54, 65.65, N'6541968G')
INSERT [dbo].[Lineas] ([cantidad], [unidad], [descripcion_producto], [precio_unitario], [importe], [idAlbaran]) VALUES (125, N'KG', N'PATATAS', 0.85, 23.54, 1)
INSERT [dbo].[Lineas] ([cantidad], [unidad], [descripcion_producto], [precio_unitario], [importe], [idAlbaran]) VALUES (16, N'KG', N'NARANJAS', 1, 16, 1)
INSERT [dbo].[Lineas] ([cantidad], [unidad], [descripcion_producto], [precio_unitario], [importe], [idAlbaran]) VALUES (23, N'KG', N'LIMONES', 1.4, 12.98, 1)
INSERT [dbo].[Lineas] ([cantidad], [unidad], [descripcion_producto], [precio_unitario], [importe], [idAlbaran]) VALUES (34, N'KG', N'CANONICOS', 0.25, 21.32, 2)
INSERT [dbo].[Lineas] ([cantidad], [unidad], [descripcion_producto], [precio_unitario], [importe], [idAlbaran]) VALUES (20, N'GR', N'OPIACEOS', 0.43, 45.32, 2)
ALTER TABLE [dbo].[Albaranes]  WITH CHECK ADD  CONSTRAINT [FK_Albaranes_Clientes] FOREIGN KEY([dni_cif])
REFERENCES [dbo].[Clientes] ([dni_cif])
GO
ALTER TABLE [dbo].[Albaranes] CHECK CONSTRAINT [FK_Albaranes_Clientes]
GO
ALTER TABLE [dbo].[Albaranes]  WITH CHECK ADD  CONSTRAINT [FK_Albaranes_Facturas] FOREIGN KEY([idFactura])
REFERENCES [dbo].[Facturas] ([idFactura])
GO
ALTER TABLE [dbo].[Albaranes] CHECK CONSTRAINT [FK_Albaranes_Facturas]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([dni_cif])
REFERENCES [dbo].[Clientes] ([dni_cif])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Lineas]  WITH CHECK ADD  CONSTRAINT [FK_Lineas_Albaranes] FOREIGN KEY([idAlbaran])
REFERENCES [dbo].[Albaranes] ([idAlbaran])
GO
ALTER TABLE [dbo].[Lineas] CHECK CONSTRAINT [FK_Lineas_Albaranes]
GO
USE [master]
GO
ALTER DATABASE [gestionFacturas] SET  READ_WRITE 
GO
