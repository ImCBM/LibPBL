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
    public partial class ShowBorrowers : Form
    {
        public ShowBorrowers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowBorrowers_Load(object sender, EventArgs e)
        {
                LoadStudentData();
                LoadTeacherData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    string query = "SELECT StudentID, FirstName, LastName, GradeLevel, Section FROM Students";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewstudent.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherData()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Material\dbs\PBL.db;Version=3;"))
                {
                    connection.Open();

                    string query = "SELECT EmpID,EmployeeID, FirstName, LastName, Department FROM Teachers";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewteacher.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
