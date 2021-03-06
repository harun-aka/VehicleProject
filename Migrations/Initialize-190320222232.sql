SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColorId] [int] NULL,
 CONSTRAINT [PK_Boats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON  ) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColorId] [int] NULL,
 CONSTRAINT [PK_Buses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON  ) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Wheel] [int] NOT NULL,
	[Headlights] [bit] NOT NULL,
	[ColorId] [int] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON  ) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON  ) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Boats] ON 

INSERT [dbo].[Boats] ([Id], [ColorId]) VALUES (1, NULL)
INSERT [dbo].[Boats] ([Id], [ColorId]) VALUES (2, 1)
INSERT [dbo].[Boats] ([Id], [ColorId]) VALUES (3, 2)
INSERT [dbo].[Boats] ([Id], [ColorId]) VALUES (4, 3)
INSERT [dbo].[Boats] ([Id], [ColorId]) VALUES (5, 4)
SET IDENTITY_INSERT [dbo].[Boats] OFF
GO
SET IDENTITY_INSERT [dbo].[Buses] ON 

INSERT [dbo].[Buses] ([Id], [ColorId]) VALUES (1, NULL)
INSERT [dbo].[Buses] ([Id], [ColorId]) VALUES (2, 1)
INSERT [dbo].[Buses] ([Id], [ColorId]) VALUES (3, 2)
INSERT [dbo].[Buses] ([Id], [ColorId]) VALUES (4, 3)
INSERT [dbo].[Buses] ([Id], [ColorId]) VALUES (5, 4)
SET IDENTITY_INSERT [dbo].[Buses] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (1, 4, 1, 1)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (2, 4, 0, 1)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (3, 4, 1, 2)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (4, 4, 0, 2)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (5, 4, 1, 3)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (6, 4, 0, 3)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (7, 4, 1, 4)
INSERT [dbo].[Cars] ([Id], [Wheel], [Headlights], [ColorId]) VALUES (9, 4, 0, 4)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 

INSERT [dbo].[Colors] ([Id], [Name]) VALUES (1, N'Black')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (2, N'Blue')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (3, N'Red')
INSERT [dbo].[Colors] ([Id], [Name]) VALUES (4, N'White')
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
ALTER TABLE [dbo].[Boats]  WITH CHECK ADD  CONSTRAINT [FK_Boats_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Boats] CHECK CONSTRAINT [FK_Boats_Colors]
GO
ALTER TABLE [dbo].[Buses]  WITH CHECK ADD  CONSTRAINT [FK_Buses_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Buses] CHECK CONSTRAINT [FK_Buses_Colors]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Colors] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Colors]
GO
USE [master]
GO
ALTER DATABASE [VehicleProject] SET  READ_WRITE 
GO
