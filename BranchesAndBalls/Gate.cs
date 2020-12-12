using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls
{
    class Gate: INode
    {
        /// <summary>
        /// Left node of a gate
        /// </summary>
        private INode leftNode;
        /// <summary>
        /// Right node of a gate
        /// </summary>
        private INode rightNode;
        /// <summary>
        /// whether gate open to left
        /// </summary>
        bool bGateOpenToLeft;


        public Gate(int currentLevel, int totalLevel, ref int index, bool bGateOpenRandom)
        {
            if (bGateOpenRandom)
            {
                var rand = new Random();
                bGateOpenToLeft = rand.Next(2) == 1;
            }
            //If not randomise, set to true. So we can know the expected result for unit testing
            else
            {
                bGateOpenToLeft = true;
            }

            if (currentLevel < totalLevel)
            {
                leftNode = new Gate(currentLevel + 1, totalLevel, ref index, bGateOpenRandom);
                rightNode = new Gate(currentLevel + 1, totalLevel, ref index, bGateOpenRandom);
            }
            else
            {
                leftNode = new Container(++index, 0);
                rightNode = new Container(++index, 0);
            }
        }

        public int Predict()
        {
            if (bGateOpenToLeft)
                return rightNode.Predict();
            else
                return leftNode.Predict();
        }

        public int Run()
        {
            if (bGateOpenToLeft)
            {
                bGateOpenToLeft = !bGateOpenToLeft;
                return leftNode.Run();
            }
            else
            {
                bGateOpenToLeft = !bGateOpenToLeft;
                return rightNode.Run();
            }
        }
    }
}
