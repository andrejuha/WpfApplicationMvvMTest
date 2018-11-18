CREATE TABLE [dbo].[Company] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Company_Type] INT           NULL,
    [Country_Code] INT           NULL,
    [Name]         NVARCHAR (50) NULL,
    CONSTRAINT [PK__tmp_ms_x__3214EC078DA10DD1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Company_Company_Type] FOREIGN KEY ([Company_Type]) REFERENCES [dbo].[Company_Type] ([Id])
);


