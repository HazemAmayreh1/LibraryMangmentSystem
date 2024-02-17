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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class ReturnBook : Form
    {
        LibraryContext ctx = new LibraryContext();
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                int bookId = Convert.ToInt32(textBox1.Text);
                int userId = Convert.ToInt32(textBox2.Text);
                var book = ctx.Books.SingleOrDefault(b => b.id_book == bookId);


                if (book.UserId == userId)
                {
                    if(radioButton1.Checked)
                    {
                        book.Status = "Lost";
                        MessageBox.Show($"Book ID {bookId} has been lost.");
                    }
                    
                    else if (DateTime.Now > book.datatimereturnd)
                    {
                        
                        book.Status = "Returned Late";
                        MessageBox.Show($"Book ID {bookId} has been late.");
                    }
                    else 
                    {

                        book.Status = "Available";
                        MessageBox.Show($"Book ID {bookId} has been Returnd.");
                    }
                   
                    ctx.SaveChanges();

                   
                }
                else
                {
                    MessageBox.Show("Book  Available.");
                }
            



        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != string.Empty)
            {
                int userId = Convert.ToInt32(textBox1.Text);
                var borrowedBooks = ctx.Books
                  .Where(b => b.UserId == userId)
                  .Select(b => new { b.id_book, b.Status, b.datatimeborrowd, b.datatimereturnd })
                  .ToList();
                dataGridView2.DataSource = borrowedBooks;
            }
            else
                MessageBox.Show("Unter you ID Plz");

           
        }
    }
}
