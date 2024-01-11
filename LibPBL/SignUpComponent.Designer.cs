namespace LibPBL
{
    partial class SignUpComponent
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
            label1 = new Label();
            pnlStudEmp = new Panel();
            radStud = new RadioButton();
            radEmp = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(43, 40, 68);
            label1.Location = new Point(198, 43);
            label1.Name = "label1";
            label1.Size = new Size(163, 43);
            label1.TabIndex = 1;
            label1.Text = "Sign Up as";
            label1.Click += label1_Click;
            // 
            // pnlStudEmp
            // 
            pnlStudEmp.Dock = DockStyle.Bottom;
            pnlStudEmp.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlStudEmp.Location = new Point(0, 141);
            pnlStudEmp.Margin = new Padding(3, 4, 3, 4);
            pnlStudEmp.Name = "pnlStudEmp";
            pnlStudEmp.Size = new Size(615, 715);
            pnlStudEmp.TabIndex = 2;
            // 
            // radStud
            // 
            radStud.AutoSize = true;
            radStud.Font = new Font("Franklin Gothic Medium Cond", 12F);
            radStud.ForeColor = Color.FromArgb(0, 53, 107);
            radStud.Location = new Point(181, 90);
            radStud.Margin = new Padding(3, 4, 3, 4);
            radStud.Name = "radStud";
            radStud.Size = new Size(90, 29);
            radStud.TabIndex = 7;
            radStud.TabStop = true;
            radStud.Text = "Student";
            radStud.UseVisualStyleBackColor = true;
            radStud.CheckedChanged += radStud_CheckedChanged;
            // 
            // radEmp
            // 
            radEmp.AutoSize = true;
            radEmp.Font = new Font("Franklin Gothic Medium Cond", 12F);
            radEmp.ForeColor = Color.FromArgb(0, 53, 107);
            radEmp.Location = new Point(287, 90);
            radEmp.Margin = new Padding(3, 4, 3, 4);
            radEmp.Name = "radEmp";
            radEmp.Size = new Size(90, 29);
            radEmp.TabIndex = 9;
            radEmp.TabStop = true;
            radEmp.Text = "Teacher";
            radEmp.UseVisualStyleBackColor = true;
            radEmp.CheckedChanged += radEmp_CheckedChanged;
            // 
            // SignUpComponent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(615, 856);
            Controls.Add(radEmp);
            Controls.Add(radStud);
            Controls.Add(pnlStudEmp);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpComponent";
            Text = "SignUpComponent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel pnlStudEmp;
        private RadioButton radStud;
        private RadioButton radEmp;
    }
}