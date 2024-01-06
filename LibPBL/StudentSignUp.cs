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
    public partial class StudentSignUp : Form
    {
        public StudentSignUp()
        {
            InitializeComponent();
        }

        private void StudentSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignStudAccount_Click(object sender, EventArgs e)
        {
            string sFname = txtSignFname.Text;
            string sLname = txtSignLname.Text;
            string sStudentID = txtSignID.Text;
            string sGradeLevel = cbxLevDept.Text;
            string sSection = txtSection.Text;
            string sPassword = txtSignPass.Text;

            StudentDatabase.SaveStudentData(sStudentID, sFname, sLname, sGradeLevel, sSection, sPassword);
        }
    }
}
