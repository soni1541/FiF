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
    public partial class level_5 : Form
    {
        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;

        List<string> pictures_for_level;
        int picture_now;
        public level_5(menu m_input)
        {
            InitializeComponent();

            m = m_input;
            dq = new Database_Query();

            count_nuts_on_level = 0;

            pictureBox_belka.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            picture_now = 0;

            btn_next_level.Hide();
            label_result.Hide();
            label_help.Hide();

            String path_to_pictures = Environment.CurrentDirectory + "\\Classes_animals";

            string[] pictures_files_names = Directory.GetFiles(path_to_pictures, "*.jpg");

            Random rnd = new Random();
            int count_pictures_for_level = 3;
            pictures_for_level = new List<string>();

            for (int idx = 0; idx < count_pictures_for_level; ++idx)
            {
                int random_key_word = rnd.Next(0, pictures_files_names.Count());
                pictures_for_level.Add(pictures_files_names[random_key_word]);
            }
            pictureBox.Load(pictures_for_level[picture_now]);
        }

        private string get_picture_name()
        {
            string[] splited_pictures = pictures_for_level[picture_now].Split('\\');
            string picture_name = splited_pictures.Last();
            int index__ = picture_name.IndexOf('_');
            int index_point = picture_name.IndexOf('.');
            picture_name = picture_name.Substring(index__ + 1, index_point - index__ - 1);
            return picture_name;
        }

        private void btn_to_close()
        {
            btn_rak.Enabled = false;
            btn_nasekomoe.Enabled = false;
            btn_mlekopit.Enabled = false;
            btn_pauk.Enabled = false;
            btn_pemnovodik.Enabled = false;
            btn_presmik.Enabled = false;
            btn_ptica.Enabled = false;
            btn_riby.Enabled = false;
        }
        private void btn_to_open()
        {
            btn_rak.Enabled = true;
            btn_nasekomoe.Enabled = true;
            btn_mlekopit.Enabled = true;
            btn_pauk.Enabled = true;
            btn_pemnovodik.Enabled = true;
            btn_presmik.Enabled = true;
            btn_ptica.Enabled = true;
            btn_riby.Enabled = true;
        }

        private void btn_rak_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_rak.Text)
            {
                
                label_result.Text = "Правильно, молодец!";
                if(picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }
                
            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_rak.Enabled = false;
            }
            
        }

        private void btn_pauk_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_pauk.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_pauk.Enabled = false;
            }
        }

        private void btn_nasekomoe_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_nasekomoe.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_nasekomoe.Enabled = false;
            }
        }

        private void btn_mlekopit_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_mlekopit.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_mlekopit.Enabled = false;
            }
        }

        private void btn_ptica_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_ptica.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_ptica.Enabled = false;
            }
        }

        private void btn_presmik_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_presmik.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_presmik.Enabled = false;
            }
        }

        private void btn_pemnovodik_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_pemnovodik.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_pemnovodik.Enabled = false;
            }
        }

        private void btn_riby_Click(object sender, EventArgs e)
        {
            string picture_name = get_picture_name();
            label_result.Show();
            if (picture_name == btn_riby.Text)
            {
                label_result.Text = "Правильно, молодец!";
                if (picture_now > 1)
                {
                    btn_to_close();
                    count_nuts_on_level += 5;
                    dq.update_count_nuts(m.get_id(), count_nuts_on_level);
                    label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
                    btn_next_level.Show();
                }
                else
                {
                    ++picture_now;
                    label_help.Hide();
                    pictureBox.Load(pictures_for_level[picture_now]);
                    btn_to_open();
                }

            }
            else
            {
                label_result.Text = "Попробуй еще раз";
                btn_riby.Enabled = false;
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
            string[] splited_pictures = pictures_for_level[picture_now].Split('\\');
            string picture_name = splited_pictures.Last();
            int index__ = picture_name.IndexOf('_');
            picture_name = picture_name.Substring(0, index__);
            label_help.Text = "Это " + picture_name;
            label_help.Show();
        }

        private void btn_next_level_Click(object sender, EventArgs e)
        {
            level_6 l6 = new level_6(m);
            l6.Show();
            this.Hide();
        }
    }
}
