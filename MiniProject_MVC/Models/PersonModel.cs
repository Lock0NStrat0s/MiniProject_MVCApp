using System.ComponentModel.DataAnnotations;

namespace MiniProject_MVC.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Active User")]
        public bool IsActive { get; set; }
    }
}
