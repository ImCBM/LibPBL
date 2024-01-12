namespace LibPBL
{
    partial class Payment
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
            txtPaymentAmount = new TextBox();
            dateTimePickerReturnDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPaymentAmount = new Label();
            comboBoxBorrowedBooks = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            buttonPay = new Button();
            label6 = new Label();
            comboBoxBorrowers = new ComboBox();
            SuspendLayout();
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPaymentAmount.Location = new Point(284, 463);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(376, 34);
            txtPaymentAmount.TabIndex = 2;
            txtPaymentAmount.KeyPress += txtPaymentAmount_KeyPress;
            // 
            // dateTimePickerReturnDate
            // 
            dateTimePickerReturnDate.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            dateTimePickerReturnDate.Location = new Point(284, 295);
            dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            dateTimePickerReturnDate.Size = new Size(376, 34);
            dateTimePickerReturnDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label1.Location = new Point(228, 466);
            label1.Name = "label1";
            label1.Size = new Size(63, 27);
            label1.TabIndex = 4;
            label1.Text = "Pay: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label2.Location = new Point(140, 295);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 5;
            label2.Text = "Return Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label3.Location = new Point(207, 391);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 6;
            label3.Text = "Total: ";
            // 
            // labelPaymentAmount
            // 
            labelPaymentAmount.AutoSize = true;
            labelPaymentAmount.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            labelPaymentAmount.Location = new Point(304, 391);
            labelPaymentAmount.Name = "labelPaymentAmount";
            labelPaymentAmount.Size = new Size(77, 27);
            labelPaymentAmount.TabIndex = 7;
            labelPaymentAmount.Text = "$$$$$";
            // 
            // comboBoxBorrowedBooks
            // 
            comboBoxBorrowedBooks.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            comboBoxBorrowedBooks.FormattingEnabled = true;
            comboBoxBorrowedBooks.Location = new Point(281, 144);
            comboBoxBorrowedBooks.Name = "comboBoxBorrowedBooks";
            comboBoxBorrowedBooks.Size = new Size(379, 35);
            comboBoxBorrowedBooks.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label4.Location = new Point(84, 197);
            label4.Name = "label4";
            label4.Size = new Size(191, 27);
            label4.TabIndex = 9;
            label4.Text = "Return Due Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label5.Location = new Point(124, 147);
            label5.Name = "label5";
            label5.Size = new Size(151, 27);
            label5.TabIndex = 10;
            label5.Text = "Select Book: ";
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.PaleTurquoise;
            buttonPay.FlatStyle = FlatStyle.Flat;
            buttonPay.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            buttonPay.Location = new Point(684, 463);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(139, 34);
            buttonPay.TabIndex = 11;
            buttonPay.Text = "Pay Due";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label6.Location = new Point(80, 90);
            label6.Name = "label6";
            label6.Size = new Size(195, 27);
            label6.TabIndex = 13;
            label6.Text = "Select Borrower: ";
            // 
            // comboBoxBorrowers
            // 
            comboBoxBorrowers.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            comboBoxBorrowers.FormattingEnabled = true;
            comboBoxBorrowers.Location = new Point(281, 90);
            comboBoxBorrowers.Name = "comboBoxBorrowers";
            comboBoxBorrowers.Size = new Size(379, 35);
            comboBoxBorrowers.TabIndex = 12;
            comboBoxBorrowers.SelectedIndexChanged += comboBoxBorrowers_SelectedIndexChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 606);
            Controls.Add(label6);
            Controls.Add(comboBoxBorrowers);
            Controls.Add(buttonPay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxBorrowedBooks);
            Controls.Add(labelPaymentAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPaymentAmount);
            Controls.Add(label1);
            Controls.Add(dateTimePickerReturnDate);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPaymentAmount;
        private DateTimePicker dateTimePickerReturnDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelPaymentAmount;
        private ComboBox comboBoxBorrowedBooks;
        private Label label4;
        private Label label5;
        private Button buttonPay;
        private Label label6;
        private ComboBox comboBoxBorrowers;
    }
}