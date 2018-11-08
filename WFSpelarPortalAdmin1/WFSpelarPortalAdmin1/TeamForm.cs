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
    public partial class TeamForm : Form
    {
        // access to teamModel
        Team teamModel = new Team();

        public TeamForm()
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
                    GridViewUsers.DataSource = db.Teams.ToList();
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
            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
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
            // try to take cell data
            try
            {
                // when pressed, retreive id value of row
                if (GridViewUsers.CurrentRow.Index != -1)
                {
                    // gets info where id = pressed row id.
                    teamModel.TeamId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["TeamId"].Value);
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        TeamNameBox.Text = teamModel.TeamName.ToString();
                        CoachBox.Text = teamModel.Coach.ToString();
                        ColorBox.Text = teamModel.Colors.ToString();
                        ArenaBox.Text = teamModel.ArenaName.ToString();
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

        // add team
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add team
            try
            {
                teamModel.TeamName = TeamNameBox.Text.Trim();
                teamModel.Coach = CoachBox.Text.Trim();
                teamModel.Colors = ColorBox.Text.Trim();
                teamModel.ArenaName = ArenaBox.Text.Trim();

                using (FootyDBEntities db = new FootyDBEntities())
                {
                    // to add team
                    if (teamModel.TeamId == 0)
                    {
                        db.Teams.Add(teamModel);
                    }
                    // update team
                    else
                    {
                        db.Entry(teamModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Team with ID: {teamModel.TeamId} successfully created/updated!");

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
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        var entry = db.Entry(teamModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Teams.Attach(teamModel);
                        }
                        db.Teams.Remove(teamModel);
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
