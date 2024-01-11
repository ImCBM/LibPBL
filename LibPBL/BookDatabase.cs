using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                            // Other controls...

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
                                // Other controls...

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



    }
}
