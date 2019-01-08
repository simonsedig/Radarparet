using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFOrderAuto
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        // change form
        private void UserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProduktForm produktForm = new ProduktForm();
            produktForm.ShowDialog();
            this.Close();
        }

        // change form
        private void LineupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VarukorgForm varukorgForm = new VarukorgForm();
            varukorgForm.ShowDialog();
            this.Close();
        }

        // change form
        private void PlayerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProduktTillagdForm produktTillagdForm = new ProduktTillagdForm();
            produktTillagdForm.ShowDialog();
            this.Close();
        }
    }
}
