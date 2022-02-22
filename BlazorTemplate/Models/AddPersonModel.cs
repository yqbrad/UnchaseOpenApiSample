using System.ComponentModel.DataAnnotations;
using BlazorTemplate.OpenAPIService;

namespace BlazorTemplate.Models
{
    public class AddPersonModel
    {
        [Required]
        [StringLength(250, ErrorMessage = "Name is too long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Name is too long.")]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public Gender Gender { get; set; }
    }
}