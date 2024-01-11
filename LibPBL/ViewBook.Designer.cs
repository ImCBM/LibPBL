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
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            lblProcessTIme = new Label();
            lblMemUsage = new Label();
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
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 277);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(194, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(289, 50);
            richTextBox1.TabIndex = 2;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "Test\nText";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 270);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblProcessTIme
            // 
            lblProcessTIme.AutoSize = true;
            lblProcessTIme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProcessTIme.Location = new Point(720, 39);
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
            lblMemUsage.Location = new Point(720, 61);
            lblMemUsage.Name = "lblMemUsage";
            lblMemUsage.Size = new Size(152, 17);
            lblMemUsage.TabIndex = 5;
            lblMemUsage.Text = "Current Memory Usage: ";
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
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}