using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPShoppingApp1.Classes
{

    // product class
    public class KvittoProdukt : INotifyPropertyChanged
    {
        public int TransaktionId { get; set; }
        public int VarukorgId { get; set; }
        public int ProduktId { get; set; }
        public int Antal { get; set; }
        public decimal SummaProdukt { get; set; }
        public string ProduktNamn { get; set; }
        public string ProduktVikt { get; set; }


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
