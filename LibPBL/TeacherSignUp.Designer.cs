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
            txtLevDept = new ComboBox();
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
            // txtLevDept
            // 
            txtLevDept.DropDownStyle = ComboBoxStyle.DropDownList;
            txtLevDept.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            txtLevDept.FormattingEnabled = true;
            txtLevDept.Items.AddRange(new object[] { "Department of Data Science", "Department of Computer Science", "Department of Information Technology", "Department of Arts", "Department of Nursing", "Department of Communication", "Department of Accounting" });
            txtLevDept.Location = new Point(69, 270);
            txtLevDept.Name = "txtLevDept";
            txtLevDept.Size = new Size(386, 32);
            txtLevDept.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 53, 107);
            label1.Location = new Point(113, 237);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 13;
            label1.Text = "Enter Department";
            // 
            // txtSignID
            // 
            txtSignID.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignID.Location = new Point(113, 202);
            txtSignID.Name = "txtSignID";
            txtSignID.Size = new Size(299, 32);
            txtSignID.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 53, 107);
            label2.Location = new Point(113, 169);
            label2.Name = "label2";
            label2.Size = new Size(224, 30);
            label2.TabIndex = 11;
            label2.Text = "Enter Employee ID";
            // 
            // btnSignEmpAccount
            // 
            btnSignEmpAccount.BackColor = Color.FromArgb(0, 53, 107);
            btnSignEmpAccount.FlatAppearance.BorderSize = 0;
            btnSignEmpAccount.FlatStyle = FlatStyle.Flat;
            btnSignEmpAccount.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignEmpAccount.ForeColor = Color.FromArgb(255, 255, 192);
            btnSignEmpAccount.Location = new Point(201, 505);
            btnSignEmpAccount.Name = "btnSignEmpAccount";
            btnSignEmpAccount.Size = new Size(117, 40);
            btnSignEmpAccount.TabIndex = 15;
            btnSignEmpAccount.Text = "Sign Up";
            btnSignEmpAccount.UseVisualStyleBackColor = false;
            btnSignEmpAccount.Click += btnSignEmpAccount_Click;
            // 
            // txtSignLname
            // 
            txtSignLname.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignLname.Location = new Point(113, 134);
            txtSignLname.Name = "txtSignLname";
            txtSignLname.Size = new Size(299, 32);
            txtSignLname.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 53, 107);
            label4.Location = new Point(113, 101);
            label4.Name = "label4";
            label4.Size = new Size(205, 30);
            label4.TabIndex = 18;
            label4.Text = "Enter Last Name";
            // 
            // txtSignFname
            // 
            txtSignFname.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignFname.Location = new Point(113, 66);
            txtSignFname.Name = "txtSignFname";
            txtSignFname.Size = new Size(299, 32);
            txtSignFname.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 53, 107);
            label5.Location = new Point(113, 33);
            label5.Name = "label5";
            label5.Size = new Size(208, 30);
            label5.TabIndex = 16;
            label5.Text = "Enter First Name";
            // 
            // txtSignPass
            // 
            txtSignPass.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSignPass.Location = new Point(113, 349);
            txtSignPass.Name = "txtSignPass";
            txtSignPass.Size = new Size(299, 32);
            txtSignPass.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 53, 107);
            label3.Location = new Point(113, 316);
            label3.Name = "label3";
            label3.Size = new Size(193, 30);
            label3.TabIndex = 20;
            label3.Text = "Enter Password";
            // 
            // TeacherSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(538, 642);
            Controls.Add(txtSignPass);
            Controls.Add(label3);
            Controls.Add(txtSignLname);
            Controls.Add(label4);
            Controls.Add(txtSignFname);
            Controls.Add(label5);
            Controls.Add(btnSignEmpAccount);
            Controls.Add(txtLevDept);
            Controls.Add(label1);
            Controls.Add(txtSignID);
            Controls.Add(label2);
            Name = "TeacherSignUp";
            Text = "TeacherSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox txtLevDept;
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