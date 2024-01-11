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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Inside your form where you want to use this method
            BookDatabase.LoadBooksToFlowLayoutPanel(flowLayoutPanel1);
            stopwatch.Stop();
            TimeSpan processTime = stopwatch.Elapsed;

            // Create a timer with an interval of 1000 milliseconds (1 second)
            memoryUsageTimer = new System.Windows.Forms.Timer();
            memoryUsageTimer.Interval = 1000;
            memoryUsageTimer.Tick += MemoryUsageTimer_Tick;

            // Start the timer
            memoryUsageTimer.Start();
            
            lblProcessTIme.Text = "Data Retrieved in " + processTime.Milliseconds + " milliseconds.";
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
        





        private void lblProcessTIme_Click(object sender, EventArgs e)
        {

        }

        

        private void txtSearchBar_TextChanged(object sender, EventArgs e) 
        {
            BookDatabase bookDatabase = new BookDatabase();
            // BookDatabase.SearchBooksToFlowLayoutPanel(flowLayoutPanel1, txtSearchBar.Text);
            bookDatabase.SearchBooksToFlowLayoutPanel(flowLayoutPanel1, txtSearchBar.Text);
        }
    }
}
