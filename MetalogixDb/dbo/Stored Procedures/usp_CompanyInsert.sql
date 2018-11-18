﻿CREATE PROC [dbo].[usp_CompanyInsert] 
    @Id int,
    @Name nvarchar(50) = NULL,
    @Country_Code char(2) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Company] ([Id], [Name], [Country_Code])
	SELECT @Id, @Name, @Country_Code
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [Country_Code]
	FROM   [dbo].[Company]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT