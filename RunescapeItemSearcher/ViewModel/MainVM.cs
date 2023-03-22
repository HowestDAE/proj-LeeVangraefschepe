using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RunescapeItemSearcher.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RunescapeItemSearcher.ViewModel
{
    public class MainVM : ObservableObject
    {
        public MainVM()
        {
            CurrentPage = MainPage;
            SearchItemCommand = new RelayCommand(SearchItem);
        }
        private Page currentPage;
        private string itemSearchBox = "";

        public string ItemSearchBox
        {
            get { return itemSearchBox; }
            set
            {
                itemSearchBox = value;
                OnPropertyChanged(nameof(ItemSearchBox));
            }
        }
        public OverviewPage MainPage { get; set; } = new OverviewPage();
        public Page CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }
        public RelayCommand SearchItemCommand { get; private set; }
        private void SearchItem()
        {
            var overviewVM = MainPage.DataContext as OverviewVM;
            overviewVM.SearchItems(0, ItemSearchBox.ToLower());
        }
    }
}
