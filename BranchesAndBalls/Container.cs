using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls
{
    class Container:INode
    {
        /// <summary>
        /// Index of the container
        /// </summary>
        private readonly int _index;
        /// <summary>
        /// Index of Ball that falls into the container 
        /// </summary>
        private int _ballNumber;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="ballNumber">It will initialised with 0</param>
        public Container(int index, int ballNumber)
        {
            _index = index;
            _ballNumber = ballNumber;
        }

        public int Predict()
        {
            return _index;
        }

        public int Run()
        {
            return _index;
        }
    }
}
