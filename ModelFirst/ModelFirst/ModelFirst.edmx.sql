
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/21/2018 06:17:17
-- Generated from EDMX file: C:\Users\VinodhKumar\source\repos\ModelFirst\ModelFirst\ModelFirst.edmx
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

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [DepartmentNo] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'Workers'
CREATE TABLE [dbo].[Workers] (
    [WorkerID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Place] nvarchar(max)  NOT NULL,
    [DepartmentDepartmentNo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DepartmentNo] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([DepartmentNo] ASC);
GO

-- Creating primary key on [WorkerID] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [PK_Workers]
    PRIMARY KEY CLUSTERED ([WorkerID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartmentDepartmentNo] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [FK_DepartmentWorker]
    FOREIGN KEY ([DepartmentDepartmentNo])
    REFERENCES [dbo].[Departments]
        ([DepartmentNo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentWorker'
CREATE INDEX [IX_FK_DepartmentWorker]
ON [dbo].[Workers]
    ([DepartmentDepartmentNo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------