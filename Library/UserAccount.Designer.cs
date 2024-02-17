namespace Library
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(3, 452);
            button2.Name = "button2";
            button2.Size = new Size(122, 47);
            button2.TabIndex = 31;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(296, 211);
            button1.Name = "button1";
            button1.Size = new Size(343, 47);
            button1.TabIndex = 30;
            button1.Text = "#Late_Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(296, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 31);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(203, 98);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 20;
            label3.Text = "User-ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 36);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 4;
            label1.Text = "Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(263, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 354);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, -17);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 78);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(296, 146);
            button3.Name = "button3";
            button3.Size = new Size(343, 47);
            button3.TabIndex = 33;
            button3.Text = "#Borrow_Book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(296, 274);
            button4.Name = "button4";
            button4.Size = new Size(343, 47);
            button4.TabIndex = 34;
            button4.Text = "#Return_Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(296, 408);
            button5.Name = "button5";
            button5.Size = new Size(343, 47);
            button5.TabIndex = 37;
            button5.Text = "Cal_Fine";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(296, 341);
            button6.Name = "button6";
            button6.Size = new Size(343, 47);
            button6.TabIndex = 38;
            button6.Text = "#Lost_Book";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 502);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UserAccount";
            Text = "UserAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}