using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPBL
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PopulateBorrowersComboBox();
        }

        public static void ReturnBook(int bookID, DateTime returnDate, decimal paymentAmount)
        {
            try
            {
                string userID = MainLibrary.instance.LogInID;

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    // Get book information
                    string getBookInfoQuery = $"SELECT BookBorrowedBy, BorrowDueDate FROM Books WHERE BookID = {bookID}";
                    using (SQLiteCommand getBookInfoCommand = new SQLiteCommand(getBookInfoQuery, connection))
                    {
                        using (SQLiteDataReader bookInfoReader = getBookInfoCommand.ExecuteReader())
                        {
                            if (bookInfoReader.Read())
                            {
                                string borrowedBy = bookInfoReader["BookBorrowedBy"].ToString();
                                DateTime borrowDueDate = Convert.ToDateTime(bookInfoReader["BorrowDueDate"]);

                                // Calculate days elapsed
                                int daysElapsed = (int)(returnDate - borrowDueDate).TotalDays;

                                // Check conditions for returning the book
                                if (daysElapsed > 0 && paymentAmount >= 0) // You can customize the conditions
                                {
                                    // Update the Books table
                                    string updateBookQuery = $"UPDATE Books SET BookStatus = 'Available', BookBorrowedBy = NULL, BorrowDate = NULL, BorrowDueDate = NULL WHERE BookID = {bookID}";
                                    using (SQLiteCommand updateBookCommand = new SQLiteCommand(updateBookQuery, connection))
                                    {
                                        updateBookCommand.ExecuteNonQuery();
                                    }

                                    // Update the Students table if the book was borrowed by a student
                                    if (!string.IsNullOrEmpty(borrowedBy))
                                    {
                                        string updateStudentQuery = $"UPDATE Students SET AmountBorrowed = AmountBorrowed - 1 WHERE StudentID = '{borrowedBy}' AND AmountBorrowed > 0";
                                        using (SQLiteCommand updateStudentCommand = new SQLiteCommand(updateStudentQuery, connection))
                                        {
                                            updateStudentCommand.ExecuteNonQuery();
                                        }
                                    }

                                    MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid return conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateBorrowedBooksComboBox(string selectedBorrower)
        {
            // Clear existing items
            comboBoxBorrowedBooks.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
            {
                connection.Open();

                // Retrieve borrowed books for the selected user
                string getBorrowedBooksQuery = $"SELECT BookID, BookTitle, BorrowDueDate FROM Books WHERE BookBorrowedBy = '{selectedBorrower}' AND BookStatus = 'Borrowed'";
                using (SQLiteCommand getBorrowedBooksCommand = new SQLiteCommand(getBorrowedBooksQuery, connection))
                {
                    using (SQLiteDataReader borrowedBooksReader = getBorrowedBooksCommand.ExecuteReader())
                    {
                        while (borrowedBooksReader.Read())
                        {
                            int bookID = Convert.ToInt32(borrowedBooksReader["BookID"]);
                            string bookTitle = borrowedBooksReader["BookTitle"].ToString();
                            DateTime borrowDueDate = Convert.ToDateTime(borrowedBooksReader["BorrowDueDate"]);

                            // Add book title to ComboBox
                            comboBoxBorrowedBooks.Items.Add(new BorrowedBookInfo { BookID = bookID, Title = bookTitle, DueDate = borrowDueDate });
                        }
                    }
                }
            }
        }

        private void PopulateBorrowersComboBox()
        {
            // Clear existing items
            comboBoxBorrowers.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
            {
                connection.Open();

                // Retrieve distinct users who have borrowed books
                string getBorrowersQuery = "SELECT DISTINCT BookBorrowedBy FROM Books WHERE BookStatus = 'Borrowed' AND BookBorrowedBy IS NOT NULL";
                using (SQLiteCommand getBorrowersCommand = new SQLiteCommand(getBorrowersQuery, connection))
                {
                    using (SQLiteDataReader borrowersReader = getBorrowersCommand.ExecuteReader())
                    {
                        while (borrowersReader.Read())
                        {
                            string borrowerID = borrowersReader["BookBorrowedBy"].ToString();

                            // Add user to ComboBox
                            comboBoxBorrowers.Items.Add(borrowerID);
                        }
                    }
                }
            }
        }


        private void comboBoxBorrowedBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Calculate payment amount and display it
            if (comboBoxBorrowedBooks.SelectedItem != null)
            {
                BorrowedBookInfo selectedBook = (BorrowedBookInfo)comboBoxBorrowedBooks.SelectedItem;
                DateTime returnDate = dateTimePickerReturnDate.Value;
                int daysElapsed = (int)(returnDate - selectedBook.DueDate).TotalDays;
                decimal paymentAmount = CalculatePaymentAmount(daysElapsed);

                // Display the payment amount
                labelPaymentAmount.Text = $"Payment Amount: ${paymentAmount}";
            }
        }

        private decimal CalculatePaymentAmount(int daysElapsed)
        {
            // You can customize the payment calculation logic
            const decimal dailyPenalty = 20; // $20 per day penalty
            return Math.Max(0, daysElapsed * dailyPenalty);
        }






        private void txtPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void ClearPaymentControls()
        {
            comboBoxBorrowedBooks.SelectedIndex = -1;
            dateTimePickerReturnDate.Value = DateTime.Today;
            txtPaymentAmount.Clear();
            labelPaymentAmount.Text = "Payment Amount: $0.00";
        }
        public class BorrowedBookInfo
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public DateTime DueDate { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }

        private void buttonPay_Click_1(object sender, EventArgs e)
        {
            if (comboBoxBorrowedBooks.SelectedItem != null)
            {
                try
                {
                    BorrowedBookInfo selectedBook = (BorrowedBookInfo)comboBoxBorrowedBooks.SelectedItem;
                    decimal paymentAmount = decimal.Parse(txtPaymentAmount.Text);

                    // Update the database and subtract the payment amount
                    ReturnBook(selectedBook.BookID, dateTimePickerReturnDate.Value, paymentAmount);

                    // Clear the ComboBox and update the display
                    comboBoxBorrowedBooks.Items.Remove(selectedBook);
                    ClearPaymentControls();

                    MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to pay for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBorrowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBorrowers.SelectedItem != null)
            {
                string selectedBorrower = comboBoxBorrowers.SelectedItem.ToString();

                // Populate the borrowed books ComboBox for the selected user
                PopulateBorrowedBooksComboBox(selectedBorrower);
            }
        }
        

    }
}
