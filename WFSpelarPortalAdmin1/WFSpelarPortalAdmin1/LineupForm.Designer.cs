namespace WFSpelarPortalAdmin1
{
    partial class LineupForm
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
            this.SquadIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextBoxPlayer = new System.Windows.Forms.TextBox();
            this.PlayerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(16, 12);
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
            this.SquadIdNo,
            this.PlayerId});
            this.GridViewUsers.Location = new System.Drawing.Point(275, 12);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(254, 316);
            this.GridViewUsers.TabIndex = 15;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // SquadIdNo
            // 
            this.SquadIdNo.DataPropertyName = "IdSquadNo";
            this.SquadIdNo.HeaderText = "SquadIdNo";
            this.SquadIdNo.Name = "SquadIdNo";
            // 
            // PlayerId
            // 
            this.PlayerId.DataPropertyName = "IdPlayer";
            this.PlayerId.HeaderText = "PlayerId";
            this.PlayerId.Name = "PlayerId";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(100, 191);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextBoxPlayer
            // 
            this.TextBoxPlayer.Location = new System.Drawing.Point(75, 127);
            this.TextBoxPlayer.Name = "TextBoxPlayer";
            this.TextBoxPlayer.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlayer.TabIndex = 12;
            // 
            // PlayerIdLabel
            // 
            this.PlayerIdLabel.AutoSize = true;
            this.PlayerIdLabel.Location = new System.Drawing.Point(15, 130);
            this.PlayerIdLabel.Name = "PlayerIdLabel";
            this.PlayerIdLabel.Size = new System.Drawing.Size(48, 13);
            this.PlayerIdLabel.TabIndex = 10;
            this.PlayerIdLabel.Text = "PlayerId:";
            // 
            // LineupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBoxPlayer);
            this.Controls.Add(this.PlayerIdLabel);
            this.Name = "LineupForm";
            this.Text = "Manage Lineup";
            this.Load += new System.EventHandler(this.LineupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TextBoxPlayer;
        private System.Windows.Forms.Label PlayerIdLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SquadIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerId;
    }
}