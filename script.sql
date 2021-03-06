USE [STOK_TAKIP]
GO
/****** Object:  Table [dbo].[tbl_Birim]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Birim](
	[birim_id] [int] IDENTITY(1,1) NOT NULL,
	[birim_ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Birim] PRIMARY KEY CLUSTERED 
(
	[birim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Depo]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Depo](
	[depo_id] [int] IDENTITY(1,1) NOT NULL,
	[depo_ad] [nvarchar](50) NULL,
	[depo_yer] [nvarchar](50) NULL,
	[depo_adres] [nvarchar](50) NULL,
	[depo_sorumlusu] [nvarchar](50) NULL,
	[depo_telefon] [nvarchar](50) NULL,
 CONSTRAINT [PK_Depo] PRIMARY KEY CLUSTERED 
(
	[depo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Firma]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Firma](
	[firma_id] [int] IDENTITY(1,1) NOT NULL,
	[firma_ad] [nvarchar](50) NOT NULL,
	[firma_adres] [nvarchar](50) NOT NULL,
	[firma_telefon] [nvarchar](11) NOT NULL,
	[vergi_dairesi] [nvarchar](50) NOT NULL,
	[hesap_no] [nvarchar](50) NOT NULL,
	[firma_aciklama] [nvarchar](50) NOT NULL,
	[firma_resmi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Kategori]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kategori](
	[kategori_id] [int] IDENTITY(1,1) NOT NULL,
	[kategori_ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Kategori] PRIMARY KEY CLUSTERED 
(
	[kategori_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Kullanici]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kullanici](
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
	[tc_no] [nvarchar](11) NOT NULL,
	[ad] [nvarchar](30) NOT NULL,
	[soyad] [nvarchar](30) NOT NULL,
	[kullanici_ad] [nvarchar](50) NOT NULL,
	[kullanici_sifre] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](11) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[dogum_tarih] [date] NOT NULL,
	[cinsiyet] [nvarchar](5) NOT NULL,
	[resim] [nvarchar](200) NULL,
	[hesap_durum] [nvarchar](10) NOT NULL,
	[tema] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Kullanici] UNIQUE NONCLUSTERED 
(
	[tc_no] ASC,
	[kullanici_ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Stok]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Stok](
	[stok_id] [int] IDENTITY(1,1) NOT NULL,
	[urun_kod] [nvarchar](50) NOT NULL,
	[urun_ad] [nvarchar](50) NOT NULL,
	[urun_miktar] [int] NOT NULL,
	[kategori_id] [int] NOT NULL,
	[firma_id] [int] NOT NULL,
	[birim_id] [int] NOT NULL,
	[birim_miktar] [int] NOT NULL,
	[birim_fiyat] [money] NULL,
	[depo_id] [int] NOT NULL,
	[resim] [nvarchar](200) NULL,
	[alis_tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[stok_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Stok_Satis]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Stok_Satis](
	[stok_satis_id] [int] IDENTITY(1,1) NOT NULL,
	[stok_id] [int] NOT NULL,
	[firma_id] [int] NOT NULL,
	[depo_id] [int] NOT NULL,
	[miktar] [int] NOT NULL,
	[net_fiyat] [money] NULL,
	[kdv] [int] NULL,
	[otv] [int] NULL,
	[brut_fiyat] [money] NULL,
	[satis_tarih] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[stok_satis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Transfer]    Script Date: 30.01.2022 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Transfer](
	[transfer_id] [int] IDENTITY(1,1) NOT NULL,
	[stok_id] [int] NULL,
	[miktar] [int] NULL,
	[gidicegi_tarih] [date] NULL,
	[bulundugu_depo_id] [int] NULL,
	[gidecegi_depo_id] [int] NULL,
 CONSTRAINT [PK_tbl_Transfer] PRIMARY KEY CLUSTERED 
(
	[transfer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
