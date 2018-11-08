using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSpelarPortalAdmin1.Models;

namespace WFSpelarPortalAdmin1
{
    public partial class FixtureForm : Form
    {
        // access to fixtureModel
        Fixture fixtureModel = new Fixture();

        public FixtureForm()
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
                using (FootyDBEntities db = new FootyDBEntities())
                {
                    GridViewUsers.DataSource = db.Fixtures.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error loading fixtures.. try again later!");
            }
        }

        // clear current
        void ClearData()
        {
            HomeIdBox.Text = AwayIdBox.Text = RefereeBox.Text = ResultBox.Text =  "";
            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            fixtureModel.FixtureId = 0;
        }


        // go to menu
        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menuForm = new Form1();
            menuForm.ShowDialog();
            this.Close();
        }

        // when cell data is pressed - will modified
        private void GridViewUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // try to get value from cell
            try
            {
                // when pressed, retreive id value of row
                if (GridViewUsers.CurrentRow.Index != -1)
                {
                    // gets info where id = pressed row id.
                    fixtureModel.FixtureId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["FixtureId"].Value);
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        fixtureModel = db.Fixtures.Where(x => x.FixtureId == fixtureModel.FixtureId).FirstOrDefault();

                        HomeIdBox.Text = fixtureModel.TeamHomeId.ToString();
                        AwayIdBox.Text = fixtureModel.TeamAwayId.ToString();
                        DateBox.Value = fixtureModel.Date;
                        RefereeBox.Text = fixtureModel.Referee;
                        ResultBox.Text = fixtureModel.Result;
                    }

                    // change add button to update when selected
                    AddButton.Text = "Update";
                    DeleteButton.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Could not get data from cells!");
            }
        }

        // add user
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add/update user 
            try
            {
                // dont allow same team to face eachother
                if (HomeIdBox.Text.Trim() == AwayIdBox.Text.Trim())
                {
                    MessageBox.Show("Same team cant face eachother!");
                }
                else
                {
                    fixtureModel.TeamHomeId = int.Parse(HomeIdBox.Text.Trim());
                    fixtureModel.TeamAwayId = int.Parse(AwayIdBox.Text.Trim());
                    fixtureModel.Date = DateBox.Value;
                    fixtureModel.Referee = RefereeBox.Text.Trim();
                    // if match not played yet
                    if (ResultBox.Text == "")
                    {
                        fixtureModel.Result = "TBA";
                    }
                    else
                    {
                        fixtureModel.Result = ResultBox.Text.Trim();
                    }
                    


                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        // to add user
                        if (fixtureModel.FixtureId == 0)
                        {
                            db.Fixtures.Add(fixtureModel);
                        }
                        // update user
                        else
                        {
                            db.Entry(fixtureModel).State = System.Data.Entity.EntityState.Modified;
                        }
                        db.SaveChanges();
                    }

                    MessageBox.Show($"Fixture with ID: {fixtureModel.FixtureId} successfully created/updated!");

                    PopulateGridView();
                    ClearData();
                }
            }
            // didnt work? give tips
            catch
            {
                MessageBox.Show("Could not add/update user, Form filled + correct IDS assigned? is database connection established?");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // try to delete user
            try
            {
                if (MessageBox.Show("Delete?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        var entry = db.Entry(fixtureModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Fixtures.Attach(fixtureModel);
                        }
                        db.Fixtures.Remove(fixtureModel);
                        db.SaveChanges();

                        // update gridview
                        PopulateGridView();
                        ClearData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not delete fixture! Check fields for right input, correct ids. Is database connection established?");
            }            
        }

        private void FixtureForm_Load(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
