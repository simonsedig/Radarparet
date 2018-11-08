﻿namespace WFSpelarPortalAdmin1
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArenaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(105, 191);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(100, 20);
            this.ColorBox.TabIndex = 55;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(59, 194);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 13);
            this.ColorLabel.TabIndex = 54;
            this.ColorLabel.Text = "Colors:";
            // 
            // CoachBox
            // 
            this.CoachBox.Location = new System.Drawing.Point(105, 154);
            this.CoachBox.Name = "CoachBox";
            this.CoachBox.Size = new System.Drawing.Size(100, 20);
            this.CoachBox.TabIndex = 53;
            // 
            // CoachLabel
            // 
            this.CoachLabel.AutoSize = true;
            this.CoachLabel.Location = new System.Drawing.Point(56, 157);
            this.CoachLabel.Name = "CoachLabel";
            this.CoachLabel.Size = new System.Drawing.Size(41, 13);
            this.CoachLabel.TabIndex = 52;
            this.CoachLabel.Text = "Coach:";
            // 
            // ArenaBox
            // 
            this.ArenaBox.Location = new System.Drawing.Point(105, 228);
            this.ArenaBox.Name = "ArenaBox";
            this.ArenaBox.Size = new System.Drawing.Size(100, 20);
            this.ArenaBox.TabIndex = 51;
            // 
            // ArenaLabel
            // 
            this.ArenaLabel.AutoSize = true;
            this.ArenaLabel.Location = new System.Drawing.Point(33, 231);
            this.ArenaLabel.Name = "ArenaLabel";
            this.ArenaLabel.Size = new System.Drawing.Size(67, 13);
            this.ArenaLabel.TabIndex = 50;
            this.ArenaLabel.Text = "Arena name:";
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(30, 30);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 49;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
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
            this.GridViewUsers.Location = new System.Drawing.Point(309, 62);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(545, 364);
            this.GridViewUsers.TabIndex = 48;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(153, 305);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 47;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(69, 305);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Location = new System.Drawing.Point(105, 117);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(100, 20);
            this.TeamNameBox.TabIndex = 45;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Location = new System.Drawing.Point(33, 120);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(66, 13);
            this.TeamNameLabel.TabIndex = 43;
            this.TeamNameLabel.Text = "Team name:";
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
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 456);
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
            this.Name = "TeamForm";
            this.Text = "TeamForm";
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