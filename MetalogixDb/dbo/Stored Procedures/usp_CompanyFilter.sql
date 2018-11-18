create PROC [dbo].[usp_CompanyFilter] 
    @Id int,
	@Name [nvarchar](50),
	@Country_Code [char](2) 
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Name], [Country_Code] 
	FROM   [dbo].[Company] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT