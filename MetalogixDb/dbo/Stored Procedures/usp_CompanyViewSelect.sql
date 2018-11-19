CREATE PROC [dbo].[usp_CompanyViewSelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Name], [Country_Code] ,[Company_Type],[Description]
	FROM   [dbo].[CompanyView] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT