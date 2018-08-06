
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/23/2018 11:53:56
-- Generated from EDMX file: C:\Users\VinodhKumar\source\repos\ModelFirstDemo\ModelFirstDemo\MyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [tvs];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehicles'
CREATE TABLE [dbo].[Vehicles] (
    [VehicleID] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Cars1'
CREATE TABLE [dbo].[Cars1] (
    [CarID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [VehicleVehicleID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [VehicleID] in table 'Vehicles'
ALTER TABLE [dbo].[Vehicles]
ADD CONSTRAINT [PK_Vehicles]
    PRIMARY KEY CLUSTERED ([VehicleID] ASC);
GO

-- Creating primary key on [CarID] in table 'Cars1'
ALTER TABLE [dbo].[Cars1]
ADD CONSTRAINT [PK_Cars1]
    PRIMARY KEY CLUSTERED ([CarID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [VehicleVehicleID] in table 'Cars1'
ALTER TABLE [dbo].[Cars1]
ADD CONSTRAINT [FK_VehicleCars]
    FOREIGN KEY ([VehicleVehicleID])
    REFERENCES [dbo].[Vehicles]
        ([VehicleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleCars'
CREATE INDEX [IX_FK_VehicleCars]
ON [dbo].[Cars1]
    ([VehicleVehicleID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------