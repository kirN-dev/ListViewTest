using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTest
{
    internal class MainViewModel 
    {
        public ObservableCollection<ItemModel> Items { get; set; }

        public ItemModel SelectedItem { get; set; }

        public MainViewModel()
        {
            Items = new()
            {
                new ItemModel{ Name = "Kek", Wieght = 1},
                new ItemModel{ Name = "fgf", Wieght = 11}
            };
        }
    }
}
