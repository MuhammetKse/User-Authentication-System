using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Authentication_System
{
    public partial class registeredform : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B6GKBCE\\SQLEXPRESS; Initial Catalog=UserDB; Integrated Security=TRUE");
        public registeredform()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.White;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
                txtusername.ForeColor = Color.Silver;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

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

        char? none = null;
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.Silver;
                txtpassword.PasswordChar = Convert.ToChar(none);
            }
        }

        

        private void registeredform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void registeredform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void registeredform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void txtrepassword_Enter(object sender, EventArgs e)
        {

            if (txtrepassword.Text == "rePassword")
            {
                txtrepassword.Text = "";
                txtrepassword.ForeColor = Color.White;
                txtrepassword.PasswordChar = '*';
            }
        }

        private void txtrepassword_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (txtrepassword.Text == "")
            {
                txtrepassword.Text = "rePassword";
                txtrepassword.ForeColor = Color.Silver;
                txtrepassword.PasswordChar = Convert.ToChar(none);
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "email";
                txtemail.ForeColor = Color.Silver;
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "phone";
                txtphone.ForeColor = Color.Silver;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "phone")
            {
                txtphone.Text = "";
                txtphone.ForeColor = Color.White;
            }
        }

        private void btnsgnup_Click(object sender, EventArgs e)
        {


            connection.Open();

            SqlCommand command = new SqlCommand("Insert into tblLogin (username,password,re_password,e_mail,phone) values ('"+cryptology.enc (txtusername.Text,2)+"','"+ cryptology.enc(txtpassword.Text,2)+"','"+cryptology.enc (txtrepassword.Text,2)+"','"+ cryptology.enc (txtemail.Text,2)+"','"+ cryptology.enc (txtphone.Text,2)+"')",connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Sign Up");
        }
    }
}
 