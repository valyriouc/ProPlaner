
using System.ComponentModel.DataAnnotations;

namespace ProPlaner.Database
{
    public sealed class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(12)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*?[0-9])(?=.*?[!#%])[A-Za-z0-9!#%]{12,}$")]
        public string Password { get; set; }

        public List<Promodoro> Promodoros { get; set; }

        public List<Project> Projects { get; set; }

        public List<Job> Jobs { get; set; }

        public List<Priority> Priorities { get; set; }
    }
}