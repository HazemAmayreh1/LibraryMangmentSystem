using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BookMehtods : Form
    {
        LibraryContext ctx = new LibraryContext();

        public BookMehtods()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bookId;
            if (int.TryParse(textBox2.Text, out bookId))
            {
                string newStatus = comboBox1.Text;

                bool result = UpdateBookStatus(bookId, newStatus);
                if (result)
                {
                    MessageBox.Show("Book status updated successfully.");
                    var book = ctx.Books.Where(b => b.Status == newStatus).SingleOrDefault();

                    string bookDetails = $" Status: {book.Status}";

                    richTextBox1.Text = bookDetails;
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid book ID.");
            }
            richTextBox1.Text = " ";


        }
        public bool UpdateBookStatus(int bookId, string newStatus)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Find(bookId);

                if (book != null)
                {
                    book.Status = newStatus;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(textBox3.Text);
            var book = ctx.Books.SingleOrDefault(b => b.id_book == bookId && b.Status == "Available");

            if (book != null)
            {
                book.Status = "Unavailable";
                var books = ctx.Books.Where(b => b.Status == textBox1.Text).SingleOrDefault();

                string bookDetails = $" Status: {book.Status}";
                ctx.SaveChanges();

                richTextBox2.Text = bookDetails;

            }
            else
            {
                MessageBox.Show("no book  Available");
            }
        }
    }
}
