using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamPickerAPI.Models;

namespace TeamPickerAPI.Contextes
{

    public class AuthServerDbContext : IdentityDbContext
    {
        public AuthServerDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
