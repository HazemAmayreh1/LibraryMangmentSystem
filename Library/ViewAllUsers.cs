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
    public partial class ViewAllUsers : Form
    {
        LibraryContext ctx = new LibraryContext();
        public ViewAllUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Users
                 .Select(u => new {u.ID, u.Username, u.Password})
                 .ToList();
        }
    }
}
