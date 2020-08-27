
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/27/2020 13:28:38
-- Generated from EDMX file: C:\Users\ervisa\Desktop\ikub kursi\seanca10\shembylli nga leksioni\solution1\EF-Example\EF-Example\EFDbFirstApproachExample\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFDBFirstDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Products__BrandI__15502E78]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK__Products__BrandI__15502E78];
GO
IF OBJECT_ID(N'[dbo].[FK__Products__Catego__145C0A3F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK__Products__Catego__145C0A3F];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [BrandID] bigint IDENTITY(1,1) NOT NULL,
    [BrandName] varchar(40)  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [CategoryID] bigint IDENTITY(1,1) NOT NULL,
    [CategoryName] varchar(40)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] bigint IDENTITY(1,1) NOT NULL,
    [ProductName] varchar(50)  NULL,
    [Price] decimal(15,2)  NULL,
    [DateOfPurchase] datetime  NULL,
    [AvailabilityStatus] varchar(50)  NULL,
    [CategoryID] bigint  NULL,
    [BrandID] bigint  NULL,
    [Active] bit  NULL,
    [Photo] varchar(max)  NULL,
    [pershkrimi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BrandID] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([BrandID] ASC);
GO

-- Creating primary key on [CategoryID] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BrandID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK__Products__BrandI__15502E78]
    FOREIGN KEY ([BrandID])
    REFERENCES [dbo].[Brands]
        ([BrandID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Products__BrandI__15502E78'
CREATE INDEX [IX_FK__Products__BrandI__15502E78]
ON [dbo].[Products]
    ([BrandID]);
GO

-- Creating foreign key on [CategoryID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK__Products__Catego__145C0A3F]
    FOREIGN KEY ([CategoryID])
    REFERENCES [dbo].[Categories]
        ([CategoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Products__Catego__145C0A3F'
CREATE INDEX [IX_FK__Products__Catego__145C0A3F]
ON [dbo].[Products]
    ([CategoryID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------