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
    public partial class PlayersForm : Form 
    {
        // access to fixtureModel
        Player playerModel = new Player();


        public PlayersForm()
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
                    GridViewUsers.DataSource = db.Players.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error loading players.. try again later!");
            }
        }

        // clear current
        void ClearData()
        {
            FirstNameBox.Text = SurnameBox.Text = PositionBox.Text =
                ShirtNoBox.Text = GamesPlayedBox.Text = GoalsBox.Text = AssistBox.Text =
                YellowCardsBox.Text = RedCardsBox.Text = UserIdBox.Text = TeamIdBox.Text = "";

            CheckBoxInjury.Checked = false;

            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            playerModel.PlayerId = 0;
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
            // try to populate input from cell data
            try
            {
                // when pressed, retreive id value of row
                if (GridViewUsers.CurrentRow.Index != -1)
                {
                    // gets info where id = pressed row id.
                    playerModel.PlayerId = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["PlayerId"].Value);
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        playerModel = db.Players.Where(x => x.PlayerId == playerModel.PlayerId).FirstOrDefault();

                        FirstNameBox.Text = playerModel.FirstName;
                        SurnameBox.Text = playerModel.Surname;
                        BirthdayBox.Value = playerModel.BirthDate;
                        PositionBox.Text = playerModel.Position;
                        ShirtNoBox.Text = playerModel.ShirtNumber.ToString();
                        GamesPlayedBox.Text = playerModel.PlayedGames.ToString();
                        GoalsBox.Text = playerModel.Goals.ToString();
                        AssistBox.Text = playerModel.Assists.ToString();
                        CheckBoxInjury.Checked = playerModel.Injured;
                        YellowCardsBox.Text = playerModel.YellowCards.ToString();
                        RedCardsBox.Text = playerModel.RedCards.ToString();
                        UserIdBox.Text = playerModel.UserId.ToString();
                        TeamIdBox.Text = playerModel.TeamId.ToString();
                    }

                    // change add button to update when selected
                    AddButton.Text = "Update";
                    DeleteButton.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Could not populate boxes, something went wrong! DB status?");
            }

        }

        // add user
        private void AddButton_Click(object sender, EventArgs e)
        {
            // try to add player
            try
            {
                playerModel.FirstName = FirstNameBox.Text.Trim();
                playerModel.Surname = SurnameBox.Text.Trim();
                playerModel.BirthDate = BirthdayBox.Value;
                playerModel.Position = PositionBox.Text.Trim();
                playerModel.ShirtNumber = int.Parse(ShirtNoBox.Text.Trim());
                playerModel.PlayedGames = int.Parse(GamesPlayedBox.Text.Trim());
                playerModel.Goals = int.Parse(GoalsBox.Text.Trim());
                playerModel.Assists = int.Parse(AssistBox.Text.Trim());
                playerModel.YellowCards = int.Parse(YellowCardsBox.Text.Trim());
                playerModel.RedCards = int.Parse(RedCardsBox.Text.Trim());
                playerModel.Injured = CheckBoxInjury.Checked;
                playerModel.UserId = int.Parse(UserIdBox.Text.Trim());
                playerModel.TeamId = int.Parse(TeamIdBox.Text.Trim());


                using (FootyDBEntities db = new FootyDBEntities())
                {
                    // to add user
                    if (playerModel.PlayerId == 0)
                    {
                        db.Players.Add(playerModel);
                    }
                    // update user
                    else
                    {
                        db.Entry(playerModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show($"Player with ID: {playerModel.PlayerId} successfully created/updated!");

                PopulateGridView();
                ClearData();
            }
            // couldnt add? db connection or right id? fields filled?
            catch
            {
                MessageBox.Show("Couldnt add/update player to DB, are all fields filled and correct data inputted? Check that IDS are not in use and exist");
            }            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // try to delete player
            try
            {
                if (MessageBox.Show("Delete?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (FootyDBEntities db = new FootyDBEntities())
                    {
                        var entry = db.Entry(playerModel);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Players.Attach(playerModel);
                        }
                        db.Players.Remove(playerModel);
                        db.SaveChanges();

                        // update gridview
                        PopulateGridView();
                        ClearData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Couldnt delete player to DB, are all fields filled and correct data inputted? Check that IDS are not in use and exist");
            }

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            ClearData();
        }

    }
}
