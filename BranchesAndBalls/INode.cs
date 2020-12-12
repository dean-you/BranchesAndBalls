using System;
using System.Collections.Generic;
using System.Text;

namespace BranchesAndBalls
{
    interface INode
    {
        /// <summary>
        /// Predict the index of ball which does not fall into containers
        /// </summary>
        /// <returns></returns>
        int Predict();

        /// <summary>
        /// Run one ball through the system
        /// </summary>
        /// <returns></returns>
        int Run();
    }
}
