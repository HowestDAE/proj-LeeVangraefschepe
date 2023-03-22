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
        private List<Item> items;
        private bool isLoading = false;

        public OverviewVM()
        {

        }
        async void GetItems(int category, string name)
        {
            Items = await _itemAPIRepository.GetItems(category, name);
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
        public void SearchItems(int category, string name)
        {
            IsLoading = true;
            GetItems(category, name);
            IsLoading = false;
        }
    }
}
