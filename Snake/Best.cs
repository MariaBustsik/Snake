using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class Best
    {
        Params settings = new Params();
        private static string pathToRecordFile;
        private static string pathToResultsFile;
        public Best(string folder)
        {
            pathToRecordFile = folder + "record.txt";
            pathToResultsFile = folder + "results.txt";
            List<string> res = new List<string>();
            string line;

            
            StreamReader streamReader = new StreamReader(pathToResultsFile);
            while ((line = streamReader.ReadLine()) != null)
            {
                
                res.Add(line);
            }

            streamReader.Close();

            Console.SetCursorPosition(10,2);
            Console.WriteLine("5 последних результатов:");
            
            
            for (int i = res.Count - 1, j = 1; i > res.Count - 6; i--, j++)
            {
                Console.SetCursorPosition(10, 3 + j);
                Console.WriteLine(j + ") " + res[i]);
            }
        }
    }
}
