IF OBJECT_ID(N'[__EFMigrationsHistorys]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistorys] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistorys] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Cities] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [population] int NOT NULL,
    [cases] int NOT NULL,
    [deaths] int NOT NULL,
    [tested] int NOT NULL,
    [date] nvarchar(max) NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY ([Id])
);

GO

-- INSERT INTO [__EFMigrationsHistorys] ([MigrationId], [ProductVersion])
-- VALUES (N'20190627034742_InitialSchema', N'2.2.4-servicing-10062');

GO

SELECT *
From Cities

