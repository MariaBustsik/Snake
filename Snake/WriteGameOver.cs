using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    public class WriteGameOver

    {
        public WriteGameOver()
        {
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("===============================", xOffset, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 3, yOffset++);
            WriteText("===============================", xOffset, yOffset++);
            


        }

        public void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
    

