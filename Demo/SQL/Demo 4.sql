alter table ToDos add AssignedUserId int null
alter table ToDos Add Constraint FK_ToDos_AssignedUserId 
	FOREIGN KEY (AssignedUserId)
	References Users (UserId)
	
insert into todos values ('Do this now', GETUTCDATE(), null, null, 0, 3)
delete from users where userid = 3