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
    public partial class AddBooks : Form
    {
        LibraryContext ctx = new LibraryContext();
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && textBox6.Text != "")
            {
                Book book = new Book()
                {
                    Title = textBox1.Text,
                    Author = textBox2.Text,
                    ISBN = textBox3.Text,
                    Publication = textBox4.Text,
                    Status = comboBox1.Text,
                    librariansID = Convert.ToInt32(textBox6.Text),
                   

                };

                ctx.Books.Add(book);
                ctx.SaveChanges();
                MessageBox.Show("Book Adedd");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                comboBox1.Text = " ";
                textBox6.Text = " ";
            }
            else
            MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
