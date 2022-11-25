using System;
using System.ComponentModel.DataAnnotations;

namespace todo_application.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a Description!")]
        [MinLength(3, ErrorMessage = "Title must contain at least two characters!")]
        [MaxLength(200, ErrorMessage = "Title must contain a maximum of 200 characters!")]
        public string Description { get; set; }

        
        [Required(ErrorMessage = "You must pick a Date!")]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        
        [Required(ErrorMessage = "You must pick a Due Date!")]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Started")]
        public bool IsStarted { get; set; }

        [Display(Name = "In Progress")]
        public bool IsProgressed { get; set; }

    }
}
