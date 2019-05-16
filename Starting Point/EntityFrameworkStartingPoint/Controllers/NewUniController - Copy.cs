using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkStartingPoint.Controllers.ResponseObjects;
using EntityFrameworkStartingPoint.Data;
using EntityFrameworkStartingPoint.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkStartingPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUniController : ControllerBase
    {
        private SuperheroesContext _context;
        public NewUniController(SuperheroesContext ctx)
        {
            _context = ctx;
        }
        [HttpPost]
        public Universe AddUniverse(UniverseAddRequest request)
        {
            Universe response = new Universe()
            {
                UniverseName = request.UniverseName,
                ParentCompany = request.ParentCompany
            };
            _context.Universes.Add(new Universe { UniverseName = response.UniverseName, ParentCompany = response.ParentCompany});
            _context.SaveChanges();
            return response;
        }
        [HttpPut("{id}")]
        public Universe UpdateUniverse([FromRoute]int id, [FromBody]UniverseAddRequest request)
        {
            Universe response = _context.Universes.Find(id);
            response.UniverseName = request.UniverseName;
            response.ParentCompany = request.ParentCompany;


            _context.Universes.Update(new Universe() { UniverseName = response.UniverseName, ParentCompany = response.ParentCompany });
            _context.SaveChanges();
            return response;
        }
        [HttpGet]
        public List<Universe> GetUniverse()
        {
            var uni = _context.Universes.ToList();
            return uni;
        }
        [HttpGet("{id}")]
        public Universe GetUniverse(int id)
        {
            var uni = _context.Universes.First(x=> x.UniverseId == id);
            return uni;
        }
        [HttpDelete("{id}")]
        public void DeleteUniverse(int id)
        {
            var uni = _context.Universes.First(x => x.UniverseId == id);
            _context.Universes.Remove(uni); 
        }

    }
}