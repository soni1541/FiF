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
    public partial class level_6 : Form
    {
        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;

        List<string> pictures_for_level;
        string name_picture;

        public level_6(menu m_input)
        {
            InitializeComponent();

            m = m_input;
            dq = new Database_Query();

            count_nuts_on_level = 0;

            pictureBox_belka.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            btn_next_level.Hide();
            label_final.Hide();
            label_help.Hide();

            String path_to_pictures = Environment.CurrentDirectory + "\\Sozvezdiya";

            string[] pictures_files_names = Directory.GetFiles(path_to_pictures, "*.jpg");

            Random rnd = new Random();
            int count_pictures_for_level = 2;
            pictures_for_level = new List<string>();

            for (int idx = 0; idx < count_pictures_for_level; ++idx)
            {
                int random_key = rnd.Next(0, pictures_files_names.Count());
                pictures_for_level.Add(pictures_files_names[random_key]);
            }

            pictureBox_sozvezdie1.Load(pictures_for_level[0]);
            pictureBox_sozvezdie2.Load(pictures_for_level[1]);

            int random_key_answer = rnd.Next(0, pictures_for_level.Count());
            name_picture = get_picture_name(pictures_for_level[random_key_answer]);
            label_answer.Text = "Где созвездие " + name_picture + "?";
        }

        private string get_picture_name(string picture)
        {
            string[] splited_pictures = picture.Split('\\');
            string picture_name = splited_pictures.Last();
            int index_point = picture_name.IndexOf('.');
            picture_name = picture_name.Substring(0, index_point);
            return picture_name;
        }

        private void pictureBox_sozvezdie1_Click(object sender, EventArgs e)
        {
            string name = get_picture_name(pictureBox_sozvezdie1.ImageLocation);
            label_final.Show();
            if (name == name_picture)
            {
                label_final.Text = "Молодец! Верно)";
                btn_next_level.Show();
                pictureBox_sozvezdie1.Enabled = false;
                pictureBox_sozvezdie2.Enabled = false;
            }
            else
            {
                label_final.Text = "Попробуй ещё разок";
            }
        }

        private void pictureBox_sozvezdie2_Click(object sender, EventArgs e)
        {
            string name = get_picture_name(pictureBox_sozvezdie2.ImageLocation);
            label_final.Show();
            if (name == name_picture)
            {
                label_final.Text = "Молодец! Верно)";
                count_nuts_on_level += 5;
                dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                btn_next_level.Show();
            }
            else
            {
                label_final.Text = "Попробуй ещё разок";
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
            label_help.Text = "Нажми на картинку \nс нужным созвездием";
        }

        private void btn_next_level_Click(object sender, EventArgs e)
        {
            level_7 l7 = new level_7(m);
            l7.Show();
            this.Close();
        }
    }
}
