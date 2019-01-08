namespace WFOrderAuto
{
    partial class MenuForm
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
            this.ProductAddedButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductAddedButton
            // 
            this.ProductAddedButton.Location = new System.Drawing.Point(508, 166);
            this.ProductAddedButton.Name = "ProductAddedButton";
            this.ProductAddedButton.Size = new System.Drawing.Size(145, 62);
            this.ProductAddedButton.TabIndex = 21;
            this.ProductAddedButton.Text = "Manage products added to a cart";
            this.ProductAddedButton.UseVisualStyleBackColor = true;
            this.ProductAddedButton.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(148, 166);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(145, 62);
            this.ProductButton.TabIndex = 20;
            this.ProductButton.Text = "Manage products";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(327, 166);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(145, 62);
            this.CartButton.TabIndex = 18;
            this.CartButton.Text = "Manage carts";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.LineupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Administrative menu";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.ProductAddedButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProductAddedButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Label label1;
    }
}