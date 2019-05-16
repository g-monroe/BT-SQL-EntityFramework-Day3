INSERT INTO todos values('Do this', GETDATE(), 'Description', null, 0)
INSERT INTO todos values('Do that', GETDATE(), 'Description', null, 0)

select * from ToDos

Select * from ToDos
where ToDoId = 1

Select ToDoId, Topic from ToDos
where Description = 'Description'

select count(1) CountOfTodsINThisTopic, Topic from todos
Group By Topic

update ToDos
set Description = null,
DueDate = GETUTCDATE(),
Topic = 'Do This Now'
WHERE TodoId = 2

select * from todos

delete from todos where ToDoId = 2
delete from todos where ToDoId = 1