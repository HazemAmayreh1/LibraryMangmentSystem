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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class Query : Form
    {
        LibraryContext ctx = new LibraryContext();
        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var book = ctx.Books.Where(b => b.ISBN == textBox8.Text).SingleOrDefault();
            if (book != null)
            {
                string bookDetails = $"Title: {book.Title}\nAuthor: {book.Author}\nISBN: {book.ISBN}\nPublication: {book.Publication}\nStatus: {book.Status}";

                richTextBox1.Text = bookDetails;

            }
            else
            {
                richTextBox1.Text = "No book found with the given ISBN.";

            }
            textBox8.Text = " ";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var count = ctx.Books.Count(b => b.Author == textBox1.Text);
            if (count != null)
            {
                richTextBox2.Text = count.ToString() + " Book to " + " " + textBox1.Text;

            }
            textBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var userWithMostBooks = ctx.Books
                .Where(b => b.Status == "Unavailable")
                .GroupBy(b => b.UserId)
                .Select(a => new { UserId = a.Key, BookCount = a.Count() })
                .OrderByDescending(g => g.BookCount)
                .FirstOrDefault();

            if (userWithMostBooks != null && userWithMostBooks.UserId.HasValue)
            {
                var user = ctx.Users.Find(userWithMostBooks.UserId.Value);
                MessageBox.Show(user != null ? user.ID.ToString() : "User not found");
            }
            else
            {
                MessageBox.Show("No borrowed books found or no users found.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int lostBooksCount = ctx.Books.Count(b => b.Status == "Lost" );
            int lateBooksCount = ctx.Books
                   .Count(br => br.Status == "Returned Late" );
            decimal fine = lostBooksCount * 5m + lateBooksCount * 3m;
            MessageBox.Show("This is the Final Amount in All " + fine);


        }
    }
}
