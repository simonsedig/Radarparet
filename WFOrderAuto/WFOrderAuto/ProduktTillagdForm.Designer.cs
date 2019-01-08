namespace WFOrderAuto
{
    partial class ProduktTillagdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SumPBox = new System.Windows.Forms.TextBox();
            this.SumPLabel = new System.Windows.Forms.Label();
            this.GridViewUsers = new System.Windows.Forms.DataGridView();
            this.TransaktionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarukorgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduktId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaProdukter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.AntalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 12);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 23);
            this.MenuButton.TabIndex = 106;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Product added";
            // 
            // SumPBox
            // 
            this.SumPBox.Location = new System.Drawing.Point(94, 135);
            this.SumPBox.Name = "SumPBox";
            this.SumPBox.Size = new System.Drawing.Size(100, 20);
            this.SumPBox.TabIndex = 98;
            // 
            // SumPLabel
            // 
            this.SumPLabel.AutoSize = true;
            this.SumPLabel.Location = new System.Drawing.Point(15, 138);
            this.SumPLabel.Name = "SumPLabel";
            this.SumPLabel.Size = new System.Drawing.Size(75, 13);
            this.SumPLabel.TabIndex = 97;
            this.SumPLabel.Text = "Sum products:";
            // 
            // GridViewUsers
            // 
            this.GridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransaktionId,
            this.VarukorgId,
            this.ProduktId,
            this.Antal,
            this.SummaProdukter});
            this.GridViewUsers.Location = new System.Drawing.Point(298, 43);
            this.GridViewUsers.Name = "GridViewUsers";
            this.GridViewUsers.Size = new System.Drawing.Size(545, 364);
            this.GridViewUsers.TabIndex = 94;
            this.GridViewUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewUsers_CellMouseClick);
            // 
            // TransaktionId
            // 
            this.TransaktionId.DataPropertyName = "TransaktionId";
            this.TransaktionId.HeaderText = "TransactionId";
            this.TransaktionId.Name = "TransaktionId";
            // 
            // VarukorgId
            // 
            this.VarukorgId.DataPropertyName = "VarukorgId";
            this.VarukorgId.HeaderText = "CartId";
            this.VarukorgId.Name = "VarukorgId";
            // 
            // ProduktId
            // 
            this.ProduktId.DataPropertyName = "ProduktId";
            this.ProduktId.HeaderText = "ProductId";
            this.ProduktId.Name = "ProduktId";
            // 
            // Antal
            // 
            this.Antal.DataPropertyName = "Antal";
            this.Antal.HeaderText = "Quantity";
            this.Antal.Name = "Antal";
            // 
            // SummaProdukter
            // 
            this.SummaProdukter.DataPropertyName = "SummaProdukter";
            this.SummaProdukter.HeaderText = "Sum products";
            this.SummaProdukter.Name = "SummaProdukter";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(142, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 93;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(58, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 92;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(94, 98);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityBox.TabIndex = 91;
            // 
            // AntalLabel
            // 
            this.AntalLabel.AutoSize = true;
            this.AntalLabel.Location = new System.Drawing.Point(40, 101);
            this.AntalLabel.Name = "AntalLabel";
            this.AntalLabel.Size = new System.Drawing.Size(49, 13);
            this.AntalLabel.TabIndex = 90;
            this.AntalLabel.Text = "Quantity:";
            // 
            // ProduktTillagdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumPBox);
            this.Controls.Add(this.SumPLabel);
            this.Controls.Add(this.GridViewUsers);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.AntalLabel);
            this.Name = "ProduktTillagdForm";
            this.Text = "ProduktTillagd";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumPBox;
        private System.Windows.Forms.Label SumPLabel;
        private System.Windows.Forms.DataGridView GridViewUsers;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label AntalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransaktionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarukorgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduktId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaProdukter;
    }
}