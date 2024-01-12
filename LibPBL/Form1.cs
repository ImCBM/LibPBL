using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LibPBL
{
    public partial class formLogin : Form
    {
        





        public formLogin()
        {
            InitializeComponent();
            

        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.Width = 380;
            picLogoPP.Parent = picbxLoginBG;
            picLogoPP.BackColor = Color.Transparent;

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
            radAdmin.Parent = picbxLoginBG;
            radAdmin.BackColor = Color.Transparent;

            //
            //string LogInID = "FirstN";
            //string LogInPass = "LastN";
            //OpenMainLibraryForm(LogInID, LogInPass);
            //

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





        // Open Main Library
        private void OpenMainLibraryForm(string passingID, string passingPass, bool passingLogInType)
        {


            // Open the new form (MainLibrary) and pass necessary variables
            MainLibrary mainLibraryForm = new MainLibrary(passingID, passingPass, passingLogInType);
            mainLibraryForm.Show();
            mainLibraryForm.TopLevel = true;

            // Close the current form

        }

        // Open Main Library
        private void OpenLibrarianForm(string passingID, string passingPass, bool passingLogInType)
        {


            // Open the new form (MainLibrary) and pass necessary variables
            Librarian Librarian = new Librarian(passingID, passingPass, passingLogInType);
            Librarian.Show();
            Librarian.TopLevel = true;

            // Close the current form

        }






        // CONTROLS
        private void btnToSign_Click(object sender, EventArgs e)
        {
            //this.Width = 960;
            this.MaximumSize = new Size(960, 720);
            this.MinimumSize = new Size(960, 720);
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







        //LOG IN
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

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {
            radStud.ForeColor = Color.Gainsboro;
            radEmp.ForeColor = Color.Silver;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radStud.Checked == true)
            {
                // Get the entered studentID and password
                string enteredID = txtLogID.Text;
                string enteredPassword = txtLogPass.Text;

                // Check credentials using LoginComponents
                if (StudEmpLoginComponent.CheckStudCredentials(enteredID, enteredPassword))
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // You can navigate to the next form or perform other actions here


                    string LogInID = txtLogID.Text;
                    string LogInPass = txtLogPass.Text;
                    bool isLogInStud = true;

                    OpenMainLibraryForm(LogInID, LogInPass, isLogInStud);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show($"Invalid credentials. Please check entered Student ID or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (radEmp.Checked == true)
            {
                // Get the entered studentID and password
                string enteredID = txtLogID.Text;
                string enteredPassword = txtLogPass.Text;

                // Check credentials using LoginComponents
                if (StudEmpLoginComponent.CheckEmpCredentials(enteredID, enteredPassword))
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // You can navigate to the next form or perform other actions here

                    string LogInID = txtLogID.Text;
                    string LogInPass = txtLogPass.Text;
                    bool isLogInStud = false;


                    OpenMainLibraryForm(LogInID, LogInPass, isLogInStud);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show($"Invalid credentials. Please check entered Employee ID or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (radAdmin.Checked == true)
            {
                string enteredID = txtLogID.Text;
                string enteredPassword = txtLogPass.Text;
                if (enteredID == "admin" || enteredPassword == "admin123")
                {
                    string LogInID = txtLogID.Text;
                    string LogInPass = txtLogPass.Text;
                    bool isLogInStud = false;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenLibrarianForm(LogInID, LogInPass, isLogInStud);
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show($"Invalid credentials. Please check entered ID or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSign_Click(object sender, EventArgs e)
        {
            //this.Width = 380;
            this.MaximumSize = new Size(380, 720);
            this.MinimumSize = new Size(380, 720);
            do
            {
                this.Width -= 20;
            }
            while (this.Width != 380);

        }


    }
}
