using AuthServerAPI.Enums;
using Microsoft.AspNetCore.Identity;

namespace AuthServerAPI.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public required string FullName { get; set; }
        public required string Nickname { get; set; }
        public DateOnly? DateOfBirth {  get; set; }
        public required UserType UserType { get; set; }
    }
}
