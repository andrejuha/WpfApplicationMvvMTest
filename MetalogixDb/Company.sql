CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Country_Code] CHAR(2) NULL, 
    [FK_Company_Type] INT NULL
)
