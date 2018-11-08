namespace WFSpelarPortalAdmin1
{
    partial class FixtureForm
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
            this.MenuButton = new System.Windows.Forms.Button();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.TeamHomeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FixtureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAwayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AwayIdBox = new System.Windows.Forms.TextBox();
            this.HomeIdBox = new System.Windows.Forms.TextBox();
            this.TeamAwayLabel = new System.Windows.Forms.Label();
            this.TeamHomeLabel = new System.Windows.Forms.Label();
            this.RefereeBox = new System.Windows.Forms.TextBox();
            this.RefereeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(21, 33);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 16;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamHomeId,
            this.FixtureId,
            this.TeamAwayId,
            this.Date,
            this.Referee,
            this.Result});
            this.GridViewUsers.Location = new System.Drawing.Point(346, 65);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(605, 364);
            this.GridViewUsers.TabIndex = 15;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // TeamHomeId
            // 
            this.TeamHomeId.DataPropertyName = "TeamHomeId";
            this.TeamHomeId.HeaderText = "TeamHomeId";
            this.TeamHomeId.Name = "TeamHomeId";
            // 
            // FixtureId
            // 
            this.FixtureId.DataPropertyName = "FixtureId";
            this.FixtureId.HeaderText = "FixtureId";
            this.FixtureId.Name = "FixtureId";
            this.FixtureId.Visible = false;
            // 
            // TeamAwayId
            // 
            this.TeamAwayId.DataPropertyName = "TeamAwayId";
            this.TeamAwayId.HeaderText = "TeamAwayId";
            this.TeamAwayId.Name = "TeamAwayId";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Referee
            // 
            this.Referee.DataPropertyName = "Referee";
            this.Referee.HeaderText = "Referee";
            this.Referee.Name = "Referee";
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(144, 345);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(60, 345);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AwayIdBox
            // 
            this.AwayIdBox.Location = new System.Drawing.Point(96, 148);
            this.AwayIdBox.Name = "AwayIdBox";
            this.AwayIdBox.Size = new System.Drawing.Size(100, 20);
            this.AwayIdBox.TabIndex = 12;
            // 
            // HomeIdBox
            // 
            this.HomeIdBox.Location = new System.Drawing.Point(96, 110);
            this.HomeIdBox.Name = "HomeIdBox";
            this.HomeIdBox.Size = new System.Drawing.Size(100, 20);
            this.HomeIdBox.TabIndex = 11;
            // 
            // TeamAwayLabel
            // 
            this.TeamAwayLabel.AutoSize = true;
            this.TeamAwayLabel.Location = new System.Drawing.Point(18, 151);
            this.TeamAwayLabel.Name = "TeamAwayLabel";
            this.TeamAwayLabel.Size = new System.Drawing.Size(72, 13);
            this.TeamAwayLabel.TabIndex = 10;
            this.TeamAwayLabel.Text = "TeamAwayId:";
            // 
            // TeamHomeLabel
            // 
            this.TeamHomeLabel.AutoSize = true;
            this.TeamHomeLabel.Location = new System.Drawing.Point(16, 113);
            this.TeamHomeLabel.Name = "TeamHomeLabel";
            this.TeamHomeLabel.Size = new System.Drawing.Size(74, 13);
            this.TeamHomeLabel.TabIndex = 9;
            this.TeamHomeLabel.Text = "TeamHomeId:";
            // 
            // RefereeBox
            // 
            this.RefereeBox.Location = new System.Drawing.Point(96, 230);
            this.RefereeBox.Name = "RefereeBox";
            this.RefereeBox.Size = new System.Drawing.Size(100, 20);
            this.RefereeBox.TabIndex = 20;
            // 
            // RefereeLabel
            // 
            this.RefereeLabel.AutoSize = true;
            this.RefereeLabel.Location = new System.Drawing.Point(42, 233);
            this.RefereeLabel.Name = "RefereeLabel";
            this.RefereeLabel.Size = new System.Drawing.Size(48, 13);
            this.RefereeLabel.TabIndex = 18;
            this.RefereeLabel.Text = "Referee:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(57, 194);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Date:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(96, 267);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(100, 20);
            this.ResultBox.TabIndex = 23;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(50, 270);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 21;
            this.ResultLabel.Text = "Result:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(96, 194);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 20);
            this.DateBox.TabIndex = 24;
            // 
            // FixtureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 518);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.RefereeBox);
            this.Controls.Add(this.RefereeLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AwayIdBox);
            this.Controls.Add(this.HomeIdBox);
            this.Controls.Add(this.TeamAwayLabel);
            this.Controls.Add(this.TeamHomeLabel);
            this.Name = "FixtureForm";
            this.Text = "Manage Fixture";
            this.Load += new System.EventHandler(this.FixtureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AwayIdBox;
        private System.Windows.Forms.TextBox HomeIdBox;
        private System.Windows.Forms.Label TeamAwayLabel;
        private System.Windows.Forms.Label TeamHomeLabel;
        private System.Windows.Forms.TextBox RefereeBox;
        private System.Windows.Forms.Label RefereeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamHomeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FixtureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAwayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}