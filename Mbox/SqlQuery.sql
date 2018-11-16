select 
	p.Name, c.Name 
from Product p
left join ProductToCategory ptc on ptc.ProductId = p.Id
left join Category c on c.Id = ptc.CategoryId



-- Migrations
CREATE TABLE [dbo].[Category](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_[Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Product](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductToCategory](
	[ProductId] [uniqueidentifier] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ProductToCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'a8cc7c25-004e-47c5-85cf-11889760a460', N'Ягоды')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'997bf3e8-8579-4efd-9890-41924d88c659', N'Фрукты')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'c531be56-4b14-44a2-8ae7-4f6f818cd3da', N'18+')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'af6e85d7-f068-48a9-91ca-65ec0cfbdbb4', N'Алкоголь')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'993c4eaf-9a47-4965-9d4c-8d3640380f76', N'Детям')
GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (N'b1c613f8-9aeb-4bfb-92dc-a5e7eed96112', N'Табак')
GO
INSERT [dbo].[Product] ([Id], [Name]) VALUES (N'58153079-5d12-4d6d-af81-2c833697928f', N'Пиво')
GO
INSERT [dbo].[Product] ([Id], [Name]) VALUES (N'f4b76d81-377f-4861-a1f9-3c11ddcf5ead', N'Зарин')
GO
INSERT [dbo].[Product] ([Id], [Name]) VALUES (N'5c5847ff-5dc7-475c-8094-72fe761bb66f', N'Арбуз')
GO
INSERT [dbo].[ProductToCategory] ([ProductId], [CategoryId], [Id]) VALUES (N'58153079-5d12-4d6d-af81-2c833697928f', N'af6e85d7-f068-48a9-91ca-65ec0cfbdbb4', N'841a155c-ce4a-4161-bd62-2547b969abb4')
GO
INSERT [dbo].[ProductToCategory] ([ProductId], [CategoryId], [Id]) VALUES (N'58153079-5d12-4d6d-af81-2c833697928f', N'c531be56-4b14-44a2-8ae7-4f6f818cd3da', N'eab6705b-30dc-4697-afbc-34353a9a9235')
GO
INSERT [dbo].[ProductToCategory] ([ProductId], [CategoryId], [Id]) VALUES (N'f4b76d81-377f-4861-a1f9-3c11ddcf5ead', N'993c4eaf-9a47-4965-9d4c-8d3640380f76', N'28b80bb0-e93a-4bde-8385-882f2a3ea3d2')
GO
ALTER TABLE [dbo].[ProductToCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProductToCategory_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductToCategory] CHECK CONSTRAINT [FK_ProductToCategory_Category]
GO
ALTER TABLE [dbo].[ProductToCategory]  WITH CHECK ADD  CONSTRAINT [FK_ProductToCategory_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductToCategory] CHECK CONSTRAINT [FK_ProductToCategory_Product]
GO



