using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFOrderAuto.Models;

namespace WFOrderAuto
{
    public partial class ProduktTillagdForm : Form
    {
        // access to ShoppingModel
        Models.ProduktTillagd ProduktTillagdModel = new Models.ProduktTillagd();
        public ProduktTillagdForm()
        {
            InitializeComponent();

            PopulateGridView();
        }

        // load data to gridview
        void PopulateGridView()
        {
            try
            {
                GridViewUsers.AutoGenerateColumns = false;
                using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                {
                    GridViewUsers.DataSource = db.ProduktTillagd.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error loading table.. try again later!");
            }
        }

        // clear current
        void ClearData()
        {
            QuantityBox.Text = "";
            SumPBox.Text = "";

            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            ProduktTillagdModel.TransaktionId = 0;
        }

        // go to menu
        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
            this.Close();
        }

        // when cell data is pressed - will modified
        private void GridViewUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // try to take cell data
            try
            {
                // when pressed, retreive id value of row
                if (GridViewUsers.CurrentRow.Index != -1)
                {
                    // gets info where id = pressed row id.
                    ProduktTillagdModel.TransaktionId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["TransaktionId"].Value);
                    using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                    {
                        ProduktTillagdModel = db.ProduktTillagd.Where(x => x.TransaktionId == ProduktTillagdModel.TransaktionId).FirstOrDefault();

                        QuantityBox.Text = ProduktTillagdModel.Antal.ToString();
                        SumPBox.Text = ProduktTillagdModel.SummaProdukter.ToString();
                    }

                    // change add button to update when selected
                    AddButton.Text = "Update";
                    DeleteButton.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Couldnt take cell data, DB-connection established?");
            }
        }

        // add productAdded
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add productAdded
            try
            {
                ProduktTillagdModel.Antal = int.Parse(QuantityBox.Text.Trim());
                ProduktTillagdModel.SummaProdukter = decimal.Parse(SumPBox.Text.Trim());

                using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                {
                    // to add productAdded
                    if (ProduktTillagdModel.TransaktionId == 0)
                    {
                        db.ProduktTillagd.Add(ProduktTillagdModel);
                    }
                    // update productAdded
                    else
                    {
                        db.Entry(ProduktTillagdModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Team with ID: {ProduktTillagdModel.TransaktionId} successfully created/updated!");

                PopulateGridView();
                ClearData();
            }
            catch
            {
                MessageBox.Show("Couldnt add/update table. Are the fields filled with correct data? Check input ID if exists and not in use already. DB connection OK?");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // try to delete table item
            try
            {
                if (MessageBox.Show("Delete?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                    {
                        var entry = db.Entry(ProduktTillagdModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.ProduktTillagd.Attach(ProduktTillagdModel);
                        }
                        db.ProduktTillagd.Remove(ProduktTillagdModel);
                        db.SaveChanges();

                        // update gridview
                        PopulateGridView();
                        ClearData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Couldnt delete table item, is the ID correct and db-connection established?");
            }
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
