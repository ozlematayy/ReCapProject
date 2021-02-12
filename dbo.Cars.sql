CREATE TABLE [dbo].[Table]
(
	[CarID] INT NOT NULL PRIMARY KEY, 
    [ColorId] INT NOT NULL, 
    [BrandId] INT NOT NULL, 
    [ModelYear] INT NOT NULL, 
    [DailyPrice] INT NOT NULL, 
    [Description] NVARCHAR(20) NOT NULL
)
