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
            txtSignID.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignID.Location = new Point(105, 243);
            txtSignID.Margin = new Padding(3, 4, 3, 4);
            txtSignID.Name = "txtSignID";
            txtSignID.Size = new Size(341, 34);
            txtSignID.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label2.ForeColor = Color.FromArgb(0, 53, 107);
            label2.Location = new Point(105, 211);
            label2.Name = "label2";
            label2.Size = new Size(155, 29);
            label2.TabIndex = 5;
            label2.Text = "Enter Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label1.ForeColor = Color.FromArgb(0, 53, 107);
            label1.Location = new Point(105, 301);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 7;
            label1.Text = "Enter Level:";
            // 
            // cbxLevDept
            // 
            cbxLevDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLevDept.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            cbxLevDept.FormattingEnabled = true;
            cbxLevDept.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            cbxLevDept.Location = new Point(105, 333);
            cbxLevDept.Margin = new Padding(3, 4, 3, 4);
            cbxLevDept.Name = "cbxLevDept";
            cbxLevDept.Size = new Size(341, 37);
            cbxLevDept.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label3.ForeColor = Color.FromArgb(0, 53, 107);
            label3.Location = new Point(105, 392);
            label3.Name = "label3";
            label3.Size = new Size(130, 29);
            label3.TabIndex = 9;
            label3.Text = "Enter Section:";
            // 
            // txtSection
            // 
            txtSection.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSection.Location = new Point(105, 424);
            txtSection.Margin = new Padding(3, 4, 3, 4);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(341, 34);
            txtSection.TabIndex = 10;
            // 
            // btnSignStudAccount
            // 
            btnSignStudAccount.BackColor = Color.FromArgb(0, 53, 107);
            btnSignStudAccount.FlatAppearance.BorderSize = 0;
            btnSignStudAccount.FlatStyle = FlatStyle.Flat;
            btnSignStudAccount.Font = new Font("Franklin Gothic Book", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignStudAccount.ForeColor = Color.White;
            btnSignStudAccount.Location = new Point(202, 588);
            btnSignStudAccount.Margin = new Padding(3, 4, 3, 4);
            btnSignStudAccount.Name = "btnSignStudAccount";
            btnSignStudAccount.Size = new Size(150, 50);
            btnSignStudAccount.TabIndex = 11;
            btnSignStudAccount.Text = "SIGN UP";
            btnSignStudAccount.UseVisualStyleBackColor = false;
            btnSignStudAccount.Click += btnSignStudAccount_Click;
            // 
            // txtSignLname
            // 
            txtSignLname.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignLname.Location = new Point(105, 152);
            txtSignLname.Margin = new Padding(3, 4, 3, 4);
            txtSignLname.Name = "txtSignLname";
            txtSignLname.Size = new Size(341, 34);
            txtSignLname.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label4.ForeColor = Color.FromArgb(0, 53, 107);
            label4.Location = new Point(105, 120);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 14;
            label4.Text = "Enter Last Name:";
            // 
            // txtSignFname
            // 
            txtSignFname.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignFname.Location = new Point(105, 61);
            txtSignFname.Margin = new Padding(3, 4, 3, 4);
            txtSignFname.Name = "txtSignFname";
            txtSignFname.Size = new Size(341, 34);
            txtSignFname.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label5.ForeColor = Color.FromArgb(0, 53, 107);
            label5.Location = new Point(105, 29);
            label5.Name = "label5";
            label5.Size = new Size(156, 29);
            label5.TabIndex = 12;
            label5.Text = "Enter First Name:";
            // 
            // txtSignPass
            // 
            txtSignPass.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            txtSignPass.Location = new Point(105, 522);
            txtSignPass.Margin = new Padding(3, 4, 3, 4);
            txtSignPass.Name = "txtSignPass";
            txtSignPass.Size = new Size(341, 34);
            txtSignPass.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label6.ForeColor = Color.FromArgb(0, 53, 107);
            label6.Location = new Point(105, 490);
            label6.Name = "label6";
            label6.Size = new Size(147, 29);
            label6.TabIndex = 22;
            label6.Text = "Enter Password:";
            // 
            // StudentSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(597, 663);
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
            Margin = new Padding(3, 4, 3, 4);
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