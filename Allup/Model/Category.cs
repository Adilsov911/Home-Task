﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Model
{
    public class Category :BaseEntity
    {
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool IsMain { get; set; }

        public Category? Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
        public IEnumerable<Product> Products { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
