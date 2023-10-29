using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceTermProject.Models
{
    public class AddListings
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter product name, 30 characters max.")]
        [Display(Name = "Name of Product")]
        public string? ProductName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter address, 50 characters max.")]
        public string? Address { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter city, 30 characters max.")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Enter only alphabetical letters.")]
        public string? City { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Please enter state, 2 characters max.")]
        [RegularExpression(@"^[a-z A-Z]+$", ErrorMessage = "Enter only alphabetical letters.")]
        public string? State { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Please enter zipcode, 10 numbers max.")]
        public string? Zipcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime ListingDate { get; set; }

        [Column("CategoryColumn")]
        public string? Category { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "The price should only be between {1} and {2}.")]
        public decimal Price { get; set; }
    }
}