CREATE PROC [dbo].[usp_CompanySelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Name], [Country_Code] 
	FROM   [dbo].[Company] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT