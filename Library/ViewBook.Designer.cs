namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label9 = new Label();
            textBox8 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 126);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(483, 48);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 150);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(288, 132);
            button1.Name = "button1";
            button1.Size = new Size(263, 48);
            button1.TabIndex = 3;
            button1.Text = "Click here Refrech";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 275);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(13, 494);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 331);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(128, 31);
            label9.Name = "label9";
            label9.Size = new Size(27, 23);
            label9.TabIndex = 31;
            label9.Text = "ID";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(200, 23);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(191, 31);
            textBox8.TabIndex = 23;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(420, 239);
            button4.Name = "button4";
            button4.Size = new Size(89, 34);
            button4.TabIndex = 30;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(515, 239);
            button2.Name = "button2";
            button2.Size = new Size(89, 34);
            button2.TabIndex = 29;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(325, 239);
            button3.Name = "button3";
            button3.Size = new Size(89, 34);
            button3.TabIndex = 28;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(582, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 31);
            textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(582, 23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 31);
            textBox5.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(200, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 31);
            textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(200, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 31);
            textBox2.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Black;
            textBox7.Location = new Point(200, 70);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(191, 31);
            textBox7.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(471, 124);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 21;
            label7.Text = "librariansID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(478, 78);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 20;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(470, 31);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 19;
            label5.Text = "Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(128, 163);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 18;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(128, 124);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 17;
            label3.Text = "Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(130, 78);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 16;
            label8.Text = "Title";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Unavailable" });
            comboBox1.Location = new Point(582, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 31);
            comboBox1.TabIndex = 32;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(970, 869);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Button button4;
        private TextBox textBox8;
        private Label label9;
        private ComboBox comboBox1;
    }
}