using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models.Enums
{
    public enum Status
    {
        [Display(Name = "To Do")]
        ToDo,
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Completed")]
        Done
    }
}
