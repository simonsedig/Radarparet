using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPShoppingWarehouseClient.Classes;
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

namespace UWPShoppingWarehouseClient
{
    public sealed partial class ConfirmSendDialog : ContentDialog
    {
        // DB connection string
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        int thisCartId;
        public ConfirmSendDialog(int cartId)
        {
            this.InitializeComponent();

            // get passed cart id
            thisCartId = cartId;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
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
                            cmd.CommandText = $"update Varukorg set Levererad = @val1 where VarukorgId = '{thisCartId}'";


                            cmd.Parameters.AddWithValue("@val1", true);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch
            {
                // create reference to page to access showmsg method  
                MainPage mainPage = new MainPage();

                Debug.Write("Couldnt connect to DB");
                mainPage.ShowMessage("Något gick fel när klienten försökte kontakta databasen! Försök igen senare!");
            }
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
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
                                tempVarukorg.DatumAvslutad = Convert.ToDateTime(reader.GetString(2)).AddMinutes(15).ToLocalTime().ToString();
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
    }
}
