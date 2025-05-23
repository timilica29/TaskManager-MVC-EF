using System.ComponentModel.DataAnnotations;
using TaskManager.Models.Enums;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public Status TaskStatus { get; set; }
    }
}
