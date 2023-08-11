using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace testApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Введите имя";
           
            UserPasswordField.Text = "Введите пароль";
        }

        private void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Введите имя")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.Black;
            }
           
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.ForeColor = Color.Black;
                UserPasswordField.UseSystemPasswordChar = true;
            }

        }
        private void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Введите имя";
                UserLoginField.ForeColor = Color.Gray;
            }
           
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите пароль";
                UserPasswordField.ForeColor = Color.Gray;
                UserPasswordField.UseSystemPasswordChar = false;
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPasswordField_TextChanged(object sender, EventArgs e)
        {

        }


        private void UserEmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Введите имя")
            {
                MessageBox.Show("Вы не ввели имя");
                return;

            }
            
            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Введите пароль")
            {
                MessageBox.Show("Вы не ввели пароль");
                return;

            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM users WHERE login = @login AND password = @password", db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            
            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            db.OpenConnection();

            int countUser = Convert.ToInt32(command.ExecuteScalar());
            if (countUser > 0)
            {
                this.Hide();
                PingPong pingPong = new PingPong();
                pingPong.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("User does not exists");


            db.CloseConnection();


        }
        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }

        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Close();
        }
    }

}
