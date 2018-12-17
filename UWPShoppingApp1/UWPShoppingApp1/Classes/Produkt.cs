using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPShoppingApp1.Classes
{
    // product class
    public class Produkt : INotifyPropertyChanged
    {
        public int ProduktId { get; set; }
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public string Kategori { get; set; }
        public string Bildadress { get; set; }
        public string Vikt { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
