using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkStartingPoint.Data
{
    public class SuperheroesContext : DbContext
    {
        public SuperheroesContext(DbContextOptions<SuperheroesContext> options) : base(options)
        {
        }

        public virtual DbSet<ToDo> ToDos { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Universe> Unvierses { get; set; }
    }
}
