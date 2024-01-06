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
            label1.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(43, 40, 68);
            label1.Location = new Point(171, 18);
            label1.Name = "label1";
            label1.Size = new Size(187, 41);
            label1.TabIndex = 1;
            label1.Text = "Sign Up as";
            label1.Click += label1_Click;
            // 
            // pnlStudEmp
            // 
            pnlStudEmp.Dock = DockStyle.Bottom;
            pnlStudEmp.Location = new Point(0, 106);
            pnlStudEmp.Name = "pnlStudEmp";
            pnlStudEmp.Size = new Size(538, 536);
            pnlStudEmp.TabIndex = 2;
            // 
            // radStud
            // 
            radStud.AutoSize = true;
            radStud.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radStud.ForeColor = Color.FromArgb(0, 53, 107);
            radStud.Location = new Point(150, 78);
            radStud.Name = "radStud";
            radStud.Size = new Size(112, 31);
            radStud.TabIndex = 7;
            radStud.TabStop = true;
            radStud.Text = "Student";
            radStud.UseVisualStyleBackColor = true;
            radStud.CheckedChanged += radStud_CheckedChanged;
            // 
            // radEmp
            // 
            radEmp.AutoSize = true;
            radEmp.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radEmp.ForeColor = Color.FromArgb(0, 53, 107);
            radEmp.Location = new Point(267, 78);
            radEmp.Name = "radEmp";
            radEmp.Size = new Size(116, 31);
            radEmp.TabIndex = 9;
            radEmp.TabStop = true;
            radEmp.Text = "Teacher";
            radEmp.UseVisualStyleBackColor = true;
            radEmp.CheckedChanged += radEmp_CheckedChanged;
            // 
            // SignUpComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 235, 254);
            ClientSize = new Size(538, 642);
            Controls.Add(radEmp);
            Controls.Add(radStud);
            Controls.Add(pnlStudEmp);
            Controls.Add(label1);
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