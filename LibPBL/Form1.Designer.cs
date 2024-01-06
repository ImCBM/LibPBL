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
            pnlLogin = new Panel();
            radEmp = new RadioButton();
            radStud = new RadioButton();
            lblLoginAs = new Label();
            btnLogin = new Button();
            txtSignPass = new TextBox();
            lblLoginPass = new Label();
            txtSignID = new TextBox();
            lblLoginID = new Label();
            panel3 = new Panel();
            pnlTopLog = new Panel();
            picbxLoginBG = new PictureBox();
            panel1 = new Panel();
            pnlSignUp = new Panel();
            panel2 = new Panel();
            lblToSign = new Label();
            btnToSign = new FontAwesome.Sharp.IconButton();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxLoginBG).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(radEmp);
            pnlLogin.Controls.Add(radStud);
            pnlLogin.Controls.Add(lblLoginAs);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtSignPass);
            pnlLogin.Controls.Add(lblLoginPass);
            pnlLogin.Controls.Add(txtSignID);
            pnlLogin.Controls.Add(lblLoginID);
            pnlLogin.Controls.Add(panel3);
            pnlLogin.Controls.Add(pnlTopLog);
            pnlLogin.Controls.Add(picbxLoginBG);
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(944, 681);
            pnlLogin.TabIndex = 0;
            // 
            // radEmp
            // 
            radEmp.AutoSize = true;
            radEmp.BackColor = Color.Transparent;
            radEmp.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radEmp.ForeColor = Color.Gainsboro;
            radEmp.Location = new Point(181, 400);
            radEmp.Name = "radEmp";
            radEmp.Size = new Size(116, 31);
            radEmp.TabIndex = 31;
            radEmp.TabStop = true;
            radEmp.Text = "Teacher";
            radEmp.UseVisualStyleBackColor = false;
            radEmp.CheckedChanged += radEmp_CheckedChanged;
            // 
            // radStud
            // 
            radStud.AutoSize = true;
            radStud.BackColor = Color.Transparent;
            radStud.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radStud.ForeColor = Color.Gainsboro;
            radStud.Location = new Point(64, 400);
            radStud.Name = "radStud";
            radStud.Size = new Size(112, 31);
            radStud.TabIndex = 30;
            radStud.TabStop = true;
            radStud.Text = "Student";
            radStud.UseVisualStyleBackColor = false;
            radStud.CheckedChanged += radStud_CheckedChanged;
            // 
            // lblLoginAs
            // 
            lblLoginAs.AutoSize = true;
            lblLoginAs.BackColor = Color.Transparent;
            lblLoginAs.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginAs.ForeColor = Color.WhiteSmoke;
            lblLoginAs.Location = new Point(101, 356);
            lblLoginAs.Name = "lblLoginAs";
            lblLoginAs.Size = new Size(151, 41);
            lblLoginAs.TabIndex = 29;
            lblLoginAs.Text = "Login as";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 53, 107);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(255, 255, 192);
            btnLogin.Location = new Point(118, 450);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 40);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // txtSignPass
            // 
            txtSignPass.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignPass.Location = new Point(27, 304);
            txtSignPass.Name = "txtSignPass";
            txtSignPass.Size = new Size(299, 32);
            txtSignPass.TabIndex = 27;
            // 
            // lblLoginPass
            // 
            lblLoginPass.AutoSize = true;
            lblLoginPass.BackColor = Color.Transparent;
            lblLoginPass.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginPass.ForeColor = Color.WhiteSmoke;
            lblLoginPass.Location = new Point(80, 271);
            lblLoginPass.Name = "lblLoginPass";
            lblLoginPass.Size = new Size(193, 30);
            lblLoginPass.TabIndex = 26;
            lblLoginPass.Text = "Enter Password";
            // 
            // txtSignID
            // 
            txtSignID.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignID.Location = new Point(27, 227);
            txtSignID.Name = "txtSignID";
            txtSignID.Size = new Size(299, 32);
            txtSignID.TabIndex = 25;
            // 
            // lblLoginID
            // 
            lblLoginID.AutoSize = true;
            lblLoginID.BackColor = Color.Transparent;
            lblLoginID.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginID.ForeColor = Color.WhiteSmoke;
            lblLoginID.Location = new Point(130, 194);
            lblLoginID.Name = "lblLoginID";
            lblLoginID.Size = new Size(105, 30);
            lblLoginID.TabIndex = 24;
            lblLoginID.Text = "Enter ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 40, 68);
            panel3.Location = new Point(383, -7);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 720);
            panel3.TabIndex = 0;
            // 
            // pnlTopLog
            // 
            pnlTopLog.Location = new Point(0, 93);
            pnlTopLog.Name = "pnlTopLog";
            pnlTopLog.Size = new Size(384, 25);
            pnlTopLog.TabIndex = 3;
            // 
            // picbxLoginBG
            // 
            picbxLoginBG.Image = Properties.Resources.NatLib1;
            picbxLoginBG.Location = new Point(0, 0);
            picbxLoginBG.Name = "picbxLoginBG";
            picbxLoginBG.Size = new Size(384, 553);
            picbxLoginBG.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxLoginBG.TabIndex = 2;
            picbxLoginBG.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 549);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 132);
            panel1.TabIndex = 1;
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = SystemColors.ActiveCaption;
            pnlSignUp.Location = new Point(390, 0);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(554, 681);
            pnlSignUp.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 33, 103);
            panel2.Controls.Add(lblToSign);
            panel2.Controls.Add(btnToSign);
            panel2.Location = new Point(0, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 132);
            panel2.TabIndex = 2;
            // 
            // lblToSign
            // 
            lblToSign.AutoSize = true;
            lblToSign.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToSign.ForeColor = Color.FromArgb(255, 236, 214);
            lblToSign.Location = new Point(72, 29);
            lblToSign.Name = "lblToSign";
            lblToSign.Size = new Size(228, 23);
            lblToSign.TabIndex = 1;
            lblToSign.Text = "Don't have an account?";
            lblToSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnToSign
            // 
            btnToSign.BackColor = Color.FromArgb(76, 185, 231);
            btnToSign.FlatAppearance.BorderSize = 0;
            btnToSign.FlatStyle = FlatStyle.Flat;
            btnToSign.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            btnToSign.ForeColor = Color.White;
            btnToSign.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnToSign.IconColor = Color.MidnightBlue;
            btnToSign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnToSign.IconSize = 40;
            btnToSign.ImageAlign = ContentAlignment.MiddleRight;
            btnToSign.Location = new Point(72, 55);
            btnToSign.Name = "btnToSign";
            btnToSign.Size = new Size(225, 37);
            btnToSign.TabIndex = 0;
            btnToSign.Text = "Create Account    ";
            btnToSign.TextAlign = ContentAlignment.MiddleLeft;
            btnToSign.UseVisualStyleBackColor = false;
            btnToSign.Click += btnToSign_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 681);
            Controls.Add(panel2);
            Controls.Add(pnlSignUp);
            Controls.Add(pnlLogin);
            ForeColor = Color.Coral;
            MaximumSize = new Size(960, 720);
            Name = "formLogin";
            Text = "Login";
            Load += formLogin_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxLoginBG).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlSignUp;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnToSign;
        private Label lblToSign;
        private PictureBox picbxLoginBG;
        private Panel panel3;
        private TextBox txtSignPass;
        private Label lblLoginPass;
        private TextBox txtSignID;
        private Label lblLoginID;
        private Button btnLogin;
        private RadioButton radEmp;
        private RadioButton radStud;
        private Label lblLoginAs;
        private Panel pnlTopLog;
    }
}
