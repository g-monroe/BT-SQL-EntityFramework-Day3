using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkStartingPoint.Controllers.ResponseObjects
{
    public class Universe
    {
        [Key]
        public int UniverseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UniverseName { get; set; }
        [Required]
        [MaxLength(50)]
        public string ParentCompany { get; set; }
    }
}