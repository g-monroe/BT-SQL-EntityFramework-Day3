using EntityFrameworkStartingPoint.Data;
using Microsoft.AspNetCore.Mvc;

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
            var todo = _context.ToDos.Find(1);
            _context.ToDos.Remove(todo);
            _context.SaveChanges();
        }
    }
}