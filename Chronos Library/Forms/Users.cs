using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos_Library.Forms
{
    public partial class Users : Form
    {
        //variables and visibility/debugging
        public string[] comboBoxchoices = new string[] {"Phone","Email"};
        public string imgLoc = string.Empty;
        string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ChronosLibrary; Integrated Security = True;";

        public Users()
        {
            InitializeComponent();
            updateButton.Enabled = false;
            fillComboBox();
        }

        private void fillComboBox()
        {
            foreach (var choice in comboBoxchoices)
            {
                contactMethodComboBox.Items.Add(choice);
            }
        }

        private void clearUserInput(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is Guna.UI2.WinForms.Suite.TextBox)
                    ((Guna.UI2.WinForms.Suite.TextBox)ctrl).Text = string.Empty;
                if (ctrl is System.Windows.Forms.ComboBox)
                    ((System.Windows.Forms.ComboBox)ctrl).ResetText();
                if (ctrl is System.Windows.Forms.PictureBox)
                    ((System.Windows.Forms.PictureBox)ctrl).Image = null;
                clearUserInput(ctrl.Controls);
            }
        }

        private bool isUserInputComplete(Control.ControlCollection ctrls)
        {
            bool isComplete = true;
            foreach (Control ctrl in ctrls) //checks all ctrls in control collection
            {
                if (ctrl == searchTextBox) //search box can be null hence continue
                    continue;
                if (ctrl is Guna.UI2.WinForms.Suite.TextBox) //if it is a textBox ...
                    if (((Guna.UI2.WinForms.Suite.TextBox)ctrl).Text == string.Empty) //... and it is empty ...
                        isComplete = false; //... then user has left a textBox blank
                if (ctrl is System.Windows.Forms.ComboBox) //if it is a comboBox ...
                    if (((System.Windows.Forms.ComboBox)ctrl).Text == string.Empty) //... and it is empty ...
                        isComplete = false; //... then user has left comboBox 
                if (ctrl is System.Windows.Forms.PictureBox)
                    if (((System.Windows.Forms.PictureBox)ctrl).Image == null)
                        isComplete = false;
            }

            return isComplete;
        }

        private byte[] manipulateImage(byte[] img)
        {
            if (img == null)
            {
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
            }
            
            return img;
        }

        private void showDataGridView()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Users", connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            usersDataGridView.AutoGenerateColumns = false;
            usersDataGridView.DataSource = dataTable;

            connection.Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //browse for pictures
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog.FileName.ToString();
                borrowerPictureBox.ImageLocation = imgLoc;
            }
        }

        private Image toImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            Image img;
            using (MemoryStream stream = new MemoryStream(data))
            {
                using (Image temp = Image.FromStream(stream))
                {
                    img = new Bitmap(temp);
                }
            }
            return img;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sqlQuery = "SELECT * FROM Users WHERE borrower_id LIKE '" + searchTextBox.Text.Trim() + "%' OR borrower_id LIKE '%" + searchTextBox.Text.Trim() + "%'";
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);

            usersDataGridView.AutoGenerateColumns = false;
            usersDataGridView.DataSource = dataTable;

            connection.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string streetAddress = stAddressTextBox.Text;
            string city = cityTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string contactMethod = contactMethodComboBox.Text;
            byte[] img = null;

            if (!isUserInputComplete(this.Controls))
            {
                MessageBox.Show("Please fill all", "Reminder", MessageBoxButtons.OK);
            } else if (isUserInputComplete(this.Controls)) //upload all entries to database
            {
                //manipulate image
                img = manipulateImage(img);

                //set up connection
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //t-sql commands
                string queryString = "INSERT INTO Users VALUES(@first_name, @last_name, @street_address, @city, @phone, @email, @contact_method, @borrower_image);";
                SqlCommand command = new SqlCommand(queryString, connection);

                //adding parameters
                #region
                command.Parameters.AddWithValue("@first_name", firstName);
                command.Parameters.AddWithValue("@last_name", lastName);
                command.Parameters.AddWithValue("@street_address", streetAddress);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contact_method", contactMethod);
                command.Parameters.AddWithValue("@borrower_image", img);
                #endregion

                command.ExecuteNonQuery();
                connection.Close();
                showDataGridView();

                MessageBox.Show("User has been registered successfully", "Registered", MessageBoxButtons.OK);
                clearUserInput(this.Controls);
            }

        }

        private void usersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            //disables addButton and enables updateButton
            addButton.Enabled = false;
            updateButton.Enabled = true;

            if (usersDataGridView.CurrentRow.Index != -1)
            {
                //set up connection
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //opens image
                string queryString = "SELECT borrower_image FROM Users WHERE borrower_id = @borrower_id";
                SqlCommand command = new SqlCommand(queryString, connection);
                string borrower_id = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
                command.Parameters.AddWithValue("@borrower_id", borrower_id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    byte[] blob = (byte[])reader["borrower_image"];
                    borrowerPictureBox.Image = toImage(blob);
                }
                reader.Close();
                command.ExecuteNonQuery();
                connection.Close();

                //fill up textboxes with data from gridview
                firstNameTextBox.Text = usersDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNameTextBox.Text = usersDataGridView.CurrentRow.Cells[2].Value.ToString();
                stAddressTextBox.Text = usersDataGridView.CurrentRow.Cells[3].Value.ToString();
                cityTextBox.Text = usersDataGridView.CurrentRow.Cells[4].Value.ToString();
                phoneTextBox.Text = usersDataGridView.CurrentRow.Cells[5].Value.ToString();
                emailTextBox.Text = usersDataGridView.CurrentRow.Cells[6].Value.ToString();
                contactMethodComboBox.Text = usersDataGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            //variables
            string borrower_id = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string streetAddress = stAddressTextBox.Text;
            string city = cityTextBox.Text;
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string contactMethod = contactMethodComboBox.Text;
            byte[] img = (byte[])usersDataGridView.CurrentRow.Cells[8].Value;

            if (!isUserInputComplete(this.Controls))
            {
                MessageBox.Show("Please fill all", "Reminder", MessageBoxButtons.OK);
            } else if (isUserInputComplete(this.Controls)) //upload all entries to database
            {
                //manipulate image
                img = manipulateImage(img);

                //set up connection
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //t-sql commands
                string queryString = "UPDATE Users SET first_name = @first_name, last_name = @last_name, street_address = @street_address, city = @city, phone = @phone, email = @email, contact_method = @contact_method, borrower_image = @borrower_image WHERE borrower_id = @borrower_id;";
                SqlCommand command = new SqlCommand(queryString, connection);

                //adding parameters
                #region
                command.Parameters.AddWithValue("@borrower_id", borrower_id);
                command.Parameters.AddWithValue("@first_name", firstName);
                command.Parameters.AddWithValue("@last_name", lastName);
                command.Parameters.AddWithValue("@street_address", streetAddress);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@contact_method", contactMethod);
                command.Parameters.AddWithValue("@borrower_image", img);
                #endregion

                command.ExecuteNonQuery();
                connection.Close();
                showDataGridView();

                MessageBox.Show("User has been updated successfully", "Updated", MessageBoxButtons.OK);

            }

            //disables itself (updateButton) and enables addButton
            addButton.Enabled = true;
            updateButton.Enabled = false;

            clearUserInput(this.Controls);
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //set up connection
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //t-sql commands
            string queryString = "DELETE FROM Users WHERE borrower_id = @borrower_id;";
            SqlCommand command = new SqlCommand(queryString, connection);

            //adding parameters
            string borrower_id = usersDataGridView.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.AddWithValue("@borrower_id", borrower_id);

            MessageBox.Show("User record has been deleted", "Updated", MessageBoxButtons.OK);

            command.ExecuteNonQuery();
            connection.Close();
            showDataGridView();
        }
    }
}
