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
    public partial class ViewBook : Form
    {
        LibraryContext ctx = new LibraryContext();


        public ViewBook()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                try
                {
                    int id = int.Parse(textBox8.Text);
                    string Title = textBox7.Text;
                    string Author = textBox2.Text;
                    string ISBN = textBox3.Text;
                    string Publication = textBox5.Text;
                    string Status = comboBox1.Text;
                    int librariansID = int.Parse(textBox6.Text);

                    UpdateBook(id, Title, Author, ISBN, Publication, Status, librariansID);
                    MessageBox.Show("Book updated successfully.");
                    dataGridView1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                textBox8.Text =" ";
                textBox7.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";
                comboBox1.Text = " ";
                textBox6.Text = " ";
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            textBox8.Text = Convert.ToString(dataGridView1[0, row].Value);
            textBox7.Text = Convert.ToString(dataGridView1[1, row].Value);
            textBox2.Text = Convert.ToString(dataGridView1[2, row].Value);
            textBox3.Text = Convert.ToString(dataGridView1[3, row].Value);
            textBox5.Text = Convert.ToString(dataGridView1[4, row].Value);
            comboBox1.Text = Convert.ToString(dataGridView1[5, row].Value);
            textBox6.Text = Convert.ToString(dataGridView1[6, row].Value);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadBooksIntoDataGridView()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            var list = ctx.Books.Take(1000).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.DataSource = ctx.Books
                 .Select(b => new { b.id_book, b.Title, b.Author, b.ISBN, b.Publication, b.Status, b.librariansID ,b.UserId,b.datatimeborrowd,b.datatimereturnd})
                 .ToList();



        }
        private void UpdateBook(int id, string Title, string Author, string ISBN, string Publication, string status ,int librariansID)
        {
                var book = ctx.Books.Find(id);

                if (book != null)
                {
                    book.id_book = id;
                    book.Title = Title;
                    book.Author = Author;
                    book.ISBN = ISBN;
                    book.Publication = Publication;
                    book.Status=status;
                    book.librariansID = librariansID;

                    ctx.SaveChanges();
                }
                else
                {
                    throw new Exception("Book not found.");
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedBookId =Convert.ToInt32(textBox8.Text);

            try
            {
                DeleteBook(selectedBookId);
                MessageBox.Show("Book Deleted Successfully.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            textBox8.Text = " ";
            textBox7.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox5.Text = " ";
            comboBox1.Text = " ";
            textBox6.Text = " ";
        }
        public void DeleteBook(int bookId)
        {
            
                var book = ctx.Books.Find(bookId);

                if (book != null)
                {
                    
                    ctx.Books.Remove(book);
                    ctx.SaveChanges();
                    dataGridView1.Refresh();
                }
                else
                {
                    throw new Exception("Book not found.");
                }
            
        }
    }
}
