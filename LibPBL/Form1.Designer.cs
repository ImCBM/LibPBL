namespace LibPBL
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            pnlSignUp = new Panel();
            btnRemoveSign = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblToSign = new Label();
            btnToSign = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            picbxLoginBG = new PictureBox();
            panel3 = new Panel();
            lblLoginID = new Label();
            txtLogID = new TextBox();
            lblLoginPass = new Label();
            txtLogPass = new TextBox();
            btnLogin = new Button();
            lblLoginAs = new Label();
            radStud = new RadioButton();
            radEmp = new RadioButton();
            pnlLogin = new Panel();
            radAdmin = new RadioButton();
            picLogoPP = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxLoginBG).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoPP).BeginInit();
            SuspendLayout();
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = SystemColors.ActiveCaption;
            pnlSignUp.Location = new Point(449, 41);
            pnlSignUp.Margin = new Padding(3, 4, 3, 4);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(630, 867);
            pnlSignUp.TabIndex = 1;
            pnlSignUp.Paint += pnlSignUp_Paint;
            // 
            // btnRemoveSign
            // 
            btnRemoveSign.FlatAppearance.BorderColor = Color.FromArgb(15, 33, 103);
            btnRemoveSign.FlatStyle = FlatStyle.Flat;
            btnRemoveSign.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnRemoveSign.IconColor = Color.Black;
            btnRemoveSign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoveSign.IconSize = 28;
            btnRemoveSign.Location = new Point(1003, 3);
            btnRemoveSign.Margin = new Padding(3, 4, 3, 4);
            btnRemoveSign.Name = "btnRemoveSign";
            btnRemoveSign.Size = new Size(62, 37);
            btnRemoveSign.TabIndex = 0;
            btnRemoveSign.UseVisualStyleBackColor = true;
            btnRemoveSign.Click += btnRemoveSign_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 33, 103);
            panel2.Controls.Add(lblToSign);
            panel2.Controls.Add(btnToSign);
            panel2.Location = new Point(0, 732);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 176);
            panel2.TabIndex = 2;
            // 
            // lblToSign
            // 
            lblToSign.AutoSize = true;
            lblToSign.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToSign.ForeColor = Color.FromArgb(255, 236, 214);
            lblToSign.Location = new Point(77, 40);
            lblToSign.Name = "lblToSign";
            lblToSign.Size = new Size(240, 29);
            lblToSign.TabIndex = 1;
            lblToSign.Text = "Don't have an account?";
            lblToSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnToSign
            // 
            btnToSign.BackColor = Color.FromArgb(76, 185, 231);
            btnToSign.FlatAppearance.BorderSize = 0;
            btnToSign.FlatStyle = FlatStyle.Flat;
            btnToSign.Font = new Font("Franklin Gothic Book", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToSign.ForeColor = Color.White;
            btnToSign.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnToSign.IconColor = Color.MidnightBlue;
            btnToSign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnToSign.IconSize = 40;
            btnToSign.ImageAlign = ContentAlignment.MiddleRight;
            btnToSign.Location = new Point(69, 73);
            btnToSign.Margin = new Padding(3, 4, 3, 4);
            btnToSign.Name = "btnToSign";
            btnToSign.Size = new Size(257, 49);
            btnToSign.TabIndex = 0;
            btnToSign.Text = "Create Account    ";
            btnToSign.UseVisualStyleBackColor = false;
            btnToSign.Click += btnToSign_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 732);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 176);
            panel1.TabIndex = 1;
            // 
            // picbxLoginBG
            // 
            picbxLoginBG.Image = Properties.Resources.NatLib1;
            picbxLoginBG.Location = new Point(12, 13);
            picbxLoginBG.Margin = new Padding(3, 4, 3, 4);
            picbxLoginBG.Name = "picbxLoginBG";
            picbxLoginBG.Size = new Size(420, 711);
            picbxLoginBG.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxLoginBG.TabIndex = 2;
            picbxLoginBG.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 40, 68);
            panel3.Location = new Point(438, -9);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 960);
            panel3.TabIndex = 0;
            // 
            // lblLoginID
            // 
            lblLoginID.AutoSize = true;
            lblLoginID.BackColor = Color.Transparent;
            lblLoginID.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            lblLoginID.ForeColor = Color.White;
            lblLoginID.Location = new Point(155, 232);
            lblLoginID.Name = "lblLoginID";
            lblLoginID.Size = new Size(97, 36);
            lblLoginID.TabIndex = 24;
            lblLoginID.Text = "Enter ID";
            // 
            // txtLogID
            // 
            txtLogID.BackColor = SystemColors.InactiveCaption;
            txtLogID.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            txtLogID.Location = new Point(31, 285);
            txtLogID.Margin = new Padding(3, 4, 3, 4);
            txtLogID.Name = "txtLogID";
            txtLogID.Size = new Size(342, 38);
            txtLogID.TabIndex = 25;
            // 
            // lblLoginPass
            // 
            lblLoginPass.AutoSize = true;
            lblLoginPass.BackColor = Color.Transparent;
            lblLoginPass.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            lblLoginPass.ForeColor = Color.White;
            lblLoginPass.Location = new Point(116, 335);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(173, 36);
            lblLoginPass.TabIndex = 26;
            lblLoginPass.Text = "Enter Password";
            // 
            // txtLogPass
            // 
            txtLogPass.BackColor = SystemColors.InactiveCaption;
            txtLogPass.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            txtLogPass.Location = new Point(32, 387);
            txtLogPass.Margin = new Padding(3, 4, 3, 4);
            txtLogPass.Name = "txtLogPass";
            txtLogPass.Size = new Size(341, 38);
            txtLogPass.TabIndex = 27;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 53, 107);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Franklin Gothic Book", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(135, 656);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 53);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // lblLoginAs
            // 
            lblLoginAs.AutoSize = true;
            lblLoginAs.BackColor = Color.Transparent;
            lblLoginAs.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            lblLoginAs.ForeColor = Color.White;
            lblLoginAs.Location = new Point(153, 457);
            lblLoginAs.Name = "lblLoginAs";
            lblLoginAs.Size = new Size(99, 36);
            lblLoginAs.TabIndex = 29;
            lblLoginAs.Text = "Login as";
            // 
            // radStud
            // 
            radStud.AutoSize = true;
            radStud.BackColor = Color.Transparent;
            radStud.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            radStud.ForeColor = Color.Gainsboro;
            radStud.Location = new Point(81, 515);
            radStud.Margin = new Padding(3, 4, 3, 4);
            radStud.Name = "radStud";
            radStud.Size = new Size(117, 40);
            radStud.TabIndex = 30;
            radStud.TabStop = true;
            radStud.Text = "Student";
            radStud.UseVisualStyleBackColor = false;
            radStud.CheckedChanged += radStud_CheckedChanged;
            // 
            // radEmp
            // 
            radEmp.AutoSize = true;
            radEmp.BackColor = Color.Transparent;
            radEmp.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            radEmp.ForeColor = Color.Gainsboro;
            radEmp.Location = new Point(222, 515);
            radEmp.Margin = new Padding(3, 4, 3, 4);
            radEmp.Name = "radEmp";
            radEmp.Size = new Size(116, 40);
            radEmp.TabIndex = 31;
            radEmp.TabStop = true;
            radEmp.Text = "Teacher";
            radEmp.UseVisualStyleBackColor = false;
            radEmp.CheckedChanged += radEmp_CheckedChanged;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(216, 235, 254);
            pnlLogin.Controls.Add(radAdmin);
            pnlLogin.Controls.Add(picLogoPP);
            pnlLogin.Controls.Add(btnRemoveSign);
            pnlLogin.Controls.Add(radEmp);
            pnlLogin.Controls.Add(radStud);
            pnlLogin.Controls.Add(lblLoginAs);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtLogPass);
            pnlLogin.Controls.Add(lblLoginPass);
            pnlLogin.Controls.Add(txtLogID);
            pnlLogin.Controls.Add(lblLoginID);
            pnlLogin.Controls.Add(panel3);
            pnlLogin.Controls.Add(picbxLoginBG);
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(3, 4, 3, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1077, 897);
            pnlLogin.TabIndex = 0;
            // 
            // radAdmin
            // 
            radAdmin.AutoSize = true;
            radAdmin.BackColor = Color.Transparent;
            radAdmin.Font = new Font("Franklin Gothic Medium Cond", 16.2F);
            radAdmin.ForeColor = Color.Gainsboro;
            radAdmin.Location = new Point(146, 569);
            radAdmin.Margin = new Padding(3, 4, 3, 4);
            radAdmin.Name = "radAdmin";
            radAdmin.Size = new Size(127, 40);
            radAdmin.TabIndex = 33;
            radAdmin.TabStop = true;
            radAdmin.Text = "Librarian";
            radAdmin.UseVisualStyleBackColor = false;
            // 
            // picLogoPP
            // 
            picLogoPP.Image = Properties.Resources.PAGEPAL;
            picLogoPP.Location = new Point(77, 55);
            picLogoPP.Margin = new Padding(3, 4, 3, 4);
            picLogoPP.Name = "picLogoPP";
            picLogoPP.Size = new Size(259, 163);
            picLogoPP.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoPP.TabIndex = 32;
            picLogoPP.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 897);
            Controls.Add(panel2);
            Controls.Add(pnlSignUp);
            Controls.Add(pnlLogin);
            ForeColor = Color.Coral;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1095, 944);
            Name = "formLogin";
            Text = "Login";
            Load += formLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxLoginBG).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoPP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSignUp;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnToSign;
        private Label lblToSign;
        private FontAwesome.Sharp.IconButton btnRemoveSign;
        private Panel panel1;
        private PictureBox picbxLoginBG;
        private Panel panel3;
        private Label lblLoginID;
        private TextBox txtLogID;
        private Label lblLoginPass;
        private TextBox txtLogPass;
        private Button btnLogin;
        private Label lblLoginAs;
        private RadioButton radStud;
        private RadioButton radEmp;
        private Panel pnlLogin;
        private Button button1;
        private PictureBox picLogoPP;
        private RadioButton radAdmin;
    }
}
