using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using UWPShoppingApp1.Classes;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPShoppingApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShoppingPage : Page
    {
        // const current cart id (saved from passed variable), will get from e.parameter
        int cartId;

        // DB connection string
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // access other page through model
        MainPage mainPage = new MainPage();

        // override navigation-event to get passed variable kundvagnId
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is int)
            {
                CartId.Text = e.Parameter.ToString();
                cartId = int.Parse(e.Parameter.ToString());
            }
            else
            {
                CartId.Text = "Error getting Id";
            }

            // make cart empty text visible
            CartEmptyText.Visibility = Visibility.Visible;
        }

        public ShoppingPage()
        {
            this.InitializeComponent();

            GridViewItem.ItemsSource = GetProducts("select * from Produkt");

            // since cart will always be empty from start, you dont need to set itemsource until you add item. -> button AddItemToCart will set itemsource and update it eachtime item is added.
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
                CartEmptyText.Visibility = Visibility.Collapsed;
                return products;
            }
            else
            {
                CartEmptyText.Visibility = Visibility.Visible;
                return null;
            }

            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Products @ Kvitto could not be loaded!");
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
                        cmd.CommandText = $"select Namn, Vikt from Produkt where ProduktId = '{id}'";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // will only get one name, therefore your can set produktname = product.name at the end w/o worry of being overwritten, hence id are unique
                            while (reader.Read())
                            {
                                var product = new Produkt();
                                product.Namn = reader.GetString(0);
                                product.Vikt = reader.GetString(1);

                                // transfer data from temp-model to new one
                                productNamnAndVikt.ProduktNamn = product.Namn;
                                productNamnAndVikt.ProduktVikt = product.Vikt;
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
                mainPage.ShowMessage("Could not establish connection with DB!");
            }
            return null;
        }

        // used to get product by category only
        public ObservableCollection<Produkt> GetProducts(string sqlQuery)
        {           
            var products = new ObservableCollection<Produkt>();

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
                                var product = new Produkt();
                                product.ProduktId = reader.GetInt32(0);
                                product.Namn = reader.GetString(1);
                                product.Pris = reader.GetSqlMoney(2).ToDecimal();
                                product.Kategori = reader.GetString(3);                                
                                product.Bildadress = reader.GetString(4);
                                product.Vikt = reader.GetString(5);

                                products.Add(product);
                            }
                        }
                    }
                }
            }

            // check if products inside collection
            if (products.Count > 0)
            {
                NoProductText.Visibility = Visibility.Collapsed;
                return products;
            }
            else
            {
                NoProductText.Visibility = Visibility.Visible;
                return null;
            }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Could not establish connection with DB!");
                return null;
            }
            
        }

        // method which will get products by name, help sql-query which is put in name-variable
        public ObservableCollection<Produkt> GetProductsByName(string name)
        {
            var products = new ObservableCollection<Produkt>();
            try
            {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"select * from Produkt where Namn like '%{name}%'";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Produkt();
                                product.ProduktId = reader.GetInt32(0);
                                product.Namn = reader.GetString(1);
                                product.Pris = reader.GetSqlMoney(2).ToDecimal();
                                product.Kategori = reader.GetString(3);
                                product.Bildadress = reader.GetString(4);
                                product.Vikt = reader.GetString(5);

                                products.Add(product);
                            }
                        }
                    }
                }
            }

            // check if products inside collection
            if (products.Count > 0)
            {
                NoProductText.Visibility = Visibility.Collapsed;
                return products;
            }
            else
            {
                NoProductText.Visibility = Visibility.Visible;
                return null;
            }
            
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Products could not be loaded!");
                return null;
            }
            
        }

                // abort button click
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // add funcitonality to first CHECK if db connection is ok, then remove order??
            // pass cartId to try to automatically remove
            AbortOrderBox abortOrderBox = new AbortOrderBox(cartId);

            await abortOrderBox.ShowAsync();
        }


        // ** Produkt Windows buttons 
        // remove -1 product from current product count
        private void MinusProdukt_Click(object sender, RoutedEventArgs e)
        {           
            // associate button, bind button to txtbox tag

            Button btn = (Button)sender;
            TextBox textBox = (TextBox)btn.Tag;

            // store and remove number - transfer new val to box
            int tempVal = int.Parse(textBox.Text);

            // dont allow 0 or less as amount
            if (tempVal > 1)
            {
                tempVal--;

                string newVal;
                newVal = tempVal.ToString();

                textBox.Text = newVal;
                this.DataContext = newVal;
            }
            else 
            {
                // if 0 or less, do nothing
            }
        }

        // add +1 product to current product count
        private void PlusProduct_Click(object sender, RoutedEventArgs e)
        {
            // associate button, bind button to txtbox tag
            Button btn = (Button)sender;
            TextBox textBox = (TextBox)btn.Tag;

            // store and remove number - transfer new val to box
            int tempVal = int.Parse(textBox.Text);

            // dont allow more than 99 as amount
            if (tempVal >= 99)
            {
                // do nothing
            }
            else
            {
                tempVal++;

                string newVal;
                newVal = tempVal.ToString();

                textBox.Text = newVal;
            }
        }
        

        private void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            // associate button with id-tag, 
            Button btn = (Button)sender;    
            
            // gets amount of produkt user wants to order
            TextBox amountTxt = (TextBox)btn.Tag;

            // fills produkt class with selected class
            Produkt selectedProdukt = btn.DataContext as Produkt;

            // try to add item to cart
            try
            {
                // open connection to DB
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // create transaction - and associate with customer cart   /// TODO!             
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = @"INSERT INTO ProduktTillagd (VarukorgId, ProduktId, Antal, SummaProdukter) VALUES(@val1, @val2, @val3, @val4)";

                            cmd.Parameters.AddWithValue("@val1", cartId);
                            cmd.Parameters.AddWithValue("@val2", selectedProdukt.ProduktId);
                            cmd.Parameters.AddWithValue("@val3", int.Parse(amountTxt.Text));
                            cmd.Parameters.AddWithValue("@val4", (Convert.ToDecimal(int.Parse(amountTxt.Text)) * selectedProdukt.Pris));

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // call method from other class
                    mainPage.ShowMessage($"Produkten {selectedProdukt.Namn} har lagts till i din varukorg!");

                    // update listview reciept, only shows current cart. which was created by user when user started this order
                    KvittoListView.ItemsSource = GetProductsKvitto($"select * from ProduktTillagd where VarukorgId = '{cartId}'");

                    // update totalprice + amount of cart
                    TotalPrisKvitto.Text = $"Totalpris: {GetTotalPrice(cartId).ToString("0.00")} kr";
                    TotalVarorKvitto.Text = $"Antal varor: {GetTotalItemsAmount(cartId)}";

                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Could not add object to cart! Database issues? Check connection");
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
                mainPage.ShowMessage("Could not retrieve prices of items! Database issues? Check connection");
                return 0;
            }
        }

        // method which will get products by name, help sql-query which is put in name-variable
        public int GetTotalItemsAmount (int id)
        {
            ObservableCollection<KvittoProdukt> productDesc= new ObservableCollection<KvittoProdukt>();
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
                mainPage.ShowMessage("Products in cart could not be loaded! Therefore cant be counted");
                return 0;
            }            
        }

        // Show product buttons - categories
        private void ShowAllProductsButton_Click(object sender, RoutedEventArgs e)
        {
            GridViewItem.ItemsSource = GetProducts("select * from Produkt");
        }

        private void ShowMeatButton_Click(object sender, RoutedEventArgs e)
        {
            GridViewItem.ItemsSource = GetProducts("select * from Produkt where Kategori = 'Kött'");
        }

        private void ShowMejeriButton_Click(object sender, RoutedEventArgs e)
        {
            GridViewItem.ItemsSource = GetProducts("select * from Produkt where Kategori = 'Mejeri'");
        }

        private void ShowVegetableButton_Click(object sender, RoutedEventArgs e)
        {
            GridViewItem.ItemsSource = GetProducts("select * from Produkt where Kategori = 'Frukt & Grönsaker'");
        }

        private void ShowExtrasButton_Click(object sender, RoutedEventArgs e)
        {
            GridViewItem.ItemsSource = GetProducts("select * from Produkt where Kategori = 'Diverse'");
        }

        // seach-textbox changed
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // try to find
            try
            {
                GridViewItem.ItemsSource = GetProductsByName(SearchBox.Text);

                // if user empties box, show all products
                if (SearchBox.Text == "")
                {
                    GridViewItem.ItemsSource = GetProducts("select * from Produkt");
                }
            }
            catch
            {
                // continue search until find
            }            
        }

        // delete button for items
        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            // associate button with id-tag, 
            Button btn = (Button)sender;

            // fills produkt class with selected class
            KvittoProdukt selectedProdukt = btn.DataContext as KvittoProdukt;

            try
            {
                // open connection to DB
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // create transaction - and associate with customer cart   /// TODO!             
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = $"delete from ProduktTillagd where TransaktionId = '{selectedProdukt.TransaktionId}'";

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // update listview reciept, only shows current cart. which was created by user when user started this order
                    KvittoListView.ItemsSource = GetProductsKvitto($"select * from ProduktTillagd where VarukorgId = '{cartId}'");

                    // update totalprice of cart
                    TotalPrisKvitto.Text = $"Totalpris: {GetTotalPrice(cartId).ToString("0.00")} kr";
                    TotalVarorKvitto.Text = $"Antal varor: {GetTotalItemsAmount(cartId)}";
                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Products in cart could not be loaded! Therefore cant be deleted");
            }
        }

        // print reciept through method
        private async void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {           
            CheckoutDialog checkoutDialog = new CheckoutDialog(cartId);
            await checkoutDialog.ShowAsync();
        }

    }
}
