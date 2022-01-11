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

namespace level_4
{
    public partial class level_4 : Form
    {
        private string path_to_file;
        private int count_riddles;

        private List<Riddle> riddles;
        private List<Riddle> riddles_rand;
        
        public level_4()
        {
            InitializeComponent();

            pictureBox_belka.Load("belka.png");
            
            path_to_file = "riddles.txt";
            count_riddles = 5;

            riddles = Riddle.read_riddles_from_file(path_to_file);

            riddles_rand = Riddle.get_random_count_riddles(riddles, count_riddles);
            
            for (int idx = 0; idx < count_riddles; ++idx)
            {
                Label label_riddle = new Label();
                label_riddle.Location = new Point(55, 35 + 30 * idx);
                label_riddle.AutoSize = true;
                label_riddle.Text = riddles_rand[idx].get_text();
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

                label_final.Text = "Всё правильно! Молодец! Возьми с полки пирожек";
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
                
            label_final.Text = help;
        }
    }
}
