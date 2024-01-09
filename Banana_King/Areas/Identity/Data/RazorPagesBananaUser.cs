using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Banana_King.Areas.Identity.Data
{
    public class RazorPagesBananaUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;
    }
}