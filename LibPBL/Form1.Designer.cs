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
            pnlTopLog.Size = new Size(384, 44);
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
            pnlLogin.ResumeLayout(false);
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
        private Panel pnlTopLog;
        private PictureBox picbxLoginBG;
        private Panel panel3;
    }
}
