﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        public string DisplayOrder { get; set; }
    }
}
