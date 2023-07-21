CREATE TABLE [dbo].[PeopleEmployers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PeopleId] INT NOT NULL, 
    [EmployerId] INT NOT NULL
)
