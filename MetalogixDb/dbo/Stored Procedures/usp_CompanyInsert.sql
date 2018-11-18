CREATE PROC [dbo].[usp_CompanyInsert] 
   
    @Name nvarchar(50) = NULL,
    @Country_Code char(2) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Company] ( [Name], [Country_Code])
	SELECT  @Name, @Country_Code
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [Country_Code]
	FROM   [dbo].[Company]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT