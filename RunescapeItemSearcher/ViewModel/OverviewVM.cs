using CommunityToolkit.Mvvm.ComponentModel;
using RunescapeItemSearcher.Model;
using RunescapeItemSearcher.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.ViewModel
{
    public class OverviewVM : ObservableObject
    {
        ItemAPIRepository _itemAPIRepository = new ItemAPIRepository();
        private List<Item> items = new List<Item>();
        private bool isLoading = false;

        public OverviewVM()
        {

        }
        async void GetItems(string name)
        {
            IsLoading = true;
            Items = await _itemAPIRepository.GetItems(name);
            IsLoading = false;
        }
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }
        public List<Item> Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged(nameof(Items));
            }
        }
        public void SearchItems(string name)
        {
            Items = new List<Item>();
            GetItems(name);
        }
    }
}
