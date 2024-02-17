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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class login : Form
    {
        LibraryContext ctx = new LibraryContext();
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                User user = new User()
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                MessageBox.Show(" is successfully. Your id =" + user.ID.ToString());
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
            if (radioButton2.Checked == true)
            {
                Librarian librarians = new Librarian()
                {
                    Name = textBox1.Text,
                    Password = textBox2.Text,
                };
                ctx.Librarians.Add(librarians);
                ctx.SaveChanges();
                MessageBox.Show(" is successfully. Your id =" + librarians.ID.ToString());
                textBox1.Text = " ";
                textBox2.Text = " ";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                var a = ctx.Librarians.FirstOrDefault(a2 => a2.Name == textBox1.Text && a2.Password == textBox2.Text && a2.ID == Convert.ToInt32(textBox3.Text));
                if (a != null)
                {
                    this.Hide();
                    dashbord das = new dashbord();
                    das.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login failed, try again!!");
                }

            }


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button2.Visible = true;
                button1.Visible = false;
                button4.Visible = false;
                textBox3.Visible = false;
                panel3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                button1.Visible = false;
                textBox3.Visible = true;
                panel3.Visible = true;
                button2.Visible = false;
                button4.Visible = false;

            }
        }

        private void login_Load_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && radioButton3.Checked)
            {
                button4.Visible = true;
                button1.Visible = false;
                button2.Visible = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && radioButton3.Checked)
            {
                button4.Visible = false;
                button1.Visible = true;
                button2.Visible = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var lib = ctx.Users.FirstOrDefault(a2 => a2.Username == textBox1.Text && a2.Password == textBox2.Text && a2.ID == Convert.ToInt32(textBox3.Text));
            if (lib != null)
            {
                this.Hide();
                userdashbord userdas = new userdashbord();
                userdas.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login failed, try again!!");
            }

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Id")
            {
                textBox3.Clear();

            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                User user = new User()
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                MessageBox.Show(" is successfully. Your id =" + user.ID.ToString());
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
            if (radioButton2.Checked == true)
            {
                Librarian librarians = new Librarian()
                {
                    Name = textBox1.Text,
                    Password = textBox2.Text,
                };
                ctx.Librarians.Add(librarians);
                ctx.SaveChanges();
                MessageBox.Show(" is successfully. Your id =" + librarians.ID.ToString());
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                var a = ctx.Librarians.FirstOrDefault(a2 => a2.Name == textBox1.Text && a2.Password == textBox2.Text && a2.ID == Convert.ToInt32(textBox3.Text));
                if (a != null)
                {
                    this.Hide();
                    dashbord das = new dashbord();
                    das.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login failed, try again!!");
                }

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            var lib = ctx.Users.FirstOrDefault(a2 => a2.Username == textBox1.Text && a2.Password == textBox2.Text && a2.ID == Convert.ToInt32(textBox3.Text));
            if (lib != null)
            {
                this.Hide();
                userdashbord userdas = new userdashbord();
                userdas.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login failed, try again!!");
            }
        }
    }
}
