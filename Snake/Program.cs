using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            /*Console.BackgroundColor = ConsoleColor.White;*/
            Console.ForegroundColor = ConsoleColor.Green;

            Walls walls = new Walls (80,25);
            walls.Draw();
          

            //Otrisovka tochek
            Point p = new Point(4, 5, '*');
            

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Params settings = new Params();

            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play();

            Sounds sound1 = new Sounds(settings.GetResourceFolder());

            Score score = new Score(0, 1);
            score.ScoreWrite();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    food = foodCreator.CreateFood();
                    food.Draw();
                    sound1.PlayEat();



                }
                else
                {
                    snake.Move();
                }

                new Speed(score.GetScore());

                

                if (Console.KeyAvailable)
                {

                    snake.HandeKey(Console.ReadKey(true).Key);
                }
                


               /*Console.ReadLine();*/
            }

            Console.Clear();
            new WriteGameOver();
            Thread.Sleep(1500);
            new Results(score.GetScore(), settings.GetResourceFolder());
            Console.Clear();
            Best best = new Best(settings.GetResourceFolder());

            Thread.Sleep(2000);
            /*new Best();*/






        }


    }


    
}
