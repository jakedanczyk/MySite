using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mysite.Models
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Range(0,999999)]
        public float Price { get; set; }

        public string Description { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }
    }
}