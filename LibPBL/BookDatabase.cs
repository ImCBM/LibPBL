using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LibPBL
{
    internal class BookDatabase
    {



        
        //Loader of Books at the start of ViewBook.cs
        public static void LoadBooksToFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel)
        {


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Books;", connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Fetch data from the database
                            int bookID = Convert.ToInt32(reader["BookID"]);
                            string bookImgPath = reader["BookImg"].ToString();
                            string bookTitle = reader["BookTitle"].ToString();
                            string bookAuthor = reader["BookAuthor"].ToString();
                            string bookCategory = reader["BookCategory"].ToString();
                            string bookISBN = reader["BookISBN"].ToString();
                            string bookPublisher = reader["BookPublisher"].ToString();
                            string bookCopyright = reader["BookCopyright"].ToString();
                            string bookStatus = reader["BookStatus"].ToString();

                            // Create controls
                            Panel panel = new Panel
                            {
                                Name = $"pnlBookHolder{bookID}",
                                BackColor = Color.WhiteSmoke,
                                Size = new Size(486, 285)
                            };

                            Panel panelPicOutline = new Panel
                            {
                                Name = $"pnlPicOutline{bookID}",
                                BackColor = Color.FromArgb(175, 234, 224),
                                Size = new Size(192, 280),
                                Location = new Point(4, 2)
                            };

                            Panel panelSeparator = new Panel
                            {
                                Name = $"panelSeparator{bookID}",
                                BackColor = Color.FromArgb(17, 77, 64),
                                Size = new Size(240, 2),
                                Location = new Point(198, 65)
                            };

                            PictureBox picBox = new PictureBox
                            {
                                Name = $"picBookInHolder{bookID}",
                                Size = new Size(182, 270),
                                Location = new Point(9, 7),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };


                            Uri uri = new Uri(bookImgPath);
                            string localFilePath = uri.LocalPath;
                            picBox.Image = Image.FromFile(localFilePath);

                            Label labelTitle = new Label
                            {
                                //Name = $"lblTitleInHolder{bookID}",
                                //Text = bookTitle,
                                //TextAlign = ContentAlignment.MiddleLeft,
                                ////Size = new Size(95, 27),
                                //Size = new Size(289, 27),
                                //MaximumSize = new Size(289, 55),
                                //Location = new Point(194, 8),
                                //ForeColor = Color.Black,
                                //Font = new Font("Arial Black", 15f, FontStyle.Bold),
                                //AutoSize = true

                                Name = $"lblTitleInHolder{bookID}",
                                Text = bookTitle,
                                Parent = panel,
                                BackColor = Color.Transparent,
                                Size = new Size(289, 27),
                                MaximumSize = new Size(289, 54),
                                Location = new Point(194, 8),
                                ForeColor = Color.FromArgb(40, 174, 144),
                                Font = new Font("Arial Black", 14f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelAuthor = new Label
                            {
                                Name = $"lblAuthorInHolder{bookID}",
                                Text = $"Author: {bookAuthor}",
                                Parent = panel,
                                BackColor = Color.Transparent,
                                Location = new Point(194, 70),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 14f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelISBN = new Label
                            {
                                Name = $"lblISBNInHolder{bookID}",
                                Text = $"ISBN: {bookISBN}",
                                Parent = panel,
                                BackColor = Color.Transparent,
                                Location = new Point(195, 100),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelCategory = new Label
                            {
                                Name = $"lblCategoryInHolder{bookID}",
                                Text = $"Category: {bookCategory}",
                                Parent = panel,
                                BackColor = Color.Transparent,
                                Location = new Point(194, 120),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                AutoSize = true
                            };



                            Label labelPublisher = new Label
                            {
                                Name = $"lblPublisherInHolder{bookID}",
                                Text = $"Publisher: {bookPublisher}",
                                Location = new Point(194, 140),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelCopyright = new Label
                            {
                                Name = $"lblCopyrightInHolder{bookID}",
                                Text = $"Copyright: {bookCopyright}",
                                Location = new Point(194, 160),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelStatusText = new Label
                            {
                                Name = $"lblStatusTextInHolder{bookID}",
                                Text = $"Status: ",
                                Location = new Point(194, 200),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelStatus = new Label
                            {
                                Name = $"lblStatusInHolder{bookID}",
                                Text = $"{bookStatus}",
                                Location = new Point(250, 198),
                                ForeColor = Color.FromArgb(26, 116, 96),
                                Font = new Font("Ebrima", 13f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Panel panelBookButtonHolder = new Panel
                            {
                                Name = $"panelBookButtonHolder{bookID}",
                                BackColor = Color.WhiteSmoke,
                                Size = new Size(280, 54),
                                Location = new Point(196, 230),
                            };

                            Button btnBorrowInButtonHolder = new Button
                            {
                                Name = $"btnBorrowInButtonHolder{bookID}",
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.FromArgb(61, 93, 150),
                                ForeColor = Color.PeachPuff,
                                Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                Text = "Borrow",
                                Size = new Size(80, 30),
                                Location = new Point(50, 10),
                            };

                            Button btnReserveInButtonHolder = new Button
                            {
                                Name = $"btnReserveInButtonHolder{bookID}",
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.FromArgb(61, 93, 150),
                                ForeColor = Color.PeachPuff,
                                Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                Text = "Reserve",
                                Size = new Size(80, 30),
                                Location = new Point(140, 10),
                            };

                            // Other controls...

                            //Code Controls
                            // Event handler for Borrow button
                            btnBorrowInButtonHolder.Click += (sender, e) =>
                            {
                                int IDtoGet = bookID;
                                // Open the form for borrowing
                                using (ViewBookBorrow borrowForm = new ViewBookBorrow(IDtoGet))
                                {

                                    // Pass any necessary data to the form


                                    // Show the form
                                    borrowForm.ShowDialog();
                                }
                            };

                            // Add controls to panel

                            panel.Controls.Add(picBox);
                            panel.Controls.Add(panelPicOutline);
                            panel.Controls.Add(panelSeparator);
                            panel.Controls.Add(labelTitle);
                            panel.Controls.Add(labelAuthor);
                            panel.Controls.Add(labelCategory);
                            panel.Controls.Add(labelISBN);
                            panel.Controls.Add(labelPublisher);
                            panel.Controls.Add(labelCopyright);
                            panel.Controls.Add(labelStatus);
                            panel.Controls.Add(labelStatusText);
                            if (MainLibrary.instance.isLogInTypeAdmin != true)
                            {
                                
                                panel.Controls.Add(panelBookButtonHolder);
                            }
                            

                            if (bookCategory != "Academic")
                            {
                                if (bookStatus == "Borrowed")
                                {

                                }
                                else if (bookStatus == "Reserved")
                                {

                                }
                                else
                                {

                                    panelBookButtonHolder.Controls.Add(btnBorrowInButtonHolder);
                                    panelBookButtonHolder.Controls.Add(btnReserveInButtonHolder);
                                }
                            };

                            // Add other controls...


                            // Add panel to flowLayoutPanel
                            flowLayoutPanel.Controls.Add(panel);

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Loads the book for Searching
        public void SearchBooksToFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, string searchTerm)
        {


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT * FROM Books WHERE " +
                           "LOWER(BookTitle) LIKE @searchTerm OR " +
                           "LOWER(BookAuthor) LIKE @searchTerm OR " +
                           "LOWER(BookCategory) LIKE @searchTerm OR " +
                           "LOWER(BookPublisher) LIKE @searchTerm OR " +
                           "LOWER(BookISBN) LIKE @searchTerm OR " +
                           "LOWER(BookCopyright) LIKE @searchTerm OR " +
                           "LOWER(BookTag) LIKE @searchTerm";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm.ToLower()}%");

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing controls in the flowLayoutPanel
                            flowLayoutPanel.Controls.Clear();

                            while (reader.Read())
                            {
                                // Fetch data from the database
                                int bookID = Convert.ToInt32(reader["BookID"]);
                                string bookImgPath = reader["BookImg"].ToString();
                                string bookTitle = reader["BookTitle"].ToString();
                                string bookAuthor = reader["BookAuthor"].ToString();
                                string bookCategory = reader["BookCategory"].ToString();
                                string bookISBN = reader["BookISBN"].ToString();
                                string bookPublisher = reader["BookPublisher"].ToString();
                                string bookCopyright = reader["BookCopyright"].ToString();
                                string bookStatus = reader["BookStatus"].ToString();

                                // Create controls
                                Panel panel = new Panel
                                {
                                    Name = $"pnlBookHolder{bookID}",
                                    BackColor = Color.WhiteSmoke,
                                    Size = new Size(486, 285)
                                };

                                Panel panelPicOutline = new Panel
                                {
                                    Name = $"pnlPicOutline{bookID}",
                                    BackColor = Color.FromArgb(175, 234, 224),
                                    Size = new Size(192, 280),
                                    Location = new Point(4, 2)
                                };

                                Panel panelSeparator = new Panel
                                {
                                    Name = $"panelSeparator{bookID}",
                                    BackColor = Color.FromArgb(17, 77, 64),
                                    Size = new Size(240, 2),
                                    Location = new Point(198, 65)
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Name = $"picBookInHolder{bookID}",
                                    Size = new Size(182, 270),
                                    Location = new Point(9, 7),
                                    SizeMode = PictureBoxSizeMode.Zoom
                                };


                                Uri uri = new Uri(bookImgPath);
                                string localFilePath = uri.LocalPath;
                                picBox.Image = Image.FromFile(localFilePath);

                                Label labelTitle = new Label
                                {
                                    //Name = $"lblTitleInHolder{bookID}",
                                    //Text = bookTitle,
                                    //TextAlign = ContentAlignment.MiddleLeft,
                                    ////Size = new Size(95, 27),
                                    //Size = new Size(289, 27),
                                    //MaximumSize = new Size(289, 55),
                                    //Location = new Point(194, 8),
                                    //ForeColor = Color.Black,
                                    //Font = new Font("Arial Black", 15f, FontStyle.Bold),
                                    //AutoSize = true

                                    Name = $"lblTitleInHolder{bookID}",
                                    Text = bookTitle,
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Size = new Size(289, 27),
                                    MaximumSize = new Size(289, 54),
                                    Location = new Point(194, 8),
                                    ForeColor = Color.FromArgb(40, 174, 144),
                                    Font = new Font("Arial Black", 14f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelAuthor = new Label
                                {
                                    Name = $"lblAuthorInHolder{bookID}",
                                    Text = $"Author: {bookAuthor}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(194, 70),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 14f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelISBN = new Label
                                {
                                    Name = $"lblISBNInHolder{bookID}",
                                    Text = $"ISBN: {bookISBN}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(195, 100),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelCategory = new Label
                                {
                                    Name = $"lblCategoryInHolder{bookID}",
                                    Text = $"Category: {bookCategory}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(194, 120),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };



                                Label labelPublisher = new Label
                                {
                                    Name = $"lblPublisherInHolder{bookID}",
                                    Text = $"Publisher: {bookPublisher}",
                                    Location = new Point(194, 140),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelCopyright = new Label
                                {
                                    Name = $"lblCopyrightInHolder{bookID}",
                                    Text = $"Copyright: {bookCopyright}",
                                    Location = new Point(194, 160),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelStatusText = new Label
                                {
                                    Name = $"lblStatusTextInHolder{bookID}",
                                    Text = $"Status: ",
                                    Location = new Point(194, 200),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelStatus = new Label
                                {
                                    Name = $"lblStatusInHolder{bookID}",
                                    Text = $"{bookStatus}",
                                    Location = new Point(250, 198),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 13f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Panel panelBookButtonHolder = new Panel
                                {
                                    Name = $"panelBookButtonHolder{bookID}",
                                    BackColor = Color.WhiteSmoke,
                                    Size = new Size(280, 54),
                                    Location = new Point(196, 230),
                                };

                                Button btnBorrowInButtonHolder = new Button
                                {
                                    Name = $"btnBorrowInButtonHolder{bookID}",
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.FromArgb(61, 93, 150),
                                    ForeColor = Color.PeachPuff,
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    Text = "Borrow",
                                    Size = new Size(80, 30),
                                    Location = new Point(50, 10),
                                };

                                Button btnReserveInButtonHolder = new Button
                                {
                                    Name = $"btnReserveInButtonHolder{bookID}",
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.FromArgb(61, 93, 150),
                                    ForeColor = Color.PeachPuff,
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    Text = "Reserve",
                                    Size = new Size(80, 30),
                                    Location = new Point(140, 10),
                                };

                                // Other controls...

                                //Code Controls
                                // Event handler for Borrow button
                                btnBorrowInButtonHolder.Click += (sender, e) =>
                                {
                                    int IDtoGet = bookID;
                                    // Open the form for borrowing
                                    using (ViewBookBorrow borrowForm = new ViewBookBorrow(IDtoGet))
                                    {
                                        
                                        // Pass any necessary data to the form
                                        
                                       
                                        // Show the form
                                        borrowForm.ShowDialog();
                                    }
                                };

                                // Add controls to panel

                                panel.Controls.Add(picBox);
                                panel.Controls.Add(panelPicOutline);
                                panel.Controls.Add(panelSeparator);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelAuthor);
                                panel.Controls.Add(labelCategory);
                                panel.Controls.Add(labelISBN);
                                panel.Controls.Add(labelPublisher);
                                panel.Controls.Add(labelCopyright);
                                panel.Controls.Add(labelStatus);
                                panel.Controls.Add(labelStatusText);
                                panel.Controls.Add(panelBookButtonHolder);
                                
                                if (bookCategory != "Academic")
                                {
                                    if (bookStatus == "Borrowed")
                                    {

                                    }
                                    else if (bookStatus == "Reserved")
                                    {

                                    }
                                    else
                                    {

                                        panelBookButtonHolder.Controls.Add(btnBorrowInButtonHolder);
                                        panelBookButtonHolder.Controls.Add(btnReserveInButtonHolder);
                                    }
                                };

                                // Add other controls...

                                // Add controls to flowLayoutPanel
                                flowLayoutPanel.Controls.Add(panel);
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool BorrowBook(int bookID, DateTime borrowDate)
        {
            string userID = MainLibrary.instance.LogInID;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    // Check if the student can borrow more books
                    int currentAmountBorrowed = GetAmountBorrowed(userID);

                    if (currentAmountBorrowed < 3)
                    {
                        // Check if the book is available for borrowing (e.g., status is 'Available')
                        string checkAvailabilityQuery = $"SELECT BookStatus FROM Books WHERE BookID = {bookID}";

                        using (SQLiteCommand checkAvailabilityCommand = new SQLiteCommand(checkAvailabilityQuery, connection))
                        {
                            string currentStatus = checkAvailabilityCommand.ExecuteScalar()?.ToString();

                            if (currentStatus == "Available")
                            {
                                // Update the Books table with the borrow information
                                string borrowDateStr = borrowDate.ToString("yyyy-MM-dd");
                                string dueDate = borrowDate.AddDays(3).ToString("yyyy-MM-dd"); // Assuming a 3-day borrowing period

                                string updateQuery = $"UPDATE Books SET BookStatus = 'Borrowed', BookBorrowedBy = '{userID}', BorrowDate = '{borrowDateStr}', BorrowDueDate = '{dueDate}' WHERE BookID = {bookID}";

                                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                                {
                                    updateCommand.ExecuteNonQuery();
                                }

                                // Increase the AmountBorrowed for the student
                                IncreaseAmountBorrowed(userID);

                                return true; // Successfully borrowed
                            }
                            else
                            {
                                // Book is not available for borrowing
                                return false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have already borrowed the maximum number of books (3).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error borrowing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void IncreaseAmountBorrowed(string studentID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection((@"Data Source=C:\Material\dbs\PBL.db;Version=3;")))
                {
                    connection.Open();

                    string updateQuery = $"UPDATE Students SET AmountBorrowed = AmountBorrowed + 1 WHERE StudentID = '{studentID}'";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error increasing AmountBorrowed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void DecreaseAmountBorrowed(string studentID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    string updateQuery = $"UPDATE Students SET AmountBorrowed = AmountBorrowed - 1 WHERE StudentID = '{studentID}'";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                    {
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error decreasing AmountBorrowed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int GetAmountBorrowed(string studentID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    string selectQuery = $"SELECT AmountBorrowed FROM Students WHERE StudentID = '{studentID}'";

                    using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                    {
                        object result = selectCommand.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int amount))
                        {
                            return amount;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting AmountBorrowed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        public static void LoadBooksToFlowLayoutPanelOnlyBorrower(FlowLayoutPanel flowLayoutPanel, string userID)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT * FROM Books WHERE BookStatus = 'Borrowed' AND BookBorrowedBy = @userID;";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing controls in the flowLayoutPanel
                            flowLayoutPanel.Controls.Clear();

                            while (reader.Read())
                            {
                                // Fetch data from the database
                                int bookID = Convert.ToInt32(reader["BookID"]);
                                string bookImgPath = reader["BookImg"].ToString();
                                string bookTitle = reader["BookTitle"].ToString();
                                string bookAuthor = reader["BookAuthor"].ToString();
                                string bookCategory = reader["BookCategory"].ToString();
                                string bookISBN = reader["BookISBN"].ToString();
                                string bookPublisher = reader["BookPublisher"].ToString();
                                string bookCopyright = reader["BookCopyright"].ToString();
                                string bookStatus = reader["BookStatus"].ToString();

                                // Create controls
                                Panel panel = new Panel
                                {
                                    Name = $"pnlBookHolder{bookID}",
                                    BackColor = Color.WhiteSmoke,
                                    Size = new Size(486, 285)
                                };

                                Panel panelPicOutline = new Panel
                                {
                                    Name = $"pnlPicOutline{bookID}",
                                    BackColor = Color.FromArgb(175, 234, 224),
                                    Size = new Size(192, 280),
                                    Location = new Point(4, 2)
                                };

                                Panel panelSeparator = new Panel
                                {
                                    Name = $"panelSeparator{bookID}",
                                    BackColor = Color.FromArgb(17, 77, 64),
                                    Size = new Size(240, 2),
                                    Location = new Point(198, 65)
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Name = $"picBookInHolder{bookID}",
                                    Size = new Size(182, 270),
                                    Location = new Point(9, 7),
                                    SizeMode = PictureBoxSizeMode.Zoom
                                };


                                Uri uri = new Uri(bookImgPath);
                                string localFilePath = uri.LocalPath;
                                picBox.Image = Image.FromFile(localFilePath);

                                Label labelTitle = new Label
                                {
                                    //Name = $"lblTitleInHolder{bookID}",
                                    //Text = bookTitle,
                                    //TextAlign = ContentAlignment.MiddleLeft,
                                    ////Size = new Size(95, 27),
                                    //Size = new Size(289, 27),
                                    //MaximumSize = new Size(289, 55),
                                    //Location = new Point(194, 8),
                                    //ForeColor = Color.Black,
                                    //Font = new Font("Arial Black", 15f, FontStyle.Bold),
                                    //AutoSize = true

                                    Name = $"lblTitleInHolder{bookID}",
                                    Text = bookTitle,
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Size = new Size(289, 27),
                                    MaximumSize = new Size(289, 54),
                                    Location = new Point(194, 8),
                                    ForeColor = Color.FromArgb(40, 174, 144),
                                    Font = new Font("Arial Black", 14f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelAuthor = new Label
                                {
                                    Name = $"lblAuthorInHolder{bookID}",
                                    Text = $"Author: {bookAuthor}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(194, 70),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 14f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelISBN = new Label
                                {
                                    Name = $"lblISBNInHolder{bookID}",
                                    Text = $"ISBN: {bookISBN}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(195, 100),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelCategory = new Label
                                {
                                    Name = $"lblCategoryInHolder{bookID}",
                                    Text = $"Category: {bookCategory}",
                                    Parent = panel,
                                    BackColor = Color.Transparent,
                                    Location = new Point(194, 120),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };



                                Label labelPublisher = new Label
                                {
                                    Name = $"lblPublisherInHolder{bookID}",
                                    Text = $"Publisher: {bookPublisher}",
                                    Location = new Point(194, 140),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelCopyright = new Label
                                {
                                    Name = $"lblCopyrightInHolder{bookID}",
                                    Text = $"Copyright: {bookCopyright}",
                                    Location = new Point(194, 160),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 10f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelStatusText = new Label
                                {
                                    Name = $"lblStatusTextInHolder{bookID}",
                                    Text = $"Status: ",
                                    Location = new Point(194, 200),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Label labelStatus = new Label
                                {
                                    Name = $"lblStatusInHolder{bookID}",
                                    Text = $"{bookStatus}",
                                    Location = new Point(250, 198),
                                    ForeColor = Color.FromArgb(26, 116, 96),
                                    Font = new Font("Ebrima", 13f, FontStyle.Bold),
                                    AutoSize = true
                                };

                                Panel panelBookButtonHolder = new Panel
                                {
                                    Name = $"panelBookButtonHolder{bookID}",
                                    BackColor = Color.WhiteSmoke,
                                    Size = new Size(280, 54),
                                    Location = new Point(196, 230),
                                };

                                Button btnBorrowInButtonHolder = new Button
                                {
                                    Name = $"btnBorrowInButtonHolder{bookID}",
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.FromArgb(61, 93, 150),
                                    ForeColor = Color.PeachPuff,
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    Text = "Borrow",
                                    Size = new Size(80, 30),
                                    Location = new Point(50, 10),
                                };

                                Button btnReserveInButtonHolder = new Button
                                {
                                    Name = $"btnReserveInButtonHolder{bookID}",
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.FromArgb(61, 93, 150),
                                    ForeColor = Color.PeachPuff,
                                    Font = new Font("Ebrima", 12f, FontStyle.Bold),
                                    Text = "Reserve",
                                    Size = new Size(80, 30),
                                    Location = new Point(140, 10),
                                };

                                // Add controls to panel
                                panel.Controls.Add(picBox);
                                panel.Controls.Add(panelPicOutline);
                                panel.Controls.Add(panelSeparator);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelAuthor);
                                panel.Controls.Add(labelCategory);
                                panel.Controls.Add(labelISBN);
                                panel.Controls.Add(labelPublisher);
                                panel.Controls.Add(labelCopyright);
                                panel.Controls.Add(labelStatus);
                                panel.Controls.Add(labelStatusText);
                                

                                // ... (Your existing code to add other controls)

                                // Add panel to flowLayoutPanel
                                flowLayoutPanel.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
