using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFSpelarPortalAdmin1
{
    public partial class Form1 : Form
    {
        // connection string to connect to sql db @ azure
        const string connectionString = "Data Source=footballnow.database.windows.net;Initial Catalog=FootyDB;Persist Security Info=True;User ID=joca0024;Password=Sqlfoot1";

        public Form1()
        {            
            InitializeComponent();
        }

        private void AttemptButton_Click(object sender, EventArgs e)
        {
            // check db-connection
            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    sql.Open();
                    ConnectedLabel.Visible = true;
                    DisconnectedLabel.Visible = false;
                    UndefinedLabel.Visible = false;
                }
            }
            catch
            {
                DisconnectedLabel.Visible = true;
                ConnectedLabel.Visible = false;
                UndefinedLabel.Visible = false;
            }
        }

        // change form
        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            this.Close();
        }

        // change form
        private void LineupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineupForm lineupForm = new LineupForm();
            lineupForm.ShowDialog();
            this.Close();
        }

        // change form
        private void PlayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
            this.Close();
        }

        // change form
        private void FixtureButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FixtureForm fixtureForm = new FixtureForm();
            fixtureForm.ShowDialog();
            this.Close();
        }

        // change form
        private void TableButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableForm tableForm = new TableForm();
            tableForm.ShowDialog();
            this.Close();
        }
    }
}
