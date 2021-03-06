USE [master]
GO
/****** Object:  Database [Banco]    Script Date: 06/02/2018 14:57:27 ******/
CREATE DATABASE [Banco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Banco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Banco.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Banco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Banco_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Banco] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Banco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Banco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Banco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Banco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Banco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Banco] SET ARITHABORT OFF 
GO
ALTER DATABASE [Banco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Banco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Banco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Banco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Banco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Banco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Banco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Banco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Banco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Banco] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Banco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Banco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Banco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Banco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Banco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Banco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Banco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Banco] SET RECOVERY FULL 
GO
ALTER DATABASE [Banco] SET  MULTI_USER 
GO
ALTER DATABASE [Banco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Banco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Banco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Banco] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Banco] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Banco', N'ON'
GO
USE [Banco]
GO
/****** Object:  Table [dbo].[Agencia]    Script Date: 06/02/2018 14:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Endereço] [nvarchar](50) NULL,
	[Acesso] [int] NULL,
 CONSTRAINT [PK_Agencia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 06/02/2018 14:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](15) NULL,
	[Sobrenome] [nvarchar](15) NULL,
	[CPF] [nchar](11) NULL,
	[CEP] [nchar](8) NULL,
	[Senha] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Conta]    Script Date: 06/02/2018 14:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](15) NULL,
	[Saldo] [int] NULL,
	[Id_cliente] [int] NOT NULL,
	[Id_agencia] [int] NOT NULL,
 CONSTRAINT [PK_Conta_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 06/02/2018 14:57:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferencias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_env] [int] NULL,
	[Id_rec] [int] NULL,
	[Quantia] [int] NULL,
 CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Agencia] ON 

INSERT [dbo].[Agencia] ([Id], [Endereço], [Acesso]) VALUES (1, NULL, 0)
INSERT [dbo].[Agencia] ([Id], [Endereço], [Acesso]) VALUES (2, N'Estrada dos Tres Rios', 34334)
SET IDENTITY_INSERT [dbo].[Agencia] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nome], [Sobrenome], [CPF], [CEP], [Senha]) VALUES (1, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Cliente] ([Id], [Nome], [Sobrenome], [CPF], [CEP], [Senha]) VALUES (2, N'Miguel ', N'Amoedo', N'12345678900', N'12345678', 2781)
INSERT [dbo].[Cliente] ([Id], [Nome], [Sobrenome], [CPF], [CEP], [Senha]) VALUES (3, N'Arthur', N'Olibeiras', N'98765432100', N'98765432', 236)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Conta] ON 

INSERT [dbo].[Conta] ([Id], [Tipo], [Saldo], [Id_cliente], [Id_agencia]) VALUES (1, NULL, NULL, 1, 1)
INSERT [dbo].[Conta] ([Id], [Tipo], [Saldo], [Id_cliente], [Id_agencia]) VALUES (3, N'Conta Corrente', 80, 2, 1)
INSERT [dbo].[Conta] ([Id], [Tipo], [Saldo], [Id_cliente], [Id_agencia]) VALUES (4, N'Conta Poupança', 10000000, 3, 2)
SET IDENTITY_INSERT [dbo].[Conta] OFF
SET IDENTITY_INSERT [dbo].[Transferencias] ON 

INSERT [dbo].[Transferencias] ([Id], [Id_env], [Id_rec], [Quantia]) VALUES (1, 3, 3, 90)
INSERT [dbo].[Transferencias] ([Id], [Id_env], [Id_rec], [Quantia]) VALUES (2, 3, 1, 10)
INSERT [dbo].[Transferencias] ([Id], [Id_env], [Id_rec], [Quantia]) VALUES (3, 4, 4, 10000000)
SET IDENTITY_INSERT [dbo].[Transferencias] OFF
ALTER TABLE [dbo].[Conta]  WITH CHECK ADD  CONSTRAINT [FK_Conta_Agencia] FOREIGN KEY([Id_agencia])
REFERENCES [dbo].[Agencia] ([Id])
GO
ALTER TABLE [dbo].[Conta] CHECK CONSTRAINT [FK_Conta_Agencia]
GO
ALTER TABLE [dbo].[Conta]  WITH CHECK ADD  CONSTRAINT [FK_Conta_Cliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Conta] CHECK CONSTRAINT [FK_Conta_Cliente]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Conta] FOREIGN KEY([Id_env])
REFERENCES [dbo].[Conta] ([Id])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Conta]
GO
ALTER TABLE [dbo].[Transferencias]  WITH CHECK ADD  CONSTRAINT [FK_Transferencias_Conta1] FOREIGN KEY([Id_rec])
REFERENCES [dbo].[Conta] ([Id])
GO
ALTER TABLE [dbo].[Transferencias] CHECK CONSTRAINT [FK_Transferencias_Conta1]
GO
USE [master]
GO
ALTER DATABASE [Banco] SET  READ_WRITE 
GO
