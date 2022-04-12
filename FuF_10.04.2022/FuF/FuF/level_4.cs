using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace FuF
{
    public partial class level_4 : Form
    {
        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;

        private string path_to_file;
        private int count_riddles;

        private List<Riddle> riddles;
        private List<Riddle> riddles_rand;
        
        public level_4(menu m_input)
        {
            InitializeComponent();

            m = m_input;
            dq = new Database_Query();

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();
            pictureBox_nut.Load("nut.png");
            pictureBox_belka.Load("belka.png");

            label_final.Hide();

            btn_next_level.Hide();
            
            path_to_file = "riddles.txt";
            count_riddles = 5;

            riddles = Riddle.read_riddles_from_file(path_to_file);

            riddles_rand = Riddle.get_random_count_riddles(riddles, count_riddles);
            
            for (int idx = 0; idx < count_riddles; ++idx)
            {
                Label label_riddle = new Label();
                label_riddle.Location = new Point(55, 100 + 35 * idx);
                label_riddle.AutoSize = true;
                label_riddle.Text = riddles_rand[idx].get_text();
                label_riddle.Font = new Font(label_riddle.Font.Name, 13);
                Controls.Add(label_riddle);
            }
            
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            
            if (
                (textBox_answer1.Text.ToLower() == riddles_rand[0].get_answer().ToLower()) && 

                (textBox_answer2.Text.ToLower() == riddles_rand[1].get_answer().ToLower()) &&

                (textBox_answer3.Text.ToLower() == riddles_rand[2].get_answer().ToLower()) &&

                (textBox_answer4.Text.ToLower() == riddles_rand[3].get_answer().ToLower()) &&

                (textBox_answer5.Text.ToLower() == riddles_rand[4].get_answer().ToLower())
              )
            {
                label_final.Show();
                label_final.Text = "Всё правильно! Молодец! Возьми с полки пирожек";
                count_nuts_on_level += 5;
                dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                btn_next_level.Show();
                dq.update_level(m.get_id());

            }
            else
            {
                if(textBox_answer1.Text.Split(' ').Count() != 1 ||
                textBox_answer2.Text.Split(' ').Count() != 1 ||
                textBox_answer3.Text.Split(' ').Count() != 1 ||
                textBox_answer4.Text.Split(' ').Count() != 1 ||
                textBox_answer5.Text.Split(' ').Count() != 1)
                {
                    label_final.Text = "Ответ на загадку должен содержать только одно слово";
                }

                else if(textBox_answer1.Text.Length == 0 ||
                        textBox_answer2.Text.Length == 0 ||
                        textBox_answer3.Text.Length == 0 ||
                        textBox_answer4.Text.Length == 0 ||
                        textBox_answer5.Text.Length == 0)
                {
                    label_final.Text = "Ответь на все загадки. Попробуй еще раз";
                }
                else
                {
                    label_final.Text = "Попробуй ответить ещё раз";
                }
                    
            }
            
        }

        private void pictureBox_belka_Click(object sender, EventArgs e)
        {
            string help = "";
            for (int idx = 0; idx < count_riddles; ++idx)
            {
                Random rnd = new Random();
                string word = string.Join("", riddles_rand[idx].get_answer().ToLower().OrderBy(x => rnd.Next()));
                help += word + "\n";
            }
            label_final.Show();    
            label_final.Text = help;
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

        private void btn_next_level_Click(object sender, EventArgs e)
        {
            level_5 l5 = new level_5(m);
            l5.Show();
            this.Close();
        }
    }
}
