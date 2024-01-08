using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibPBL
{
    public partial class MainLibrary : Form
    {
        private string LogInID;
        private string variable2;
        string studentIDToRetrieve;

        public MainLibrary(string var1, string var2)
        {
            InitializeComponent();
            LogInID = var1;
            studentIDToRetrieve = var1;
            variable2 = var2;
        }

        private void MainLibrary_Load(object sender, EventArgs e)
        {
            string fullName = StudentDatabase.GetFullNameByStudentID(studentIDToRetrieve);
            lblUsername.Text = fullName;
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
