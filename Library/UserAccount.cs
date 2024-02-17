using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class UserAccount : Form
    {
        LibraryContext ctx = new LibraryContext();

        public UserAccount()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int userid = Convert.ToInt32(textBox1.Text);
            
                int borrowedBooksCount = ctx.Books.Count(b => b.UserId == userid && b.Status == "Unavailable");
                MessageBox.Show("This is Number of borrow Book = " + borrowedBooksCount);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Number of Book Lating = " + CountLateBook());
        }
        public int CountLateBook()
        {
            int userid = Convert.ToInt32(textBox1.Text);
            
                int lateBooksCount = ctx.Books
                    .Count(br => br.Status == "Returned Late" && br.UserId == userid );
                return lateBooksCount;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    int userId = Convert.ToInt32(textBox1.Text);
                    int returnedBooksCount = ctx.Books
                        .Count(br => br.UserId == userId && br.datatimereturnd != null);

                    MessageBox.Show("Number of Returned Books: " + returnedBooksCount);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid User ID.");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a User ID.");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Number of Lost Book = " + CountLostBooks());
        }
        public int CountLostBooks()
        {
            int userid = Convert.ToInt32(textBox1.Text);
                int lostBooksCount = ctx.Books.Count(b => b.Status == "Lost" && b.UserId == userid);
                return lostBooksCount;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox1.Text);
            int lostBooksCount = ctx.Books.Count(b => b.Status == "Lost" && b.UserId == userid);
            int lateBooksCount = ctx.Books
                   .Count(br => br.Status == "Returned Late" && br.UserId == userid);
            decimal fine = lostBooksCount * 5m + lateBooksCount * 3m;
            MessageBox.Show("The Fine = " + fine);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
