using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ToDo_list.Models;

namespace ToDo_list.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        string desc;

        public ReactiveCommand<Unit, TodoItem> Ok { get; set; }
        public ReactiveCommand<Unit, Unit> Cancel { get; set; }

        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(x => x.Desc, x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(() => new TodoItem { Desc = Desc }, okEnabled);
            Cancel = ReactiveCommand.Create(() => { });
        }

        public string Desc
        {
            get { return this.desc; }
            set { this.RaiseAndSetIfChanged(ref this.desc, value); }
        }
    }
}
