using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class Score
    {
        /*Params settings = new Params();
        private static string pathToRecordFile;
        private static string pathToResultsFile;*/
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

        /*public void WriteBestResult()
        {
            if (score > Convert.ToInt32(GetBestResult()))
            {
                // Write in file
                StreamWriter streamWriter = new StreamWriter(pathToRecordFile);
                streamWriter.Write(score);
                streamWriter.Close();

                // Write in file
                StreamWriter streamWriter1 = new StreamWriter(pathToResultsFile, true);
                streamWriter1.WriteLine(score);
                streamWriter1.Close();
            }
            else
            {
                // Write in file
                StreamWriter streamWriter = new StreamWriter(pathToResultsFile, true);
                streamWriter.WriteLine(score);
                streamWriter.Close();
            }
        }

        public string GetBestResult()
        {
            // Read from file
            StreamReader streamReader = new StreamReader(pathToRecordFile);
            string record = streamReader.ReadToEnd();
            streamReader.Close();
            if (record == "")
            {
                record = "0";
            }

            return record;
        }*/
        public int GetScore()
        {
            return score;
        }

        public void ScoreWrite()
        {
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("Score: " + score.ToString());
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Level: " + level.ToString());
        }
        
    }
}
