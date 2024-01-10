using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LibPBL
{
    public partial class MainLibrary : Form
    {
        private string LogInID;
        private string LogInPass;
        string studentIDToRetrieve;
        bool isLogInTypeStud;

        public MainLibrary(string passedID, string passedPass, bool isStudent)
        {
            InitializeComponent();
            LogInID = passedID;
            studentIDToRetrieve = passedID;
            LogInPass = passedPass;
            isLogInTypeStud = isStudent;

        }

        private void MainLibrary_Load(object sender, EventArgs e)
        {
            //Gets the name from DB
            string fullName;
            if (isLogInTypeStud == true)
            {
                fullName = StudentDatabase.GetFullNameByStudentID(studentIDToRetrieve);
                lblUsername.Text = fullName;
            }
           else if (isLogInTypeStud == false)
            {
                fullName = TeacherDatabase.GetFullNameByEmpID(studentIDToRetrieve);
                lblUsername.Text = fullName;
            }
            


        }


        private Form currentMainView;
        private void OpenChildMainForm(Form childMain)
        {
            if (currentMainView != null)
            {
                currentMainView.Close();
            }
            childMain.FormBorderStyle = FormBorderStyle.None;
            childMain.TopLevel = false;
            childMain.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childMain);
            childMain.BringToFront();
            childMain.Show();
        }



        private void btnViewBook_Click(object sender, EventArgs e)
        {
            OpenChildMainForm(new ViewBook());
        }
    }
}
