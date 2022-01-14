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
        public level_3()
        {
            InitializeComponent();

            String path_to_file = @"dictionary.txt";

            string[] dictionary_from_file = File.ReadAllLines(path_to_file);

            Random rnd = new Random();
            int count_words_for_level = 5;
            int random_key_word;

            List<string> dictionary_for_level = new List<string>(count_words_for_level);

            for (int idx = 0; idx < count_words_for_level; ++idx)
            {
                random_key_word = rnd.Next(0, dictionary_from_file.Count());
                dictionary_for_level.Add(dictionary_from_file[random_key_word]);
            }

            List<string> dictionary_for_level_has_not_letterLower = new List<string>(count_words_for_level);

            for (int i = 0; i < count_words_for_level; ++i)
            {
                //string word = dictionary_for_level[i];
                for (int idx_l = 0; idx_l < dictionary_for_level[i].Length; ++idx_l)
                {
                    if (char.IsUpper(dictionary_for_level[i][idx_l]))
                    { 
                        string word_has_not_letter = dictionary_for_level[i].Replace(dictionary_for_level[i][idx_l].ToString(), "   ");
                        dictionary_for_level[i] = word_has_not_letter;
                        TextBox text_let = new TextBox();
                        text_let.Size = new Size(15, 20);
                        text_let.Location = new Point(50 + idx_l * text_let.Size.Width + 6, 110 + 100 - 40 * i);
                        Controls.Add(text_let);
                    }
                }
            }

            for (int idx = 0; idx < dictionary_for_level.Count(); ++idx)
            {
                Label label_word = new Label();
                label_word.Location = new Point(50, 100 + 100 - 40*idx);
                label_word.Text = dictionary_for_level[idx];
                label_word.Font = new Font(label_word.Font.FontFamily, 20);
                label_word.AutoSize = true;
                Controls.Add(label_word);
                
            }
        }

    }
}
