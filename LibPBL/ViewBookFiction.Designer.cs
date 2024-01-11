namespace LibPBL
{
    partial class ViewBookFiction
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            picFbook1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFbook1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1139, 583);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picFbook1);
            panel1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 293);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(226, 12);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(361, 111);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Data Structures and Algorithm Analysis in C++";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 180);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // picFbook1
            // 
            picFbook1.Location = new Point(9, 4);
            picFbook1.Margin = new Padding(3, 4, 3, 4);
            picFbook1.Name = "picFbook1";
            picFbook1.Size = new Size(210, 285);
            picFbook1.TabIndex = 0;
            picFbook1.TabStop = false;
            // 
            // ViewBookFiction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1139, 583);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewBookFiction";
            Text = "ViewBookFiction";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFbook1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlFbook4;
        private Panel pnlFbook5;
        private Panel pnlFbook6;
        private Panel panel1;
        private PictureBox picFbook1;
        private Label label1;
        private Panel pnlFbook8;
        private RichTextBox richTextBox1;
    }
}