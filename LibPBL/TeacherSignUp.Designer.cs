namespace LibPBL
{
    partial class TeacherSignUp
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
            cbxLevDept = new ComboBox();
            label1 = new Label();
            txtSignID = new TextBox();
            label2 = new Label();
            btnSignEmpAccount = new Button();
            txtSignLname = new TextBox();
            label4 = new Label();
            txtSignFname = new TextBox();
            label5 = new Label();
            txtSignPass = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbxLevDept
            // 
            cbxLevDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLevDept.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            cbxLevDept.FormattingEnabled = true;
            cbxLevDept.Items.AddRange(new object[] { "Department of Data Science", "Department of Computer Science", "Department of Information Technology", "Department of Arts", "Department of Nursing", "Department of Communication", "Department of Accounting" });
            cbxLevDept.Location = new Point(135, 360);
            cbxLevDept.Margin = new Padding(3, 4, 3, 4);
            cbxLevDept.Name = "cbxLevDept";
            cbxLevDept.Size = new Size(341, 37);
            cbxLevDept.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label1.ForeColor = Color.FromArgb(0, 53, 107);
            label1.Location = new Point(135, 328);
            label1.Name = "label1";
            label1.Size = new Size(166, 29);
            label1.TabIndex = 13;
            label1.Text = "Enter Department:";
            // 
            // txtSignID
            // 
            txtSignID.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignID.Location = new Point(135, 269);
            txtSignID.Margin = new Padding(3, 4, 3, 4);
            txtSignID.Name = "txtSignID";
            txtSignID.Size = new Size(341, 34);
            txtSignID.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label2.ForeColor = Color.FromArgb(0, 53, 107);
            label2.Location = new Point(135, 237);
            label2.Name = "label2";
            label2.Size = new Size(170, 29);
            label2.TabIndex = 11;
            label2.Text = "Enter Employee ID:";
            // 
            // btnSignEmpAccount
            // 
            btnSignEmpAccount.BackColor = Color.FromArgb(0, 53, 107);
            btnSignEmpAccount.FlatAppearance.BorderSize = 0;
            btnSignEmpAccount.FlatStyle = FlatStyle.Flat;
            btnSignEmpAccount.Font = new Font("Franklin Gothic Book", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignEmpAccount.ForeColor = Color.White;
            btnSignEmpAccount.Location = new Point(230, 531);
            btnSignEmpAccount.Margin = new Padding(3, 4, 3, 4);
            btnSignEmpAccount.Name = "btnSignEmpAccount";
            btnSignEmpAccount.Size = new Size(150, 50);
            btnSignEmpAccount.TabIndex = 15;
            btnSignEmpAccount.Text = "SIGN UP";
            btnSignEmpAccount.UseVisualStyleBackColor = false;
            btnSignEmpAccount.Click += btnSignEmpAccount_Click;
            // 
            // txtSignLname
            // 
            txtSignLname.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignLname.Location = new Point(135, 179);
            txtSignLname.Margin = new Padding(3, 4, 3, 4);
            txtSignLname.Name = "txtSignLname";
            txtSignLname.Size = new Size(341, 34);
            txtSignLname.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label4.ForeColor = Color.FromArgb(0, 53, 107);
            label4.Location = new Point(135, 147);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 18;
            label4.Text = "Enter Last Name:";
            // 
            // txtSignFname
            // 
            txtSignFname.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignFname.Location = new Point(135, 88);
            txtSignFname.Margin = new Padding(3, 4, 3, 4);
            txtSignFname.Name = "txtSignFname";
            txtSignFname.Size = new Size(341, 34);
            txtSignFname.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label5.ForeColor = Color.FromArgb(0, 53, 107);
            label5.Location = new Point(135, 56);
            label5.Name = "label5";
            label5.Size = new Size(156, 29);
            label5.TabIndex = 16;
            label5.Text = "Enter First Name:";
            // 
            // txtSignPass
            // 
            txtSignPass.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignPass.Location = new Point(135, 448);
            txtSignPass.Margin = new Padding(3, 4, 3, 4);
            txtSignPass.Name = "txtSignPass";
            txtSignPass.Size = new Size(341, 34);
            txtSignPass.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label3.ForeColor = Color.FromArgb(0, 53, 107);
            label3.Location = new Point(135, 416);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 20;
            label3.Text = "Enter Password:";
            // 
            // TeacherSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(615, 856);
            Controls.Add(txtSignPass);
            Controls.Add(label3);
            Controls.Add(txtSignLname);
            Controls.Add(label4);
            Controls.Add(txtSignFname);
            Controls.Add(label5);
            Controls.Add(btnSignEmpAccount);
            Controls.Add(cbxLevDept);
            Controls.Add(label1);
            Controls.Add(txtSignID);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeacherSignUp";
            Text = "TeacherSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxLevDept;
        private Label label1;
        private TextBox txtSignID;
        private Label label2;
        private Button btnSignEmpAccount;
        private TextBox txtSignLname;
        private Label label4;
        private TextBox txtSignFname;
        private Label label5;
        private TextBox txtSignPass;
        private Label label3;
    }
}