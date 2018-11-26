
Create PROC [dbo].[usp_CompanyInsert] 
   
    @Name nvarchar(50) =  NULL,
    @Country_Code int =  NULL,
	@Company_Type int = NULL 
AS 
	declare  @newId int = -1

	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Company] ( [Name], [Country_Code],[Company_Type]) values( @Name, @Country_Code,@Company_Type)
	set @newId=SCOPE_IDENTITY()
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [Country_Code] ,[Company_Type],[Description]
	FROM   [dbo].[CompanyView] 
	WHERE  [Id] = @newId
	-- End Return Select <- do not remove
               
	COMMIT