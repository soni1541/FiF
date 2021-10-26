using System;
using System.Collections.Generic;

namespace Math_examples
{
    class math_example
    {
        private int value_left;
        private int value_right;
        private char[]chars;
        
        private int min_number;
        private int max_number;
        private int value_for_randoming_char;

        private String math_example_str;
        private int result_math_example;

        private math_example()
        {}
        public math_example(char[] chars_input, int min_number_input, int max_number_input)
        {    
            chars = chars_input;
            min_number = min_number_input;
            max_number = max_number_input;
        }
        void randoming()
        {
            Random rnd = new Random();
            value_left = rnd.Next(min_number, max_number);
            value_right = rnd.Next(min_number, max_number);
            //Console.WriteLine("value_left = " + value_left.ToString());
            //Console.WriteLine("value_right = " + value_right.ToString());
            value_for_randoming_char = rnd.Next(chars.Length - 1);
        }
        private void generation_math_example()
        {
            randoming();

            math_example_str = value_left + " " + chars[value_for_randoming_char] + " " + value_right;   
        }

        public int result_for_math_example()
        {
            generation_math_example();

            if (value_for_randoming_char == 1 && value_left > value_right)
            {
                //Console.WriteLine("-");
                result_math_example = value_left - value_right;
            }
            else if (value_for_randoming_char == 3 && value_left % value_right == 0 && value_left >= value_right)
            {
                //Console.WriteLine("/");
                result_math_example = value_left / value_right;
            }

            else if (value_for_randoming_char == 0)
            {
                //Console.WriteLine("+");
                result_math_example = value_left + value_right;
            }
            else if (value_for_randoming_char == 2)
            {
                //Console.WriteLine("*");
                result_math_example = value_left * value_right;
            }
            else
            {
                //Console.WriteLine("char = " + value_for_randoming_char.ToString());
                generation_math_example();  // вычитание или деление не выполняются
                result_for_math_example();
            }
            

            return result_math_example;
        }
        public String get_math_example_str()
        {
            return math_example_str;
        }
    }

    

    class Math_Program
    {
        static void Main(string[] args)
        {
            char[] chars_for_example = { '+', '-', '*', '/' };

            math_example example = new math_example(chars_for_example, 1, 50);

            int result_example = example.result_for_math_example();

            String text_example = example.get_math_example_str();

            Console.WriteLine("text_example = " + text_example);
            Console.WriteLine("result_example = " + result_example.ToString());


            Console.WriteLine(text_example + " = "+ result_example.ToString());
        }
    }
}
