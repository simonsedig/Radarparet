using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPShoppingWarehouseClient.Classes;
using System.Data;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPShoppingWarehouseClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // DB connection string
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // set timer = 5
        int timeLeft = 5;
        DispatcherTimer dispatcherTimer;

        public MainPage()
        {
            this.InitializeComponent();

            // add app title
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = "MHK Ordercentral";

            // will change labels to alert user if connection has been established to db
            IsConnected();

            // start timer
            StartTimers();

            OrderListView.ItemsSource = GetOrderedVarukorg("select * from Varukorg where Betalad = '1' AND Levererad = '0'");
        }

        public ObservableCollection<Varukorg> GetOrderedVarukorg(string sqlQuery)
        {
            // create varukorg-list
            ObservableCollection<Varukorg> varukorgCollection = new ObservableCollection<Varukorg>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sqlQuery;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // temporary obj
                                Varukorg tempVarukorg = new Varukorg();

                                tempVarukorg.VarukorgId = reader.GetInt32(0);
                                tempVarukorg.DatumSkapad = reader.GetDateTime(1);

                                // add 15 minutes - protocol standard for delivery time
                                tempVarukorg.DatumAvslutad = Convert.ToDateTime(reader.GetString(2)).AddMinutes(15).ToString();
                                tempVarukorg.Betalad = reader.GetBoolean(3);
                                tempVarukorg.Levererad = reader.GetBoolean(4);

                                varukorgCollection.Add(tempVarukorg);
                            }
                        }
                    }
                }
            }
            // dont allow null model
            if (varukorgCollection.Count > 0)
            {
                return varukorgCollection;
            }
            else
            {
                Debug.Write("Varukorg-model empty.");
                return null;
            }          
        }

        // used to get product by category only
        public ObservableCollection<KvittoProdukt> GetProductsKvitto(string sqlQuery)
        {
            var products = new ObservableCollection<KvittoProdukt>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = sqlQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var kvittoProduct = new KvittoProdukt();
                                    kvittoProduct.TransaktionId = reader.GetInt32(0);
                                    kvittoProduct.VarukorgId = reader.GetInt32(1);
                                    kvittoProduct.ProduktId = reader.GetInt32(2);
                                    kvittoProduct.Antal = reader.GetInt32(3);
                                    kvittoProduct.SummaProdukt = reader.GetSqlMoney(4).ToDecimal();
                                    kvittoProduct.ProduktNamn = GetProductsById(kvittoProduct.ProduktId).ProduktNamn;
                                    kvittoProduct.ProduktVikt = GetProductsById(kvittoProduct.ProduktId).ProduktVikt;

                                    products.Add(kvittoProduct);
                                }
                            }
                        }
                    }
                }

                // check if products inside collection
                if (products.Count > 0)
                {
                    return products;
                }
                else
                {
                    // will not happend - order app doesnt allow 0 product order
                    return null;
                }

            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                return null;
            }
        }

        // method which will get products by name, help sql-query which is put in name-variable
        public KvittoProdukt GetProductsById(int id)
        {
            KvittoProdukt productNamnAndVikt = new KvittoProdukt();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = $"select Namn, Vikt, Lagerplats from Produkt where ProduktId = '{id}'";
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                // will only get one name, therefore your can set produktname = product.name at the end w/o worry of being overwritten, hence id are unique
                                while (reader.Read())
                                {
                                    var product = new Produkt();
                                    product.Namn = reader.GetString(0);
                                    product.Vikt = reader.GetString(1);
                                    product.Lagerplats = reader.GetString(2);

                                    // transfer data from temp-model to new one
                                    productNamnAndVikt.ProduktNamn = product.Namn;
                                    productNamnAndVikt.ProduktVikt = product.Vikt;
                                    productNamnAndVikt.Lagerplats = product.Lagerplats;
                                }

                            }
                        }
                    }
                }
                // you dont have to worry for "id" not existing. hence it only used on items that already exists
                return productNamnAndVikt;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                ShowMessage("Produkter i varukorgen kunde ej laddas! Försök igen senare!");
                return null;
            }
        }

        // update total price
        public decimal GetTotalPrice(int id)
        {
            // total sum - will get filled through sql-query
            decimal totalSum = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // create transaction - and associate with customer cart   /// TODO!             
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = $"select SummaProdukter from ProduktTillagd where VarukorgId = '{id}'";
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                // will only get one name, therefore your can set produktname = product.name at the end w/o worry of being overwritten, hence id are unique
                                while (reader.Read())
                                {
                                    totalSum += reader.GetSqlMoney(0).ToDecimal();
                                }
                            }
                        }
                    }
                }
                return totalSum;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                ShowMessage("Kunde inte ladda priset på produkterna! Kolla anslutningen och försök igen!");
                return 0;
            }
        }

        // method which will get products by name, help sql-query which is put in name-variable
        public int GetTotalItemsAmount(int id)
        {
            ObservableCollection<KvittoProdukt> productDesc = new ObservableCollection<KvittoProdukt>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = $"select * from ProduktTillagd where VarukorgId = '{id}'";
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                // will only get one name, therefore your can set produktname = product.name at the end w/o worry of being overwritten, hence id are unique
                                while (reader.Read())
                                {
                                    var product = new KvittoProdukt();
                                    product.TransaktionId = reader.GetInt32(0);
                                    product.VarukorgId = reader.GetInt32(1);
                                    product.ProduktId = reader.GetInt32(2);
                                    product.Antal = reader.GetInt32(3);
                                    product.SummaProdukt = reader.GetSqlMoney(4).ToDecimal();

                                    productDesc.Add(product);
                                }
                            }
                        }
                    }
                }
                // you dont have to worry for "id" not existing. hence it only used on items that already exists

                // assign count of product in this var later.
                int productCount;

                // set productCount value, length of productDesc-list - catch error if = null. then it is 0 in length
                try
                {
                    productCount = productDesc.Count;
                    return productCount;
                }
                catch
                {
                    productCount = 0;
                    return productCount;
                }

            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                ShowMessage("Produkter i varukorgen kunde ej laddas! Försök igen senare!");
                return 0;
            }
        }

        public void ShowOrder(int cartnum)
        {
            // kvitto-text to be written
            string orderTxt = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = $"select * from ProduktTillagd where VarukorgId = '{cartnum}'";

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                orderTxt += $"Kundvagn ID innehåller följade produkter: \r\n-------------------------------------------";

                                while (reader.Read())
                                {
                                    // prod-id
                                    orderTxt += "\r\nProduktId: " + reader.GetInt32(2) + "\r\n";

                                    // prod-namn
                                    orderTxt += "Produktnamn: " + GetProductsById(reader.GetInt32(2)).ProduktNamn + "\r\n";

                                    // prod-vikt
                                    orderTxt += "Vikt: " + GetProductsById(reader.GetInt32(2)).ProduktVikt.ToString() + "\r\n";

                                    // lagerplats
                                    orderTxt += "Lagerplats: " + GetProductsById(reader.GetInt32(2)).Lagerplats + "\r\n";

                                    // antal
                                    orderTxt += "Antal: " + reader.GetInt32(3) + "\r\n";

                                    // totalpris
                                    orderTxt += "Totalpris: " + Convert.ToDouble(reader.GetSqlMoney(4).ToDecimal()) + " kr\r\n------------------------------------------\r\n";
                                }

                                orderTxt += $"Antal varor: {GetTotalItemsAmount(cartnum)}     Totalpris: {Convert.ToDouble(GetTotalPrice(cartnum))} kr";
                            }
                        }
                    }
                }
                // show order
                ShowMessage(orderTxt);
            }
            catch (Exception eSql)
            {
                // debug + display warning to user
                Debug.WriteLine("Exception: " + eSql.Message);
                ShowMessage("Ordern kunde inte laddas! Möjligt fel vid kontakt av databasen, försök senare!");
            }
        }

        void StartTimers()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        // callback runs on UI thread
        void dispatcherTimer_Tick(object sender, object e)
        {
            // deduct 1 from timer
            timeLeft--;

            // set label = time every tick
            TimeText.Text = timeLeft.ToString();

            if (timeLeft == 0)
            {
                // update listview
                OrderListView.ItemsSource = GetOrderedVarukorg("select * from Varukorg where Betalad = '1' AND Levererad = '0'");

                // set label = time every tick
                TimeText.Text = "Uppdaterar...";

                // reset timer, so it can update every 10 sec
                timeLeft = 5;
            }
        }

        // db online tester method
        public void IsConnected()
        {
            // try to connect to db
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    PendingText.Visibility = Visibility.Collapsed;
                    OnlineText.Visibility = Visibility.Visible;
                }
            }
            // doesnt work?
            catch
            {
                PendingText.Visibility = Visibility.Collapsed;
                OfflineText.Visibility = Visibility.Visible;
            }
        }

        // create custom messages method
        public async void ShowMessage(string msg)
        {
            var dialog = new MessageDialog(msg);
            await dialog.ShowAsync();
        }

        private void ViewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            // set button as sender
            Button button = (Button)sender;

            // fills produkt class with selected class
            Varukorg selectedVarukorg = button.DataContext as Varukorg;

            // show order
            ShowOrder(selectedVarukorg.VarukorgId);
        }

        private async void OrderDeliveredButton_Click(object sender, RoutedEventArgs e)
        {
            // set button as sender
            Button button = (Button)sender;

            // fills produkt class with selected class
            Varukorg selectedVarukorg = button.DataContext as Varukorg;

            // send cartId
            ConfirmSendDialog confirmSendDialog = new ConfirmSendDialog(selectedVarukorg.VarukorgId);

            // show dialog
            await confirmSendDialog.ShowAsync();           
        }

        //// used to get product by category only
        //public ObservableCollection<KvittoProdukt> GetProductsOrder(string sqlQuery)
        //{
        //    // store id
        //    List<int> productsId = new List<int>();

        //    // store all transactions
        //    var products = new ObservableCollection<KvittoProdukt>();

        //    //  try
        //    // {
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //        {

        //        conn.Open();
        //        if (conn.State == System.Data.ConnectionState.Open)
        //        {
        //            using (SqlCommand cmd = conn.CreateCommand())
        //            {
        //                cmd.CommandText = sqlQuery;
        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        var kvittoProduct = new KvittoProdukt();
        //                        int tempVarukorgId = reader.GetInt32(0);

        //                        if (tempVarukorgId != 0)
        //                        {
        //                            productsId.Add(tempVarukorgId);
        //                        }                                    
        //                    }
        //                }
        //            }

        //            using (SqlCommand newCmd = conn.CreateCommand())
        //            {
        //                newCmd.CommandText = "select * from ProduktTillagd";
        //                using (SqlDataReader reader = newCmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        var kvittoProduct = new KvittoProdukt();
        //                        kvittoProduct.TransaktionId = reader.GetInt32(0);
        //                        kvittoProduct.VarukorgId = reader.GetInt32(1);
        //                        kvittoProduct.ProduktId = reader.GetInt32(2);
        //                        kvittoProduct.Antal = reader.GetInt32(3);
        //                        kvittoProduct.SummaProdukt = reader.GetSqlMoney(4).ToDecimal();

        //                        // get prod-name + weight by helper-method
        //                        kvittoProduct.ProduktNamn = GetProductsById(kvittoProduct.ProduktId).ProduktNamn;
        //                        kvittoProduct.ProduktVikt = GetProductsById(kvittoProduct.ProduktId).ProduktVikt;

        //                        products.Add(kvittoProduct);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    // create temp list to get all transactions of accepted carts
        //    var tempProductsList = new List<KvittoProdukt>();

        //    // add unique id
        //    foreach (var kundvagnIdOK in productsId)
        //    {
        //        tempProductsList.AddRange(products.Where(x => x.VarukorgId == kundvagnIdOK));
        //    }

        //    // create final cart (observable collection)
        //    OrderProducts finalProductList = new OrderProducts();

        //    foreach (var item in tempProductsList)
        //    {
        //        finalProductList.Final.Add(item);
        //    }

        //    // check if products inside collection
        //    if (finalProductList.Final.Count > 0)
        //    {
        //        OrderEmptyText.Visibility = Visibility.Collapsed;
        //        return finalProductList.Final;
        //    }
        //    else
        //    {
        //        OrderEmptyText.Visibility = Visibility.Visible;
        //        return null;
        //    }

        //   // }
        //    //catch (Exception eSql)
        //    //{
        //    //    Debug.WriteLine("Exception: " + eSql.Message);
        //    //    // mainPage.ShowMessage("Product @ Order could not be loaded!");
        //    //    return null;
        //    //}
        //}

        //// method which will get products by name, help sql-query which is put in name-variable
        //public KvittoProdukt GetProductsById(int id)
        //{
        //    KvittoProdukt productNamnAndVikt = new KvittoProdukt();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            if (conn.State == System.Data.ConnectionState.Open)
        //            {
        //                using (SqlCommand cmd = conn.CreateCommand())
        //                {
        //                    cmd.CommandText = $"select Namn, Vikt from Produkt where ProduktId = '{id}'";
        //                    using (SqlDataReader reader = cmd.ExecuteReader())
        //                    {
        //                        // will only get one name, therefore your can set produktname = product.name at the end w/o worry of being overwritten, hence id are unique
        //                        while (reader.Read())
        //                        {
        //                            var product = new Produkt();
        //                            product.Namn = reader.GetString(0);
        //                            product.Vikt = reader.GetString(1);

        //                            // transfer data from temp-model to new one
        //                            productNamnAndVikt.ProduktNamn = product.Namn;
        //                            productNamnAndVikt.ProduktVikt = product.Vikt;
        //                        }

        //                    }
        //                }
        //            }
        //        }
        //        // you dont have to worry for "id" not existing. hence it only used on items that already exists
        //        return productNamnAndVikt;
        //    }
        //    catch (Exception eSql)
        //    {
        //        // create reference              
        //        Debug.WriteLine("Exception: " + eSql.Message);
        //        OfflineText.Text = "Could not establish connection with DB!";
        //        OnlineText.Text = "Could not establish connection with DB!";
        //    }
        //    return null;
        //}
    }
}
