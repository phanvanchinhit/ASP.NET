CREATE DATABASE [WineStore]
GO
USE [WineStore]
GO
--Tạo bảng Catalogy
CREATE TABLE [dbo].[Catalogy](
[CatalogyID] [nchar](10) NOT NULL,
[CatalogyName] [nvarchar](50) NOT NULL,
[Description] [nvarchar](100) NULL,
CONSTRAINT [PK_Catalogies] PRIMARY KEY CLUSTERED
(
[CatalogyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
--Tạo bảng Product
CREATE TABLE [dbo].[Product](
[ProductID] [int] NOT NULL,
[ProductName] [nvarchar](50) NOT NULL,
[Description] [text] NULL,
[PurchasePrice] [numeric](8, 2) NOT NULL,
[Price] [numeric](8, 2) NOT NULL,
[Quantity] [int] NOT NULL,
[Vintage] [nchar](20) NULL,
[CatalogyID] [nchar](10) NOT NULL,
[Image] [text] NULL,
[Region] [nvarchar](100) NOT NULL,
CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED
(
[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
--Tạo các khóa ngoài
ALTER TABLE [dbo].[Product] WITH CHECK ADD CONSTRAINT [FK_Products_Catalogy] FOREIGN
KEY([CatalogyID])
REFERENCES [dbo].[Catalogy] ([CatalogyID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Products_Catalogy]
GO