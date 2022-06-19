using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Игра1
{
    class Stata
    {
        public uint Total = 0;
        public uint Messed = 0;
        public uint Correct = 0;
        public uint Accurate = 0;

        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Messed++;
            }
            else
            {
                Correct++;
            }
            Accurate = 100*Correct/ (Messed + Correct);
        }
    }
}
