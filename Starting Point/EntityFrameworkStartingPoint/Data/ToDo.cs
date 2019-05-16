﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkStartingPoint.Data
{
    public class ToDo
    {
        public int ToDoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}
