using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos_Library.Forms
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            usersDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void clearUserInput(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is Guna.UI2.WinForms.Suite.TextBox)
                    ((Guna.UI2.WinForms.Suite.TextBox)ctrl).Text = string.Empty;
                clearUserInput(ctrl.Controls);
            }
        }

        private void usersConfirmButton_Click(object sender, EventArgs e)
        {
            string borrowerID = borrowerIDTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string streetAddress = stAddressTextBox.Text;
            string city = cityTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;

            //set up connection
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ChronosLibrary; Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //t-sql commands
            string queryString = "SELECT * FROM Users WHERE borrower_id LIKE '%" + borrowerID + "%' AND " +
                "first_name LIKE '" + firstName + "%' AND " +
                "last_name LIKE '" + lastName + "%' AND " +
                "street_address LIKE '" + streetAddress + "%' AND " +
                "city LIKE '" + city + "%' AND " +
                "phone LIKE '" + phone + "%' AND " +
                "email LIKE '" + email + "%';";

            //fill
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(queryString, connection);
            sqlData.Fill(dataTable);
            usersDataGridView.AutoGenerateColumns = false;
            usersDataGridView.DataSource = dataTable;

            connection.Close();

            clearUserInput(this.Controls);
        }
    }
}
