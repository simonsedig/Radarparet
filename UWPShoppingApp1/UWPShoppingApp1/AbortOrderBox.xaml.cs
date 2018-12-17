using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    public sealed partial class AbortOrderBox : ContentDialog
    {
        const string connectionString = "Server=tcp:footballnow.database.windows.net,1433;Initial Catalog=ShoppingDB;Persist Security Info=False;User ID=joca0024;Password=Sqlfoot1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // cart Id
        int currentCartId;

        public AbortOrderBox(int passedCustomerId)
        {
            this.InitializeComponent();

            // set current cart id to passed id;
            currentCartId = passedCustomerId;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // try to delete current cart, if not possible. Admin will have to do this manually.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // remove everything that has to do with current cartId if they cancel purchase. (part 1, produkttillagd-activity)
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = $"delete from ProduktTillagd where VarukorgId = '{currentCartId}'";

                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();

                // remove everything that has to do with current cartId if they cancel purchase. (part 2, varukorg)
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = $"delete from Varukorg where VarukorgId = '{currentCartId}'";

                        cmd.ExecuteNonQuery();
                    }
                }

                // no errors? transfer user to main screen
                (Window.Current.Content as Frame)?.Navigate(typeof(MainPage));
            }
            // no errors = will go through whole process to connect to new page

            //}
            //catch
            //{
            //    ShowMessage("Something went from trying to remove cart and its connected components... Admin will have to remove manually! Have a good day!");     
            //
            // transfer user
            // (Window.Current.Content as Frame)?.Navigate(typeof(MainPage));
            //}
        }
  
        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // else close dialog
        }
    }
}
