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
    public partial class ProduktForm : Form
    {
        // access to ShoppingModel
        Models.Produkt produktModel = new Models.Produkt(); 
        
        public ProduktForm()
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
                    GridViewUsers.DataSource = db.Produkt.ToList();
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
            NamnBox.Text = "";
            PrisBox.Text = "";
            KategoriBox.Text = "";
            BildadressBox.Text = "";
            ViktBox.Text = "";
            LagerplatsBox.Text = "";

            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            produktModel.ProduktId = 0;
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
                    produktModel.ProduktId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["ProduktId"].Value);
                    using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                    {
                        produktModel = db.Produkt.Where(x => x.ProduktId == produktModel.ProduktId).FirstOrDefault();

                        NamnBox.Text = produktModel.Namn;
                        PrisBox.Text = produktModel.Pris.ToString();
                        KategoriBox.Text = produktModel.Kategori;
                        BildadressBox.Text = produktModel.Bildadress;
                        ViktBox.Text = produktModel.Vikt;
                        LagerplatsBox.Text = produktModel.Lagerplats;
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

        // add product
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add product
            try
            {
                produktModel.Namn = NamnBox.Text.Trim();
                produktModel.Pris = decimal.Parse(PrisBox.Text.Trim());
                produktModel.Kategori = KategoriBox.Text.Trim();
                produktModel.Bildadress = BildadressBox.Text.Trim();
                produktModel.Vikt = ViktBox.Text.Trim();
                produktModel.Lagerplats = LagerplatsBox.Text.Trim();

                using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                {
                    // to add product
                    if (produktModel.ProduktId == 0)
                    {
                        db.Produkt.Add(produktModel);
                    }
                    // update product
                    else
                    {
                        db.Entry(produktModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Team with ID: {produktModel.ProduktId} successfully created/updated!");

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
                        var entry = db.Entry(produktModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Produkt.Attach(produktModel);
                        }
                        db.Produkt.Remove(produktModel);
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
