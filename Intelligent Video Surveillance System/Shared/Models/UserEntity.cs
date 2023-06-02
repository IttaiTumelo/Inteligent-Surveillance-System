global using System.ComponentModel.DataAnnotations.Schema;

namespace Intelligent_Video_Surveillance_System.Shared.Models
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        [NotMapped]
        public string Name { get=>$"{FirstName} {LastName}"; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        admin, superadmin
    }
}
