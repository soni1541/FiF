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

namespace level_3
{
    public partial class level_3 : Form
    {
        List<string> dictionary_for_level;
        List<char> chars_upper;

        public level_3()
        {
            InitializeComponent();

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

            chars_upper = new List<char>();

            for (int i = 0; i < count_words_for_level; ++i)
            {
                for (int idx_l = 0; idx_l < dictionary_for_level[i].Length; ++idx_l)
                {
                    if (char.IsUpper(dictionary_for_level[i][idx_l]))
                    {
                        chars_upper.Add(dictionary_for_level[i][idx_l]);
                        string word_has_not_letter = dictionary_for_level[i].Replace(dictionary_for_level[i][idx_l].ToString(), "_");
                        dictionary_for_level[i] = word_has_not_letter;
                    }
                }
            }

            word1.Text = dictionary_for_level[0];
            word2.Text = dictionary_for_level[1];
            word3.Text = dictionary_for_level[2];
            word4.Text = dictionary_for_level[3];
            word5.Text = dictionary_for_level[4];

            for (int i = 0; i < count_words_for_level; ++i)
            {
                cbox_word1.Items.Add(chars_upper[i]);
                cbox_word2.Items.Add(chars_upper[i]);
                cbox_word3.Items.Add(chars_upper[i]);
                cbox_word4.Items.Add(chars_upper[i]);
                cbox_word5.Items.Add(chars_upper[i]);
            }

            cbox_word1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_word5.DropDownStyle = ComboBoxStyle.DropDownList;

            cbox_word1.SelectedIndex = 0;
            cbox_word2.SelectedIndex = 0;
            cbox_word3.SelectedIndex = 0;
            cbox_word4.SelectedIndex = 0;
            cbox_word5.SelectedIndex = 0;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if(cbox_word1.SelectedIndex == 0 &&
               cbox_word2.SelectedIndex == 1 &&
               cbox_word3.SelectedIndex == 2 &&
               cbox_word4.SelectedIndex == 3 &&
               cbox_word5.SelectedIndex == 4)
            {
                label_result.Text = "Молодец";
            }
            else
            {
                label_result.Text = "Сверься со словарем и попробуй еще разок";
            }
        }
    }
}
