namespace LibPBL
{
    partial class ShowBorrowers
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
            dataGridViewteacher = new DataGridView();
            dataGridViewstudent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewteacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstudent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewteacher
            // 
            dataGridViewteacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewteacher.Location = new Point(41, 94);
            dataGridViewteacher.Name = "dataGridViewteacher";
            dataGridViewteacher.Size = new Size(403, 484);
            dataGridViewteacher.TabIndex = 0;
            dataGridViewteacher.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewstudent
            // 
            dataGridViewstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewstudent.Location = new Point(568, 94);
            dataGridViewstudent.Name = "dataGridViewstudent";
            dataGridViewstudent.Size = new Size(406, 484);
            dataGridViewstudent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 57);
            label1.Name = "label1";
            label1.Size = new Size(115, 27);
            label1.TabIndex = 2;
            label1.Text = "TEACHER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold);
            label2.Location = new Point(723, 57);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 3;
            label2.Text = "STUDENTS";
            // 
            // ShowBorrowers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 606);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewstudent);
            Controls.Add(dataGridViewteacher);
            Name = "ShowBorrowers";
            Text = "ShowBorrowers";
            Load += ShowBorrowers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewteacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewteacher;
        private DataGridView dataGridViewstudent;
        private Label label1;
        private Label label2;
    }
}