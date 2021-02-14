using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class Results
    {
        public Results(int score, string pathToResources)
        {
            Console.Clear();
            Console.WriteLine("Введите Ваше имя пользователя: ");
            string name = Console.ReadLine();
            StreamWriter file = new StreamWriter(pathToResources + "Results.txt", true);
            file.WriteLine(name + ": " + score + " ");
            file.Close();
        }


        
            
    }


    
}
