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
    public partial class Librarian : Form
    {
        public static Librarian instance;
        public bool isLib = true;
        public Librarian(string passedID, string passedPass, bool isStudent)
        {
            InitializeComponent();
            instance = this;
        }

        private void Librarian_Load(object sender, EventArgs e)
        {

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

        private void btnViewBorrowers_Click(object sender, EventArgs e)
        {
            OpenChildMainForm(new ShowBorrowers());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            OpenChildMainForm(new Payment());
        }
    }
}
