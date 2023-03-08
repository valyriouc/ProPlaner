
using System.ComponentModel.DataAnnotations;

namespace ProPlaner.Database
{
    public sealed class Job
    {
        [Key]
        public int JobId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        public Priority Priority { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public int? ProjectId { get; set; }

        public Project? Project { get; set; }
    }
}