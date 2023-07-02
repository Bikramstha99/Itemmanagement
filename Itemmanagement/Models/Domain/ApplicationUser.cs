using Microsoft.AspNetCore.Identity;

namespace Itemmanagement.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
    }
}
