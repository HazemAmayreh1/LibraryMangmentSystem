using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class userdashbord : Form
    {
        public userdashbord()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            login log = new login();
            log.ShowDialog();
        }

        private void userdashbord_Load(object sender, EventArgs e)
        {

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookInUsers vbu = new ViewBookInUsers();
            vbu.ShowDialog();
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBorrowBook ubb = new UserBorrowBook();
            ubb.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserAccount ua = new UserAccount();
            ua.ShowDialog();
        }
    }
}
