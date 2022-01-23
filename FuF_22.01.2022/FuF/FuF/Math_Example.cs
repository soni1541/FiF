using System;
using System.Collections.Generic;
using System.Text;

namespace FuF
{
    class Math_Example
    {
        //private int value_left;
        //private int value_right;
        private char char_for_example;

        private int min_value;
        private int max_value;

        private string math_example_str;
        private int result_math_example;

        private Random rnd;

        private string chars_for_example;
        private int number_first;
        private int number_second;
        private int number_third;

        private Math_Example()
        {
            chars_for_example = "+-*/";
            rnd = new Random();
        }

        public Math_Example(int min_number_input, int max_number_input)
        {
            chars_for_example = "+-*/";
            rnd = new Random();
            min_value = min_number_input;
            max_value = max_number_input;
        }
        public Math_Example(char char_input, int min_number_input, int max_number_input)
        {
            chars_for_example = "+-*/";
            rnd = new Random();
            char_for_example = char_input;
            min_value = min_number_input;
            max_value = max_number_input;
            gen_and_calc_simple_math_example();
        }
        
        // Изменяем простые примеры

        public void gen_and_calc_simple_math_example()
        {
            int value_left = rnd.Next(min_value, max_value);
            int value_right;

            if(char_for_example == '+' || char_for_example == '*')
            {
                value_right = rnd.Next(min_value, max_value);
            }
            else if (char_for_example == '-')
            {
                value_right = rnd.Next(min_value, value_left);
            }
            else // /
            {
                value_right = rnd.Next(min_value, max_value);
                int multi = value_left * value_right;
                value_left = multi;
            }
            
            if (char_for_example == '+')
            {
                result_math_example = value_left + value_right;
            }
            else if (char_for_example == '*')
            {
                result_math_example = value_left * value_right;
            }
            else if (char_for_example == '-')
            {
                result_math_example = value_left - value_right;
            }
            else if (char_for_example == '/')
            {
                result_math_example = value_left / value_right;
            }

            math_example_str = value_left.ToString() + char_for_example + value_right.ToString() + " =";
        }

        public int get_result_example()
        {
            return result_math_example;
        }

        public String get_math_example_str()
        {
            return math_example_str;
        }

        private void randoming_for_hard_example()
        {
            //rnd_hard = new Random();
            number_first = rnd.Next(min_value, max_value);
            number_second = rnd.Next(min_value, max_value);
            number_third = rnd.Next(min_value, max_value);
        }

        public string generation_hard_math_example()
        {
            randoming_for_hard_example();

            //rnd_hard = new Random();

            int number_for_choice_char_first = rnd.Next(0, 3);

            if (chars_for_example[number_for_choice_char_first] == '-' && number_first < number_second)
            {
                math_example_str = generation_hard_math_example();
            }
            else if (chars_for_example[number_for_choice_char_first] == '/' && number_first < number_second && number_first % number_second != 0)
            {
                math_example_str = generation_hard_math_example();
            }
            else if (chars_for_example[number_for_choice_char_first] == '*' && number_first > 10 && number_second > 10)
            {
                math_example_str = generation_hard_math_example();
            }
            else
            {
                math_example_str = "(" + number_first + " " + chars_for_example[number_for_choice_char_first] + " " + number_second + ")";
                if (chars_for_example[number_for_choice_char_first] == '+')
                {
                    result_math_example = number_first + number_second;
                }
                else if (chars_for_example[number_for_choice_char_first] == '-')
                {
                    result_math_example = number_first - number_second;
                }
                else if (chars_for_example[number_for_choice_char_first] == '*')
                {
                    result_math_example = number_first * number_second;
                }
                else if (chars_for_example[number_for_choice_char_first] == '/')
                {
                    result_math_example = number_first / number_second;
                }
            }

            int number_for_choice_char_second = rnd.Next(1, 3);

            if (chars_for_example[number_for_choice_char_second] == '-' && result_math_example < number_third)
            {
                math_example_str = generation_hard_math_example();
            }
            else if (chars_for_example[number_for_choice_char_second] == '/' && result_math_example < number_third && result_math_example % number_third != 0)
            {
                math_example_str = generation_hard_math_example();
            }
            else if (chars_for_example[number_for_choice_char_second] == '*' && result_math_example > 10 && number_third > 10)
            {
                math_example_str = generation_hard_math_example();
            }
            else if (chars_for_example[number_for_choice_char_first] == chars_for_example[number_for_choice_char_second])
            {
                math_example_str = generation_hard_math_example();
            }
            else
            {
                math_example_str += " " + chars_for_example[number_for_choice_char_second] + " " + number_third + " =";

                if (chars_for_example[number_for_choice_char_second] == '-')
                {
                    result_math_example -= number_third;
                }
                else if (chars_for_example[number_for_choice_char_second] == '*')
                {
                    result_math_example *= number_third;
                }
                else if (chars_for_example[number_for_choice_char_second] == '/')
                {
                    result_math_example /= number_third;
                }
            }
            return math_example_str;
        }

    }
}
