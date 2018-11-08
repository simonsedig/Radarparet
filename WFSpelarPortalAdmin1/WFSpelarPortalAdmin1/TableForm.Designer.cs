namespace WFSpelarPortalAdmin1
{
    partial class TableForm
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
            this.GamesLostBox = new System.Windows.Forms.TextBox();
            this.LossLabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.RankingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesWon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesDraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesLost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.GamesPlayedBox = new System.Windows.Forms.TextBox();
            this.TeamIdBox = new System.Windows.Forms.TextBox();
            this.PlayedLabel = new System.Windows.Forms.Label();
            this.TeamIdLabel = new System.Windows.Forms.Label();
            this.GamesDrawBox = new System.Windows.Forms.TextBox();
            this.DrawLabel = new System.Windows.Forms.Label();
            this.GamesWonBox = new System.Windows.Forms.TextBox();
            this.WonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // GamesLostBox
            // 
            this.GamesLostBox.Location = new System.Drawing.Point(98, 260);
            this.GamesLostBox.Name = "GamesLostBox";
            this.GamesLostBox.Size = new System.Drawing.Size(100, 20);
            this.GamesLostBox.TabIndex = 35;
            // 
            // LossLabel
            // 
            this.LossLabel.AutoSize = true;
            this.LossLabel.Location = new System.Drawing.Point(26, 263);
            this.LossLabel.Name = "LossLabel";
            this.LossLabel.Size = new System.Drawing.Size(66, 13);
            this.LossLabel.TabIndex = 34;
            this.LossLabel.Text = "Games Lost:";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(23, 34);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 32;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankingId,
            this.TeamId,
            this.GamesPlayed,
            this.GamesWon,
            this.GamesDraw,
            this.GamesLost,
            this.Points});
            this.GridViewUsers.Location = new System.Drawing.Point(348, 66);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(605, 364);
            this.GridViewUsers.TabIndex = 31;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // RankingId
            // 
            this.RankingId.DataPropertyName = "RankingId";
            this.RankingId.HeaderText = "RankingId";
            this.RankingId.Name = "RankingId";
            this.RankingId.Visible = false;
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            // 
            // GamesPlayed
            // 
            this.GamesPlayed.DataPropertyName = "PlayedGames";
            this.GamesPlayed.HeaderText = "GamesPlayed";
            this.GamesPlayed.Name = "GamesPlayed";
            // 
            // GamesWon
            // 
            this.GamesWon.DataPropertyName = "WonGames";
            this.GamesWon.HeaderText = "GamesWon";
            this.GamesWon.Name = "GamesWon";
            // 
            // GamesDraw
            // 
            this.GamesDraw.DataPropertyName = "DrawGames";
            this.GamesDraw.HeaderText = "GamesDraw";
            this.GamesDraw.Name = "GamesDraw";
            // 
            // GamesLost
            // 
            this.GamesLost.DataPropertyName = "LostGames";
            this.GamesLost.HeaderText = "GamesLost";
            this.GamesLost.Name = "GamesLost";
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(146, 346);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(62, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GamesPlayedBox
            // 
            this.GamesPlayedBox.Location = new System.Drawing.Point(98, 149);
            this.GamesPlayedBox.Name = "GamesPlayedBox";
            this.GamesPlayedBox.Size = new System.Drawing.Size(100, 20);
            this.GamesPlayedBox.TabIndex = 28;
            // 
            // TeamIdBox
            // 
            this.TeamIdBox.Location = new System.Drawing.Point(98, 111);
            this.TeamIdBox.Name = "TeamIdBox";
            this.TeamIdBox.Size = new System.Drawing.Size(100, 20);
            this.TeamIdBox.TabIndex = 27;
            // 
            // PlayedLabel
            // 
            this.PlayedLabel.AutoSize = true;
            this.PlayedLabel.Location = new System.Drawing.Point(14, 152);
            this.PlayedLabel.Name = "PlayedLabel";
            this.PlayedLabel.Size = new System.Drawing.Size(78, 13);
            this.PlayedLabel.TabIndex = 26;
            this.PlayedLabel.Text = "Games Played:";
            // 
            // TeamIdLabel
            // 
            this.TeamIdLabel.AutoSize = true;
            this.TeamIdLabel.Location = new System.Drawing.Point(46, 114);
            this.TeamIdLabel.Name = "TeamIdLabel";
            this.TeamIdLabel.Size = new System.Drawing.Size(46, 13);
            this.TeamIdLabel.TabIndex = 25;
            this.TeamIdLabel.Text = "TeamId:";
            // 
            // GamesDrawBox
            // 
            this.GamesDrawBox.Location = new System.Drawing.Point(98, 223);
            this.GamesDrawBox.Name = "GamesDrawBox";
            this.GamesDrawBox.Size = new System.Drawing.Size(100, 20);
            this.GamesDrawBox.TabIndex = 41;
            // 
            // DrawLabel
            // 
            this.DrawLabel.AutoSize = true;
            this.DrawLabel.Location = new System.Drawing.Point(21, 226);
            this.DrawLabel.Name = "DrawLabel";
            this.DrawLabel.Size = new System.Drawing.Size(71, 13);
            this.DrawLabel.TabIndex = 40;
            this.DrawLabel.Text = "Games Draw:";
            // 
            // GamesWonBox
            // 
            this.GamesWonBox.Location = new System.Drawing.Point(98, 186);
            this.GamesWonBox.Name = "GamesWonBox";
            this.GamesWonBox.Size = new System.Drawing.Size(100, 20);
            this.GamesWonBox.TabIndex = 39;
            // 
            // WonLabel
            // 
            this.WonLabel.AutoSize = true;
            this.WonLabel.Location = new System.Drawing.Point(23, 189);
            this.WonLabel.Name = "WonLabel";
            this.WonLabel.Size = new System.Drawing.Size(69, 13);
            this.WonLabel.TabIndex = 38;
            this.WonLabel.Text = "Games Won:";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 456);
            this.Controls.Add(this.GamesDrawBox);
            this.Controls.Add(this.DrawLabel);
            this.Controls.Add(this.GamesWonBox);
            this.Controls.Add(this.WonLabel);
            this.Controls.Add(this.GamesLostBox);
            this.Controls.Add(this.LossLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GamesPlayedBox);
            this.Controls.Add(this.TeamIdBox);
            this.Controls.Add(this.PlayedLabel);
            this.Controls.Add(this.TeamIdLabel);
            this.Name = "TableForm";
            this.Text = "Manage Tables";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GamesLostBox;
        private System.Windows.Forms.Label LossLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox GamesPlayedBox;
        private System.Windows.Forms.TextBox TeamIdBox;
        private System.Windows.Forms.Label PlayedLabel;
        private System.Windows.Forms.Label TeamIdLabel;
        private System.Windows.Forms.TextBox GamesDrawBox;
        private System.Windows.Forms.Label DrawLabel;
        private System.Windows.Forms.TextBox GamesWonBox;
        private System.Windows.Forms.Label WonLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesWon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesLost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
    }
}