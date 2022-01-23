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
using System.Security.Cryptography;

namespace FuF
{
    public partial class main : Form
    {
        static string connection_string = @"Data Source=.\SQLEXPRESS; Initial Catalog=game; Integrated Security=True";
        SqlConnection connection = new SqlConnection(connection_string);

        string left_salt;
        string right_salt;

        int id_user;

        public main()
        {
            InitializeComponent();
            left_salt = "5kj92";
            right_salt = "008gg";
            id_user = -1;
        }

        private void Xback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email_input = tb_email.Text;
            string password_input = tb_password.Text;

            if(email_input.Length == 0 && password_input.Length == 0)
            {
                er_val.Text = "Все поля должны быть заполнены";
                return;
            }
            else if(email_input.Length == 0)
            {
                er_val.Text = "Введите email";
                return;
            }
            else if (password_input.Length == 0)
            {
                er_val.Text = "Введите пароль";
                return;
            }

            password_input = left_salt + password_input + right_salt;
            password_input = GetMD5Hash(password_input);

            string SqlExpression = "SELECT user_id, email, password" +
                " FROM users";
            connection.Open();
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            var dt = command.ExecuteReader();

            int count = 0;
            bool pass_ok = false;
            for (; dt.Read();)
            {
                string email_table = dt.GetValue(1).ToString();
                if(email_input == email_table)
                {
                    id_user = Convert.ToInt32(dt.GetValue(0).ToString());
                    ++count;
                    string password_table = dt.GetValue(2).ToString();
                    if(password_input == password_table)
                    {
                        pass_ok = true;
                    }
                }
            }
            connection.Close();

            if(count == 0 || !pass_ok)
            {
                er_val.Text = "Неверный логин или пароль"; 
            }
            else if(count != 1)
            {
                er_val.Text = "У тебя есть двойник";
            }
            else
            {
                er_val.Text = "Всё ОК))))))";
                menu m = new menu(id_user);
                m.Show();
                this.Hide();
            }
        }
        private static string GetMD5Hash(string text)
        {
            using (var hashAlg = MD5.Create()) // Создаем экземпляр класса реализующего алгоритм MD5
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text)); // Хешируем байты строки text
                var builder = new StringBuilder(hash.Length * 2); // Создаем экземпляр StringBuilder. Этот класс предназначен для эффективного конструирования строк
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2")); // Добавляем к строке очередной байт в виде строки в 16-й системе счисления
                }
                return builder.ToString(); // Возвращаем значение хеша
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            registration r = new registration(this);
            r.Show();
            this.Hide();
        }
    }
}
