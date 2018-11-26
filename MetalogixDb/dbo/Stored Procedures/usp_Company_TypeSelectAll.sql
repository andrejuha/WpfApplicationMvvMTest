Create PROC [dbo].[usp_Company_TypeSelectAll] 
    
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Name], [Description] 
	FROM   [dbo].[Company_Type] 

	COMMIT

GO