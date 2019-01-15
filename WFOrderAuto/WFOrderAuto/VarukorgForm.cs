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
    public partial class VarukorgForm : Form
    {
        // access to ShoppingModel
        Models.Varukorg VarukorgModel = new Models.Varukorg();

        public VarukorgForm()
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
                    GridViewUsers.DataSource = db.Varukorg.ToList();
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
            DateCBox.Text = "";
            DateDBox.Text = "";
            PaidBox.Text = "";
            DeliveredBox.Text = "";

            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            VarukorgModel.VarukorgId = 0;
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
                    VarukorgModel.VarukorgId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["VarukorgId"].Value);
                    using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                    {
                        VarukorgModel = db.Varukorg.Where(x => x.VarukorgId == VarukorgModel.VarukorgId).FirstOrDefault();

                        DateCBox.Text = VarukorgModel.DatumSkapad.ToString();
                        DateDBox.Text = VarukorgModel.DatumAvslutad.ToString();
                        PaidBox.Text = VarukorgModel.Betalad.ToString();
                        DeliveredBox.Text = VarukorgModel.Levererad.ToString();
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

        // add cart
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add cart
            try
            {
                VarukorgModel.DatumSkapad = DateTime.Parse(DateCBox.Text.Trim());
                VarukorgModel.DatumAvslutad = DateDBox.Text.Trim();
                VarukorgModel.Betalad = Convert.ToBoolean(PaidBox.Text.Trim());
                VarukorgModel.Levererad = Convert.ToBoolean(DeliveredBox.Text.Trim());


                using (ShoppingDBEntities4 db = new ShoppingDBEntities4())
                {
                    // to add cart
                    if (VarukorgModel.VarukorgId == 0)
                    {
                        db.Varukorg.Add(VarukorgModel);
                    }
                    // update cart
                    else
                    {
                        db.Entry(VarukorgModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Team with ID: {VarukorgModel.VarukorgId} successfully created/updated!");

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
                        var entry = db.Entry(VarukorgModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Varukorg.Attach(VarukorgModel);
                        }
                        db.Varukorg.Remove(VarukorgModel);
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
