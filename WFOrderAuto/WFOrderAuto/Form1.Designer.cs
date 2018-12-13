namespace WFOrderAuto
{
    partial class Form1
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
            this.KategoriBox = new System.Windows.Forms.TextBox();
            this.KategoriLabel = new System.Windows.Forms.Label();
            this.PrisBox = new System.Windows.Forms.TextBox();
            this.PrisLabel = new System.Windows.Forms.Label();
            this.BildadressBox = new System.Windows.Forms.TextBox();
            this.BildadressLabel = new System.Windows.Forms.Label();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.ProduktId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bildadress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vikt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagerplats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NamnBox = new System.Windows.Forms.TextBox();
            this.NamnLabel = new System.Windows.Forms.Label();
            this.ViktBox = new System.Windows.Forms.TextBox();
            this.Viktlabel = new System.Windows.Forms.Label();
            this.LagerplatsBox = new System.Windows.Forms.TextBox();
            this.Lagerplatslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // KategoriBox
            // 
            this.KategoriBox.Location = new System.Drawing.Point(93, 172);
            this.KategoriBox.Name = "KategoriBox";
            this.KategoriBox.Size = new System.Drawing.Size(100, 20);
            this.KategoriBox.TabIndex = 66;
            // 
            // KategoriLabel
            // 
            this.KategoriLabel.AutoSize = true;
            this.KategoriLabel.Location = new System.Drawing.Point(35, 175);
            this.KategoriLabel.Name = "KategoriLabel";
            this.KategoriLabel.Size = new System.Drawing.Size(52, 13);
            this.KategoriLabel.TabIndex = 65;
            this.KategoriLabel.Text = "Category:";
            // 
            // PrisBox
            // 
            this.PrisBox.Location = new System.Drawing.Point(93, 135);
            this.PrisBox.Name = "PrisBox";
            this.PrisBox.Size = new System.Drawing.Size(100, 20);
            this.PrisBox.TabIndex = 64;
            // 
            // PrisLabel
            // 
            this.PrisLabel.AutoSize = true;
            this.PrisLabel.Location = new System.Drawing.Point(52, 138);
            this.PrisLabel.Name = "PrisLabel";
            this.PrisLabel.Size = new System.Drawing.Size(34, 13);
            this.PrisLabel.TabIndex = 63;
            this.PrisLabel.Text = "Price:";
            // 
            // BildadressBox
            // 
            this.BildadressBox.Location = new System.Drawing.Point(93, 209);
            this.BildadressBox.Name = "BildadressBox";
            this.BildadressBox.Size = new System.Drawing.Size(100, 20);
            this.BildadressBox.TabIndex = 62;
            // 
            // BildadressLabel
            // 
            this.BildadressLabel.AutoSize = true;
            this.BildadressLabel.Location = new System.Drawing.Point(9, 212);
            this.BildadressLabel.Name = "BildadressLabel";
            this.BildadressLabel.Size = new System.Drawing.Size(78, 13);
            this.BildadressLabel.TabIndex = 61;
            this.BildadressLabel.Text = "Picture source:";
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduktId,
            this.Namn,
            this.Pris,
            this.Kategori,
            this.Bildadress,
            this.Vikt,
            this.Lagerplats});
            this.GridViewUsers.Location = new System.Drawing.Point(297, 43);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(741, 364);
            this.GridViewUsers.TabIndex = 60;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // ProduktId
            // 
            this.ProduktId.DataPropertyName = "ProduktId";
            this.ProduktId.HeaderText = "ProductId";
            this.ProduktId.Name = "ProduktId";
            // 
            // Namn
            // 
            this.Namn.DataPropertyName = "Namn";
            this.Namn.HeaderText = "Product name";
            this.Namn.Name = "Namn";
            // 
            // Pris
            // 
            this.Pris.DataPropertyName = "Pris";
            this.Pris.HeaderText = "Price";
            this.Pris.Name = "Pris";
            // 
            // Kategori
            // 
            this.Kategori.DataPropertyName = "Kategori";
            this.Kategori.HeaderText = "Category";
            this.Kategori.Name = "Kategori";
            // 
            // Bildadress
            // 
            this.Bildadress.DataPropertyName = "Bildadress";
            this.Bildadress.HeaderText = "Picture source";
            this.Bildadress.Name = "Bildadress";
            // 
            // Vikt
            // 
            this.Vikt.DataPropertyName = "Vikt";
            this.Vikt.HeaderText = "Weight";
            this.Vikt.Name = "Vikt";
            // 
            // Lagerplats
            // 
            this.Lagerplats.DataPropertyName = "Lagerplats";
            this.Lagerplats.HeaderText = "Bin";
            this.Lagerplats.Name = "Lagerplats";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(141, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 59;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(57, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NamnBox
            // 
            this.NamnBox.Location = new System.Drawing.Point(93, 98);
            this.NamnBox.Name = "NamnBox";
            this.NamnBox.Size = new System.Drawing.Size(100, 20);
            this.NamnBox.TabIndex = 57;
            // 
            // NamnLabel
            // 
            this.NamnLabel.AutoSize = true;
            this.NamnLabel.Location = new System.Drawing.Point(47, 101);
            this.NamnLabel.Name = "NamnLabel";
            this.NamnLabel.Size = new System.Drawing.Size(38, 13);
            this.NamnLabel.TabIndex = 56;
            this.NamnLabel.Text = "Name:";
            // 
            // ViktBox
            // 
            this.ViktBox.Location = new System.Drawing.Point(93, 244);
            this.ViktBox.Name = "ViktBox";
            this.ViktBox.Size = new System.Drawing.Size(100, 20);
            this.ViktBox.TabIndex = 70;
            // 
            // Viktlabel
            // 
            this.Viktlabel.AutoSize = true;
            this.Viktlabel.Location = new System.Drawing.Point(47, 247);
            this.Viktlabel.Name = "Viktlabel";
            this.Viktlabel.Size = new System.Drawing.Size(41, 13);
            this.Viktlabel.TabIndex = 69;
            this.Viktlabel.Text = "weight:";
            // 
            // LagerplatsBox
            // 
            this.LagerplatsBox.Location = new System.Drawing.Point(93, 281);
            this.LagerplatsBox.Name = "LagerplatsBox";
            this.LagerplatsBox.Size = new System.Drawing.Size(100, 20);
            this.LagerplatsBox.TabIndex = 68;
            // 
            // Lagerplatslabel
            // 
            this.Lagerplatslabel.AutoSize = true;
            this.Lagerplatslabel.Location = new System.Drawing.Point(59, 284);
            this.Lagerplatslabel.Name = "Lagerplatslabel";
            this.Lagerplatslabel.Size = new System.Drawing.Size(25, 13);
            this.Lagerplatslabel.TabIndex = 67;
            this.Lagerplatslabel.Text = "Bin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViktBox);
            this.Controls.Add(this.Viktlabel);
            this.Controls.Add(this.LagerplatsBox);
            this.Controls.Add(this.Lagerplatslabel);
            this.Controls.Add(this.KategoriBox);
            this.Controls.Add(this.KategoriLabel);
            this.Controls.Add(this.PrisBox);
            this.Controls.Add(this.PrisLabel);
            this.Controls.Add(this.BildadressBox);
            this.Controls.Add(this.BildadressLabel);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NamnBox);
            this.Controls.Add(this.NamnLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KategoriBox;
        private System.Windows.Forms.Label KategoriLabel;
        private System.Windows.Forms.TextBox PrisBox;
        private System.Windows.Forms.Label PrisLabel;
        private System.Windows.Forms.TextBox BildadressBox;
        private System.Windows.Forms.Label BildadressLabel;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NamnBox;
        private System.Windows.Forms.Label NamnLabel;
        private System.Windows.Forms.TextBox ViktBox;
        private System.Windows.Forms.Label Viktlabel;
        private System.Windows.Forms.TextBox LagerplatsBox;
        private System.Windows.Forms.Label Lagerplatslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduktId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bildadress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vikt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerplats;
    }
}

