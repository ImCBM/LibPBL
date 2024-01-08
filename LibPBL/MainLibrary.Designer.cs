namespace LibPBL
{
    partial class MainLibrary
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
            pnlLeft = new Panel();
            btnViewBook = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            pnlTopHeader = new Panel();
            pnlMain = new Panel();
            pnlHeaderUser = new Panel();
            panel3 = new Panel();
            lblUsername = new Label();
            btnReturnBook = new FontAwesome.Sharp.IconButton();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTopHeader.SuspendLayout();
            pnlHeaderUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(15, 33, 103);
            pnlLeft.Controls.Add(btnReturnBook);
            pnlLeft.Controls.Add(btnViewBook);
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(235, 681);
            pnlLeft.TabIndex = 0;
            // 
            // btnViewBook
            // 
            btnViewBook.FlatAppearance.BorderSize = 0;
            btnViewBook.FlatStyle = FlatStyle.Flat;
            btnViewBook.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBook.ForeColor = Color.FromArgb(255, 236, 214);
            btnViewBook.IconChar = FontAwesome.Sharp.IconChar.None;
            btnViewBook.IconColor = Color.Black;
            btnViewBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewBook.Location = new Point(0, 169);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(232, 54);
            btnViewBook.TabIndex = 1;
            btnViewBook.Text = "View Books";
            btnViewBook.TextAlign = ContentAlignment.MiddleRight;
            btnViewBook.UseVisualStyleBackColor = true;
            btnViewBook.Click += btnViewBook_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 33, 103);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LibLogo;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.FromArgb(15, 33, 103);
            pnlTopHeader.Controls.Add(panel3);
            pnlTopHeader.Controls.Add(pnlHeaderUser);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(235, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1029, 100);
            pnlTopHeader.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ActiveCaption;
            pnlMain.Location = new Point(235, 97);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1029, 584);
            pnlMain.TabIndex = 2;
            // 
            // pnlHeaderUser
            // 
            pnlHeaderUser.BackColor = Color.FromArgb(15, 33, 123);
            pnlHeaderUser.Controls.Add(lblUsername);
            pnlHeaderUser.Dock = DockStyle.Left;
            pnlHeaderUser.Location = new Point(0, 0);
            pnlHeaderUser.Name = "pnlHeaderUser";
            pnlHeaderUser.Size = new Size(356, 100);
            pnlHeaderUser.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 40, 68);
            panel3.Location = new Point(354, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 103);
            panel3.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 236, 214);
            lblUsername.Location = new Point(79, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(192, 33);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "fname, lname";
            // 
            // btnReturnBook
            // 
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.ForeColor = Color.FromArgb(255, 236, 214);
            btnReturnBook.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReturnBook.IconColor = Color.Black;
            btnReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturnBook.Location = new Point(0, 223);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(232, 54);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.TextAlign = ContentAlignment.MiddleRight;
            btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // MainLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlMain);
            Controls.Add(pnlTopHeader);
            Controls.Add(pnlLeft);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "MainLibrary";
            Text = "MainLibrary";
            Load += MainLibrary_Load;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTopHeader.ResumeLayout(false);
            pnlHeaderUser.ResumeLayout(false);
            pnlHeaderUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlTopHeader;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnViewBook;
        private Panel pnlHeaderUser;
        private Panel pnlMain;
        private Panel panel3;
        private Label lblUsername;
        private FontAwesome.Sharp.IconButton btnReturnBook;
    }
}