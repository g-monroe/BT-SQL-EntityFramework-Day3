CREATE TABLE ToDos(
	ToDoId int not null,
	Topic nvarchar(100) NOT NULL,
	DateAdded dateTime2(7) NOT NULL,
	Description nvarchar(max) NULL,
	DueDate DateTime2(7) NULL,
	IsCompleted bit NOT NULL
)