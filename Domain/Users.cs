using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Users : IdentityUser
    {
        [Required, MaxLength(120)]
        public string FirstName { get; set; }
        [Required, MaxLength(120)]
        public string LastName { get; set; }
        [MaxLength(120)]
        public string Address { get; set; }
    }
}
