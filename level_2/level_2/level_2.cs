using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace level_2
{
    public partial class level_2 : Form
    {
        private Math_Example example_sum;
        private Math_Example example_diff;
        private Math_Example example_multi;
        private Math_Example example_div;

        private Math_Example hard_Math_Example;

        public level_2()
        {
            InitializeComponent();
            pictureBox1.Load(@"belka.png");

            pictureBox_result_sum.Visible = false;
            pictureBox_result_dif.Visible = false;
            pictureBox_result_multi.Visible = false;
            pictureBox_result_div.Visible = false;

            textbox_final_example.Visible = false;
            btn_check_final_example.Visible = false;
            btn_next_level.Visible = false;

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

                btn_next_level.Visible = true;
             
                if (answer_sum == example_sum.get_result_example())
                {
                    pictureBox_result_sum.Load(path_to_image_correct_answer);
                }
                else
                {
                    pictureBox_result_sum.Load(path_to_image_incorrect_answer);
                }

                if (answer_diff == example_diff.get_result_example())
                {
                    pictureBox_result_dif.Load(path_to_image_correct_answer);
                }
                else
                {
                    pictureBox_result_dif.Load(path_to_image_incorrect_answer);
                }

                if (answer_multi == example_multi.get_result_example())
                {
                    pictureBox_result_multi.Load(path_to_image_correct_answer);
                }
                else
                {
                    pictureBox_result_multi.Load(path_to_image_incorrect_answer);
                }

                if (answer_div == example_div.get_result_example())
                {
                    pictureBox_result_div.Load(path_to_image_correct_answer);
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
                    pictureBox_result_sum.Load(path_to_image_correct_answer);
                    pictureBox_result_dif.Load(path_to_image_correct_answer);
                    pictureBox_result_multi.Load(path_to_image_correct_answer);
                    pictureBox_result_div.Load(path_to_image_correct_answer);

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

        }

        private void btn_check_final_example_Click(object sender, EventArgs e)
        {
            if (textbox_final_example.Text == hard_Math_Example.get_result_example().ToString())
            {
                btn_next_level.Enabled = true;
                label_right.Visible = true;
            }
            else
            {
                label_right.Visible = true;
                label_right.Text = "Попробуй посчитать еще разок";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            label_help.Text = "Подсказка";
        }
    }
}
