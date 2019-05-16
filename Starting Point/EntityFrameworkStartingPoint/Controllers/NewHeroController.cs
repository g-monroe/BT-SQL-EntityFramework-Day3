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
    public class NewHeroController : ControllerBase
    {
        private SuperheroesContext _context;
        public NewHeroController(SuperheroesContext ctx)
        {
            _context = ctx;
        }
        [HttpPost]
        public SuperHero AddSuperhero(SuperheroAddRequest request)
        {
            var unis = _context.Universes.First(x => x.UniverseId == request.UniverseId);
            if (unis == null)
            {
                return null;
            }
            SuperHero response = new SuperHero()
            {
                Abilities = request.Abilities,
                AgeAtOrigin = request.AgeAtOrigin,
                IsAlien = request.IsAlien,
                OriginStory = request.OriginStory,
                SecretIdentity = request.SecretIdentity,
                SuperheroName = request.SuperheroName,
                YearOfAppearance = request.YearOfAppearance,
                UniverseId = request.UniverseId
            };
            _context.Heros.Add(new SuperHero() { SuperheroName = response.SuperheroName, Abilities = response.Abilities, AgeAtOrigin = response.AgeAtOrigin, IsAlien = response.IsAlien, OriginStory = response.OriginStory, SecretIdentity = response.SecretIdentity, YearOfAppearance = response.YearOfAppearance, UniverseId = response.UniverseId });
            _context.SaveChanges();
            return response;
        }
        [HttpPut("{id}")]
        public SuperHero UpdateSuperhero([FromRoute]int id, [FromBody]SuperheroAddRequest request)
        {
            var hero = _context.Heros.Find(id);
            if (hero == null)
            {
                return null;
            }
            SuperHero response = hero;
            response.Abilities = request.Abilities;
            response.AgeAtOrigin = request.AgeAtOrigin;
            response.IsAlien = request.IsAlien;
            response.OriginStory = request.OriginStory;
            response.SecretIdentity = request.SecretIdentity;
            response.SuperheroName = request.SuperheroName;
            response.YearOfAppearance = request.YearOfAppearance;
            response.UniverseId = request.UniverseId;
            _context.Heros.Update(new SuperHero() { SuperheroName = response.SuperheroName, Abilities = response.Abilities, AgeAtOrigin = response.AgeAtOrigin, IsAlien = response.IsAlien, OriginStory = response.OriginStory, SecretIdentity = response.SecretIdentity, YearOfAppearance = response.YearOfAppearance, UniverseId = response.UniverseId });
            _context.SaveChanges();
            return response;
        }
        [HttpGet]
        public List<SuperHero> GetHeros()
        {
            var hero = _context.Heros.ToList();
            return hero;
        }
        [HttpGet("{id}")]
        public SuperHero GetHero(int id)
        {
            var hero = _context.Heros.First(x=> x.SuperheroId == id);
            return hero;
        }
        [HttpDelete("{id}")]
        public void DeleteHero(int id)
        {
            var hero = _context.Heros.First(x => x.SuperheroId == id);
            _context.Heros.Remove(hero);
        }

    }
}