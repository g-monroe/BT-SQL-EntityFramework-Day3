using EntityFrameworkStartingPoint.Controllers.ResponseObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkStartingPoint.Data
{
    public class SuperheroesContext : DbContext
    {
       public SuperheroesContext(DbContextOptions<SuperheroesContext> options) :base(options)
        {

        }
        public SuperheroesContext():base()
        {

        }
        public virtual DbSet<SuperHero> Heros { get; set; }
        public virtual DbSet<Universe> Universes { get; set; }
    }
}
