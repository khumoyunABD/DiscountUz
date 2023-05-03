using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountUz.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string? Location { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        [ValidateNever]
        public DateTime StartDate { get; set; }
        [Required]
        [ValidateNever]
        public DateTime EndDate { get; set; }
        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        [Required]
        [ValidateNever]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

    }
}
