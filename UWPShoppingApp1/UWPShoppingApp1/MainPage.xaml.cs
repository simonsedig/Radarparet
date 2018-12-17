using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPShoppingApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // DB connection string
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public MainPage()
        {
            this.InitializeComponent();

            // add app title
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = "MHK Shoppingcentral";

            // will change labels to alert user if connection has been established to db
            IsConnected();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {          
            // check if store is online - again
            try
            {
                // productId of created cart which will be passed on to next page
                int produktIdCart = 0;

                // try est connection to db
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // create new cart for customers
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        // create a standard empty cart = sql constructor? :>
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            DateTime currentTime = DateTime.Now.ToLocalTime();

                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = @"INSERT INTO Varukorg (DatumAvslutad, DatumSkapad, Betalad, Levererad) VALUES(@val1, @val2, @val3, @val4)";

                            cmd.Parameters.AddWithValue("@val1", "");
                            cmd.Parameters.AddWithValue("@val2", currentTime);
                            cmd.Parameters.AddWithValue("@val3", 0);
                            cmd.Parameters.AddWithValue("@val4", 0);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    // get the id of cart which was newly created
                    if (conn.State == System.Data.ConnectionState.Open)
                    {                       
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            DateTime currentTime = DateTime.Now.ToLocalTime();

                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;

                            cmd.CommandText = @"select max(VarukorgId) from Varukorg";

                            produktIdCart = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                    }
                    conn.Close();
                }
                // no errors = will go through whole process to connect to new page
                
                // sql will auto-increment, therefor will not allow zero. if everything went fine, should not be zero
                if (produktIdCart != 0)
                {
                    // navigate to next page to begin order
                    this.Frame.Navigate(typeof(ShoppingPage), produktIdCart);
                }
            }
            catch
            {
                ShowMessage("Could not pass you through to the catalog since connection to database failed!");
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
    }
}
