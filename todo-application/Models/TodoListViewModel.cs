using System.Collections.Generic;

namespace todo_application.Models
{
    public class TodoListViewModel
    {
     
        public List<Todo> TodoItems { get; set; }

        public Todo EditableItem { get; set; }
    }
}
