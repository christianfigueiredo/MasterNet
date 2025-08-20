using Microsoft.AspNetCore.Identity;

namespace MasterNet.Persistence.Models
{
    public class AppUser : IdentityUser
    {
        public string? NomeCompleto { get; set; }
        public string? Profissao { get; set; }
    }
}