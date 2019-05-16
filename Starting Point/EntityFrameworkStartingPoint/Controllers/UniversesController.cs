using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkStartingPoint.Controllers.ResponseObjects;
using EntityFrameworkStartingPoint.Data;
using EntityFrameworkStartingPoint.Extensions;
using EntityFrameworkStartingPoint.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using WebApiAssignment.Datastore.DataModels;

namespace EntityFrameworkStartingPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversesController : ControllerBase
    {
        private SuperheroesContext _context;
        public UniversesController(SuperheroesContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public object GetUniverses()
        {
            //return _context.Users.Include(x => x.ToDoAssigneds).ThenInclude(x => x.ToDo);
            return null;
        }

        [HttpGet("{id}")]
        public object GetUniverse(int id)
        {
            //return _context.Users.Include(x => x.ToDoAssigneds).ThenInclude(x=> x.ToDo);
            return null;
        }

        [HttpPut("{id}")]
        public UniverseListItem UpdateUniverse([FromRoute] int id, UniverseAddRequest request)
        {
            var universe = _context.Unvierses.Find(id);
            universe = request.ToDbItem(universe);
            _context.SaveChanges();
            return universe.ToListItem();
        }

        [HttpPost]
        public UniverseListItem AddUniverse(UniverseAddRequest request)
        {
            var universe = request.ToDbItem();
            _context.Unvierses.Add(universe);
            _context.SaveChanges();
            return universe.ToListItem();
        }

        [HttpDelete]
        public void DeleteUniverses(int id)
        {
            _context.Unvierses.Remove(_context.Unvierses.Find(id));
            _context.SaveChanges();
        }
    }
}