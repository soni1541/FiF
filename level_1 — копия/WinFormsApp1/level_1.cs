using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class level_1 : Form
    {
        int count_error;

        public level_1()
        {
            InitializeComponent();

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
                    label_bool_answer.Text = "Правильно! Молодец!";
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
        }
    }
}
