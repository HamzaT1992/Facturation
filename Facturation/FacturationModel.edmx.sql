create database [Facturation];
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/26/2018 13:21:39
-- Generated from EDMX file: C:\Users\assus025\Desktop\Facturation\Facturation\FacturationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Facturation];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_Eaux_dbo_Etats_Etat_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eaux] DROP CONSTRAINT [FK_dbo_Eaux_dbo_Etats_Etat_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Eaux_dbo_TypeEaux_TypeEau_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eaux] DROP CONSTRAINT [FK_dbo_Eaux_dbo_TypeEaux_TypeEau_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Electricites_dbo_Etats_Etat_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Electricites] DROP CONSTRAINT [FK_dbo_Electricites_dbo_Etats_Etat_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Electricites_dbo_TypeElectricites_TypeElec_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Electricites] DROP CONSTRAINT [FK_dbo_Electricites_dbo_TypeElectricites_TypeElec_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_RelveeEaux_dbo_Eaux_Eau_NPolice_Eau_Adresse_Eau_Date_Eau_Tel_Eau_NCompteur_Eau_Reference]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RelveeEaux] DROP CONSTRAINT [FK_dbo_RelveeEaux_dbo_Eaux_Eau_NPolice_Eau_Adresse_Eau_Date_Eau_Tel_Eau_NCompteur_Eau_Reference];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_RelveeElecs_dbo_Electricites_Elec_NPolice_Elec_Adresse_Elec_Date_Elec_Tel_Elec_NCompteur_Elec_Reference]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RelveeElecs] DROP CONSTRAINT [FK_dbo_RelveeElecs_dbo_Electricites_Elec_NPolice_Elec_Adresse_Elec_Date_Elec_Tel_Elec_NCompteur_Elec_Reference];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_TeleCommunications_dbo_Etats_Etat_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeleCommunications] DROP CONSTRAINT [FK_dbo_TeleCommunications_dbo_Etats_Etat_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeleCommunications] DROP CONSTRAINT [FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Eaux]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eaux];
GO
IF OBJECT_ID(N'[dbo].[Electricites]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Electricites];
GO
IF OBJECT_ID(N'[dbo].[Etats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Etats];
GO
IF OBJECT_ID(N'[dbo].[RelveeEaux]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RelveeEaux];
GO
IF OBJECT_ID(N'[dbo].[RelveeElecs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RelveeElecs];
GO
IF OBJECT_ID(N'[dbo].[TeleCommunications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeleCommunications];
GO
IF OBJECT_ID(N'[dbo].[TypeEaux]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeEaux];
GO
IF OBJECT_ID(N'[dbo].[TypeElectricites]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeElectricites];
GO
IF OBJECT_ID(N'[dbo].[TypeTelecommunications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeTelecommunications];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Eaux'
CREATE TABLE [dbo].[Eaux] (
    [NPolice] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(100)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Tel] nvarchar(20)  NOT NULL,
    [NCompteur] nvarchar(50)  NOT NULL,
    [Reference] nvarchar(50)  NOT NULL,
    [Annee] smallint  NOT NULL,
    [Etat_id] int  NULL,
    [TypeEau_id] int  NULL
);
GO

-- Creating table 'Electricites'
CREATE TABLE [dbo].[Electricites] (
    [NPolice] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(100)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Tel] nvarchar(20)  NOT NULL,
    [NCompteur] nvarchar(50)  NOT NULL,
    [Reference] nvarchar(50)  NOT NULL,
    [Annee] smallint  NOT NULL,
    [Etat_id] int  NULL,
    [TypeElec_id] int  NULL
);
GO

-- Creating table 'Etats'
CREATE TABLE [dbo].[Etats] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NomEtat] nvarchar(max)  NULL
);
GO

-- Creating table 'RelveeEaux'
CREATE TABLE [dbo].[RelveeEaux] (
    [Id] int  NOT NULL,
    [Annee] smallint  NOT NULL,
    [Trimestre] int  NOT NULL,
    [NIndex] int  NOT NULL,
    [PIndex] int  NOT NULL,
    [NPayer] float  NOT NULL,
    [Eau_NPolice] nvarchar(50)  NULL,
    [Eau_Adresse] nvarchar(100)  NULL,
    [Eau_Date] datetime  NULL,
    [Eau_Tel] nvarchar(20)  NULL,
    [Eau_NCompteur] nvarchar(50)  NULL,
    [Eau_Reference] nvarchar(50)  NULL,
    [Rapport] nvarchar(255)  NULL
);
GO

-- Creating table 'RelveeTeleCom'
CREATE TABLE [dbo].[RelveeTeleCom] (
    [Id] int  NOT NULL primary key,
    [Mois] smallint  NOT NULL,
    [NPayer] float  NOT NULL,
    [TeleCom_NPolice] nvarchar(50)  NULL,
    [TeleCom_Adresse] nvarchar(100)  NULL,
    [TeleCom_Date] datetime  NULL,
    [TeleCom_Tel] nvarchar(20)  NULL,
    [TeleCom_MD] nvarchar(50)  NULL,
    [TeleCom_Reference] nvarchar(50)  NULL,
    [Rapport] nvarchar(255)  NULL
);
GO

-- Creating table 'RelveeElecs'
CREATE TABLE [dbo].[RelveeElecs] (
    [Id] int  NOT NULL,
    [Annee] smallint  NOT NULL,
    [Trimestre] int  NOT NULL,
    [NIndex] int  NOT NULL,
    [PIndex] int  NOT NULL,
    [NPayer] float  NOT NULL,
    [Elec_NPolice] nvarchar(50)  NULL,
    [Elec_Adresse] nvarchar(100)  NULL,
    [Elec_Date] datetime  NULL,
    [Elec_Tel] nvarchar(20)  NULL,
    [Elec_NCompteur] nvarchar(50)  NULL,
    [Elec_Reference] nvarchar(50)  NULL,
    [Rapport] nvarchar(255)  NULL
);
GO

-- Creating table 'TeleCommunications'
CREATE TABLE [dbo].[TeleCommunications] (
    [NPolice] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(100)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Tel] nvarchar(20)  NOT NULL,
    [MD] nvarchar(50)  NOT NULL,
    [Forfait] int  NOT NULL,
    [Montant] float  NOT NULL,
    [Etat_id] int  NULL,
    [TypeTelecom_id] int  NULL
);
GO

-- Creating table 'TypeEaux'
CREATE TABLE [dbo].[TypeEaux] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NomTypeEau] nvarchar(max)  NULL
);
GO

-- Creating table 'TypeElectricites'
CREATE TABLE [dbo].[TypeElectricites] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NomTypeElec] nvarchar(max)  NULL
);
GO

-- Creating table 'TypeTelecommunications'
CREATE TABLE [dbo].[TypeTelecommunications] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NomTypeTelecommunication] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference] in table 'Eaux'
ALTER TABLE [dbo].[Eaux]
ADD CONSTRAINT [PK_Eaux]
    PRIMARY KEY CLUSTERED ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference] ASC);
GO

-- Creating primary key on [NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference] in table 'Electricites'
ALTER TABLE [dbo].[Electricites]
ADD CONSTRAINT [PK_Electricites]
    PRIMARY KEY CLUSTERED ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference] ASC);
GO

-- Creating primary key on [id] in table 'Etats'
ALTER TABLE [dbo].[Etats]
ADD CONSTRAINT [PK_Etats]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id], [Annee], [Trimestre] in table 'RelveeEaux'
ALTER TABLE [dbo].[RelveeEaux]
ADD CONSTRAINT [PK_RelveeEaux]
    PRIMARY KEY CLUSTERED ([Id], [Annee], [Trimestre] ASC);
GO

-- Creating primary key on [Id], [Annee], [Trimestre] in table 'RelveeElecs'
ALTER TABLE [dbo].[RelveeElecs]
ADD CONSTRAINT [PK_RelveeElecs]
    PRIMARY KEY CLUSTERED ([Id], [Annee], [Trimestre] ASC);
GO

-- Creating primary key on [NPolice], [Adresse], [Date], [Tel], [MD] in table 'TeleCommunications'
ALTER TABLE [dbo].[TeleCommunications]
ADD CONSTRAINT [PK_TeleCommunications]
    PRIMARY KEY CLUSTERED ([NPolice], [Adresse], [Date], [Tel], [MD] ASC);
GO

-- Creating primary key on [id] in table 'TypeEaux'
ALTER TABLE [dbo].[TypeEaux]
ADD CONSTRAINT [PK_TypeEaux]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TypeElectricites'
ALTER TABLE [dbo].[TypeElectricites]
ADD CONSTRAINT [PK_TypeElectricites]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TypeTelecommunications'
ALTER TABLE [dbo].[TypeTelecommunications]
ADD CONSTRAINT [PK_TypeTelecommunications]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Etat_id] in table 'Eaux'
ALTER TABLE [dbo].[Eaux]
ADD CONSTRAINT [FK_dbo_Eaux_dbo_Etats_Etat_id]
    FOREIGN KEY ([Etat_id])
    REFERENCES [dbo].[Etats]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Eaux_dbo_Etats_Etat_id'
CREATE INDEX [IX_FK_dbo_Eaux_dbo_Etats_Etat_id]
ON [dbo].[Eaux]
    ([Etat_id]);
GO

-- Creating foreign key on [TypeEau_id] in table 'Eaux'
ALTER TABLE [dbo].[Eaux]
ADD CONSTRAINT [FK_dbo_Eaux_dbo_TypeEaux_TypeEau_id]
    FOREIGN KEY ([TypeEau_id])
    REFERENCES [dbo].[TypeEaux]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Eaux_dbo_TypeEaux_TypeEau_id'
CREATE INDEX [IX_FK_dbo_Eaux_dbo_TypeEaux_TypeEau_id]
ON [dbo].[Eaux]
    ([TypeEau_id]);
GO

-- Creating foreign key on [Eau_NPolice], [Eau_Adresse], [Eau_Date], [Eau_Tel], [Eau_NCompteur], [Eau_Reference] in table 'RelveeEaux'
ALTER TABLE [dbo].[RelveeEaux]
ADD CONSTRAINT [FK_dbo_RelveeEaux_dbo_Eaux_Eau_NPolice_Eau_Adresse_Eau_Date_Eau_Tel_Eau_NCompteur_Eau_Reference]
    FOREIGN KEY ([Eau_NPolice], [Eau_Adresse], [Eau_Date], [Eau_Tel], [Eau_NCompteur], [Eau_Reference])
    REFERENCES [dbo].[Eaux]
        ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_RelveeEaux_dbo_Eaux_Eau_NPolice_Eau_Adresse_Eau_Date_Eau_Tel_Eau_NCompteur_Eau_Reference'
CREATE INDEX [IX_FK_dbo_RelveeEaux_dbo_Eaux_Eau_NPolice_Eau_Adresse_Eau_Date_Eau_Tel_Eau_NCompteur_Eau_Reference]
ON [dbo].[RelveeEaux]
    ([Eau_NPolice], [Eau_Adresse], [Eau_Date], [Eau_Tel], [Eau_NCompteur], [Eau_Reference]);
GO

-- Creating foreign key on [Etat_id] in table 'Electricites'
ALTER TABLE [dbo].[Electricites]
ADD CONSTRAINT [FK_dbo_Electricites_dbo_Etats_Etat_id]
    FOREIGN KEY ([Etat_id])
    REFERENCES [dbo].[Etats]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Electricites_dbo_Etats_Etat_id'
CREATE INDEX [IX_FK_dbo_Electricites_dbo_Etats_Etat_id]
ON [dbo].[Electricites]
    ([Etat_id]);
GO

-- Creating foreign key on [TypeElec_id] in table 'Electricites'
ALTER TABLE [dbo].[Electricites]
ADD CONSTRAINT [FK_dbo_Electricites_dbo_TypeElectricites_TypeElec_id]
    FOREIGN KEY ([TypeElec_id])
    REFERENCES [dbo].[TypeElectricites]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Electricites_dbo_TypeElectricites_TypeElec_id'
CREATE INDEX [IX_FK_dbo_Electricites_dbo_TypeElectricites_TypeElec_id]
ON [dbo].[Electricites]
    ([TypeElec_id]);
GO

-- Creating foreign key on [Elec_NPolice], [Elec_Adresse], [Elec_Date], [Elec_Tel], [Elec_NCompteur], [Elec_Reference] in table 'RelveeElecs'
ALTER TABLE [dbo].[RelveeElecs]
ADD CONSTRAINT [FK_dbo_RelveeElecs_dbo_Electricites_Elec_NPolice_Elec_Adresse_Elec_Date_Elec_Tel_Elec_NCompteur_Elec_Reference]
    FOREIGN KEY ([Elec_NPolice], [Elec_Adresse], [Elec_Date], [Elec_Tel], [Elec_NCompteur], [Elec_Reference])
    REFERENCES [dbo].[Electricites]
        ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_RelveeElecs_dbo_Electricites_Elec_NPolice_Elec_Adresse_Elec_Date_Elec_Tel_Elec_NCompteur_Elec_Reference'
CREATE INDEX [IX_FK_dbo_RelveeElecs_dbo_Electricites_Elec_NPolice_Elec_Adresse_Elec_Date_Elec_Tel_Elec_NCompteur_Elec_Reference]
ON [dbo].[RelveeElecs]
    ([Elec_NPolice], [Elec_Adresse], [Elec_Date], [Elec_Tel], [Elec_NCompteur], [Elec_Reference]);
GO

-- Creating foreign key on [Etat_id] in table 'TeleCommunications'
ALTER TABLE [dbo].[TeleCommunications]
ADD CONSTRAINT [FK_dbo_TeleCommunications_dbo_Etats_Etat_id]
    FOREIGN KEY ([Etat_id])
    REFERENCES [dbo].[Etats]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TeleCommunications_dbo_Etats_Etat_id'
CREATE INDEX [IX_FK_dbo_TeleCommunications_dbo_Etats_Etat_id]
ON [dbo].[TeleCommunications]
    ([Etat_id]);
GO

-- Creating foreign key on [TypeTelecom_id] in table 'TeleCommunications'
ALTER TABLE [dbo].[TeleCommunications]
ADD CONSTRAINT [FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id]
    FOREIGN KEY ([TypeTelecom_id])
    REFERENCES [dbo].[TypeTelecommunications]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE [dbo].[RelveeTeleCom]
ADD CONSTRAINT [FK_dbo_RelveeTeleCom_dbo_TeleCom]
    FOREIGN KEY ([TeleCom_NPolice], [TeleCom_Adresse], [TeleCom_Date], [TeleCom_Tel], [TeleCom_MD])
    REFERENCES [dbo].[TeleCommunications]
        ([NPolice], [Adresse], [Date], [Tel], [MD])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id'
CREATE INDEX [IX_FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id]
ON [dbo].[TeleCommunications]
    ([TypeTelecom_id]);
GO

SET IDENTITY_INSERT [dbo].[Etats] ON 

INSERT [dbo].[Etats] ([id], [NomEtat]) VALUES (1, N'En cours')
INSERT [dbo].[Etats] ([id], [NomEtat]) VALUES (2, N'Résilié')
INSERT [dbo].[Etats] ([id], [NomEtat]) VALUES (3, N'Provisoire')
SET IDENTITY_INSERT [dbo].[Etats] OFF
SET IDENTITY_INSERT [dbo].[TypeEaux] ON 

INSERT [dbo].[TypeEaux] ([id], [NomTypeEau]) VALUES (1, N'Domeistique')
INSERT [dbo].[TypeEaux] ([id], [NomTypeEau]) VALUES (2, N'Bouche d''arrosage')
INSERT [dbo].[TypeEaux] ([id], [NomTypeEau]) VALUES (3, N'Borne Fourniture')
SET IDENTITY_INSERT [dbo].[TypeEaux] OFF
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'100', N'hay salam', CAST(N'2016-05-14 00:00:00.000' AS DateTime), N'061482554', N'5240', N'214', 2005, 2, 2)
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'124', N'hay kamal', CAST(N'2017-05-25 00:00:00.000' AS DateTime), N'068596412', N'2154', N'5425', 2009, 2, 3)
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'125', N'mojama3 lkhir', CAST(N'2016-05-14 00:00:00.000' AS DateTime), N'061548597', N'2149', N'2542', 2000, 2, 2)
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'132', N'miftah lkhir', CAST(N'2016-05-14 00:00:00.000' AS DateTime), N'064211547', N'4121', N'142', 2001, 2, 3)
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'213', N'hay salam', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'061415484', N'3600', N'546545', 2011, 2, 2)
INSERT [dbo].[Eaux] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeEau_id]) VALUES (N'214', N'mimouna', CAST(N'2018-04-24 00:00:00.000' AS DateTime), N'061468752', N'1860', N'8451651', 2014, 3, 3)
SET IDENTITY_INSERT [dbo].[TypeElectricites] ON 

INSERT [dbo].[TypeElectricites] ([id], [NomTypeElec]) VALUES (1, N'MT')
INSERT [dbo].[TypeElectricites] ([id], [NomTypeElec]) VALUES (2, N'BT')
INSERT [dbo].[TypeElectricites] ([id], [NomTypeElec]) VALUES (3, N'Pompe')
INSERT [dbo].[TypeElectricites] ([id], [NomTypeElec]) VALUES (4, N'Domistique')
SET IDENTITY_INSERT [dbo].[TypeElectricites] OFF
INSERT [dbo].[Electricites] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeElec_id]) VALUES (N'41', N'hay salam', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614332877', N'4225', N'241', 2005, 3, 3)
INSERT [dbo].[Electricites] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeElec_id]) VALUES (N'124', N'hay mimouna', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614855554', N'5053', N'455', 2001, 2, 1)
INSERT [dbo].[Electricites] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeElec_id]) VALUES (N'125', N'mojam3 lkhir', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614331595', N'4154', N'214', 2004, 2, 1)
INSERT [dbo].[Electricites] ([NPolice], [Adresse], [Date], [Tel], [NCompteur], [Reference], [Annee], [Etat_id], [TypeElec_id]) VALUES (N'140', N'hay kamal', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0645859621', N'1521', N'518', 2014, 1, 2)
SET IDENTITY_INSERT [dbo].[TypeTelecommunications] ON 

INSERT [dbo].[TypeTelecommunications] ([id], [NomTypeTelecommunication]) VALUES (1, N'Fix')
INSERT [dbo].[TypeTelecommunications] ([id], [NomTypeTelecommunication]) VALUES (2, N'GSM')
INSERT [dbo].[TypeTelecommunications] ([id], [NomTypeTelecommunication]) VALUES (3, N'Internet')
SET IDENTITY_INSERT [dbo].[TypeTelecommunications] OFF
INSERT [dbo].[TeleCommunications] ([NPolice], [Adresse], [Date], [Tel], [MD], [Forfait], [Etat_id], [TypeTelecom_id]) VALUES (N'124', N'mimouna', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614124445', N'064141414', 222, 1, 2)
INSERT [dbo].[TeleCommunications] ([NPolice], [Adresse], [Date], [Tel], [MD], [Forfait], [Etat_id], [TypeTelecom_id]) VALUES (N'145', N'hay salam', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614541782', N'061465225', 228, 1, 3)
INSERT [dbo].[TeleCommunications] ([NPolice], [Adresse], [Date], [Tel], [MD], [Forfait], [Etat_id], [TypeTelecom_id]) VALUES (N'154', N'mimouna', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614358211', N'061345484', 4000, 1, 2)
INSERT [dbo].[TeleCommunications] ([NPolice], [Adresse], [Date], [Tel], [MD], [Forfait], [Etat_id], [TypeTelecom_id]) VALUES (N'214', N'hay salam', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614332847', N'061433578', 220, 3, 2)
INSERT [dbo].[TeleCommunications] ([NPolice], [Adresse], [Date], [Tel], [MD], [Forfait], [Etat_id], [TypeTelecom_id]) VALUES (N'244', N'hay kamal', CAST(N'2018-04-23 10:18:57.823' AS DateTime), N'0614331125', N'061433575', 2254, 2, 3)
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201804200937263_InitialCreate', N'Facturation.FacturationEntities', 0x1F8B0800000000000400ED1DD96EE4B8F13D40FE41D05312785BB607BB488CEE5D386D3B30B23E30ED59E46D404B745B88447524CAB011E4CBF2B09F945F08A983A27848D4E56EEF08F3D216C962DD552C5135FFFBEFAFCB9F5EC3C07A8171E24768659F2C8E6D0B2237F27CB45DD9297EFAEECFF64F3FFEFE77CB4B2F7CB57E29E77DA2F3C84A94ACEC678C77678E93B8CF3004C922F4DD384AA227BC70A3D0015EE49C1E1FFFC5393971200161135896B5FC9C22EC8730FB83FCB98E900B773805C14DE4C120299E93914D06D5BA05214C76C0852BFB0AB8388D012678D8D679E00382C206064FB605108A703670F625811B1C4768BBD99107207878DB4132EF0904092C103FABA69BD2707C4A6970AA852528374D7014760478F2A9608A232EEFC55A9B318DB0ED92B017BF51AA33D6ADEC4B90DA96B8CFD93A88E99C1A531764EA91C53D38626227DA41FF1D59EB3420A37085608A63101C59F7E963E0BB7F876F0FD13F215AA13408787C084664ACF6803CBA8FA31D8CF1DB67F85460797B1F113044424EFBDC732F86496236F70260B3890F30309A77BB8EC21D86696C349BFC8231B12A0987A523B285AD163992CBE91AE14FA7B6754BF80B1E03C834DA6904C2589503219641ACDBB66EC0EBCF106DF133B1FB6362CF57FE2BF4CA2705E02FC827CE802CC2710A3B6F9CF33DDF95FE7E2036DF194826132DE6A79320CEC97708E339C1EB59FFFD14049C230479AD39F9A11DC42D78F1B799C90BC02E89BBB0ADCF30C80693677F97BB5CEA2ABEE6835771147E8E82DCD364CFBE6EA234CE288F848107106F2136DF9E1291F92F0D066CBC8E44F158894739A64265E954DEB3D9A766941B3A5532B82FAFEA7BDDFD0E5DD3ACF91CC51B1CC5F06F1041421AF4EE01C6302631F0DA8319CB5A8D2D0A73566A6D84FC3432925E6264EA6326C962FA2C4CAD301943F723CFCB00BA644BD7A7B1C7D03AAB2573EAD386E89CFACCA9CF9CFA702E434E81843139051127F44A89089056D4AA896AF4CAF14614D9A441E95209A5A36F1696CD715763B645DCCD64BDA7440A0690388F3025B08A3A86A188C58573106E99777331C7D30F124FA9A8DE79CBAB287E023EEE28E9EE3150B25B2912AA6748C14633AD4F54A4A0DC2834C4B7B6A2096D6EA201F6FCECC131B300D4C3ADAA16CFF153E31DF3F8A960F6BB04D3F324895C3FDBB1AAD8E7E65447FB127996AED096235A94C508AA4494FE2EA069D3DBCAFE93C40105A8525979509949D7611D2F1627225D1C05ED849525822684A4FADD20F2C48A1F078DD52BC624523C1E6871D39E153872F9ACB903D9BA53C6A4D2551D3E4C30944F22A332403AC3880AA0DF62103F34315287725BC0E49096B36D73CEB404DC2915A439089B23AC8CC893B14715D1050D52848EDE6CCB83C43A4218F824A295795D15B9B3093E4C14B9C0970416E940524420914C0A7B0371E58F09982A2CF13E56E290B0946CA95C9B294DCBE2C2EDAAD6338FDCB67F65B44A34789B36C1A6199CE426DA408A5AA4042AEBA901A692AEE9F05528A5009ED3C09A4E14B93C372CBEF41393BE86D484D150AA9B74C66D4846F8C5B9C28989649D0643FA9892A94954A628AD494A5742C5B4845B5FD9C77072A562A582E6C68CC52C67E1A9AFD95213177459CA14625756469B79A14E62CCD398A13C91121751451A80F66091EE4C2F33C924B3E992DBF074293C6703BB5AB2990914A9A59260C22C6DD6D323EF199375AA4C47503955F4316669790266C90D1B5B3AF96DBFE2C1D2D15C0B5CDE80DD8E1CC6B96B82C5136B93DF115C7FB7E97E872ECC61386EA2B84AC7B0653BE128065B288C92AD09A6577E9CE00B80C123A0E580B5174AD354A99C26EC973B72D99A2CCF32F49793E96F29695C28E259C5BC2B424F0811CE4883F54026AFB2E8DD4C10805857655E47411AA296BABA1E0E2B34F370B435773D9CBC6ECC035117E3F510B2A2310F4059A46FE048F542B5C613FD7B743D2CEEAD2A0F4BFB96BD91C3F97BD21A7FF347328CA5232889A8818EA482823F10D5D94CD93377DD5BDB15E1C844DD95CB745CA4354A9E85729DB35137CAAB4F35CD281F1E8C1C582ADA57149A64DA401ADA959309849D0B0499680EA57B144B2DF5EB6D25DC89B687B134AD9E63C41C23F8F1E97CD318862096777AFAAA3E06318ECFCA0EB32AA7950D1C8EC0E4134A6F9149C5B31E426B8731FB31D3F5F4B203BF5CBEA7D2B49ADD5BE041B08787A3C0EA23F010BF239769FB791F033893FA2045B959E1905A8BD2EF21DC7A81423A647FAD3E49509EA38B7183B332ADB688376A8412B74CBC918832102A3951DAD99E1DD029EA4986E874757FE338BFA1AE6F98E31B2F7D1B2B796B94F53A429E9FBD7CBD4EE8E5197645C5408DC41A5E2F2B628726BD21B129FD6D49788BD2D39C4A28235994F06A6836AA6FCAA8F4CA34DCAEA4B779AD277B5DB4D21F56544AAD7953B7EFE8A5791B391BDC376570934531E53BE3768BABE68E6775E2BBE021818E8219D9FAC477DFB3057E5316D8A05683AD50772DC1B02EA4897FADB51F85C2375F36D8732C6CBE6231DB63477B3429671D6EE46AB9A4626A3AB545D35890E2CEC980D056429AC49E14D76F66B33A48B36A568576EB922E2A89535885B278C2FE6617958A4B42ED4DCDA45B43F914DB221C78F13D7A6368F39660182EE884C5E65FC13AF021C2D5841B80FC2798E0FC2B2DFBF4F8E454688F7638ADCA9C24F16A1F91A9FB95D5E5F5DBFA80775F5D347CAA33C3BEF9452F20769F412C7FF53BE0935E8FFCC6033FE9552276DA1D2FA903461FA649FD2FD46CFB7E587B8B240441D0073D967370144A5F925C230FBEAEEC7F676BCEACEB7F7C2D961D597731F13967D6B1F51F7E6BF97B4785C0B8C258B7CDAB95E6FB776BE6D5C3E30CFBAE3523BDF5CBD5AEFA5BEFA7552ADE1F42F0FAC791B8A5BC95F59119567B4F310DCFB4659F39B4CDA14D05640E6D1F31B49505B01EB12D5F3A41706BBC98F6E1DD36D7F2689258D75CE2F88D79EF113A0BCD8EB84B57A0B1200A4D7F3E9EE7E46B35DD9D67B57A22FFD972B5EEA37B516DE39B115C6A9FE6367C4360F33E1475185C0F5AE3AE31457243FFD3807584121C035FBE7A781FFBC8F57720E0B1958B9F26F2A75C63E0C4910BB883880A96A3C8649B86D7490CA4A0856D748FDCE047386F75EBC3B32729EB3F62DA9BA09BAFACBD87AC8DFB1C8D61D07CF30D1E5497F640876DE08DDF9F1C9CA177E9F5249E410635603A10B568FF6468EF1AD272D7E71DB4A46307AC311C85A2A90EAF6DDD5B431DB4D330F90AEAD05C47CF2E604D89EA90465C07A83DA69F051D883AB55FBC185DAB84D7F3052272030E51CE52FB335DF7B3FC25FCCAF61E23A202F9A9870CBC2A7447EE8BA66D8BA684AAEC4BA3EC51A644B7FA864201BC1834409B0F9832F6FCA89288A64E444A5A1AF793666869EBB4AF6CBEF2CEF21CE5DEADAD76CC7AB799B76ED371C0A021CF246DDE3835AF5A67C8A62F1CD6844F7C5A2EE61892C12CA06F3737C1B86ACD27F640D2C81DDBBA4B4AB64DE9F2FAB86456B5FCC10DD934CE45F991FEFE993061CBB5EE72D7FA47CD75CF29C8AFDD381DB1975A93F36DF8847A3FECEAD0274DBE6648B22AEE7F5825295EE26F2B10F4FE24221ACCE7536CCE357A8ACAF44EC0A89C22BECB80187824D93A8FB1FF045C4C865D982459BBF45F4090523D0C1FA1778DEE52BC4B312119868F41AD253B4D0F9BF6CF9AC1D5715EDEEDB250370609044D9FBE1EBA437F4DFDC063785FC915741D089A771665792A4B4CCBF3DB3706E9364286800AF6B174F90186BB80004BEED006BCC03EB87D49E0CF700BDCB7F2B6A81E48BB20EA6C5F5EF8601B8330296054EBC99F4487BDF0F5C7FF03C113500E68780000, N'6.2.0-61023')

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------