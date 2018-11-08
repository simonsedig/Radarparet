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
    public partial class LineupForm : Form
    {
        // give access to model db entity and db entity
        CurrentSquad squadModel = new CurrentSquad();

        public LineupForm()
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
                    GridViewUsers.DataSource = db.CurrentSquads.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error loading lineup.. try again later!");
            }
        }

        // clear current
        void ClearData()
        {
            TextBoxPlayer.Text = "";
            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            squadModel.IdSquadNo = 0;
        }

        private void LineupForm_Load(object sender, EventArgs e)
        {
            ClearData();
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
            // try retrieve data
            try
            {
                // when pressed, retreive id value of row
                if (GridViewUsers.CurrentRow.Index != -1)
                {
                    // gets info where id = pressed row id.
                    squadModel.IdSquadNo = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["SquadIdNo"].Value);
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        squadModel = db.CurrentSquads.Where(x => x.IdSquadNo == squadModel.IdSquadNo).FirstOrDefault();

                        TextBoxPlayer.Text = squadModel.IdPlayer.ToString();
                    }

                    // change add button to update when selected
                    AddButton.Text = "Update";
                    DeleteButton.Enabled = true;
                }
            }
            // didnt work? give message to user
            catch
            {
                MessageBox.Show("Users could not be retrieved");
            }                        
        }

        // add user
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try add/update data
            try
            {
                squadModel.IdPlayer = int.Parse(TextBoxPlayer.Text.Trim());

                using (FootyDBEntities db = new FootyDBEntities())
                {
                    // to add user
                    if (squadModel.IdSquadNo == 0)
                    {
                        db.CurrentSquads.Add(squadModel);
                    }
                    // update user
                    else
                    {
                        db.Entry(squadModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Player has been added to SquadID: {squadModel.IdSquadNo} successfully created/updated!");

                PopulateGridView();
                ClearData();
            }
            // something wrong? 
            catch
            {
                MessageBox.Show("Player was not modified/added. All fields filled + ID are correct?");
            }
        }




        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        var entry = db.Entry(squadModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.CurrentSquads.Attach(squadModel);
                        }
                        db.CurrentSquads.Remove(squadModel);
                        db.SaveChanges();

                        // update gridview
                        PopulateGridView();
                        ClearData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, player not deleted from squad! Correct ID/database connection established?");
            }

        }
    }
}
