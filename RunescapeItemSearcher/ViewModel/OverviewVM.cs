using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RunescapeItemSearcher.Model;
using RunescapeItemSearcher.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RunescapeItemSearcher.ViewModel
{
    public class OverviewVM : ObservableObject
    {
        ItemAPIRepository _itemAPIRepository = new ItemAPIRepository();
        private List<Item> items = new List<Item>();
        private bool isLoading = false;
        private List<Category> _categories = new List<Category>();
        private Item selectedItem;

        public OverviewVM()
        {
            Categories = _itemAPIRepository.GetCategories();
            SelectedCategory = Categories[0];
            ShowDetailPage = new RelayCommand(LoadDetailPage, IsSelected);
        }
        async void GetItems(string name)
        {
            IsLoading = true;
            Items = await _itemAPIRepository.GetItems(name, SelectedCategory);
            IsLoading = false;
        }
        public List<Category> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged(nameof(Categories));
            }
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
        public Category SelectedCategory { get; set; }
        public MainVM MainVM { get; set; }
        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
                ShowDetailPage.NotifyCanExecuteChanged();
            }
        }
        public RelayCommand ShowDetailPage { get; private set; }
        public void LoadDetailPage()
        {
            MainVM.GotoDetails(SelectedItem);
        }
        public bool IsSelected()
        {
            return SelectedItem != null;
        }
        public void SearchItems(string name)
        {
            Items = new List<Item>();
            GetItems(name);
        }
    }
}