namespace WFOrderAuto
{
    partial class VarukorgForm
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
            this.Varukorglabel = new System.Windows.Forms.Label();
            this.PaidBox = new System.Windows.Forms.TextBox();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.DateDBox = new System.Windows.Forms.TextBox();
            this.DateDLabel = new System.Windows.Forms.Label();
            this.DeliveredBox = new System.Windows.Forms.TextBox();
            this.DeliveredLabel = new System.Windows.Forms.Label();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.VarukorgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSkapad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumAvslutad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Betalad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Levererad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateCBox = new System.Windows.Forms.TextBox();
            this.DateCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 12);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 89;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // Varukorglabel
            // 
            this.Varukorglabel.AutoSize = true;
            this.Varukorglabel.Location = new System.Drawing.Point(91, 17);
            this.Varukorglabel.Name = "Varukorglabel";
            this.Varukorglabel.Size = new System.Drawing.Size(26, 13);
            this.Varukorglabel.TabIndex = 88;
            this.Varukorglabel.Text = "Cart";
            // 
            // PaidBox
            // 
            this.PaidBox.Location = new System.Drawing.Point(94, 172);
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.Size = new System.Drawing.Size(100, 20);
            this.PaidBox.TabIndex = 83;
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Location = new System.Drawing.Point(52, 175);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(31, 13);
            this.PaidLabel.TabIndex = 82;
            this.PaidLabel.Text = "Paid:";
            // 
            // DateDBox
            // 
            this.DateDBox.Location = new System.Drawing.Point(94, 135);
            this.DateDBox.Name = "DateDBox";
            this.DateDBox.Size = new System.Drawing.Size(100, 20);
            this.DateDBox.TabIndex = 81;
            // 
            // DateDLabel
            // 
            this.DateDLabel.AutoSize = true;
            this.DateDLabel.Location = new System.Drawing.Point(9, 138);
            this.DateDLabel.Name = "DateDLabel";
            this.DateDLabel.Size = new System.Drawing.Size(79, 13);
            this.DateDLabel.TabIndex = 80;
            this.DateDLabel.Text = "Date delivered:";
            // 
            // DeliveredBox
            // 
            this.DeliveredBox.Location = new System.Drawing.Point(94, 209);
            this.DeliveredBox.Name = "DeliveredBox";
            this.DeliveredBox.Size = new System.Drawing.Size(100, 20);
            this.DeliveredBox.TabIndex = 79;
            // 
            // DeliveredLabel
            // 
            this.DeliveredLabel.AutoSize = true;
            this.DeliveredLabel.Location = new System.Drawing.Point(30, 212);
            this.DeliveredLabel.Name = "DeliveredLabel";
            this.DeliveredLabel.Size = new System.Drawing.Size(55, 13);
            this.DeliveredLabel.TabIndex = 78;
            this.DeliveredLabel.Text = "Delivered:";
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarukorgId,
            this.DatumSkapad,
            this.DatumAvslutad,
            this.Betalad,
            this.Levererad});
            this.GridViewUsers.Location = new System.Drawing.Point(298, 43);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(545, 364);
            this.GridViewUsers.TabIndex = 77;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // VarukorgId
            // 
            this.VarukorgId.DataPropertyName = "VarukorgId";
            this.VarukorgId.HeaderText = "CartId";
            this.VarukorgId.Name = "VarukorgId";
            // 
            // DatumSkapad
            // 
            this.DatumSkapad.DataPropertyName = "DatumSkapad";
            this.DatumSkapad.HeaderText = "Date created";
            this.DatumSkapad.Name = "DatumSkapad";
            // 
            // DatumAvslutad
            // 
            this.DatumAvslutad.DataPropertyName = "DatumAvslutad";
            this.DatumAvslutad.HeaderText = "Date finished";
            this.DatumAvslutad.Name = "DatumAvslutad";
            // 
            // Betalad
            // 
            this.Betalad.DataPropertyName = "Betalad";
            this.Betalad.HeaderText = "paid";
            this.Betalad.Name = "Betalad";
            // 
            // Levererad
            // 
            this.Levererad.DataPropertyName = "Levererad";
            this.Levererad.HeaderText = "Delivered";
            this.Levererad.Name = "Levererad";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(142, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 76;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(58, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 75;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateCBox
            // 
            this.DateCBox.Location = new System.Drawing.Point(94, 98);
            this.DateCBox.Name = "DateCBox";
            this.DateCBox.Size = new System.Drawing.Size(100, 20);
            this.DateCBox.TabIndex = 74;
            // 
            // DateCLabel
            // 
            this.DateCLabel.AutoSize = true;
            this.DateCLabel.Location = new System.Drawing.Point(17, 101);
            this.DateCLabel.Name = "DateCLabel";
            this.DateCLabel.Size = new System.Drawing.Size(72, 13);
            this.DateCLabel.TabIndex = 73;
            this.DateCLabel.Text = "Date created:";
            // 
            // VarukorgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.Varukorglabel);
            this.Controls.Add(this.PaidBox);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.DateDBox);
            this.Controls.Add(this.DateDLabel);
            this.Controls.Add(this.DeliveredBox);
            this.Controls.Add(this.DeliveredLabel);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateCBox);
            this.Controls.Add(this.DateCLabel);
            this.Name = "VarukorgForm";
            this.Text = "Varukorg";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label Varukorglabel;
        private System.Windows.Forms.TextBox PaidBox;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.TextBox DateDBox;
        private System.Windows.Forms.Label DateDLabel;
        private System.Windows.Forms.TextBox DeliveredBox;
        private System.Windows.Forms.Label DeliveredLabel;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox DateCBox;
        private System.Windows.Forms.Label DateCLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarukorgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSkapad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumAvslutad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Betalad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Levererad;
    }
}