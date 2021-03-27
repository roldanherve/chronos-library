using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos_Library
{
    public partial class MainMenu : Form
    {
        //Fields
        private Form activeForm;
        public MainMenu()
        {
            InitializeComponent();
            openChildForm(new Forms.Home());
        }

        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(childForm);
            this.containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            formLabel.Text = childForm.Text;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Home());
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Users());
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Records());
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.Info());
        }
    }
}
