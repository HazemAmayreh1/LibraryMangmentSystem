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
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            login log = new login();
            log.ShowDialog();
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks addbooks = new AddBooks();
            addbooks.ShowDialog();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.ShowDialog();

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.ShowDialog();
        }

        private void bookDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookMehtods bm = new BookMehtods();
            bm.ShowDialog();
        }

        private void ubdateStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAllUsers val = new ViewAllUsers();
            val.ShowDialog();   
        }
    }
}
