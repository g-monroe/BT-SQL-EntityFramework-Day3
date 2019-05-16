create table Users(
	userId int not null identity (1,1)
	CONSTRAINT PK_Users_userId PRIMARY KEY CLUSTERED (userId),
	name varchar(100) not null
)

/****** Object:  Table [dbo].[ToDos]    Script Date: 5/16/2019 10:01:04 AM ******/
DROP TABLE [dbo].[ToDos]
GO

/****** Object:  Table [dbo].[ToDos]    Script Date: 5/16/2019 10:01:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ToDos](
	[ToDoId] [int] NOT NULL identity(1,1),
	CONSTRAINT PK_ToDos_ToDoId PRIMARY KEY CLUSTERED (ToDoId) ,
	[Topic] [nvarchar](100) NOT NULL,
	[DateAdded] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DueDate] [datetime2](7) NULL,
	[IsCompleted] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


