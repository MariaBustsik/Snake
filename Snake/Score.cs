using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class Score
    {
       
        private int score;
        public int level;

        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }

        public void ScoreUp()
        {
            score += 1;
            if (score%10==0)
            {
                level += 1;
            }
        }

        
        public int GetScore()
        {
            return score;
        }

        public void ScoreWrite()
        {
            Console.SetCursorPosition(85, 20);
            Console.WriteLine("Очки: " + score.ToString());
            Console.SetCursorPosition(85, 21);
            Console.WriteLine("Уровень: " + level.ToString());
        }
        
    }
}
