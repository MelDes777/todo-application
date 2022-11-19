using System;
using System.ComponentModel.DataAnnotations;

namespace todo_application.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsStarted { get; set; }
        public bool IsProgressed { get; set; }

    }
}
