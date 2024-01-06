namespace LibPBL
{
    partial class StudentSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSignID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbxLevDept = new ComboBox();
            label3 = new Label();
            txtSection = new TextBox();
            btnSignStudAccount = new Button();
            txtSignLname = new TextBox();
            label4 = new Label();
            txtSignFname = new TextBox();
            label5 = new Label();
            txtSignPass = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtSignID
            // 
            txtSignID.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignID.Location = new Point(113, 182);
            txtSignID.Name = "txtSignID";
            txtSignID.Size = new Size(299, 32);
            txtSignID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 53, 107);
            label2.Location = new Point(113, 149);
            label2.Name = "label2";
            label2.Size = new Size(201, 30);
            label2.TabIndex = 5;
            label2.Text = "Enter Student ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 53, 107);
            label1.Location = new Point(113, 217);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 7;
            label1.Text = "Enter Level";
            // 
            // cbxLevDept
            // 
            cbxLevDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLevDept.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            cbxLevDept.FormattingEnabled = true;
            cbxLevDept.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            cbxLevDept.Location = new Point(113, 250);
            cbxLevDept.Name = "cbxLevDept";
            cbxLevDept.Size = new Size(299, 32);
            cbxLevDept.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 53, 107);
            label3.Location = new Point(113, 285);
            label3.Name = "label3";
            label3.Size = new Size(168, 30);
            label3.TabIndex = 9;
            label3.Text = "Enter Section";
            // 
            // txtSection
            // 
            txtSection.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSection.Location = new Point(113, 318);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(299, 32);
            txtSection.TabIndex = 10;
            // 
            // btnSignStudAccount
            // 
            btnSignStudAccount.BackColor = Color.FromArgb(0, 53, 107);
            btnSignStudAccount.FlatAppearance.BorderSize = 0;
            btnSignStudAccount.FlatStyle = FlatStyle.Flat;
            btnSignStudAccount.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignStudAccount.ForeColor = Color.FromArgb(255, 255, 192);
            btnSignStudAccount.Location = new Point(197, 445);
            btnSignStudAccount.Name = "btnSignStudAccount";
            btnSignStudAccount.Size = new Size(117, 40);
            btnSignStudAccount.TabIndex = 11;
            btnSignStudAccount.Text = "Sign Up";
            btnSignStudAccount.UseVisualStyleBackColor = false;
            btnSignStudAccount.Click += btnSignStudAccount_Click;
            // 
            // txtSignLname
            // 
            txtSignLname.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignLname.Location = new Point(113, 114);
            txtSignLname.Name = "txtSignLname";
            txtSignLname.Size = new Size(299, 32);
            txtSignLname.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 53, 107);
            label4.Location = new Point(113, 81);
            label4.Name = "label4";
            label4.Size = new Size(205, 30);
            label4.TabIndex = 14;
            label4.Text = "Enter Last Name";
            // 
            // txtSignFname
            // 
            txtSignFname.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignFname.Location = new Point(113, 46);
            txtSignFname.Name = "txtSignFname";
            txtSignFname.Size = new Size(299, 32);
            txtSignFname.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 53, 107);
            label5.Location = new Point(113, 13);
            label5.Name = "label5";
            label5.Size = new Size(208, 30);
            label5.TabIndex = 12;
            label5.Text = "Enter First Name";
            // 
            // txtSignPass
            // 
            txtSignPass.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignPass.Location = new Point(113, 394);
            txtSignPass.Name = "txtSignPass";
            txtSignPass.Size = new Size(299, 32);
            txtSignPass.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 53, 107);
            label6.Location = new Point(113, 361);
            label6.Name = "label6";
            label6.Size = new Size(193, 30);
            label6.TabIndex = 22;
            label6.Text = "Enter Password";
            // 
            // StudentSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(522, 497);
            Controls.Add(txtSignPass);
            Controls.Add(label6);
            Controls.Add(txtSignLname);
            Controls.Add(label4);
            Controls.Add(txtSignFname);
            Controls.Add(label5);
            Controls.Add(btnSignStudAccount);
            Controls.Add(txtSection);
            Controls.Add(label3);
            Controls.Add(cbxLevDept);
            Controls.Add(label1);
            Controls.Add(txtSignID);
            Controls.Add(label2);
            Name = "StudentSignUp";
            Text = "StudentSignUp";
            Load += StudentSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSignID;
        private Label label2;
        private Label label1;
        private ComboBox cbxLevDept;
        private Label label3;
        private TextBox txtSection;
        private Button btnSignStudAccount;
        private TextBox txtSignLname;
        private Label label4;
        private TextBox txtSignFname;
        private Label label5;
        private TextBox txtSignPass;
        private Label label6;
    }
}