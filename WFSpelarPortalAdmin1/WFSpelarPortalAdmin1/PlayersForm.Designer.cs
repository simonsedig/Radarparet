namespace WFSpelarPortalAdmin1
{
    partial class PlayersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.ShirtNoBox = new System.Windows.Forms.TextBox();
            this.ShirtLabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.PlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShirtNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayedGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YellowCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Injured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.YellowCardsBox = new System.Windows.Forms.TextBox();
            this.YellowCardLabel = new System.Windows.Forms.Label();
            this.AssistBox = new System.Windows.Forms.TextBox();
            this.AssistsLabel = new System.Windows.Forms.Label();
            this.RedCardsBox = new System.Windows.Forms.TextBox();
            this.RedCardLabel = new System.Windows.Forms.Label();
            this.GoalsBox = new System.Windows.Forms.TextBox();
            this.GamesPlayedBox = new System.Windows.Forms.TextBox();
            this.GoalsLabel = new System.Windows.Forms.Label();
            this.PlayedLabel = new System.Windows.Forms.Label();
            this.TeamIdBox = new System.Windows.Forms.TextBox();
            this.TeamIdLabel = new System.Windows.Forms.Label();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BirthdayBox = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxInjury = new System.Windows.Forms.CheckBox();
            this.fileService11 = new WFSpelarPortalAdmin1.FileService1();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(87, 174);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(100, 20);
            this.PositionBox.TabIndex = 55;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(34, 177);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(47, 13);
            this.PositionLabel.TabIndex = 54;
            this.PositionLabel.Text = "Position:";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(29, 146);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(52, 13);
            this.BirthDateLabel.TabIndex = 52;
            this.BirthDateLabel.Text = "Birthdate:";
            // 
            // ShirtNoBox
            // 
            this.ShirtNoBox.Location = new System.Drawing.Point(87, 211);
            this.ShirtNoBox.Name = "ShirtNoBox";
            this.ShirtNoBox.Size = new System.Drawing.Size(100, 20);
            this.ShirtNoBox.TabIndex = 51;
            // 
            // ShirtLabel
            // 
            this.ShirtLabel.AutoSize = true;
            this.ShirtLabel.Location = new System.Drawing.Point(34, 214);
            this.ShirtLabel.Name = "ShirtLabel";
            this.ShirtLabel.Size = new System.Drawing.Size(48, 13);
            this.ShirtLabel.TabIndex = 50;
            this.ShirtLabel.Text = "Shirt No.";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 12);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 49;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerId,
            this.FirstName,
            this.Surname,
            this.BirthDate,
            this.Position,
            this.ShirtNumber,
            this.PlayedGames,
            this.Goals,
            this.Assists,
            this.YellowCards,
            this.RedCards,
            this.Injured,
            this.UserIs,
            this.TeamId});
            this.GridViewUsers.Location = new System.Drawing.Point(333, 12);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(1038, 593);
            this.GridViewUsers.TabIndex = 48;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // PlayerId
            // 
            this.PlayerId.DataPropertyName = "PlayerId";
            this.PlayerId.HeaderText = "PlayerId";
            this.PlayerId.Name = "PlayerId";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // ShirtNumber
            // 
            this.ShirtNumber.DataPropertyName = "ShirtNumber";
            this.ShirtNumber.HeaderText = "ShirtNumber";
            this.ShirtNumber.Name = "ShirtNumber";
            // 
            // PlayedGames
            // 
            this.PlayedGames.DataPropertyName = "PlayedGames";
            this.PlayedGames.HeaderText = "PlayedGames";
            this.PlayedGames.Name = "PlayedGames";
            // 
            // Goals
            // 
            this.Goals.DataPropertyName = "Goals";
            this.Goals.HeaderText = "Goals";
            this.Goals.Name = "Goals";
            // 
            // Assists
            // 
            this.Assists.DataPropertyName = "Assists";
            this.Assists.HeaderText = "Assists";
            this.Assists.Name = "Assists";
            // 
            // YellowCards
            // 
            this.YellowCards.DataPropertyName = "YellowCards";
            this.YellowCards.HeaderText = "YellowCards";
            this.YellowCards.Name = "YellowCards";
            // 
            // RedCards
            // 
            this.RedCards.DataPropertyName = "RedCards";
            this.RedCards.HeaderText = "RedCards";
            this.RedCards.Name = "RedCards";
            // 
            // Injured
            // 
            this.Injured.DataPropertyName = "Injured";
            this.Injured.HeaderText = "Injured";
            this.Injured.Name = "Injured";
            // 
            // UserIs
            // 
            this.UserIs.DataPropertyName = "UserId";
            this.UserIs.HeaderText = "UserId";
            this.UserIs.Name = "UserIs";
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(132, 594);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 47;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(48, 594);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(87, 100);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameBox.TabIndex = 45;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(87, 62);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 44;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(29, 103);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 43;
            this.SurnameLabel.Text = "Surname:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(26, 65);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 42;
            this.FirstNameLabel.Text = "Firstname:";
            // 
            // YellowCardsBox
            // 
            this.YellowCardsBox.Location = new System.Drawing.Point(87, 358);
            this.YellowCardsBox.Name = "YellowCardsBox";
            this.YellowCardsBox.Size = new System.Drawing.Size(100, 20);
            this.YellowCardsBox.TabIndex = 65;
            // 
            // YellowCardLabel
            // 
            this.YellowCardLabel.AutoSize = true;
            this.YellowCardLabel.Location = new System.Drawing.Point(10, 361);
            this.YellowCardLabel.Name = "YellowCardLabel";
            this.YellowCardLabel.Size = new System.Drawing.Size(71, 13);
            this.YellowCardLabel.TabIndex = 64;
            this.YellowCardLabel.Text = "Yellow Cards:";
            // 
            // AssistBox
            // 
            this.AssistBox.Location = new System.Drawing.Point(87, 321);
            this.AssistBox.Name = "AssistBox";
            this.AssistBox.Size = new System.Drawing.Size(100, 20);
            this.AssistBox.TabIndex = 63;
            // 
            // AssistsLabel
            // 
            this.AssistsLabel.AutoSize = true;
            this.AssistsLabel.Location = new System.Drawing.Point(39, 324);
            this.AssistsLabel.Name = "AssistsLabel";
            this.AssistsLabel.Size = new System.Drawing.Size(42, 13);
            this.AssistsLabel.TabIndex = 62;
            this.AssistsLabel.Text = "Assists:";
            // 
            // RedCardsBox
            // 
            this.RedCardsBox.Location = new System.Drawing.Point(87, 395);
            this.RedCardsBox.Name = "RedCardsBox";
            this.RedCardsBox.Size = new System.Drawing.Size(100, 20);
            this.RedCardsBox.TabIndex = 61;
            // 
            // RedCardLabel
            // 
            this.RedCardLabel.AutoSize = true;
            this.RedCardLabel.Location = new System.Drawing.Point(21, 398);
            this.RedCardLabel.Name = "RedCardLabel";
            this.RedCardLabel.Size = new System.Drawing.Size(60, 13);
            this.RedCardLabel.TabIndex = 60;
            this.RedCardLabel.Text = "Red Cards:";
            // 
            // GoalsBox
            // 
            this.GoalsBox.Location = new System.Drawing.Point(87, 284);
            this.GoalsBox.Name = "GoalsBox";
            this.GoalsBox.Size = new System.Drawing.Size(100, 20);
            this.GoalsBox.TabIndex = 59;
            // 
            // GamesPlayedBox
            // 
            this.GamesPlayedBox.Location = new System.Drawing.Point(87, 246);
            this.GamesPlayedBox.Name = "GamesPlayedBox";
            this.GamesPlayedBox.Size = new System.Drawing.Size(100, 20);
            this.GamesPlayedBox.TabIndex = 58;
            // 
            // GoalsLabel
            // 
            this.GoalsLabel.AutoSize = true;
            this.GoalsLabel.Location = new System.Drawing.Point(45, 287);
            this.GoalsLabel.Name = "GoalsLabel";
            this.GoalsLabel.Size = new System.Drawing.Size(37, 13);
            this.GoalsLabel.TabIndex = 57;
            this.GoalsLabel.Text = "Goals:";
            // 
            // PlayedLabel
            // 
            this.PlayedLabel.AutoSize = true;
            this.PlayedLabel.Location = new System.Drawing.Point(4, 249);
            this.PlayedLabel.Name = "PlayedLabel";
            this.PlayedLabel.Size = new System.Drawing.Size(78, 13);
            this.PlayedLabel.TabIndex = 56;
            this.PlayedLabel.Text = "Played Games:";
            // 
            // TeamIdBox
            // 
            this.TeamIdBox.Location = new System.Drawing.Point(87, 506);
            this.TeamIdBox.Name = "TeamIdBox";
            this.TeamIdBox.Size = new System.Drawing.Size(100, 20);
            this.TeamIdBox.TabIndex = 73;
            // 
            // TeamIdLabel
            // 
            this.TeamIdLabel.AutoSize = true;
            this.TeamIdLabel.Location = new System.Drawing.Point(35, 509);
            this.TeamIdLabel.Name = "TeamIdLabel";
            this.TeamIdLabel.Size = new System.Drawing.Size(46, 13);
            this.TeamIdLabel.TabIndex = 72;
            this.TeamIdLabel.Text = "TeamId:";
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(87, 469);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(100, 20);
            this.UserIdBox.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "UserId";
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(87, 140);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(200, 20);
            this.BirthdayBox.TabIndex = 74;
            // 
            // CheckBoxInjury
            // 
            this.CheckBoxInjury.AutoSize = true;
            this.CheckBoxInjury.Location = new System.Drawing.Point(87, 434);
            this.CheckBoxInjury.Name = "CheckBoxInjury";
            this.CheckBoxInjury.Size = new System.Drawing.Size(64, 17);
            this.CheckBoxInjury.TabIndex = 75;
            this.CheckBoxInjury.Text = "Injured?";
            this.CheckBoxInjury.UseVisualStyleBackColor = true;
            // 
            // fileService11
            // 
            this.fileService11.ExitCode = 0;
            this.fileService11.ServiceName = "FileService1";
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 629);
            this.Controls.Add(this.CheckBoxInjury);
            this.Controls.Add(this.BirthdayBox);
            this.Controls.Add(this.TeamIdBox);
            this.Controls.Add(this.TeamIdLabel);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YellowCardsBox);
            this.Controls.Add(this.YellowCardLabel);
            this.Controls.Add(this.AssistBox);
            this.Controls.Add(this.AssistsLabel);
            this.Controls.Add(this.RedCardsBox);
            this.Controls.Add(this.RedCardLabel);
            this.Controls.Add(this.GoalsBox);
            this.Controls.Add(this.GamesPlayedBox);
            this.Controls.Add(this.GoalsLabel);
            this.Controls.Add(this.PlayedLabel);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.ShirtNoBox);
            this.Controls.Add(this.ShirtLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "PlayersForm";
            this.Text = "Manage Players";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox ShirtNoBox;
        private System.Windows.Forms.Label ShirtLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox YellowCardsBox;
        private System.Windows.Forms.Label YellowCardLabel;
        private System.Windows.Forms.TextBox AssistBox;
        private System.Windows.Forms.Label AssistsLabel;
        private System.Windows.Forms.TextBox RedCardsBox;
        private System.Windows.Forms.Label RedCardLabel;
        private System.Windows.Forms.TextBox GoalsBox;
        private System.Windows.Forms.TextBox GamesPlayedBox;
        private System.Windows.Forms.Label GoalsLabel;
        private System.Windows.Forms.Label PlayedLabel;
        private System.Windows.Forms.TextBox TeamIdBox;
        private System.Windows.Forms.Label TeamIdLabel;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker BirthdayBox;
        private System.Windows.Forms.CheckBox CheckBoxInjury;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShirtNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayedGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn YellowCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Injured;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private FileService1 fileService11;
    }
}