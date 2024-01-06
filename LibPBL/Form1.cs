using System.Reflection.Metadata;
using System.Windows.Controls;

namespace LibPBL
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.Width = 380;


        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            lblLoginID.Parent = picbxLoginBG;
            lblLoginID.BackColor = Color.Transparent;

            lblLoginPass.Parent = picbxLoginBG;
            lblLoginPass.BackColor = Color.Transparent;

            lblLoginAs.Parent = picbxLoginBG;
            lblLoginAs.BackColor = Color.Transparent;

            radStud.Parent = picbxLoginBG;
            radStud.BackColor = Color.Transparent;
            radEmp.Parent = picbxLoginBG;
            radEmp.BackColor = Color.Transparent;
        }


        private Form currentSignForm;
        private void OpenChildSignForm(Form signform)
        {
            if (currentSignForm != null)
            {
                currentSignForm.Close();
            }
            signform.FormBorderStyle = FormBorderStyle.None;
            signform.TopLevel = false;
            signform.Dock = DockStyle.Fill;
            pnlSignUp.Controls.Add(signform);
            signform.BringToFront();
            signform.Show();
        }

        private void btnToSign_Click(object sender, EventArgs e)
        {
            //this.Width = 960;

            do
            {
                this.Width += 20;
            }
            while (this.Width != 960);
            OpenChildSignForm(new SignUpComponent());
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 2;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void radStud_CheckedChanged(object sender, EventArgs e)
        {
            radEmp.ForeColor = Color.Gainsboro;
            radStud.ForeColor = Color.Silver;
        }

        private void radEmp_CheckedChanged(object sender, EventArgs e)
        {
            radStud.ForeColor = Color.Gainsboro;
            radEmp.ForeColor = Color.Silver;
        }
    }
}
