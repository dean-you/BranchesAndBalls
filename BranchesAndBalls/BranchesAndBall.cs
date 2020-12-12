using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls
{
    public class BranchesAndBall
    {
        private readonly int _level;
        private readonly Gate _tree;

        public BranchesAndBall(int level, bool bGateOpenRandom)
        {
            _level = level;
            var index = 0;
            _tree = new Gate(1, level, ref index, bGateOpenRandom);
        }

        public int Predict()
        {
            return _tree.Predict();
        }

        public int RunBalls()
        {
            var totalBalls = Math.Pow(2, _level) - 1;
            for (int ballIndex = 1; ballIndex <= totalBalls; ballIndex++)
            {
                Console.WriteLine($"Ball {ballIndex} goes into container {_tree.Run()}");
            }
            return _tree.Run();
        }
    }
}
