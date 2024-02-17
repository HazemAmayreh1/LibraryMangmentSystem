namespace Library
{
    partial class dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashbord));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            bookDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            closeApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, returnBooksToolStripMenuItem, bookDeToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1427, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(120, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addNewBooksToolStripMenuItem.Image = (Image)resources.GetObject("addNewBooksToolStripMenuItem.Image");
            addNewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(239, 56);
            addNewBooksToolStripMenuItem.Text = "Add New Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(239, 56);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.Wheat;
            returnBooksToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(163, 54);
            returnBooksToolStripMenuItem.Text = "Query Page";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // bookDeToolStripMenuItem
            // 
            bookDeToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookDeToolStripMenuItem.Image = (Image)resources.GetObject("bookDeToolStripMenuItem.Image");
            bookDeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bookDeToolStripMenuItem.Name = "bookDeToolStripMenuItem";
            bookDeToolStripMenuItem.Size = new Size(188, 54);
            bookDeToolStripMenuItem.Text = "Book Mehtdos";
            bookDeToolStripMenuItem.Click += bookDeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 54);
            toolStripMenuItem1.Text = "View All Users";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Wheat;
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, closeApplicationToolStripMenuItem });
            exitToolStripMenuItem.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(102, 54);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(217, 28);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // closeApplicationToolStripMenuItem
            // 
            closeApplicationToolStripMenuItem.Image = (Image)resources.GetObject("closeApplicationToolStripMenuItem.Image");
            closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            closeApplicationToolStripMenuItem.Size = new Size(217, 28);
            closeApplicationToolStripMenuItem.Text = "Close Application";
            closeApplicationToolStripMenuItem.Click += closeApplicationToolStripMenuItem_Click;
            // 
            // dashbord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1427, 609);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "dashbord";
            Text = "dashbord";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem bookDeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem closeApplicationToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}