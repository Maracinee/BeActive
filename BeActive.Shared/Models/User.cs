using System.ComponentModel.DataAnnotations;

namespace BeActive.Shared.Models
{
    public class User
    {
        [Key]
        public Guid IdUser { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

    }
}