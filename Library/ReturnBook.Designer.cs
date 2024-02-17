namespace Library
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(438, 49);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 1;
            label1.Text = "Return  Book ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(242, 507);
            button3.Name = "button3";
            button3.Size = new Size(186, 44);
            button3.TabIndex = 48;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 419);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 47;
            label2.Text = "Book Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(148, 416);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 31);
            textBox1.TabIndex = 46;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(24, 141);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(629, 178);
            dataGridView2.TabIndex = 45;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(55, 507);
            button2.Name = "button2";
            button2.Size = new Size(181, 44);
            button2.TabIndex = 44;
            button2.Text = "Return Box";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-106, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 113);
            panel1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(58, 373);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 50;
            label3.Text = "User Id";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(148, 365);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 31);
            textBox2.TabIndex = 49;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(373, 366);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 27);
            radioButton1.TabIndex = 51;
            radioButton1.TabStop = true;
            radioButton1.Text = "Lost-Book";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(215, 116);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 53;
            label4.Text = "Returnd-Book";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 563);
            Controls.Add(label4);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private Label label4;
    }
}