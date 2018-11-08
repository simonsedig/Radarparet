namespace WFSpelarPortalAdmin1
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
            this.DBTestLabel = new System.Windows.Forms.Label();
            this.AttemptButton = new System.Windows.Forms.Button();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.DisconnectedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserButton = new System.Windows.Forms.Button();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.FixtureButton = new System.Windows.Forms.Button();
            this.LineupButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.UndefinedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DBTestLabel
            // 
            this.DBTestLabel.AutoSize = true;
            this.DBTestLabel.Location = new System.Drawing.Point(137, 26);
            this.DBTestLabel.Name = "DBTestLabel";
            this.DBTestLabel.Size = new System.Drawing.Size(134, 13);
            this.DBTestLabel.TabIndex = 0;
            this.DBTestLabel.Text = "Test database connection:";
            // 
            // AttemptButton
            // 
            this.AttemptButton.Location = new System.Drawing.Point(411, 21);
            this.AttemptButton.Name = "AttemptButton";
            this.AttemptButton.Size = new System.Drawing.Size(96, 23);
            this.AttemptButton.TabIndex = 1;
            this.AttemptButton.Text = "Attempt";
            this.AttemptButton.UseVisualStyleBackColor = true;
            this.AttemptButton.Click += new System.EventHandler(this.AttemptButton_Click);
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectedLabel.ForeColor = System.Drawing.Color.Green;
            this.ConnectedLabel.Location = new System.Drawing.Point(277, 26);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(68, 13);
            this.ConnectedLabel.TabIndex = 2;
            this.ConnectedLabel.Text = "Connected";
            this.ConnectedLabel.Visible = false;
            // 
            // DisconnectedLabel
            // 
            this.DisconnectedLabel.AutoSize = true;
            this.DisconnectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectedLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DisconnectedLabel.Location = new System.Drawing.Point(277, 26);
            this.DisconnectedLabel.Name = "DisconnectedLabel";
            this.DisconnectedLabel.Size = new System.Drawing.Size(85, 13);
            this.DisconnectedLabel.TabIndex = 3;
            this.DisconnectedLabel.Text = "Disconnected";
            this.DisconnectedLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrative menu";
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(241, 330);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(145, 62);
            this.UserButton.TabIndex = 5;
            this.UserButton.Text = "Manage Users";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // PlayerButton
            // 
            this.PlayerButton.Location = new System.Drawing.Point(241, 202);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(145, 62);
            this.PlayerButton.TabIndex = 6;
            this.PlayerButton.Text = "Manage Players";
            this.PlayerButton.UseVisualStyleBackColor = true;
            this.PlayerButton.Click += new System.EventHandler(this.PlayerButton_Click);
            // 
            // FixtureButton
            // 
            this.FixtureButton.Location = new System.Drawing.Point(62, 330);
            this.FixtureButton.Name = "FixtureButton";
            this.FixtureButton.Size = new System.Drawing.Size(145, 62);
            this.FixtureButton.TabIndex = 7;
            this.FixtureButton.Text = "Manage Fixtures";
            this.FixtureButton.UseVisualStyleBackColor = true;
            this.FixtureButton.Click += new System.EventHandler(this.FixtureButton_Click);
            // 
            // LineupButton
            // 
            this.LineupButton.Location = new System.Drawing.Point(62, 202);
            this.LineupButton.Name = "LineupButton";
            this.LineupButton.Size = new System.Drawing.Size(145, 62);
            this.LineupButton.TabIndex = 8;
            this.LineupButton.Text = "Manage Current Lineup";
            this.LineupButton.UseVisualStyleBackColor = true;
            this.LineupButton.Click += new System.EventHandler(this.LineupButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.Location = new System.Drawing.Point(422, 202);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(145, 62);
            this.TableButton.TabIndex = 9;
            this.TableButton.Text = "Manage Table";
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // UndefinedLabel
            // 
            this.UndefinedLabel.AutoSize = true;
            this.UndefinedLabel.Location = new System.Drawing.Point(280, 26);
            this.UndefinedLabel.Name = "UndefinedLabel";
            this.UndefinedLabel.Size = new System.Drawing.Size(56, 13);
            this.UndefinedLabel.TabIndex = 10;
            this.UndefinedLabel.Text = "Undefined";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(632, 429);
            this.Controls.Add(this.UndefinedLabel);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.LineupButton);
            this.Controls.Add(this.FixtureButton);
            this.Controls.Add(this.PlayerButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectedLabel);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.AttemptButton);
            this.Controls.Add(this.DBTestLabel);
            this.Name = "Form1";
            this.Text = "SpelarPortalen Admin - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DBTestLabel;
        private System.Windows.Forms.Button AttemptButton;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.Label DisconnectedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Button FixtureButton;
        private System.Windows.Forms.Button LineupButton;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Label UndefinedLabel;
    }
}

