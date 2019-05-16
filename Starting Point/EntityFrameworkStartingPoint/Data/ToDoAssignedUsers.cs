namespace EntityFrameworkStartingPoint.Data
{
    public class ToDoAssignedUsers
    {
        public int ToDoAssignedUsersId { get; set; }
        public int ToDoId { get; set; }
        public int UserId { get; set; }

        public ToDo ToDo { get; set; }
        public User User { get; set; }
    }
}