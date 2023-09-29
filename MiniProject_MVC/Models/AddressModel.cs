using System.ComponentModel.DataAnnotations;

namespace MiniProject_MVC.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [StringLength(6, MinimumLength = 6)]
        public string PostalCode { get; set; }
    }
}
