﻿namespace LibPBL
{
    partial class Librarian
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
            panel1 = new Panel();
            btnPayment = new FontAwesome.Sharp.IconButton();
            btnViewBorrowers = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblUsernameAdmin = new Label();
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
            pnlLeft.Controls.Add(panel1);
            pnlLeft.Controls.Add(btnPayment);
            pnlLeft.Controls.Add(btnViewBorrowers);
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Controls.Add(lblUsernameAdmin);
            pnlLeft.Controls.Add(btnReturnBook);
            pnlLeft.Controls.Add(btnViewBook);
            pnlLeft.Location = new Point(0, 36);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(235, 645);
            pnlLeft.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 63, 105);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(225, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 645);
            panel1.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.FromArgb(67, 63, 89);
            btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnPayment.IconColor = Color.FromArgb(67, 63, 89);
            btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(12, 343);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(220, 54);
            btnPayment.TabIndex = 7;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleRight;
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnViewBorrowers
            // 
            btnViewBorrowers.FlatAppearance.BorderSize = 0;
            btnViewBorrowers.FlatStyle = FlatStyle.Flat;
            btnViewBorrowers.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBorrowers.ForeColor = Color.FromArgb(67, 63, 89);
            btnViewBorrowers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnViewBorrowers.IconColor = Color.FromArgb(67, 63, 89);
            btnViewBorrowers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewBorrowers.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewBorrowers.Location = new Point(12, 296);
            btnViewBorrowers.Name = "btnViewBorrowers";
            btnViewBorrowers.Size = new Size(220, 54);
            btnViewBorrowers.TabIndex = 6;
            btnViewBorrowers.Text = "Borrowers";
            btnViewBorrowers.TextAlign = ContentAlignment.MiddleRight;
            btnViewBorrowers.UseVisualStyleBackColor = true;
            btnViewBorrowers.Click += btnViewBorrowers_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 63, 105);
            panel2.Location = new Point(12, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 2);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.UserDefPic;
            pictureBox1.Location = new Point(46, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblUsernameAdmin
            // 
            lblUsernameAdmin.AutoSize = true;
            lblUsernameAdmin.FlatStyle = FlatStyle.Flat;
            lblUsernameAdmin.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblUsernameAdmin.ForeColor = Color.FromArgb(67, 63, 89);
            lblUsernameAdmin.Location = new Point(56, 120);
            lblUsernameAdmin.Name = "lblUsernameAdmin";
            lblUsernameAdmin.Size = new Size(105, 54);
            lblUsernameAdmin.TabIndex = 0;
            lblUsernameAdmin.Text = "Admin\r\nLibrarian";
            lblUsernameAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReturnBook
            // 
            btnReturnBook.FlatAppearance.BorderSize = 0;
            btnReturnBook.FlatStyle = FlatStyle.Flat;
            btnReturnBook.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.ForeColor = Color.FromArgb(67, 63, 89);
            btnReturnBook.IconChar = FontAwesome.Sharp.IconChar.RightLeft;
            btnReturnBook.IconColor = Color.FromArgb(67, 63, 89);
            btnReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReturnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturnBook.Location = new Point(12, 244);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(220, 54);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.TextAlign = ContentAlignment.MiddleRight;
            btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnViewBook
            // 
            btnViewBook.FlatAppearance.BorderSize = 0;
            btnViewBook.FlatStyle = FlatStyle.Flat;
            btnViewBook.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBook.ForeColor = Color.FromArgb(67, 63, 89);
            btnViewBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnViewBook.IconColor = Color.FromArgb(67, 63, 89);
            btnViewBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewBook.Location = new Point(12, 190);
            btnViewBook.Name = "btnViewBook";
            btnViewBook.Size = new Size(220, 54);
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
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1264, 38);
            pnlTopHeader.TabIndex = 4;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.FromArgb(32, 49, 46);
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 30;
            btnMinimize.Location = new Point(1181, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(45, 32);
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
            btnX.Location = new Point(1216, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(45, 32);
            btnX.TabIndex = 0;
            btnX.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Location = new Point(235, 36);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1029, 645);
            pnlMain.TabIndex = 5;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTopHeader);
            Controls.Add(pnlMain);
            Name = "Librarian";
            Text = "Librarian";
            Load += Librarian_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTopHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblUsernameAdmin;
        private FontAwesome.Sharp.IconButton btnReturnBook;
        private FontAwesome.Sharp.IconButton btnViewBook;
        private Panel pnlTopHeader;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnX;
        private Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnViewBorrowers;
        private FontAwesome.Sharp.IconButton btnPayment;
    }
}