CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [ModelYear]   INT           NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [DailyPrice]  MONEY         NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cars_Brands2] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [FK_Cars_Colors1] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);



CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT           IDENTITY (1, 1) NOT NULL,
    [BrandName] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Brands_1] PRIMARY KEY CLUSTERED ([BrandId] ASC)
);



CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT           IDENTITY (1, 1) NOT NULL,
    [ColorName] NVARCHAR (15) NOT NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);



CREATE TABLE [dbo].[Users] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[Customers] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);



CREATE TABLE [dbo].[Rentals] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [CarId]      INT  NOT NULL,
    [CustomerId] INT  NOT NULL,
    [RentDate]   DATE NOT NULL,
    [ReturnDate] DATE NULL,
    CONSTRAINT [PK__Rentals__3214EC0753024DDA] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK__Rentals__Custome__46B27FE2] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]),
    CONSTRAINT [FK__Rentals__CarId__45BE5BA9] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id])
);
