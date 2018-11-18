CREATE PROC [dbo].[usp_CompanyUpdate] 
    @Id int,
    @Name nvarchar(50) = NULL,
    @Country_Code char(2) = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Company]
	SET    [Name] = @Name, [Country_Code] = @Country_Code
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [Country_Code]
	FROM   [dbo].[Company]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT