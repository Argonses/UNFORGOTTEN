using Microsoft.AspNetCore.Identity;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public DateTime BornDate { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}