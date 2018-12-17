using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPShoppingWarehouseClient.Classes
{
    public class OrderProducts
    {
        public ObservableCollection<KvittoProdukt> Final { get; set; }
        
        // init list
        public OrderProducts()
        {
            KvittoProdukt kvittoProdukt = new KvittoProdukt();
            this.Final = new ObservableCollection<KvittoProdukt>();
        }
    }

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
        public string Lagerplats { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

    // Varukorg class
    public class Varukorg : INotifyPropertyChanged
    {
        public int VarukorgId { get; set; }
        public DateTime DatumSkapad { get; set; }
        public string DatumAvslutad { get; set; }
        public Boolean Betalad { get; set; }
        public Boolean Levererad { get; set; }


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
