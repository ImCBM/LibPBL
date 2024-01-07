using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LibPBL
{
    public partial class TeacherSignUp : Form
    {
        public TeacherSignUp()
        {
            InitializeComponent();
        }

        private void btnSignEmpAccount_Click(object sender, EventArgs e)
        {
            string sFname = txtSignFname.Text;
            string sLname = txtSignLname.Text;
            string sEmpID = txtSignID.Text;
            string sDept = cbxLevDept.Text;
            string sPassword = txtSignPass.Text;

            

            TeacherDatabase.SaveTeacherData(sEmpID, sFname, sLname, sDept, sPassword);
        }


    }
}
