
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/03/2017 09:36:52
-- Generated from EDMX file: G:\GitHubSrc\StarseaDesktop\Starsea.DB\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QuickDev];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BlogBlogArticle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogArticles] DROP CONSTRAINT [FK_BlogBlogArticle];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BASE_ACCOUNT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BASE_ACCOUNT];
GO
IF OBJECT_ID(N'[dbo].[Blogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Blogs];
GO
IF OBJECT_ID(N'[dbo].[BlogArticles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogArticles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BASE_ACCOUNT'
CREATE TABLE [dbo].[BASE_ACCOUNT] (
    [ID] nchar(10)  NOT NULL,
    [ACCOUNT] nchar(100)  NULL,
    [PASSWORD] nchar(100)  NULL,
    [PERSONNAME] nchar(100)  NULL,
    [AGE] decimal(2,0)  NULL,
    [SEX] nchar(10)  NULL
);
GO

-- Creating table 'Blogs'
CREATE TABLE [dbo].[Blogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OwnerID] uniqueidentifier  NOT NULL,
    [Caption] nvarchar(max)  NOT NULL,
    [DateCreate] datetime  NOT NULL
);
GO

-- Creating table 'BlogArticles'
CREATE TABLE [dbo].[BlogArticles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BlogId] uniqueidentifier  NOT NULL,
    [Subject] nvarchar(max)  NOT NULL,
    [DateCreate] datetime  NOT NULL,
    [DateModify] datetime  NOT NULL,
    [Blog_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'BASE_ACCOUNT'
ALTER TABLE [dbo].[BASE_ACCOUNT]
ADD CONSTRAINT [PK_BASE_ACCOUNT]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'Blogs'
ALTER TABLE [dbo].[Blogs]
ADD CONSTRAINT [PK_Blogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BlogArticles'
ALTER TABLE [dbo].[BlogArticles]
ADD CONSTRAINT [PK_BlogArticles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Blog_Id] in table 'BlogArticles'
ALTER TABLE [dbo].[BlogArticles]
ADD CONSTRAINT [FK_BlogBlogArticle]
    FOREIGN KEY ([Blog_Id])
    REFERENCES [dbo].[Blogs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogBlogArticle'
CREATE INDEX [IX_FK_BlogBlogArticle]
ON [dbo].[BlogArticles]
    ([Blog_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------