namespace LibPBL
{
    partial class ViewBookBorrow
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
            dateTimePickerBorrow = new DateTimePicker();
            label1 = new Label();
            btnBorrow = new Button();
            SuspendLayout();
            // 
            // dateTimePickerBorrow
            // 
            dateTimePickerBorrow.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerBorrow.Location = new Point(83, 131);
            dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            dateTimePickerBorrow.Size = new Size(344, 29);
            dateTimePickerBorrow.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.Location = new Point(178, 106);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
            label1.TabIndex = 1;
            label1.Text = "Borrow Until";
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.LightSkyBlue;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            btnBorrow.Location = new Point(160, 268);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(143, 47);
            btnBorrow.TabIndex = 2;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // ViewBookBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 461);
            Controls.Add(btnBorrow);
            Controls.Add(label1);
            Controls.Add(dateTimePickerBorrow);
            Name = "ViewBookBorrow";
            Text = "Borrow";
            Load += ViewBookBorrow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlFbook4;
        private Panel pnlFbook5;
        private Panel pnlFbook6;
        private Panel pnlFbook8;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePickerBorrow;
        private Label label1;
        private Button btnBorrow;
    }
}