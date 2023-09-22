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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            UserEmailField.Text = "Введите новый email";

            UserPasswordField.Text = "Введите новый пароль";
        }


        private void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Введите новый email")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.Black;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Введите новый пароль")
            {
                UserPasswordField.Text = "";
                UserPasswordField.ForeColor = Color.Black;
                UserPasswordField.UseSystemPasswordChar = true;
            }

        }
        private void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Введите новый email";
                UserEmailField.ForeColor = Color.Gray;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Введите новый пароль";
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

        private void UserLoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (UserEmailField.Text.Trim() == "" || UserEmailField.Text.Trim() == "Введите новый email")
            {
                MessageBox.Show("Вы не ввели новый email");
                return;

            }
            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Введите новый пароль")
            {
                MessageBox.Show("Вы не ввели новый пароль");
                return;

            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `email` = @email, `password` = @password WHERE `users`.`login` = 'admin'", db.GetConnection());
            command.Parameters.AddWithValue("email", UserEmailField.Text);

            command.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                AuthButton.Text = "Готово";
                UserEmailField.Text = "";
                UserPasswordField.Text = "";
                MessageBox.Show("Данные изменены");
            }
            else MessageBox.Show("Логина 'админ' не существует");
            db.CloseConnection();
            UserEmailField.Text = "";
            UserPasswordField.Text = "";


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

    

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
}
