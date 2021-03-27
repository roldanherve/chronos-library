namespace Chronos_Library
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.infoButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chronosLabel = new System.Windows.Forms.Label();
            this.chronosPicture = new System.Windows.Forms.PictureBox();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.userButton = new Guna.UI2.WinForms.Guna2Button();
            this.recordsButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronosPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.Controls.Add(this.infoButton);
            this.mainMenuPanel.Controls.Add(this.panel3);
            this.mainMenuPanel.Controls.Add(this.homeButton);
            this.mainMenuPanel.Controls.Add(this.userButton);
            this.mainMenuPanel.Controls.Add(this.recordsButton);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(190, 608);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.BorderRadius = 22;
            this.infoButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.infoButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.infoButton.CheckedState.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.infoButton.CheckedState.Image = global::Chronos_Library.Properties.Resources.information__012C3D;
            this.infoButton.CheckedState.Parent = this.infoButton;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.CustomImages.Parent = this.infoButton;
            this.infoButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.infoButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.HoverState.Parent = this.infoButton;
            this.infoButton.Image = global::Chronos_Library.Properties.Resources.information;
            this.infoButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.infoButton.ImageOffset = new System.Drawing.Point(8, 0);
            this.infoButton.Location = new System.Drawing.Point(24, 402);
            this.infoButton.Name = "infoButton";
            this.infoButton.ShadowDecoration.Parent = this.infoButton;
            this.infoButton.Size = new System.Drawing.Size(150, 43);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "Info";
            this.infoButton.UseTransparentBackground = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chronosLabel);
            this.panel3.Controls.Add(this.chronosPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 156);
            this.panel3.TabIndex = 7;
            // 
            // chronosLabel
            // 
            this.chronosLabel.AutoSize = true;
            this.chronosLabel.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chronosLabel.Location = new System.Drawing.Point(58, 63);
            this.chronosLabel.Name = "chronosLabel";
            this.chronosLabel.Size = new System.Drawing.Size(116, 62);
            this.chronosLabel.TabIndex = 1;
            this.chronosLabel.Text = "CHRONOS\r\nLIBRARY\r\n";
            // 
            // chronosPicture
            // 
            this.chronosPicture.Image = global::Chronos_Library.Properties.Resources.logo;
            this.chronosPicture.Location = new System.Drawing.Point(11, 68);
            this.chronosPicture.Name = "chronosPicture";
            this.chronosPicture.Size = new System.Drawing.Size(50, 50);
            this.chronosPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chronosPicture.TabIndex = 0;
            this.chronosPicture.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BorderRadius = 22;
            this.homeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeButton.Checked = true;
            this.homeButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.homeButton.CheckedState.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.homeButton.CheckedState.Image = global::Chronos_Library.Properties.Resources.home__012C3D;
            this.homeButton.CheckedState.Parent = this.homeButton;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.CustomImages.Parent = this.homeButton;
            this.homeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.homeButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.Parent = this.homeButton;
            this.homeButton.Image = global::Chronos_Library.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeButton.ImageOffset = new System.Drawing.Point(8, 0);
            this.homeButton.Location = new System.Drawing.Point(24, 189);
            this.homeButton.Name = "homeButton";
            this.homeButton.ShadowDecoration.Parent = this.homeButton;
            this.homeButton.Size = new System.Drawing.Size(150, 43);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseTransparentBackground = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.Transparent;
            this.userButton.BorderRadius = 22;
            this.userButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.userButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.userButton.CheckedState.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.userButton.CheckedState.Image = global::Chronos_Library.Properties.Resources.users__012C3D;
            this.userButton.CheckedState.Parent = this.userButton;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.CustomImages.Parent = this.userButton;
            this.userButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.userButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.HoverState.Parent = this.userButton;
            this.userButton.Image = global::Chronos_Library.Properties.Resources.users;
            this.userButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userButton.ImageOffset = new System.Drawing.Point(8, 0);
            this.userButton.Location = new System.Drawing.Point(24, 260);
            this.userButton.Name = "userButton";
            this.userButton.ShadowDecoration.Parent = this.userButton;
            this.userButton.Size = new System.Drawing.Size(150, 43);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "Users";
            this.userButton.UseTransparentBackground = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // recordsButton
            // 
            this.recordsButton.BackColor = System.Drawing.Color.Transparent;
            this.recordsButton.BorderRadius = 22;
            this.recordsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.recordsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.recordsButton.CheckedState.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.recordsButton.CheckedState.Image = global::Chronos_Library.Properties.Resources.records__002D3D;
            this.recordsButton.CheckedState.Parent = this.recordsButton;
            this.recordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordsButton.CustomImages.Parent = this.recordsButton;
            this.recordsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.recordsButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsButton.ForeColor = System.Drawing.Color.White;
            this.recordsButton.HoverState.Parent = this.recordsButton;
            this.recordsButton.Image = global::Chronos_Library.Properties.Resources.records;
            this.recordsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.recordsButton.ImageOffset = new System.Drawing.Point(8, 0);
            this.recordsButton.Location = new System.Drawing.Point(24, 331);
            this.recordsButton.Name = "recordsButton";
            this.recordsButton.ShadowDecoration.Parent = this.recordsButton;
            this.recordsButton.Size = new System.Drawing.Size(150, 43);
            this.recordsButton.TabIndex = 3;
            this.recordsButton.Text = "Records";
            this.recordsButton.UseTransparentBackground = true;
            this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(190, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 38);
            this.panel1.TabIndex = 1;
            // 
            // formLabel
            // 
            this.formLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Source Sans Pro Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(394, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(98, 31);
            this.formLabel.TabIndex = 1;
            this.formLabel.Text = "Chronos";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(190, 38);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(6, 10, 10, 10);
            this.containerPanel.Size = new System.Drawing.Size(882, 570);
            this.containerPanel.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuPanel);
            this.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chronos Library";
            this.mainMenuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chronosPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.PictureBox chronosPicture;
        private System.Windows.Forms.Label chronosLabel;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2Button infoButton;
        private Guna.UI2.WinForms.Guna2Button userButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Button recordsButton;
    }
}

