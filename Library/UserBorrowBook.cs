using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserBorrowBook : Form
    {
        LibraryContext ctx = new LibraryContext();
        public UserBorrowBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


                int bookId = Convert.ToInt32(textBox8.Text);
                int userId = Convert.ToInt32(textBox1.Text);
                var book = ctx.Books.SingleOrDefault(b => b.id_book == bookId);


                if (book.Status == "Available")
                {
                    book.datatimeborrowd = DateTime.Now;
                    book.datatimereturnd = dateTimePicker1.Value;
                    book.UserId = userId;
                    book.Status = "Unavailable";
                    ctx.SaveChanges();

                    MessageBox.Show($"Book ID {bookId} has been borrowed.");
                }
                else
                {
                    MessageBox.Show("Book is not available for borrowing or does not exist.");
                }
            

        }


        private void button3_Click(object sender, EventArgs e)
        {
            var list = ctx.Books.Take(1000).ToList();
            dataGridView2.DataSource = list;
            dataGridView2.DataSource = ctx.Books
                 .Select(b => new { b.id_book, b.Status })
                 .ToList();
            if (textBox1.Text!=string.Empty)
            {
                int userId = Convert.ToInt32(textBox1.Text);
                var borrowedBooks = ctx.Books
                  .Where(b =>b.UserId == userId)
                  .Select(b => new { b.id_book, b.Status, b.datatimeborrowd , b.datatimereturnd })
                  .ToList();
                dataGridView1.DataSource = borrowedBooks;
            }
            else
                MessageBox.Show("Unter you ID Plz");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
