create PROC [dbo].[usp_CompanyFilter] 
    @Id int,
	@Name [nvarchar](50),
	@Country_Code int ,
	@Company_Type int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN
	if @Id!=null
	BEGIN
		SELECT [Id],[Company_Type],[Country_Code],[Name],[Description],[TypeName]
		FROM [dbo].[CompanyView]
		WHERE  ([Id] = @Id)
	END

	if @Name!=null
	BEGIN
		SELECT [Id],[Company_Type],[Country_Code],[Name],[Description],[TypeName]
		FROM [dbo].[CompanyView]
		WHERE   ( [Name] = @Name )
	END

	if @Country_Code!=null
	BEGIN
		SELECT [Id],[Company_Type],[Country_Code],[Name],[Description],[TypeName]
		FROM [dbo].[CompanyView]
		WHERE   ( [Country_Code] = @Country_Code )
	END	 

	if @Company_Type!=null
	BEGIN
	SELECT [Id],[Company_Type],[Country_Code],[Name],[Description],[TypeName]
		FROM [dbo].[CompanyView]
		WHERE   ( [Company_Type] = @Company_Type )
	END

		SELECT [Id],[Company_Type],[Country_Code],[Name],[Description],[TypeName]
		FROM [dbo].[CompanyView]

	COMMIT