namespace Library
{
    partial class UserBorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBorrowBook));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label9 = new Label();
            textBox8 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(417, 168);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(226, 479);
            button1.Name = "button1";
            button1.Size = new Size(176, 55);
            button1.TabIndex = 10;
            button1.Text = "Borrow Box";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(447, 81);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 1;
            label1.Text = "Borrow  Book ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-60, -51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 148);
            panel1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(212, 381);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 33;
            label9.Text = "Book Id";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(327, 378);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(203, 31);
            textBox8.TabIndex = 32;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(417, 479);
            button3.Name = "button3";
            button3.Size = new Size(181, 55);
            button3.TabIndex = 38;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(215, 329);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 40;
            label2.Text = "User Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(327, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 31);
            textBox1.TabIndex = 39;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(212, 429);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 54;
            label4.Text = "Return Book";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(327, 429);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 23);
            dateTimePicker1.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(604, 100);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 56;
            label5.Text = "All-Book";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(478, 125);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(412, 168);
            dataGridView2.TabIndex = 55;
            // 
            // UserBorrowBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 568);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "UserBorrowBook";
            Text = "UserBorrowBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label9;
        private TextBox textBox8;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DataGridView dataGridView2;
    }
}