CREATE PROC [dbo].[usp_CompanyDelete] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Company]
	WHERE  [Id] = @Id

	COMMIT