using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    public class Speed
    {
        public int score;
        public Speed(int score)
        {
            if (score <= 9)
            {
                Thread.Sleep(200);
            }
            else if (score >= 10 && score <= 19)
            {
                Thread.Sleep(150);
            }
            else if (score >= 20 && score <= 29)
            {
                Thread.Sleep(100);
            }
            else if (score >= 30 && score <= 39)
            {
                Thread.Sleep(80);
            }
            else if (score >= 40 && score <= 49)
            {
                Thread.Sleep(60);
            }

        }
    }
}
