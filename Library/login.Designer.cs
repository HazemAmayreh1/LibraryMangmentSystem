namespace Library
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel3 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(43, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Username";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(43, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 16);
            textBox2.TabIndex = 3;
            textBox2.Text = "Password";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(45, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(45, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 1);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(1398, -2);
            button3.Name = "button3";
            button3.Size = new Size(34, 41);
            button3.TabIndex = 10;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(88, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 17);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "user";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(6, 19);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 17);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "librarian";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(45, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 1);
            panel3.TabIndex = 15;
            panel3.Visible = false;
            panel3.Paint += panel3_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(87, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 17);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "Login";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(69, 17);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "SingUp";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Font = new Font("Aharoni", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(45, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 51);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Font = new Font("Aharoni", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(45, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 47);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(551, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 530);
            panel4.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(44, 370);
            button2.Name = "button2";
            button2.Size = new Size(183, 41);
            button2.TabIndex = 24;
            button2.Text = "SingUp";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(44, 417);
            button1.Name = "button1";
            button1.Size = new Size(183, 41);
            button1.TabIndex = 23;
            button1.Text = "LogInLibrarian";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(42, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 16);
            textBox3.TabIndex = 13;
            textBox3.Text = "Id";
            textBox3.Visible = false;
            textBox3.MouseClick += textBox3_MouseClick;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(44, 464);
            button4.Name = "button4";
            button4.Size = new Size(183, 41);
            button4.TabIndex = 25;
            button4.Text = "LogInUsers";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(225, 24);
            label1.TabIndex = 27;
            label1.Text = "Library Login Form";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(19, 85);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 438);
            panel7.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(266, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 438);
            panel5.TabIndex = 25;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 438);
            panel6.TabIndex = 26;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1432, 680);
            Controls.Add(panel4);
            Controls.Add(button3);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private TextBox textBox3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}