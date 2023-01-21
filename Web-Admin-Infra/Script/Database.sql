use [admin-app];

CREATE TABLE [dbo].[User]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Login] VARCHAR(MAX) NULL, 
    [Password] VARCHAR(MAX) NULL, 
    [UserLevelId] INT NOT NULL
);

CREATE TABLE [dbo].[UserLevel]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL
);
