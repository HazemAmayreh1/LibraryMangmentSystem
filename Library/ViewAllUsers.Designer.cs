namespace Library
{
    partial class ViewAllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllUsers));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(447, 81);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 1;
            label1.Text = "View Users";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(869, 328);
            dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(225, 133);
            button1.Name = "button1";
            button1.Size = new Size(465, 55);
            button1.TabIndex = 10;
            button1.Text = "Click here Show All Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-61, -43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 148);
            panel1.TabIndex = 9;
            // 
            // ViewAllUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 585);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ViewAllUsers";
            Text = "ViewAllUsers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
    }
}