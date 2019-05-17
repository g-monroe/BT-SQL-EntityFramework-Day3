using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkStartingPoint.Controllers.ResponseObjects
{
    public class Ability
    {
        [Key]
        public int AbilityId { get; set; }
        public SuperHero superhero { get; set; }
        public string AbilityName { get; set; }
        [ForeignKey("SuperheroId")]
        public string SuperheroId { get; set; }
    }
}