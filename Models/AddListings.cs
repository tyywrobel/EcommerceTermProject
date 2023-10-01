using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceTermProject.Models
{
    public class AddListings
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter product name, 30 characters max.")]
        public string? ProductName { get; set; }

        [StringLength(50, ErrorMessage = "Please enter address, 50 characters max.")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Please enter city, 30 characters max.")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Please enter state, 2 characters max.")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Please enter zipcode, 10 numbers max.")]
        public string? Zipcode { get; set; }
    }
}