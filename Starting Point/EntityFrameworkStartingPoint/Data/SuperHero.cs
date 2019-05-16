using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkStartingPoint.Controllers.ResponseObjects
{
    public class SuperHero
    {
        public Universe universe { get; set; }
        [Key]
        public int SuperheroId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SuperheroName { get; set; }
        [Required]
        [MaxLength(50)]
        public string SecretIdentity { get; set; }
        public int? AgeAtOrigin { get; set; }
        [Required]
        public int YearOfAppearance { get; set; }
        [Required]
        public bool IsAlien { get; set; }
        [Required]
        [MaxLength(50)]
        public string OriginStory { get; set; }
        [Required]
        [ForeignKey("UniverseId")]
        public int UniverseId { get; set; }
        [MaxLength(50)]
        public string Abilities { get; set; }
    }
}