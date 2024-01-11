namespace LibPBL
{
    partial class ViewBook
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
            txtSearchBar = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblProcessTIme = new Label();
            lblMemUsage = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSearchBar
            // 
            txtSearchBar.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchBar.Location = new Point(143, 22);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(346, 34);
            txtSearchBar.TabIndex = 1;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1013, 525);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 277);
            panel1.TabIndex = 0;
            // 
            // lblProcessTIme
            // 
            lblProcessTIme.AutoSize = true;
            lblProcessTIme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProcessTIme.Location = new Point(849, 44);
            lblProcessTIme.Name = "lblProcessTIme";
            lblProcessTIme.Size = new Size(118, 17);
            lblProcessTIme.TabIndex = 4;
            lblProcessTIme.Text = "Data Retrieved in ";
            lblProcessTIme.Click += lblProcessTIme_Click;
            // 
            // lblMemUsage
            // 
            lblMemUsage.AutoSize = true;
            lblMemUsage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMemUsage.Location = new Point(849, 61);
            lblMemUsage.Name = "lblMemUsage";
            lblMemUsage.Size = new Size(152, 17);
            lblMemUsage.TabIndex = 5;
            lblMemUsage.Text = "Current Memory Usage: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 270);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 26);
            label1.Name = "label1";
            label1.Size = new Size(71, 26);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1013, 606);
            Controls.Add(lblMemUsage);
            Controls.Add(lblProcessTIme);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSearchBar);
            Name = "ViewBook";
            Text = "ViewBook";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearchBar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblProcessTIme;
        private Label lblMemUsage;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}