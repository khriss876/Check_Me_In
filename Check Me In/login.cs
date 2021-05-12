using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Me_In
{
    public partial class login : Form
    {
        private readonly checkMeInDBEntities checkMeInDB;
        public login()
        {
            InitializeComponent();
            checkMeInDB = new checkMeInDBEntities();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {

                SHA256 sha = SHA256.Create();

                var UserName = textBox_UserName.Text.Trim();
                var Password = textBox_PW.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i= 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();

                var user = checkMeInDB.Users.FirstOrDefault(q => q.UserName == UserName && q.Password == Password);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var mainwindow = new main_window(this);
                    mainwindow.Show();
                    Hide();
                }
            }
            catch (Exception )
            {

                MessageBox.Show("Error!!!! either password or user name is incorret");
            }
        }
    }
}
