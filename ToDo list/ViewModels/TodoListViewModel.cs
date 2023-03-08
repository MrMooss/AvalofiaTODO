﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_list.Models;

namespace ToDo_list.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items) 
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}