
using System.ComponentModel.DataAnnotations;

namespace ProPlaner.Database
{
    public sealed class Priority
    {
        [Key]
        public int PriorityId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Value { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}