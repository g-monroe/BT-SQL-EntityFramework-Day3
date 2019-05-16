alter table ToDos add AssignedUserId int null
alter table ToDos Add Constraint FK_ToDos_AssignedUserId 
	FOREIGN KEY (AssignedUserId)
	References Users (UserId)
	
insert into todos values ('Do this now', GETUTCDATE(), null, null, 0, 3)
delete from users where userid = 3

select * from todos
--where AssignedUserId = 3

select * from users U
LEFT JOIN ToDos T on U.userid = T.assignedUserId
Where T.ToDoId is null

select count(1), U.Name, u.UserId from todos T
INNER JOIN Users U on T.assignedUserId = U.userId
group by U.Name, u.userId