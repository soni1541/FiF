using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace FuF
{
    public partial class level_2 : Form
    {
        private menu m;
        private Database_Query dq;
        private int count_nuts_on_level;

        private Math_Example example_sum;
        private Math_Example example_diff;
        private Math_Example example_multi;
        private Math_Example example_div;

        private Math_Example hard_Math_Example;

        public level_2(menu m_input)
        {
            InitializeComponent();

            dq = new Database_Query();

            pictureBox_help.Load("table_multiplication.png");
            pictureBox_help.Hide();

            m = m_input;

            count_nuts_on_level = 0;

            pictureBox1.Load("belka.png");
            pictureBox_nut.Load("nut.png");

            label_ex1.Hide();
            label_ex2.Hide();
            label_ex3.Hide();
            label_ex4.Hide();
            label_exf.Hide();

            
            label_count_nuts.Text = "x" + dq.get_count_nuts(m.get_id()).ToString();

            pictureBox_result_sum.Visible = false;
            pictureBox_result_dif.Visible = false;
            pictureBox_result_multi.Visible = false;
            pictureBox_result_div.Visible = false;

            textbox_final_example.Visible = false;
            btn_check_final_example.Visible = false;
            btn_next_level.Hide();

            example_sum = new Math_Example('+', 1, 50);
            example_diff = new Math_Example('-', 1, 50);
            example_multi = new Math_Example('*', 1, 15);
            example_div = new Math_Example('/', 1, 15);

            label_sum.Text = example_sum.get_math_example_str();
            label_difference.Text = example_diff.get_math_example_str();
            label_multiplication.Text = example_multi.get_math_example_str();
            label_division.Text = example_div.get_math_example_str();

            hard_Math_Example = new Math_Example(1, 50);
            string hard_Math_Example_str = hard_Math_Example.generation_hard_math_example();
            label_final_example.Text = hard_Math_Example_str;
        }

        private void btn_check_answers_Click(object sender, EventArgs e)
        {
            text_box_sum.Enabled = false;
            textbox_difference.Enabled = false;
            textbox_multiplication.Enabled = false;
            textbox_division.Enabled = false;

            btn_check_answers.Enabled = false;

            int answer_sum = Convert.ToInt32(text_box_sum.Text);
            int answer_diff = Convert.ToInt32(textbox_difference.Text);
            int answer_multi = Convert.ToInt32(textbox_multiplication.Text);
            int answer_div = Convert.ToInt32(textbox_division.Text);

            string path_to_image_correct_answer = @"correct.png";
            string path_to_image_incorrect_answer = @"incorrect.png";

            if (answer_sum == example_sum.get_result_example() ||
                answer_diff == example_diff.get_result_example() ||
                answer_multi == example_multi.get_result_example() ||
                answer_div == example_div.get_result_example())
            {

                btn_next_level.Show();
                dq.update_level(m.get_id());

                if (answer_sum == example_sum.get_result_example())
                {
                    pictureBox_result_sum.Load(path_to_image_correct_answer);
                    count_nuts_on_level += 3;
                    label_ex1.Text = "x3";
                    label_ex1.Show();
                }
                else
                {
                    pictureBox_result_sum.Load(path_to_image_incorrect_answer);
                }

                if (answer_diff == example_diff.get_result_example())
                {
                    pictureBox_result_dif.Load(path_to_image_correct_answer);
                    count_nuts_on_level += 3;
                    label_ex2.Text = "x3";
                    label_ex2.Show();
                }
                else
                {
                    pictureBox_result_dif.Load(path_to_image_incorrect_answer);
                }

                if (answer_multi == example_multi.get_result_example())
                {
                    pictureBox_result_multi.Load(path_to_image_correct_answer);
                    count_nuts_on_level += 3;
                    label_ex3.Text = "x3";
                    label_ex3.Show();
                }
                else
                {
                    pictureBox_result_multi.Load(path_to_image_incorrect_answer);
                }

                if (answer_div == example_div.get_result_example())
                {
                    pictureBox_result_div.Load(path_to_image_correct_answer);
                    count_nuts_on_level += 3;
                    label_ex4.Text = "x3";
                    label_ex4.Show();
                }
                else
                {
                    pictureBox_result_div.Load(path_to_image_incorrect_answer);
                }

                pictureBox_result_sum.Visible = true;
                pictureBox_result_dif.Visible = true;
                pictureBox_result_multi.Visible = true;
                pictureBox_result_div.Visible = true;

                if (answer_sum == example_sum.get_result_example() &&
                    answer_diff == example_diff.get_result_example() &&
                    answer_multi == example_multi.get_result_example() &&
                    answer_div == example_div.get_result_example())
                {
                    label_text.Visible = true;
                    label_text.Text = "Финальный пример!";
                    label_final_example.Visible = true;
                    textbox_final_example.Visible = true;
                    btn_check_final_example.Visible = true;
                    btn_check_answers.Enabled = false;
                }
            }
            else
            {
                pictureBox_result_sum.Load(path_to_image_incorrect_answer);
                pictureBox_result_dif.Load(path_to_image_incorrect_answer);
                pictureBox_result_multi.Load(path_to_image_incorrect_answer);
                pictureBox_result_div.Load(path_to_image_incorrect_answer);
                label_text.Text = "Попробуй еще разок";
                label_text.Visible = true;
            }

            dq.update_count_nuts(m.get_id(), count_nuts_on_level);
            label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
            count_nuts_on_level = 0;
        }

        private void btn_check_final_example_Click(object sender, EventArgs e)
        {
            btn_check_final_example.Enabled = false;
            textbox_final_example.Enabled = false;

            if (textbox_final_example.Text == hard_Math_Example.get_result_example().ToString())
            {
                label_right.Visible = true;
                label_right.Text = "Молодец! Всё верно!";
                label_exf.Text = "x6";
                count_nuts_on_level += 6;
                label_exf.Show();
            }
            else
            {
                label_right.Visible = true;
                label_right.Text = "Этого то я и боялась...";
            }

            dq.update_count_nuts(m.get_id(), count_nuts_on_level);
            label_count_nuts.Text += " +" + count_nuts_on_level.ToString();
            count_nuts_on_level = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_help.Show();
        }

        private void Xback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            m.update_menu();
            m.Show();
        }

        private void btn_next_level_Click(object sender, EventArgs e)
        {
            level_3 l3 = new level_3(m);
            l3.Show();
            this.Hide();
        }

        private void level_2_Load(object sender, EventArgs e)
        {

        }
    }
}
