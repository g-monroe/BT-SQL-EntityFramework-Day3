using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkStartingPoint.Data
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Title { get; set; }
        public String Description { get; set; }

    }
}
