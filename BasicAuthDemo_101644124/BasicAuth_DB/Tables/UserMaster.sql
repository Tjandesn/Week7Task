CREATE TABLE [dbo].[UserMaster]
(
	[Id] int not null primary key,
	[UserName] nvarchar(50) not null,
	[Password] nvarchar(50) not null,
	[IsActive] int not null
)
