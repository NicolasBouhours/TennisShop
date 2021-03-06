/****** Object:  ForeignKey [FK_COMMANDES_PRODUCTS]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_PRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES] DROP CONSTRAINT [FK_COMMANDES_PRODUCTS]
GO
/****** Object:  ForeignKey [FK_COMMANDES_USERS1]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_USERS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES] DROP CONSTRAINT [FK_COMMANDES_USERS1]
GO
/****** Object:  Table [dbo].[COMMANDES]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COMMANDES]') AND type in (N'U'))
DROP TABLE [dbo].[COMMANDES]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUCTS]') AND type in (N'U'))
DROP TABLE [dbo].[PRODUCTS]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[CATEGORIE]    Script Date: 03/29/2013 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORIE]') AND type in (N'U'))
DROP TABLE [dbo].[CATEGORIE]
GO
/****** Object:  Table [dbo].[CATEGORIE]    Script Date: 03/29/2013 11:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATEGORIE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CATEGORIE](
	[id_cat] [int] IDENTITY(1,1) NOT NULL,
	[lib_cat] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
 CONSTRAINT [PK_CATEGORIE] PRIMARY KEY CLUSTERED 
(
	[id_cat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[CATEGORIE] ON
INSERT [dbo].[CATEGORIE] ([id_cat], [lib_cat]) VALUES (0, N'Chaussures')
INSERT [dbo].[CATEGORIE] ([id_cat], [lib_cat]) VALUES (2, N'Raquettes')
INSERT [dbo].[CATEGORIE] ([id_cat], [lib_cat]) VALUES (5, N'Balles de tennis')
SET IDENTITY_INSERT [dbo].[CATEGORIE] OFF
/****** Object:  Table [dbo].[USERS]    Script Date: 03/29/2013 11:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[USERS](
	[login_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[email_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[firstname_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[lastname_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[adr_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[cp_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[ville_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[password_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[login_user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[USERS] ([login_user], [email_user], [firstname_user], [lastname_user], [adr_user], [cp_user], [ville_user], [password_user]) VALUES (N'Administrateur', N'nico', N'Bouhours', N'Nicolas', N'4 impasse lamartine', N'53960', N'Bonchamp', N'nicodu53')
INSERT [dbo].[USERS] ([login_user], [email_user], [firstname_user], [lastname_user], [adr_user], [cp_user], [ville_user], [password_user]) VALUES (N'test', N'nicodu879858', N'bouhours', N'nicolas', N'4 impasse lamartine', N'53960', N'Bonchamp', N'nicodu5')
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 03/29/2013 11:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUCTS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PRODUCTS](
	[prod_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_lib] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[prod_prix] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[prod_descrition] [nvarchar](max) COLLATE French_CI_AS NULL,
	[prod_descTech] [nvarchar](max) COLLATE French_CI_AS NULL,
	[prod_marque] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[id_cat] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PRODUCTS] ON
INSERT [dbo].[PRODUCTS] ([prod_id], [prod_lib], [prod_prix], [prod_descrition], [prod_descTech], [prod_marque], [id_cat]) VALUES (13, N'Pure Drive', N'162,00', N'Conçu pour le joueur de tennis RÉGULIER recherchant de la MANIABILITÉ. La raquette POLYVALENTE par excellence. ', N'Tamis : 645 cm².
Poids : 300 g.
Équilibre : 32 cm.
Longueur : 68,5 cm. ', N'Babolat', 2)
INSERT [dbo].[PRODUCTS] ([prod_id], [prod_lib], [prod_prix], [prod_descrition], [prod_descTech], [prod_marque], [id_cat]) VALUES (20, N'YouTek Graphene Speed S', N'179,96', N'La raquette Head Speed MP associée au cordage ouvert fait de ce cadre le premier choix des joueurs qui désirent obtenir davantage d effet.', N'Poids : 285 g
Taille du tamis : 100.0 inch²
Longueur : 68.5 cm
Équilibre : 33.0 cm
Technologie : YouTek Graphene', N'Head', 2)
INSERT [dbo].[PRODUCTS] ([prod_id], [prod_lib], [prod_prix], [prod_descrition], [prod_descTech], [prod_marque], [id_cat]) VALUES (21, N'Pure Storm', N'144,25', N'Raquette ayant un très bon compromis entre contrôle et puissance.
Raquette créé pour bon niveau et joueur de compétition ayant des gestes amples et variés ', N'Poids : 285 g
Taille de tamis : 100.0 inch²
Longueur : 68.5 cm
Équilibre : 32.5 cm
Matériaux : 100%  Graphite', N'Babolat', 2)
INSERT [dbo].[PRODUCTS] ([prod_id], [prod_lib], [prod_prix], [prod_descrition], [prod_descTech], [prod_marque], [id_cat]) VALUES (22, N'Youtek IG Radical', N'188,96', N'C est la raquette la plus polyvalente des radicales.
Elle offre le parfait mélange entre puissance et contrôle.
Idéal pour les joueurs de compétition ', N'Poids : 295 g
Taille du tamis : 98.0 inch²
Longueur : 68.5 cm
Equilibre : 32.5 cm
Technologie : YouTek-d3O/Innegra', N'Head', 2)
SET IDENTITY_INSERT [dbo].[PRODUCTS] OFF
/****** Object:  Table [dbo].[COMMANDES]    Script Date: 03/29/2013 11:01:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COMMANDES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[COMMANDES](
	[login_user] [nvarchar](50) COLLATE French_CI_AS NOT NULL,
	[prod_id] [int] NOT NULL,
	[qte_command] [int] NOT NULL
)
END
GO
/****** Object:  ForeignKey [FK_COMMANDES_PRODUCTS]    Script Date: 03/29/2013 11:01:12 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_PRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES]  WITH CHECK ADD  CONSTRAINT [FK_COMMANDES_PRODUCTS] FOREIGN KEY([prod_id])
REFERENCES [dbo].[PRODUCTS] ([prod_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_PRODUCTS]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES] CHECK CONSTRAINT [FK_COMMANDES_PRODUCTS]
GO
/****** Object:  ForeignKey [FK_COMMANDES_USERS1]    Script Date: 03/29/2013 11:01:12 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_USERS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES]  WITH CHECK ADD  CONSTRAINT [FK_COMMANDES_USERS1] FOREIGN KEY([login_user])
REFERENCES [dbo].[USERS] ([login_user])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_COMMANDES_USERS1]') AND parent_object_id = OBJECT_ID(N'[dbo].[COMMANDES]'))
ALTER TABLE [dbo].[COMMANDES] CHECK CONSTRAINT [FK_COMMANDES_USERS1]
GO
