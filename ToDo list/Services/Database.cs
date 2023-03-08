using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_list.Models;

namespace ToDo_list.Services
{
    public class Database
    {
        public IEnumerable<TodoItem> GetItems() => new[]
        {
            new TodoItem {Desc = "Walk the dog"},
            new TodoItem {Desc = "Wash the car"},
            new TodoItem {Desc = "Learn Avalonia", IsChecked = true},
        };
    }
}
