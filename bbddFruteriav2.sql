USE [master]
GO
/****** Object:  Database [gestionFacturas]    Script Date: 08/03/2018 20:44:33 ******/
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
/****** Object:  StoredProcedure [dbo].[ListarAlbaran]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 01/01/2018
-- Description:	Listado de las Lineas de los Productos del Albaran
-- =============================================
CREATE PROCEDURE [dbo].[ListarAlbaran] 
	-- Add the parameters for the stored procedure here
	@idAlbaran int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ln.cantidad AS 'CANTIDAD', ln.unidad AS 'UNIDAD', ln.descripcion_producto AS 'PRODUCTO/DESCRIPCION', ln.precio_unitario AS 'PRECIO', ln.importe AS 'IMPORTE'
	FROM Albaranes al JOIN Lineas ln
	ON al.idAlbaran = ln.idAlbaran
	WHERE al.idAlbaran = @idAlbaran;

	SELECT subtotal AS 'SUBTOTAL', total AS 'TOTAL' 
	FROM Albaranes
	WHERE idAlbaran = @idAlbaran;

	SELECT cl.dni_cif AS 'DNI / CIF', cl.nombre AS 'NOMBRE', cl.domicilio AS 'DOMICILIO',  cl.poblacion AS 'POBLACION'
	FROM Albaranes al JOIN Clientes cl
	ON al.dni_cif = cl.dni_cif
	WHERE al.idAlbaran = @idAlbaran;


END

GO
/****** Object:  StoredProcedure [dbo].[ListarAlbaranCliente]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 01/01/2018
-- Description:	Listo el Cliente del Albaran pasado por Parametros
-- =============================================
CREATE PROCEDURE [dbo].[ListarAlbaranCliente] 
	-- Add the parameters for the stored procedure here
	@idAlbaran int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cl.dni_cif AS 'DNI / CIF', cl.nombre AS 'NOMBRE', cl.domicilio AS 'DOMICILIO',  cl.poblacion AS 'POBLACION'
	FROM Albaranes al JOIN Clientes cl
	ON al.dni_cif = cl.dni_cif
	WHERE al.idAlbaran = @idAlbaran; 
END

GO
/****** Object:  StoredProcedure [dbo].[ListarAlbaranTotal]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 01/01/2018
-- Description:	Listo el Subtotal y Total de el idAlbaran pasado por Parametros
-- =============================================
CREATE PROCEDURE [dbo].[ListarAlbaranTotal] 
	-- Add the parameters for the stored procedure here
	@idAlbaran int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT subtotal AS 'SUBTOTAL', total AS 'TOTAL' 
	FROM Albaranes
	WHERE idAlbaran = @idAlbaran;
END

GO
/****** Object:  StoredProcedure [dbo].[ListarClientes]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 31-12-2017
-- Description:	Listo los clientes de la BBDD
-- =============================================
CREATE PROCEDURE [dbo].[ListarClientes] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT dni_cif AS 'DNI/CIF',
		   UPPER(nombre) AS 'NOMBRE CLIENTE',
		   domicilio AS 'DOMICILIO',
		   poblacion AS 'POBLACION' FROM Clientes;
END

GO
/****** Object:  StoredProcedure [dbo].[ListarFactura]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 04/01/2018
-- Description:	Listar los Albaranes de la Factura pasada como parametros
-- =============================================
CREATE PROCEDURE [dbo].[ListarFactura] 
	-- Add the parameters for the stored procedure here
	@idFactura int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT al.fechaAlbaran AS 'FECHA ALBARAN', al.subtotal AS 'SUBTOTAL', al.total AS 'TOTAL'
	FROM Facturas fa JOIN Albaranes al
	ON fa.idFactura = al.idFactura
	WHERE  fa.idFactura = @idFactura;
END

GO
/****** Object:  StoredProcedure [dbo].[ListarFacturaCliente]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 04/01/2018
-- Description:	Consulta que saca el Cliente del Albaran pasado por Parametros
-- =============================================
CREATE PROCEDURE [dbo].[ListarFacturaCliente] 
	-- Add the parameters for the stored procedure here
	@idFactura int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cl.dni_cif AS 'DNI / CIF', cl.nombre AS 'NOMBRE', cl.domicilio AS 'DOMICILIO',  cl.poblacion AS 'POBLACION'
	FROM Facturas fa JOIN Clientes cl
	ON fa.dni_cif = cl.dni_cif
	WHERE fa.idFactura = @idFactura; 
END

GO
/****** Object:  StoredProcedure [dbo].[ListarFacturaTotal]    Script Date: 08/03/2018 20:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Rafa
-- Create date: 04/01/2018
-- Description:	Mostrar el Subtotal y el Total de la Factura
-- =============================================
CREATE PROCEDURE [dbo].[ListarFacturaTotal] 
	-- Add the parameters for the stored procedure here
	@idFactura int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT subtotal AS 'SUBTOTAL', total AS 'TOTAL'
	FROM Facturas
	WHERE idFactura = @idFactura;
END

GO
/****** Object:  Table [dbo].[Albaranes]    Script Date: 08/03/2018 20:44:33 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 08/03/2018 20:44:33 ******/
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 08/03/2018 20:44:33 ******/
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
/****** Object:  Table [dbo].[Lineas]    Script Date: 08/03/2018 20:44:33 ******/
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
