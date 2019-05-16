using EntityFrameworkStartingPoint.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkStartingPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private SuperheroesContext _context;
        public ToDoController(SuperheroesContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public void GetTodos()
        {

            var td = new ToDo();
            td.Title = "Do This";


            //var dan = _context.Users.Find(1);
            //var daric = _context.Users.Find(2);
            //td.AssignedUsers = new System.Collections.Generic.List<ToDoAssignedUsers>();
            //td.AssignedUsers.Add(new ToDoAssignedUsers() { User = dan });
            //td.AssignedUsers.Add(new ToDoAssignedUsers() { User = daric });
            //_context.ToDos.Add(td);
            //_context.SaveChanges();

        }
    }
}