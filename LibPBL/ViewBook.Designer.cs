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
            txtSearchBar.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBar.Location = new Point(163, 29);
            txtSearchBar.Margin = new Padding(3, 4, 3, 4);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(395, 34);
            txtSearchBar.TabIndex = 1;
            txtSearchBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 108);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1158, 700);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 369);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.DetectUrls = false;
            richTextBox1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(222, 5);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(330, 67);
            richTextBox1.TabIndex = 2;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "Test\nText";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 360);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblProcessTIme
            // 
            lblProcessTIme.AutoSize = true;
            lblProcessTIme.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Italic);
            lblProcessTIme.Location = new Point(823, 52);
            lblProcessTIme.Name = "lblProcessTIme";
            lblProcessTIme.Size = new Size(123, 21);
            lblProcessTIme.TabIndex = 4;
            lblProcessTIme.Text = "Data Retrieved in ";
            lblProcessTIme.Click += lblProcessTIme_Click;
            // 
            // lblMemUsage
            // 
            lblMemUsage.AutoSize = true;
            lblMemUsage.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Italic);
            lblMemUsage.Location = new Point(823, 81);
            lblMemUsage.Name = "lblMemUsage";
            lblMemUsage.Size = new Size(162, 21);
            lblMemUsage.TabIndex = 5;
            lblMemUsage.Text = "Current Memory Usage: ";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1158, 808);
            Controls.Add(lblMemUsage);
            Controls.Add(lblProcessTIme);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtSearchBar);
            Margin = new Padding(3, 4, 3, 4);
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