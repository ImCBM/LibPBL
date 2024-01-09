using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace LibPBL
{
    public partial class ViewBook : Form
    {
        private System.Windows.Forms.Timer memoryUsageTimer;
        public ViewBook()
        {
            InitializeComponent();

            LoadBooksToFlowLayoutPanel();

            // Create a timer with an interval of 1000 milliseconds (1 second)
            memoryUsageTimer = new System.Windows.Forms.Timer();
            memoryUsageTimer.Interval = 1000;
            memoryUsageTimer.Tick += MemoryUsageTimer_Tick;

            // Start the timer
            memoryUsageTimer.Start();
        }
        private void MemoryUsageTimer_Tick(object sender, EventArgs e)
        {
            // Method to run every second
            CheckMemoryUsage();
            
        }
        private void CheckMemoryUsage()
        {
            // Get the current process
            Process currentProcess = Process.GetCurrentProcess();

            // Get the working set memory usage
            long memoryUsage = currentProcess.WorkingSet64; // in bytes

            // Convert bytes to megabytes for a more human-readable result
            double memoryUsageInMB = memoryUsage / (1024.0 * 1024.0);

            // Output the memory usage
            lblMemUsage.Text = "Current Memory Usage: " + Math.Round(memoryUsageInMB) + "MB";
        }
        private void LoadBooksToFlowLayoutPanel()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=PBL.db;Version=3;"))
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
                                Size = new Size(864, 277)
                            };

                            PictureBox picBox = new PictureBox
                            {
                                Name = $"picBookInHolder{bookID}",
                                Size = new Size(186, 247),
                                Location = new Point(9, 15),
                                SizeMode = PictureBoxSizeMode.Zoom
                            };
                            // Assuming bookImgPath contains the URL like "file:///C:/Users/Sai/Downloads/Material/Books/The Great Gatsby.jpg"
                            Uri uri = new Uri(bookImgPath);
                            string localFilePath = uri.LocalPath;

                            // Now you can use the localFilePath with Image.FromFile
                            picBox.Image = Image.FromFile(localFilePath);

                            Label labelTitle = new Label
                            {
                                Name = $"lblTitleInHolder{bookID}",
                                Text = bookTitle,
                                Location = new Point(240, 15),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 14f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelAuthor = new Label
                            {
                                Name = $"lblAuthorInHolder{bookID}",
                                Text = $"Author: {bookAuthor}",
                                Location = new Point(282, 62),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 14f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelCategory = new Label
                            {
                                Name = $"lblCategoryInHolder{bookID}",
                                Text = $"Category: {bookCategory}",
                                Location = new Point(201, 108),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelISBN = new Label
                            {
                                Name = $"lblISBNInHolder{bookID}",
                                Text = $"ISBN: {bookISBN}",
                                Location = new Point(455, 108),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelPublisher = new Label
                            {
                                Name = $"lblPublisherInHolder{bookID}",
                                Text = $"Publisher: {bookPublisher}",
                                Location = new Point(201, 161),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelCopyright = new Label
                            {
                                Name = $"lblCopyrightInHolder{bookID}",
                                Text = $"Copyright: {bookCopyright}",
                                Location = new Point(455, 161),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            Label labelStatus = new Label
                            {
                                Name = $"lblStatusInHolder{bookID}",
                                Text = $"Status: {bookStatus}",
                                Location = new Point(282, 219),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Black", 10f, FontStyle.Bold),
                                AutoSize = true
                            };

                            // Add controls to panel
                            panel.Controls.Add(picBox);
                            panel.Controls.Add(labelTitle);
                            panel.Controls.Add(labelAuthor);
                            panel.Controls.Add(labelCategory);
                            panel.Controls.Add(labelISBN);
                            panel.Controls.Add(labelPublisher);
                            panel.Controls.Add(labelCopyright);
                            panel.Controls.Add(labelStatus);

                            // Add panel to flowLayoutPanel
                            flowLayoutPanel1.Controls.Add(panel);
                            stopwatch.Stop();
                            TimeSpan processTime = stopwatch.Elapsed;
                            lblProcessTIme.Text = "Data Retrieved in " + processTime.Milliseconds + " milliseconds.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProcessTIme_Click(object sender, EventArgs e)
        {

        }
    }
}
