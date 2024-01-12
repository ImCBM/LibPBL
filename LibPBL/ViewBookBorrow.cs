using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPBL
{
    public partial class ViewBookBorrow : Form
    {
        public string UserID;
        public bool isLoginStud;
        public int selectedBookID;
        private bool isStudent;
        public ViewBookBorrow(int BookIDtoGet)
        {
            InitializeComponent();
            UserID = MainLibrary.instance.LogInID;
            isLoginStud = MainLibrary.instance.isLogInTypeStud;
            // Set the DateTimePicker to allow selecting today and two days beyond
            this.selectedBookID = BookIDtoGet;
            dateTimePickerBorrow.MinDate = DateTime.Today;
            dateTimePickerBorrow.MaxDate = DateTime.Today.AddDays(2);

        }


        private void ViewBookBorrow_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            
            // Validate and handle the borrowing logic
            DateTime selectedDate = dateTimePickerBorrow.Value;
            //BookDatabase.BorrowBook(UserID, selectedDate);
            if (selectedDate >= DateTime.Today)
            {
                // Call a method in BookDatabase to handle the book borrowing
                bool success = BookDatabase.BorrowBook(selectedBookID, selectedDate);

                if (success)
                {
                    MessageBox.Show("Book borrowed successfully." + selectedBookID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to borrow the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid date selection. Please choose today or a future date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
