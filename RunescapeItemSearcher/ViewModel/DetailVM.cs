using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RunescapeItemSearcher.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.ViewModel
{
    public class DetailVM : ObservableObject
    {
        private Item item;

        public DetailVM()
        {
            OpenPageCommand = new RelayCommand(OpenPage);
        }
        public RelayCommand OpenPageCommand { get; private set; }
        private void OpenPage()
        {
            Process.Start($"https://secure.runescape.com/m=itemdb_rs/Bond/viewitem?obj={item.Id}");
        }
        public Item Item
        {
            get { return item; }
            set
            {
                item = value;
                OnPropertyChanged(nameof(Item));
            }
        }
    }
}
