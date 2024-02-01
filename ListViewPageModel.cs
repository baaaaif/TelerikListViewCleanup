using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikListViewCleanup
{
    public partial class ListViewPageModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListViewModel>? _Items;

        public void LoadItems()
        {
            Items = [];
            for (int i = 0; i < 10; i++)
                Items.Add(new ListViewModel() { Index = i, Name = $"Name {i}" });
        }
    }
}
