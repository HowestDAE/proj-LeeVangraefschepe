using CommunityToolkit.Mvvm.ComponentModel;
using RunescapeItemSearcher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescapeItemSearcher.ViewModel
{
    public class DetailVM : ObservableObject
    {
        private Item item;

        public DetailVM() { }
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
