using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;

namespace User_Authentication_System
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS; Initial Catalog=UserDB; Integrated Security=TRUE");
        registeredform register = new registeredform();
        public Form1()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
                txtusername.ForeColor = Color.Silver;
            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.White;
            }
        }
        char? none = null;
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Silver;
                txtpassword.PasswordChar = Convert.ToChar(none);
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.White;
                txtpassword.PasswordChar = '*';
            }
        }
        bool isThere;
        private void btnlogin_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            string password = txtpassword.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select *from tblLogin", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (username == cryptology.dec(reader["username"].ToString().TrimEnd(), 2) && password == cryptology.dec(reader["password"].ToString().TrimEnd(), 2))
                {
                    isThere = true;

                    break;

                }

                else

                {

                    isThere = false;

                }
            }
            connection.Close();
            if (isThere)
            {

                MessageBox.Show("You have successfully logged in");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }



        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.ShowDialog();
        }
    }
}
