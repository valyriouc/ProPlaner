
using System.ComponentModel.DataAnnotations;

namespace ProPlaner.Database
{
    public sealed class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime? Deadline { get; set; }

        public bool IsFinished { get; set; }

        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}