
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProPlaner.Database
{
    public sealed class Promodoro
    {
        [Key]
        public int PromodoroId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool IsFinished { get; set; } = false;

        [ForeignKey("JobId")]
        public int JobId { get; set; }

        public Job Job { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}