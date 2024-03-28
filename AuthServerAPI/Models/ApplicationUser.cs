using Microsoft.AspNetCore.Identity;
using TeamPickerAPI.Enums;

namespace TeamPickerAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Nickname { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public UserType? UserType { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiry { get; set; }
    }
}
