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
    public partial class ViewBookInUsers : Form
    {
        LibraryContext ctx = new LibraryContext();
        public ViewBookInUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = ctx.Books.Take(1000).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.DataSource = ctx.Books
                 .Select(b => new { b.id_book, b.Title, b.Author, b.ISBN, b.Publication, b.Status })
                 .ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
