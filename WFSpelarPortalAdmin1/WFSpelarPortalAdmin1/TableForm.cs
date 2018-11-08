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
    public partial class TableForm : Form
    {

        // access to fixtureModel
        RankingTable tableModel = new RankingTable();

        public TableForm()
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
                    GridViewUsers.DataSource = db.RankingTables.ToList();
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
            TeamIdBox.Text = GamesPlayedBox.Text = GamesDrawBox.Text = GamesLostBox.Text = "";
            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            tableModel.RankingId = 0;
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
                    tableModel.RankingId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["RankingId"].Value);
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        tableModel = db.RankingTables.Where(x => x.RankingId == tableModel.RankingId).FirstOrDefault();

                        TeamIdBox.Text = tableModel.TeamId.ToString();
                        GamesPlayedBox.Text = tableModel.PlayedGames.ToString();
                        GamesWonBox.Text = tableModel.WonGames.ToString();
                        GamesDrawBox.Text = tableModel.DrawGames.ToString();
                        GamesLostBox.Text = tableModel.LostGames.ToString();
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

        // add user
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add user
            try
            {
                tableModel.TeamId = int.Parse(TeamIdBox.Text.Trim());
                tableModel.PlayedGames = int.Parse(GamesPlayedBox.Text.Trim());
                tableModel.WonGames = int.Parse(GamesWonBox.Text.Trim());
                tableModel.DrawGames = int.Parse(GamesDrawBox.Text.Trim());
                tableModel.LostGames = int.Parse(GamesLostBox.Text.Trim());
                tableModel.Points = (int.Parse(GamesWonBox.Text.Trim()) * 3) + (int.Parse(GamesDrawBox.Text.Trim()) * 1);

                using (FootyDBEntities db = new FootyDBEntities())
                {
                    // to add user
                    if (tableModel.RankingId == 0)
                    {
                        db.RankingTables.Add(tableModel);
                    }
                    // update user
                    else
                    {
                        db.Entry(tableModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Team with ID: {tableModel.TeamId} successfully created/updated!");

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
                        var entry = db.Entry(tableModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.RankingTables.Attach(tableModel);
                        }
                        db.RankingTables.Remove(tableModel);
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

