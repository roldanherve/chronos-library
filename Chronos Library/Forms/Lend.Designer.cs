namespace Chronos_Library.Forms
{
    partial class Lend
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
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.bookIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.brwIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lendDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateBorrowedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDueTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.lendDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.BorderRadius = 3;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.deleteButton.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(566, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(163, 41);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateButton.BorderRadius = 3;
            this.updateButton.CheckedState.Parent = this.updateButton;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.CustomImages.Parent = this.updateButton;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.updateButton.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.updateButton.HoverState.Parent = this.updateButton;
            this.updateButton.Location = new System.Drawing.Point(343, 43);
            this.updateButton.Name = "updateButton";
            this.updateButton.ShadowDecoration.Parent = this.updateButton;
            this.updateButton.Size = new System.Drawing.Size(163, 41);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.BorderRadius = 3;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.addButton.Font = new System.Drawing.Font("Source Sans Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(122, 43);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(163, 41);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.BorderRadius = 3;
            this.bookIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookIDTextBox.DefaultText = "";
            this.bookIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookIDTextBox.DisabledState.Parent = this.bookIDTextBox;
            this.bookIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.bookIDTextBox.FocusedState.Parent = this.bookIDTextBox;
            this.bookIDTextBox.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.bookIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bookIDTextBox.HoverState.Parent = this.bookIDTextBox;
            this.bookIDTextBox.Location = new System.Drawing.Point(148, 193);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.PasswordChar = '\0';
            this.bookIDTextBox.PlaceholderText = "";
            this.bookIDTextBox.SelectedText = "";
            this.bookIDTextBox.ShadowDecoration.Parent = this.bookIDTextBox;
            this.bookIDTextBox.Size = new System.Drawing.Size(232, 28);
            this.bookIDTextBox.TabIndex = 18;
            // 
            // brwIDTextBox
            // 
            this.brwIDTextBox.BorderRadius = 3;
            this.brwIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brwIDTextBox.DefaultText = "";
            this.brwIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.brwIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.brwIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brwIDTextBox.DisabledState.Parent = this.brwIDTextBox;
            this.brwIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brwIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.brwIDTextBox.FocusedState.Parent = this.brwIDTextBox;
            this.brwIDTextBox.Font = new System.Drawing.Font("Source Sans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.brwIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brwIDTextBox.HoverState.Parent = this.brwIDTextBox;
            this.brwIDTextBox.Location = new System.Drawing.Point(148, 158);
            this.brwIDTextBox.Name = "brwIDTextBox";
            this.brwIDTextBox.PasswordChar = '\0';
            this.brwIDTextBox.PlaceholderText = "";
            this.brwIDTextBox.SelectedText = "";
            this.brwIDTextBox.ShadowDecoration.Parent = this.brwIDTextBox;
            this.brwIDTextBox.Size = new System.Drawing.Size(232, 28);
            this.brwIDTextBox.TabIndex = 20;
            // 
            // lendDataGridView
            // 
            this.lendDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendDataGridView.Location = new System.Drawing.Point(408, 158);
            this.lendDataGridView.Name = "lendDataGridView";
            this.lendDataGridView.RowHeadersWidth = 51;
            this.lendDataGridView.RowTemplate.Height = 24;
            this.lendDataGridView.Size = new System.Drawing.Size(424, 342);
            this.lendDataGridView.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Returned:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(69, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Due:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Book ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date Borrowed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Borrower ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 3;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.confirmButton.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(183, 358);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(163, 30);
            this.confirmButton.TabIndex = 21;
            this.confirmButton.Text = "Confirm";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderRadius = 12;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.IconLeft = global::Chronos_Library.Properties.Resources.search;
            this.searchTextBox.Location = new System.Drawing.Point(32, 101);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(800, 28);
            this.searchTextBox.TabIndex = 5;
            // 
            // dateBorrowedTimePicker
            // 
            this.dateBorrowedTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dateBorrowedTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.dateBorrowedTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateBorrowedTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateBorrowedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBorrowedTimePicker.Location = new System.Drawing.Point(148, 228);
            this.dateBorrowedTimePicker.Name = "dateBorrowedTimePicker";
            this.dateBorrowedTimePicker.Size = new System.Drawing.Size(232, 29);
            this.dateBorrowedTimePicker.TabIndex = 22;
            // 
            // dateDueTimePicker
            // 
            this.dateDueTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dateDueTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.dateDueTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateDueTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateDueTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDueTimePicker.Location = new System.Drawing.Point(148, 264);
            this.dateDueTimePicker.Name = "dateDueTimePicker";
            this.dateDueTimePicker.Size = new System.Drawing.Size(232, 29);
            this.dateDueTimePicker.TabIndex = 22;
            // 
            // dateReturnedTimePicker
            // 
            this.dateReturnedTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.dateReturnedTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.dateReturnedTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateReturnedTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateReturnedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReturnedTimePicker.Location = new System.Drawing.Point(148, 300);
            this.dateReturnedTimePicker.Name = "dateReturnedTimePicker";
            this.dateReturnedTimePicker.Size = new System.Drawing.Size(232, 29);
            this.dateReturnedTimePicker.TabIndex = 22;
            // 
            // Lend
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.dateReturnedTimePicker);
            this.Controls.Add(this.dateDueTimePicker);
            this.Controls.Add(this.dateBorrowedTimePicker);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.brwIDTextBox);
            this.Controls.Add(this.lendDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Source Sans Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lend";
            this.Text = "Lend";
            ((System.ComponentModel.ISupportInitialize)(this.lendDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2TextBox bookIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox brwIDTextBox;
        private System.Windows.Forms.DataGridView lendDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private System.Windows.Forms.DateTimePicker dateBorrowedTimePicker;
        private System.Windows.Forms.DateTimePicker dateDueTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedTimePicker;
    }
}