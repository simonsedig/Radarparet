using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSpelarPortalAdmin1.Models;

namespace WFSpelarPortalAdmin1
{
    public partial class UserForm : Form
    {
        // give access to model db entity and db entity
        User userModel = new User();

        FileService1 service1 = new FileService1();

        public UserForm()
        {
            InitializeComponent();

            PopulateGridView();

            // start service
            service1.OnStart();
        }

        // load data to gridview
        void PopulateGridView()
        {
            try
            {
                GridViewUsers.AutoGenerateColumns = false;
                using (FootyDBEntities db = new FootyDBEntities())
                {
                    GridViewUsers.DataSource = db.Users.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error loading users.. try again later!");
            }
        }

        // clear current
        void ClearData()
        {
            TextBoxUser.Text = TextBoxPassword.Text = "";
            AddButton.Text = "Add";
            DeleteButton.Enabled = false;
            userModel.id = 0;
        }
        
        private void UserForm_Load(object sender, EventArgs e)
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

            // when pressed, retreive id value of row
            if (GridViewUsers.CurrentRow.Index != -1)
            {
                // gets info where id = pressed row id.
                userModel.id = Convert.ToInt32(GridViewUsers.CurrentRow.Cells["UserId"].Value);
                using (FootyDBEntities db = new FootyDBEntities())
                {
                    userModel = db.Users.Where(x => x.id == userModel.id).FirstOrDefault();

                    TextBoxUser.Text = userModel.Username;
                    TextBoxPassword.Text = userModel.Password;
                }

                // change add button to update when selected
                AddButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        // add user
        private void AddButton_Click(object sender, EventArgs e)
        {
            userModel.Username = TextBoxUser.Text.Trim();
            userModel.Password = TextBoxPassword.Text.Trim();


                using (FootyDBEntities db = new FootyDBEntities())
                {
                    // to add user
                    if (userModel.id == 0)
                    {
                        db.Users.Add(userModel);
                    }
                    // update user
                    else
                    {
                        db.Entry(userModel).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
            }

            MessageBox.Show($"User {userModel.Username} successfully created/updated!");

            PopulateGridView();
            ClearData();
        }




        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Delete item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FootyDBEntities db = new FootyDBEntities())
                {
                    var entry = db.Entry(userModel);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Users.Attach(userModel);
                    }
                    db.Users.Remove(userModel);
                    db.SaveChanges();

                    // update gridview
                    PopulateGridView();
                    ClearData();
                }
            }
        }

        // read file to print to db - PROUD FATHER OF THIS ALGORITM ;*
        private void BulkImport_Click(object sender, EventArgs e)
        {
            // init file opener,
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\Users\Jonte\source\repos\WFSpelarPortalAdmin1\WFSpelarPortalAdmin1\Data-library";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                // if user find file, use file in streamreader and read line for line until no more lines
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (StreamReader stringReader = new StreamReader(myStream))
                        {
                            // add all data to list to check length
                            List<string> userInfoList = new List<string>();

                            // read until empty and add elements
                            while (true)
                            {
                                // temp string 
                                string tempString = stringReader.ReadLine();

                                if (tempString != null && tempString != "")
                                {
                                    userInfoList.Add(tempString);
                                }
                                else
                                {
                                    break;
                                }
                            }

                            // length must be even for both input - then try to add to database
                            if (userInfoList.Count % 2 == 0 && userInfoList.Count > 0)
                            {
                                // temp array to store user credentials
                                string[] tempArray = new string[2];

                                // make array boxes available for loop
                                tempArray[0] = "";
                                tempArray[1] = "";

                                // loop whole document
                                for (int i = 0; i < userInfoList.Count; i++)
                                {
                                    // if space 1 empty and space 0 full, fill
                                    if (tempArray[0] != "" && tempArray[1] == "")
                                    {
                                        tempArray[1] = userInfoList[i].Trim();
                                    }

                                    // if space 0 empty, fill
                                    if (tempArray[0] == "")
                                    {
                                        tempArray[0] = userInfoList[i].Trim();
                                    }

                                    // both full? ready for upload
                                    if (tempArray[0] != "" && tempArray[1] != "")
                                    {
                                            // try upload to db and empty arrays after
                                            User newUser = new User();
                                            newUser.Username = tempArray[0];
                                            newUser.Password = tempArray[1];

                                            using (FootyDBEntities db = new FootyDBEntities())
                                            {
                                                db.Users.Add(newUser);
                                                db.SaveChanges();
                                            }

                                            // empty arrays after to make new entries available to add
                                            tempArray[0] = "";
                                            tempArray[1] = "";
                                    }
                                }

                                // refresh data
                                PopulateGridView();

                                MessageBox.Show($"{userInfoList.Count / 2} entries added to database");
                            }
                            else
                            {
                                MessageBox.Show("Bad datafile, must contain even rows to be used! (Username, Password).. 1 user = 2 rows...");
                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Exception: " + ex.Message);
                }
            }
        }

    }
}
