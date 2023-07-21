CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StreetAddress] NVARCHAR(100) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [State] NVARCHAR(50) NOT NULL, 
    [ZipCode] NCHAR(10) NOT NULL, 

)
