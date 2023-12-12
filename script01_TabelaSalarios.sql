IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_SALARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [ValorLiquido] float NOT NULL,
    [GastosObrigatorios] float NOT NULL,
    [GastosLazer] float NOT NULL,
    [ValorFinal] float NOT NULL,
    [ValorGuardado] float NOT NULL,
    [ValorEmergencial] float NOT NULL,
    [Cargo] int NOT NULL,
    [valor] float NOT NULL,
    CONSTRAINT [PK_TB_SALARIOS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cargo', N'GastosLazer', N'GastosObrigatorios', N'Nome', N'ValorEmergencial', N'ValorFinal', N'ValorGuardado', N'ValorLiquido', N'valor') AND [object_id] = OBJECT_ID(N'[TB_SALARIOS]'))
    SET IDENTITY_INSERT [TB_SALARIOS] ON;
INSERT INTO [TB_SALARIOS] ([Id], [Cargo], [GastosLazer], [GastosObrigatorios], [Nome], [ValorEmergencial], [ValorFinal], [ValorGuardado], [ValorLiquido], [valor])
VALUES (1, 5, 400.0E0, 600.0E0, N'Matheus Estagiário', 100.0E0, 500.0E0, 400.0E0, 1500.0E0, 0.0E0),
(2, 4, 500.0E0, 600.0E0, N'Matheus Trainee', 146.5E0, 746.5E0, 600.0E0, 1846.5E0, 0.0E0),
(3, 3, 700.0E0, 600.0E0, N'Matheus Júnior', 200.0E0, 1200.0E0, 1000.0E0, 2500.0E0, 0.0E0),
(4, 2, 1500.0E0, 600.0E0, N'Matheus Pleno', 400.0E0, 2900.0E0, 2500.0E0, 5000.0E0, 0.0E0),
(5, 1, 3000.0E0, 600.0E0, N'Matheus Sênior', 900.0E0, 4400.0E0, 3500.0E0, 8000.0E0, 0.0E0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cargo', N'GastosLazer', N'GastosObrigatorios', N'Nome', N'ValorEmergencial', N'ValorFinal', N'ValorGuardado', N'ValorLiquido', N'valor') AND [object_id] = OBJECT_ID(N'[TB_SALARIOS]'))
    SET IDENTITY_INSERT [TB_SALARIOS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231212033837_InitialCreate', N'7.0.14');
GO

COMMIT;
GO

