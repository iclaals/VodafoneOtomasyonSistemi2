USE [master]
GO
/****** Object:  Database [VodafoneDb]    Script Date: 4.06.2023 11:05:52 ******/
CREATE DATABASE [VodafoneDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VodafoneDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\VodafoneDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VodafoneDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\VodafoneDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [VodafoneDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VodafoneDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VodafoneDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VodafoneDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VodafoneDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VodafoneDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VodafoneDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [VodafoneDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VodafoneDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VodafoneDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VodafoneDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VodafoneDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VodafoneDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VodafoneDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VodafoneDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VodafoneDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VodafoneDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VodafoneDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VodafoneDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VodafoneDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VodafoneDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VodafoneDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VodafoneDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VodafoneDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VodafoneDb] SET RECOVERY FULL 
GO
ALTER DATABASE [VodafoneDb] SET  MULTI_USER 
GO
ALTER DATABASE [VodafoneDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VodafoneDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VodafoneDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VodafoneDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VodafoneDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VodafoneDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VodafoneDb', N'ON'
GO
ALTER DATABASE [VodafoneDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [VodafoneDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [VodafoneDb]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 4.06.2023 11:05:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alisveris]    Script Date: 4.06.2023 11:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alisveris](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Renk] [nvarchar](max) NULL,
	[Fiyat] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Alisveris] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hats]    Script Date: 4.06.2023 11:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hats](
	[HatId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[Kimlik] [int] NOT NULL,
	[Sehir] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Hats] PRIMARY KEY CLUSTERED 
(
	[HatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 4.06.2023 11:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Logins] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modems]    Script Date: 4.06.2023 11:05:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modems](
	[ModemId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[Kimlik] [int] NOT NULL,
	[Sehir] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Modems] PRIMARY KEY CLUSTERED 
(
	[ModemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202305291734400_mig_1', N'GörselProgramlamaFinal.Migrations.Configuration', 0x1F8B0800000000000400ED5ACD6EE33610BE17E83B083AB540D6CACFA50DE45DB84EBC0D367F8892DC6969EC10A12855A452FBC5F6D2430F7DA0BE424722F56BD996623B31D0209768C4F93833FC48CE8CFCEF5F7FDB5F663E335E201234E07DF3A877681AC0DDC0A37CDA376339F9F48BF9E5F38F3FD8E79E3F331EB37127C938D4E4A26F3E49199E5A96709FC027A2E753370A4430913D37F02DE205D6F1E1E1AFD6D191050861229661D8773197D487F4011F870177219431615781074C6839BE715254E39AF82042E242DFFCFACFF74800BB8D8269447C467C32A29CB05EAA691A0346091AE5009B9806E13C9044A2C9A70F021C19057CEA842820EC7E1E028E9B102640BB725A0C6FEBD5E171E295552866506E2C64E077043C3AD161B2EAEAAF0AB699871103798E0197F3C4EB34987D13032570DDA9308DFA6CA743162523D704BB97431C184B061EE4944166257F07C63066328EA0CF21965132E2361E33EA7E83F97DF00CBCCF63C6CA96A3EDF8AE2240114E144224E77730D1FE3C4431BFF04CC3AAEA5A75E55CB5A6A71CBEE0F2E4D834AED10832669013A4141C4706117C050E1191E0DD122921C2F5BDF0200DF18205B5F9AE48F44CB2E99092B8D14CE38ACC2E814FE553F27E661A233A032F9368131E38C57D894A328A61ED2C6A37EC78963BE0CF3B9F6444E744AE5B9F32846D15645FB9057E277203F627DAFB407CB4E335BCD76A6F45FB81B773A238C19CEC7E966FD467F4B90B1F1B2C85271A6DD9D2D6ACBF0CA6948B0D88AF01F681FBB180E835E4CFF4DE8AFDC97C1CFFDB393B4322C49F41B4ED6DD09A5C0943FC0DB8A5F4F7815AA925AFE156AEF871B4FE2F8E562C5E24A1B878DA82C7C0239380C3D9387D4FA1693B6039A27784D03356BD52D00EC87AB6CE00BD2BCC51954EAF94CC5BAB81F0DA67A4094225436BB4D5D1DFA09D5F2A6B00D2CDD1EC43767434453E8F7151195AAA34CC4A486B490D695F91304412946A4A2D311C55500E3F39DDCB2B5F6158AE68A8B2726BF39970839329D4DEE2D468E98846429E1149C624A1E1D0F3178635306A4994B3091B48533FF18AF8674AC9FF4AB165D957C72C623B42777D3CBD52CF2137AF5C752EE8A6D53E41722E29D086018B7DBEAAD85B85A2CBAE32881675C0504555054389DA63A892A90CA124ED11743D5486D0A2450CDBAA2D489D05D6020D6AB75D9D5AAD88A70F99ED512E3D9CBAB3AD596D59607545540E6C636DB50A6350031874D2D6D76C19408BDA6364976819249375B0445DA3154B94686F48A6EFA2ED912CBBC3BAF36CA9E6B2F066F54739BECDB5CC3A145555D47194B43D52513694910AE9DE2C7A9E3F6C6FD975DED17DD59729AEBA3EFCFAAA2F293356E17C9C315BA6DB4296591F92CF9E679BB5ACD2D619DEFACF170B299F1A621A189C17EA25E99E331712FC5E32A0E7FCC1868CA2BFC5802BC2E9048454E5AD797C78745CFBECB13F9F202C213CD6F63BC4BB35FD6912DEB54578C742B4D2E7E72F24729F48F4934F663F97A13AF7F237422AF7EB3702AAF4E4D3F06DB123FF4E3DF09DB0A0E8CD6C14EF4AFF6523A46A8F65FDD2ADE9B074B0A57383FADDFAC13B6142BD05BCD12AD6DBBCBB5886A6F4E66D5BA71F3BF23D7764BDAFB9D8AC6AD9B25CDDAF54F94FDFF4C601BAA04CEDD4CE6CC257E226E80E6DCE957DCE266CFD125AB6419BF0B3174DF01B3648175354DB2AFF0EC73E0341A70544F2AB1C0E6E92FB15A0D9980B3E093216A25B658BB221F5BD0D9278C89C4124E984B8125FBB2044DA9F7F242CC621E7FE18BC0B7E13CB3096030CA43F6695AF1FB6B57AFEB40B5CB5D9BE099327B10D17D04C8A2EC00DFF2DA6CCCBED1E35643C4B20924DA40F33B4CA91C9A1369DE748D7016F09A4C3770621F0E428BC073F6408266EB8435EE035B63D08B8842971E759A5B11C64FD4254C36E9F5192D4DE426314FAF8881CF6FCD9E7FF001DA065188E260000, N'6.4.4')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202305291736150_mig_2', N'GörselProgramlamaFinal.Migrations.Configuration', 0x1F8B0800000000000400ED5ACB6EEB3610DD17E83F085AB540AE95C7A60DE47BE13AC96D70F34294644F4B63870845A92295DA3F76375D74D10FEA2F7424524FCBB6E44762A04136D1887338333C246746FEF7AFBFED2F539F19AF10091AF0BE79D43B340DE06EE0513EE99BB11C7FFAC5FCF2F9C71FEC73CF9F1A4FD9B893641C6A72D1379FA50C4F2D4BB8CFE013D1F3A91B052218CB9E1BF816F102EBF8F0F057EBE8C802843011CB30ECFB984BEA43FA808FC380BB10CA98B0EBC00326B41CDF3829AA71437C102171A16F7EFDE77B2480DD45C124223E233EB9A09CB05EAA691A0346091AE5001B9B06E13C9044A2C9A78F021C19057CE2842820EC6116028E1B132640BB725A0C6FEBD5E171E295552866506E2C64E077043C3AD161B2EAEA6B05DBCCC388813CC780CB59E2751ACCBE898112B8EE5498467DB6D3218B92912B82DDCB210E8C05030F72CA20B392BF036318331947D0E710CB281971178F1875BFC1EC217801DEE7316365CBD1767C5711A008270A2192B37B186B7F1EA3985F7AA6615575ADBA72AE5AD3530E5F7279726C1A3768041931C809520A8E238308BE02878848F0EE889410E1FA5E7A908678CE82DA7CD7247A21D9744849DC68A6714DA657C027F239793F358D0B3A052F9368131E39C57D894A328A61E52C6A37EC78967BE02F3B9FE482CE885CB53E6508DB2AC8BE740BFC4EE406EC4FB4F781F868C73ABCD76A6F45FB81B773A238C18CEC7E966FD467F4A50B1F1B2C85671A6DD9D2D6ACBF0A2694AF4FFB547D1F781F0B88D6217EA6F756CC4FE6E3F8DFCE99191221FE0CA26D6F81D6C44AF8E16F70A02AFD7DA0566AC93ADCCA153F8ED5FFC5B18A858B2414174F5BF01478641C70381BA5EF29346D072C45F48E107AC6AA570ADA0159CFD419A0778539AACAE99512796B39105EF98C3441A8446885767AF08B066D7DA1AC504FB746B307D9C1D114F73CC2454D68A9A2302B1EAD05D5A37D4DC2102950AA26B5C470542939FCE4742FAC7C8561B9A2A1BECAADCD67C2ED4D26507B8B53A3A5173412F28C4832220909879E3F37AC814F0BA29C4DD84099FA7957C43F534AFE578A2D0BBE3A6611DB0B74D7C7B32BF51C72F3CAF5E69C6E5AE713A4E682D26C18B0D8E7CBCABC6528BAE02A836851070C554E553094A83D862A96CA104AD21E41574265082D9AC7B0ADDA82D45960CDD1A076D7D5A9D58A78FA88D91EE5D2A3A93BDB9AD5160556D742E5C0365655CB3006358041276D7DC99601B4A83D46768596413259074BD4255AB14489F68664FA26DA1EC9D40DD69D650BF4168536AB3CCAB16DAE6256A1A87AA28EA3A4ED918A82A18C5448F766C1F3DC617B4BAE738EEE6BBE4871D9D5E1D7577D4181B10CE7E37CD932DDE632CCFA907CF63CD3AC6594B6CEEE567FB4984BF7D410D3C0E0BC522F49F59C9990E0F792013DE70F366414FD2D065C134EC720A42A6CCDE3C3A3E3DAC78EFDF9F06009E1B1B65F1FDEADD54F93F0AE2CBF3B96A095EE3E7F2591FB4CA29F7C32FDB90CD5B983BF1152B94BBF1150A5139F866F8B7DF877EA7CEF8405455766A378573A2F1B2155BB2BAB976E456FA5832D1DDBD2EFD607DE090FEAADDF8DD6B0DEDEDDC5223425376FDB32FDD88FEFB91FEBFDCCF93655CB56E5F23EA5CA7EFAA6370AD005656AA7366613BE123741B76F6F2EEE6E36E1661DD1369DCF268BB3174DD81BF644E73353DB2AFFE8C63E0341270544F2131C0E6E92F215A0D9984B3E0E32FAA15B658BB221F54D0D927848994124E998B8125FBB2044DA907F222CC621E7FE08BC4B7E1BCB30960321C01FB1CAE70EDB5A3E7FDAF8ADDA6CDF86C993D8860B68264517E096FF1653E6E5765F34243A0B2092DDA34F31B4CA91C9693699E54837016F09A4C3770621F0E40C7C003F6408266EB9435E611DDB1E055CC184B8B3ACC0580CB27A21AA61B7CF28494A6EA1310A7D7C440E7BFEF4F37FDCC5E02F7B260000, N'6.4.4')
GO
SET IDENTITY_INSERT [dbo].[Alisveris] ON 

INSERT [dbo].[Alisveris] ([UrunId], [Marka], [Model], [Renk], [Fiyat]) VALUES (2, N'Samsung', N'S3 Mini', N'Lacivert', 1000)
INSERT [dbo].[Alisveris] ([UrunId], [Marka], [Model], [Renk], [Fiyat]) VALUES (3, N'Xiaomi', N'Redmi Note 10 Pro', N'Mavi', 9200)
INSERT [dbo].[Alisveris] ([UrunId], [Marka], [Model], [Renk], [Fiyat]) VALUES (5, N'Iphone', N'14 Pro Max', N'Lila', 40000)
INSERT [dbo].[Alisveris] ([UrunId], [Marka], [Model], [Renk], [Fiyat]) VALUES (11, N'Samsung', N'Note4', N'Mor', 3500)
SET IDENTITY_INSERT [dbo].[Alisveris] OFF
GO
SET IDENTITY_INSERT [dbo].[Hats] ON 

INSERT [dbo].[Hats] ([HatId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (1, N'Eren', N'Aydinç', 54655, N'Trabzon')
INSERT [dbo].[Hats] ([HatId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (7, N'Seda', N'Özkan', 64546, N'Adana')
SET IDENTITY_INSERT [dbo].[Hats] OFF
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 

INSERT [dbo].[Logins] ([userId], [username], [password]) VALUES (1, N'iclal', N'12345')
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[Modems] ON 

INSERT [dbo].[Modems] ([ModemId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (1, N'Rümeysa', N'Musaoğlu', 545656, N'Trabzon')
INSERT [dbo].[Modems] ([ModemId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (2, N'Umut', N'Çavuşoğlu', 654564, N'Siirt')
INSERT [dbo].[Modems] ([ModemId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (3, N'Buket', N'İnanç', 654564, N'İstanbul')
INSERT [dbo].[Modems] ([ModemId], [Ad], [Soyad], [Kimlik], [Sehir]) VALUES (5, N'Nisan', N'Hakan', 5455, N'Balıkesir')
SET IDENTITY_INSERT [dbo].[Modems] OFF
GO
USE [master]
GO
ALTER DATABASE [VodafoneDb] SET  READ_WRITE 
GO
