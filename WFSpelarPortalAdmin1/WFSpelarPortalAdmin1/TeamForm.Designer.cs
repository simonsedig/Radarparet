namespace WFSpelarPortalAdmin1
{
    partial class TeamForm
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
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.CoachBox = new System.Windows.Forms.TextBox();
            this.CoachLabel = new System.Windows.Forms.Label();
            this.ArenaBox = new System.Windows.Forms.TextBox();
            this.ArenaLabel = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArenaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(140, 235);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(132, 22);
            this.ColorBox.TabIndex = 55;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(79, 239);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(52, 17);
            this.ColorLabel.TabIndex = 54;
            this.ColorLabel.Text = "Colors:";
            // 
            // CoachBox
            // 
            this.CoachBox.Location = new System.Drawing.Point(140, 190);
            this.CoachBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoachBox.Name = "CoachBox";
            this.CoachBox.Size = new System.Drawing.Size(132, 22);
            this.CoachBox.TabIndex = 53;
            // 
            // CoachLabel
            // 
            this.CoachLabel.AutoSize = true;
            this.CoachLabel.Location = new System.Drawing.Point(75, 193);
            this.CoachLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoachLabel.Name = "CoachLabel";
            this.CoachLabel.Size = new System.Drawing.Size(52, 17);
            this.CoachLabel.TabIndex = 52;
            this.CoachLabel.Text = "Coach:";
            // 
            // ArenaBox
            // 
            this.ArenaBox.Location = new System.Drawing.Point(140, 281);
            this.ArenaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArenaBox.Name = "ArenaBox";
            this.ArenaBox.Size = new System.Drawing.Size(132, 22);
            this.ArenaBox.TabIndex = 51;
            // 
            // ArenaLabel
            // 
            this.ArenaLabel.AutoSize = true;
            this.ArenaLabel.Location = new System.Drawing.Point(44, 284);
            this.ArenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArenaLabel.Name = "ArenaLabel";
            this.ArenaLabel.Size = new System.Drawing.Size(89, 17);
            this.ArenaLabel.TabIndex = 50;
            this.ArenaLabel.Text = "Arena name:";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(40, 37);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(73, 28);
            this.MenuButton.TabIndex = 49;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamId,
            this.TeamName,
            this.Coach,
            this.Colors,
            this.ArenaName});
            this.GridViewUsers.Location = new System.Drawing.Point(412, 76);
            this.GridViewUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(727, 448);
            this.GridViewUsers.TabIndex = 48;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // TeamId
            // 
            this.TeamId.DataPropertyName = "TeamId";
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team name";
            this.TeamName.Name = "TeamName";
            // 
            // Coach
            // 
            this.Coach.DataPropertyName = "Coach";
            this.Coach.HeaderText = "Coach";
            this.Coach.Name = "Coach";
            // 
            // Colors
            // 
            this.Colors.DataPropertyName = "Colors";
            this.Colors.HeaderText = "Colors";
            this.Colors.Name = "Colors";
            // 
            // ArenaName
            // 
            this.ArenaName.DataPropertyName = "ArenaName";
            this.ArenaName.HeaderText = "Arena name";
            this.ArenaName.Name = "ArenaName";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(204, 375);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 47;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(92, 375);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 28);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Location = new System.Drawing.Point(140, 144);
            this.TeamNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(132, 22);
            this.TeamNameBox.TabIndex = 45;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Location = new System.Drawing.Point(44, 148);
            this.TeamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(87, 17);
            this.TeamNameLabel.TabIndex = 43;
            this.TeamNameLabel.Text = "Team name:";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 561);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.CoachBox);
            this.Controls.Add(this.CoachLabel);
            this.Controls.Add(this.ArenaBox);
            this.Controls.Add(this.ArenaLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TeamNameBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox CoachBox;
        private System.Windows.Forms.Label CoachLabel;
        private System.Windows.Forms.TextBox ArenaBox;
        private System.Windows.Forms.Label ArenaLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArenaName;
    }
}