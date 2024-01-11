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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblUsername = new Label();
            btnReturnBook = new FontAwesome.Sharp.IconButton();
            btnViewBook = new FontAwesome.Sharp.IconButton();
            pnlTopHeader = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnX = new FontAwesome.Sharp.IconButton();
            pnlMain = new Panel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(234, 249, 245);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Controls.Add(panel1);
            pnlLeft.Controls.Add(lblUsername);
            pnlLeft.Controls.Add(btnReturnBook);
            pnlLeft.Controls.Add(btnViewBook);
            pnlLeft.Location = new Point(0, 48);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(269, 860);
            pnlLeft.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 63, 105);
            panel2.Location = new Point(14, 245);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 3);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.UserDefPic;
            pictureBox1.Location = new Point(53, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 63, 105);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(258, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 860);
            panel1.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(67, 63, 89);
            lblUsername.Location = new Point(74, 171);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 58);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "fname, \r\nlname";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReturnBook
            // 
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnBook.ForeColor = Color.FromArgb(67, 63, 89);
            btnReturnBook.IconChar = FontAwesome.Sharp.IconChar.RightLeft;
            btnReturnBook.IconColor = Color.FromArgb(67, 63, 89);
            btnReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturnBook.IconSize = 40;
            btnReturnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturnBook.Location = new Point(14, 325);
            btnReturnBook.Margin = new Padding(3, 4, 3, 4);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(251, 72);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.TextAlign = ContentAlignment.MiddleRight;
            btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnViewBook
            // 
            btnViewBook.FlatAppearance.BorderSize = 0;
            btnViewBook.FlatStyle = FlatStyle.Flat;
            btnViewBook.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewBook.ForeColor = Color.FromArgb(67, 63, 89);
            btnViewBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnViewBook.IconColor = Color.FromArgb(67, 63, 89);
            btnViewBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewBook.IconSize = 40;
            btnViewBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewBook.Location = new Point(14, 253);
            btnViewBook.Margin = new Padding(3, 4, 3, 4);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(251, 72);
            btnViewBook.TabIndex = 1;
            btnViewBook.Text = "View Books";
            btnViewBook.TextAlign = ContentAlignment.MiddleRight;
            btnViewBook.UseVisualStyleBackColor = true;
            btnViewBook.Click += btnViewBook_Click;
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.FromArgb(39, 194, 159);
            pnlTopHeader.Controls.Add(btnMinimize);
            pnlTopHeader.Controls.Add(btnX);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Margin = new Padding(3, 4, 3, 4);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1442, 51);
            pnlTopHeader.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.FromArgb(32, 49, 46);
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 30;
            btnMinimize.Location = new Point(1350, 4);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(51, 43);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.IconChar = FontAwesome.Sharp.IconChar.X;
            btnX.IconColor = Color.FromArgb(32, 49, 46);
            btnX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnX.IconSize = 30;
            btnX.Location = new Point(1390, 4);
            btnX.Margin = new Padding(3, 4, 3, 4);
            btnX.Name = "btnX";
            btnX.Size = new Size(51, 43);
            btnX.TabIndex = 0;
            btnX.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(269, 48);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1176, 860);
            pnlMain.TabIndex = 2;
            // 
            // MainLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 897);
            Controls.Add(pnlTopHeader);
            Controls.Add(pnlMain);
            Controls.Add(pnlLeft);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1460, 944);
            MinimumSize = new Size(1460, 944);
            Name = "MainLibrary";
            Text = "MainLibrary";
            Load += MainLibrary_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTopHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlTopHeader;
        private FontAwesome.Sharp.IconButton btnViewBook;
        private Label lblUsername;
        private FontAwesome.Sharp.IconButton btnReturnBook;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pnlMain;
        private Panel panel2;
    }
}