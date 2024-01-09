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
            btnSearch = new FontAwesome.Sharp.IconButton();
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
            txtSearchBar.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 40;
            btnSearch.Location = new Point(495, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(59, 44);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += iconButton1_Click;
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
            lblProcessTIme.Location = new Point(576, 16);
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
            lblMemUsage.Location = new Point(576, 33);
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
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Name = "ViewBook";
            Text = "ViewBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearchBar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblProcessTIme;
        private Label lblMemUsage;
    }
}