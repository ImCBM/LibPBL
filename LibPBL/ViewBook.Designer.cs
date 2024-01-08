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
            pnlForBooks = new Panel();
            cbxBookTypes = new ComboBox();
            SuspendLayout();
            // 
            // pnlForBooks
            // 
            pnlForBooks.Dock = DockStyle.Bottom;
            pnlForBooks.Location = new Point(0, 69);
            pnlForBooks.Name = "pnlForBooks";
            pnlForBooks.Size = new Size(1013, 476);
            pnlForBooks.TabIndex = 0;
            // 
            // cbxBookTypes
            // 
            cbxBookTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBookTypes.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxBookTypes.FormattingEnabled = true;
            cbxBookTypes.Items.AddRange(new object[] { "Academic Books", "Fiction Books", "Non-Fiction Books" });
            cbxBookTypes.Location = new Point(170, 12);
            cbxBookTypes.Name = "cbxBookTypes";
            cbxBookTypes.Size = new Size(279, 41);
            cbxBookTypes.TabIndex = 1;
            cbxBookTypes.SelectedIndexChanged += cbxBookTypes_SelectedIndexChanged;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1013, 545);
            Controls.Add(cbxBookTypes);
            Controls.Add(pnlForBooks);
            Name = "ViewBook";
            Text = "ViewBook";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForBooks;
        private ComboBox cbxBookTypes;
    }
}