using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkStartingPoint.Data
{
    public class Universe
    {
        public int UniverseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        public string ParentCompany { get; set; }
    }
}
