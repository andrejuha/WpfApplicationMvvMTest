CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Country_Code] CHAR(2) NULL, 
	CONSTRAINT [FK_Company_Type] FOREIGN KEY (Id)     
    REFERENCES dbo.Company_Type (Id)     
    ,


)
