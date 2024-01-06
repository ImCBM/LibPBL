using System.Reflection.Metadata;

namespace LibPBL
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.Width = 380;
            

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

        private void formLogin_Load(object sender, EventArgs e)
        {

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
    }
}
