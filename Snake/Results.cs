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
            Console.Clear(); //Очищаем консоль
            Console.WriteLine("Write onw Name or Nickname:"); //Пишем в консоли что нужно ввести ник
            string name = Console.ReadLine(); //Переход на следующую строку и вводим имя игрока
            StreamWriter file = new StreamWriter(pathToResources + "Results.txt", true); //Записываем файл на С диск
            file.WriteLine(name + " - " + score + " "); // Записываем имя игрок и его счёт, через тире
            file.Close(); //Закрываем файл
        }


        
            
    }


    
}
