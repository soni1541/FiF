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
    public partial class level_1 : Form
    {
        int count_error;
        menu m;

        Database_Query dq;

        int count_nuts_append;

        public level_1(menu m_input)
        {
            InitializeComponent();

            label_bool_answer.Hide();
            label_help.Hide();
            button_next_level.Hide();

            dq = new Database_Query();
            m = m_input;
            count_nuts_append = 3;

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            count_error = 0;
            

            pictureBox_belka.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            string text_riddle =
                "Она собою хороша. \n" +
                "Её шубеечка рыжа, \n" +
                "Пушистый хвостик \n" +
                "Тоже рыж \n" +
                "И симпатичен. \n" +
                "Только лишь \n" +
                "Живёт рыжуха \n" +
                "Не в норе - \n" +
                "Живёт на дереве, \n" +
                "В дупле. \n";

            label_riddle.Text = text_riddle;

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            string correct_answer_to_riddle = "Белка";

            string answer_to_riddle = text_box_answer.Text;

            if (answer_to_riddle.Length == 0)
            {
                label_bool_answer.Text = "Введи ответ";
            }
            else
            {
                if (answer_to_riddle.ToLower() == correct_answer_to_riddle.ToLower())
                {
                    button_next_level.Show();
                    label_bool_answer.Text = "Правильно! Молодец!";
                    dq.update_level(m.get_id());
                    dq.update_count_nuts(m.get_id(), count_nuts_append);
                    label_count_nuts.Text += " +" + count_nuts_append.ToString();
                }
                else
                {
                    ++count_error;

                    if (count_error >= 3)
                    {
                        label_help.Text = "Слово начинается на букву Б. В слове 5 букв";
                    }
                    
                    label_bool_answer.Text = "Ответ неверен. Попробуй еще разок";
                }
            }
            label_bool_answer.Show();
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
            label_help.Text = "Слово начинается на букву Б. В слове 5 букв";
            label_help.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            m.update_menu();
            m.Show();
        }

        private void button_next_level_Click(object sender, EventArgs e)
        {
            level_2 l2 = new level_2(m);
            l2.Show();
            this.Hide();
        }
    }
}
