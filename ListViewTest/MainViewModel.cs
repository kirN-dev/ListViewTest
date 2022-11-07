using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTest
{
    internal class MainViewModel 
    {
        public ObservableCollection<ItemModel> Items { get; set; }
        public RelayCommand AddItemCommand{ get; set; }
        public RelayCommand ChangeItemCommand{ get; set; }
        public RelayCommand DeleteItemCommand{ get; set; }
        public ItemModel SelectedItem { get; set; }

        public MainViewModel()
        {
            AddItemCommand = new RelayCommand(o => AddItem());
            ChangeItemCommand = new RelayCommand(o => ChangeItem());
            DeleteItemCommand = new RelayCommand(o => DeleteItem());

            Items = new()
            {
                new ItemModel{ Name = "Kek", Wieght = 1},
                new ItemModel{ Name = "fgf", Wieght = 11}
            };
        }

        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }

        private void ChangeItem()
        {
            throw new NotImplementedException();
        }

        private void AddItem()
        {
            var newItem = new ItemModel { Name = SelectedItem.Name, Wieght = SelectedItem.Wieght };

            Items.Add(newItem);
        }
    }
}
