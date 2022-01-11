using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace level_4
{
    class Riddle
    {
        private string text;
        private string answer;

        public Riddle()
        { }

        public Riddle(string text_input, string answer_input)
        {
            text = text_input;
            answer = answer_input;
        }

        public static List<Riddle> read_riddles_from_file(string path_to_file)
        {
            List<Riddle> riddles = new List<Riddle>();

            string[] riddles_text = File.ReadAllLines(path_to_file);

            char char_begin_answer = '_';

            foreach(string r in riddles_text)
            {
                string[] text_and_answer = r.Split(char_begin_answer);

                Riddle riddle = new Riddle(text_and_answer[0], text_and_answer[1]);
                riddles.Add(riddle);
            }

            return riddles;
        }

        public static List<Riddle> get_random_count_riddles(List<Riddle> all_riddles, int count_riddles)
        {
            if(count_riddles > all_riddles.Count)
            {
                return new List<Riddle>();
            }
            List<Riddle> riddles_count = new List<Riddle>();
            Random rnd = new Random();
            //rnd.Next(0, count_riddles);
            for(int idx = 0; idx < count_riddles; ++idx)
            {
                
                for(; ; )
                {
                    int rand_idx = rnd.Next(0, all_riddles.Count - 1);
                    Riddle rand_riddle = all_riddles[rand_idx];
                    bool has_old = false;
                    foreach (Riddle r_old in riddles_count)
                    {
                        if (r_old.text == rand_riddle.text)
                        {
                            has_old = true;
                            break;
                        }
                    }
                    if(!has_old)
                    {
                        riddles_count.Add(rand_riddle);
                        break;
                    }
                }
                
            }
            return riddles_count;
        }
        
        public string get_text()
        {
            return text;
        }

        public string get_answer()
        {
            return answer;
        }
    }
}
