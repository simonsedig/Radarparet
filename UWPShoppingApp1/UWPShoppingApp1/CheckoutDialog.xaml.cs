using System;
using System.Collections.Generic;
using System.Data;
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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPShoppingApp1
{
    public sealed partial class CheckoutDialog : ContentDialog
    {
        // save passed variables
        int cartId;


        // DB connection string
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public CheckoutDialog(int id)
        {
            this.InitializeComponent();

            // set int cartId = current cart of user
            cartId = id;
        }

        // yes option
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // create references to other pages to access printticket-method & showmessage-method
            ShoppingPage shoppingPage = new ShoppingPage();
            MainPage mainPage = new MainPage();

            // check so cart/kvitto is not empty
            if (shoppingPage.GetTotalItemsAmount(cartId) > 0)
            {
                try
                {
                    // open connection to DB - try to insert new values - BETALAD = true, Timeofcompletion = DateTime.Now
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
                                // current time = time of completion, 
                                cmd.CommandText = $"update Varukorg set DatumAvslutad = @val1, Betalad = @val2 where VarukorgId = '{cartId}'";


                                cmd.Parameters.AddWithValue("@val1", DateTime.Now.ToLocalTime());
                                // 
                                cmd.Parameters.AddWithValue("@val2", 1);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    // print ticket
                    PrintTicket(cartId);

                    // display purchase successful
                    mainPage.ShowMessage("Köp slutfört! Skriver ut kvitto...");

                    // transfer user to main screen
                    (Window.Current.Content as Frame)?.Navigate(typeof(MainPage));
                }
                catch
                {
                    // create reference to page to access showmsg method                   
                    mainPage.ShowMessage("Kunde inte kontakta databasen när köpet skulle slutföras, försök igen senare!");
                }
            }
            else
            {
                // create reference to first page to access showmessage method
                mainPage.ShowMessage("Din kundvagn är tom! Lägg till några produkter och testa igen.");
            }

        }

        // no option
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // do nothing. close window
        }

        public async void PrintTicket(int cartnum)
        {
            // reference to other page
            ShoppingPage shoppingPage = new ShoppingPage();

            // kvitto-text to be written
            string kvittoTxt = "";

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
                            cmd.CommandText = $"select * from ProduktTillagd where VarukorgId = '{cartId}'";

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                kvittoTxt += $"Välkommen till MHK Stormarknad! \r\nDagens Datum: {DateTime.Now.ToLocalTime()}\r\nVarukorg ID: {cartId}\r\nTid för uthämtning: {DateTime.Now.ToLocalTime().AddMinutes(15)}\r\n-------------------------------------------";

                                while (reader.Read())
                                {
                                    // prod-id
                                    kvittoTxt += "\r\nProduktId: " + reader.GetInt32(2) + "\r\n";

                                    // prod-namn
                                    kvittoTxt += shoppingPage.GetProductsById(reader.GetInt32(2)).ProduktNamn + "\r\n";

                                    // prod-vikt
                                    kvittoTxt += shoppingPage.GetProductsById(reader.GetInt32(2)).ProduktVikt.ToString() + "\r\n";

                                    // antal
                                    kvittoTxt += "Antal: " + reader.GetInt32(3) + "\r\n";

                                    // totalpris
                                    kvittoTxt += "Totalpris: " + Convert.ToDouble(reader.GetSqlMoney(4).ToDecimal()) + " kr\r\n------------------------------------------\r\n";
                                }

                                kvittoTxt += $"Antal varor: {shoppingPage.GetTotalItemsAmount(cartId)}     Totalpris: {Convert.ToDouble(shoppingPage.GetTotalPrice(cartId))} kr \r\nVälkommen åter!";

                                // create file, if it exists generates unique name
                                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                                Windows.Storage.StorageFile newFile = await storageFolder.CreateFileAsync("customerReceipt.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

                                // get file
                                Windows.Storage.StorageFile fineFile = await storageFolder.GetFileAsync("customerReceipt.txt");

                                // print text to file
                                await Windows.Storage.FileIO.WriteTextAsync(fineFile, kvittoTxt);
                            }
                        }
                    }
                }
            }
            catch (Exception eSql)
            {
                // reference to other page
                MainPage mainPage = new MainPage();

                Debug.WriteLine("Exception: " + eSql.Message);
                mainPage.ShowMessage("Products could not be loaded! Therefore cant be printed");
            }
        }
    }
}
        

