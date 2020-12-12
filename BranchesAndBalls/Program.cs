using System;

namespace BranchesAndBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Please input the tree structure level: ");
                var level = 0;
                var input= Console.ReadLine();
                if (int.TryParse(input, out level))
                {
                    var system = new BranchesAndBall(level, true);
                    Console.Write($"The predict index of container is ");
                    GreenConsole.WriteLine(system.Predict());
                    var containerWithoutBall = system.RunBalls();
                    Console.Write($"Container ");
                    GreenConsole.Write(containerWithoutBall);
                    Console.WriteLine($" does not have ball.\n");
                }
                else
                {
                    Console.WriteLine("Please input a valid number");
                }
            }
        }
    }
}
