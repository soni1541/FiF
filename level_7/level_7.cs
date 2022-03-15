using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuF
{
    public partial class level_7 : Form
    {
        Riddle riddle_final;
        Riddle riddle_help;
        int count_error;

        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;
        public level_7(menu m_input)
        {
            InitializeComponent();

            m = m_input;
            dq = new Database_Query();

            count_nuts_on_level = 0;

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            label_final.Hide();
            label_help.Hide();

            pictureBox_belka.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            count_error = 0;

            string text = "Мягкий внутри,\n" +
                          "Жёсткий снаружи,\n" + 
                          "Его грызть всегда\n" +
                          "Белочки любят!";

            string answer = "Орех";

            riddle_final = new Riddle(text, answer);

            label_riddle.Text = riddle_final.get_text();

            string text_help = "Хоть он совсем не хрупкий,"+ "\n" +
                                "А спрятался в скорлупке." + "\n" +
                                "Заглянешь в серединку -" + "\n" +
                                "Увидишь сердцевинку." + "\n" +
                                "Из плодов он твёрже всех," + "\n" +
                                "Называется...";

            riddle_help = new Riddle(text_help, answer);
            
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string input_answer = textBox_input_answer.Text;
            label_final.Show();
            if (input_answer.Length == 0)
            {
                label_final.Text = "Введи ответ";
            }
            else if (input_answer.Split(' ').Count() != 1)
            {
                label_final.Text = "Ответ на загадку должен содержать только одно слово";
            }
            else
            {
                if (input_answer.ToLower() == riddle_final.get_answer().ToLower())
                {
                    
                    label_final.Text = "Правильно! Молодец!\n" +
                                       "Ты прошёл все уровни)";
                    count_nuts_on_level += 5;
                    dq.update_level(m.get_id());
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                }
                else
                {
                    ++count_error;

                    if (count_error >= 3)
                    {
                        label_help.Show();
                        label_help.Text = riddle_help.get_text();
                    }

                    label_final.Text = "Ответ неверен. Попробуй еще разок";
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            m.update_menu();
            m.Show();
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Xback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_belka_Click(object sender, EventArgs e)
        {
            label_help.Show();
            label_help.Text = riddle_help.get_text();
        }
    }
}
