﻿using System.ComponentModel.DataAnnotations;

namespace DotnetCoreJQuery.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string MainCategory { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
