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
    public partial class level_3 : Form
    {
        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;

        List<string> dictionary_for_level;
        List<string> dictionary_with_letter;
        List<char> chars_upper;
        List<int> idxs_corrects_answer;

        public level_3(menu m_input)
        {
            InitializeComponent();

            m = m_input;
            dq = new Database_Query();

            count_nuts_on_level = 0;

            pictureBox1.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            pictureBox_result_word1.Hide();
            pictureBox_result_word2.Hide();
            pictureBox_result_word3.Hide();
            pictureBox_result_word4.Hide();
            pictureBox_result_word5.Hide();

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            label_result.Hide();
            btn_next_level.Hide();
            label_help.Hide();

            String path_to_file = "dictionary.txt";

            string[] dictionary_from_file = File.ReadAllLines(path_to_file);

            Random rnd = new Random();
            int count_words_for_level = 5;
            int random_key_word;

            dictionary_for_level = new List<string>(count_words_for_level);

            for (int idx = 0; idx < count_words_for_level; ++idx)
            {
                random_key_word = rnd.Next(0, dictionary_from_file.Count());
                dictionary_for_level.Add(dictionary_from_file[random_key_word]);
            }

            dictionary_with_letter = new List<string>(dictionary_for_level);
            

            string[] chars_variants = File.ReadAllLines("letters.txt");

            chars_upper = new List<char>();

            for (int i = 0; i < count_words_for_level; ++i)
            {
                dictionary_with_letter[i] = dictionary_for_level[i];
                for (int idx_l = 0; idx_l < dictionary_for_level[i].Length; ++idx_l)
                {
                    if (char.IsUpper(dictionary_for_level[i][idx_l]))
                    {
                        chars_upper.Add(dictionary_for_level[i][idx_l]);
                        string word_has_not_letter = dictionary_for_level[i].Replace(dictionary_for_level[i][idx_l], '_');
                        dictionary_for_level[i] = word_has_not_letter;
                    }
                }
            }

            word1.Text = dictionary_for_level[0];
            word2.Text = dictionary_for_level[1];
            word3.Text = dictionary_for_level[2];
            word4.Text = dictionary_for_level[3];
            word5.Text = dictionary_for_level[4];

            char char1 = chars_upper[0];
            char char2 = chars_upper[1];
            char char3 = chars_upper[2];
            char char4 = chars_upper[3];
            char char5 = chars_upper[4];

            idxs_corrects_answer = new List<int>();

            for (int j = 0; j < chars_variants.Length; ++j)
            {
                if (chars_variants[j].Contains(char1))
                {
                    for (int i = 0; i < chars_variants[j].Length; ++i)
                    {
                        cbox_word1.Items.Add(chars_variants[j][i]);
                        if (chars_variants[j][i] == char1)
                        {
                            idxs_corrects_answer.Add(i);
                        }
                    }
                    cbox_word1.Items.Add("Пусто");
                    break;
                }
            }
            for (int j = 0; j < chars_variants.Length; ++j)
            {
                if (chars_variants[j].Contains(char2))
                {
                    for (int i = 0; i < chars_variants[j].Length; ++i)
                    {
                        cbox_word2.Items.Add(chars_variants[j][i]);
                        if (chars_variants[j][i] == char2)
                        {
                            idxs_corrects_answer.Add(i);
                        }
                    }
                    cbox_word2.Items.Add("Пусто");
                    break;
                }
            }
            for (int j = 0; j < chars_variants.Length; ++j)
            {
                if (chars_variants[j].Contains(char3))
                {
                    for (int i = 0; i < chars_variants[j].Length; ++i)
                    {
                        cbox_word3.Items.Add(chars_variants[j][i]);
                        if (chars_variants[j][i] == char3)
                        {
                            idxs_corrects_answer.Add(i);
                        }
                    }
                    cbox_word3.Items.Add("Пусто");
                    break;
                }
            }
            for (int j = 0; j < chars_variants.Length; ++j)
            {
                if (chars_variants[j].Contains(char4))
                {
                    for (int i = 0; i < chars_variants[j].Length; ++i)
                    {
                        cbox_word4.Items.Add(chars_variants[j][i]);
                        if (chars_variants[j][i] == char4)
                        {
                            idxs_corrects_answer.Add(i);
                        }
                    }
                    cbox_word4.Items.Add("Пусто");
                    break;
                }
            }
            for (int j = 0; j < chars_variants.Length; ++j)
            {
                if (chars_variants[j].Contains(char5))
                {
                    for (int i = 0; i < chars_variants[j].Length; ++i)
                    {
                        cbox_word5.Items.Add(chars_variants[j][i]);
                        if (chars_variants[j][i] == char5)
                        {
                            idxs_corrects_answer.Add(i);
                        }
                    }
                    cbox_word5.Items.Add("Пусто");
                    break;
                }
            }

            cbox_word1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word5.DropDownStyle = ComboBoxStyle.DropDownList;

            //cbox_word1.SelectedIndex = 0;
            //cbox_word2.SelectedIndex = 0;
            //cbox_word3.SelectedIndex = 0;
            //cbox_word4.SelectedIndex = 0;
            //cbox_word5.SelectedIndex = 0;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            string path_to_image_correct_answer = @"correct.png";
            string path_to_image_incorrect_answer = @"incorrect.png";

            if (cbox_word1.SelectedIndex == idxs_corrects_answer[0])
            {
                pictureBox_result_word1.Load(path_to_image_correct_answer);
            }
            else
            {
                pictureBox_result_word1.Load(path_to_image_incorrect_answer);
            }

            if (cbox_word2.SelectedIndex == idxs_corrects_answer[1])
            {
                pictureBox_result_word2.Load(path_to_image_correct_answer);
            }
            else
            {
                pictureBox_result_word2.Load(path_to_image_incorrect_answer);
            }

            if (cbox_word3.SelectedIndex == idxs_corrects_answer[2])
            {
                pictureBox_result_word3.Load(path_to_image_correct_answer);
            }
            else
            {
                pictureBox_result_word3.Load(path_to_image_incorrect_answer);
            }

            if (cbox_word4.SelectedIndex == idxs_corrects_answer[3])
            {
                pictureBox_result_word4.Load(path_to_image_correct_answer);
            }
            else
            {
                pictureBox_result_word4.Load(path_to_image_incorrect_answer);
            }

            if (cbox_word5.SelectedIndex == idxs_corrects_answer[4])
            {
                pictureBox_result_word5.Load(path_to_image_correct_answer);
            }
            else
            {
                pictureBox_result_word5.Load(path_to_image_incorrect_answer);
            }
            
            pictureBox_result_word1.Show();
            pictureBox_result_word2.Show();
            pictureBox_result_word3.Show();
            pictureBox_result_word4.Show();
            pictureBox_result_word5.Show();

            label_result.Show();

            if (cbox_word1.SelectedIndex == idxs_corrects_answer[0] &&
               cbox_word2.SelectedIndex == idxs_corrects_answer[1] &&
               cbox_word3.SelectedIndex == idxs_corrects_answer[2] &&
               cbox_word4.SelectedIndex == idxs_corrects_answer[3] &&
               cbox_word5.SelectedIndex == idxs_corrects_answer[4])
            {
                count_nuts_on_level += 5;
                dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                label_result.Text = "Молодец";
                btn_result.Enabled = false;
                btn_next_level.Show();
                dq.update_level(m.get_id());
            }
            else
            {
                label_result.Text = "Сверься со словарем и попробуй еще разок";
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

        private void btn_next_level_Click(object sender, EventArgs e)
        {
            level_4 l4 = new level_4(m);
            l4.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string help = "";
            for (int idx = 0; idx < dictionary_with_letter.Count; ++idx)
            {
                Random rnd = new Random();
                string word = string.Join("", dictionary_with_letter[idx].ToLower().OrderBy(x => rnd.Next()));
                help += word + "\n\n";
            }
            label_help.Show();
            label_help.Text = help;
        }
    }
}
