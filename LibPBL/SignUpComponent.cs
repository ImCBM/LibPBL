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
    public partial class SignUpComponent : Form
    {
        public SignUpComponent()
        {
            InitializeComponent();
        }

        private Form currentSignFormStudEmp;
        private void OpenChildSignForm(Form signformStudEmp)
        {
            if (currentSignFormStudEmp != null)
            {
                currentSignFormStudEmp.Close();
            }
            signformStudEmp.FormBorderStyle = FormBorderStyle.None;
            signformStudEmp.TopLevel = false;
            signformStudEmp.Dock = DockStyle.Fill;
            pnlStudEmp.Controls.Add(signformStudEmp);
            signformStudEmp.BringToFront();
            signformStudEmp.Show();
        }

        private void radStud_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildSignForm(new StudentSignUp());
        }

        private void radEmp_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildSignForm(new TeacherSignUp());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
