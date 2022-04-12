using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace FuF
{
    public partial class registration : Form
    {
        main win_m;
        static string connection_string = @"Data Source=.\SQLEXPRESS; Initial Catalog=game; Integrated Security=True";
        SqlConnection connection = new SqlConnection(connection_string);
        string left_salt;
        string right_salt;

        public registration(main m)
        {
            InitializeComponent();
            win_m = m;
            left_salt = "5kj92";
            right_salt = "008gg";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            win_m.Show();
            this.Close();
        }

        private void button_reg_insert_Click(object sender, EventArgs e)
        {
            string email_reg_input = tb_email_reg.Text;
            string password_reg1_input = tb_password_reg1.Text;
            string password_reg2_input = tb_password_reg2.Text;

            if (email_reg_input.Length == 0 ||
               password_reg1_input.Length == 0 || password_reg2_input.Length == 0)
            {
                er_val.Text = "Все поля должны быть заполнены";
                return;
            }

            if (email_reg_input.IndexOf('@') == -1 || email_reg_input.IndexOf('.') == -1)
            {
                er_val.Text = "Email некорректен";
                return;
            }

            if (password_reg1_input.Length < 8)
            {
                er_val.Text = "Пароль должен быть более 8 символов";
                return;
            }

            if (password_reg1_input != password_reg2_input)
            {
                er_val.Text = "Пароли должны совпадать";
                return;
            }

            string sql_expression = "INSERT INTO users (email, password, email_verified_at)" +
                " VALUES(@em, @pw, GETDATE())";

            password_reg1_input = left_salt + password_reg1_input + right_salt;
            password_reg1_input = GetMD5Hash(password_reg1_input);

            connection.Open();
            SqlCommand command = new SqlCommand(sql_expression, connection);
            SqlParameter em_param = new SqlParameter("@em", email_reg_input);
            SqlParameter pw_param = new SqlParameter("@pw", password_reg1_input);
            command.Parameters.Add(em_param);
            command.Parameters.Add(pw_param);
            int count_set = command.ExecuteNonQuery();
            connection.Close();
            if(count_set == 1)
            {
                er_val.Text = "Регистрация прошла успешно";
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

        private void Xback_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
