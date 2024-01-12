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
            lblProcessTIme = new Label();
            lblMemUsage = new Label();
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
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1013, 525);
            flowLayoutPanel1.TabIndex = 3;
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
            Load += ViewBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearchBar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblProcessTIme;
        private Label lblMemUsage;
    }
}