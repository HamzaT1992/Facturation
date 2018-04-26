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
    [Rapport] nchar(255)  NULL
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
    [Rapport] nchar(255)  NULL
);
GO

-- Creating table 'TeleCommunications'
CREATE TABLE [dbo].[TeleCommunications] (
    [NPolice] nvarchar(50)  NOT NULL,
    [Adresse] nvarchar(100)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Tel] nvarchar(20)  NOT NULL,
    [MD] nvarchar(20)  NOT NULL,
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

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id'
CREATE INDEX [IX_FK_dbo_TeleCommunications_dbo_TypeTelecommunications_TypeTelecom_id]
ON [dbo].[TeleCommunications]
    ([TypeTelecom_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------