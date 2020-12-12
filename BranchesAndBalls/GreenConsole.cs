using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls
{
    /// <summary>
    /// Help class to print green font on console
    /// </summary>
    class GreenConsole
    {
        public static void Write(int num)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{num}");
            Console.ResetColor();
        }

        public static void WriteLine(int num) {
            Write(num);
            Console.Write(Environment.NewLine);
        }
    }
}
