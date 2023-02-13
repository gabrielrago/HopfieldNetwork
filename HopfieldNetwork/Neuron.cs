using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HopfieldNetwork
{
    internal class Neuron
    {
        public int[] weightv = new int[9];
        public int Activation { get; set; }

        public Neuron(int[] j)
        {
            for (int i = 0; i < 9; i++)
            {
                weightv[i] = j[i];
            }
        }

        public int Act(int m, int[] x)
        {
            int a = 0;
            for (int i = 0; i < m; i++)
            {
                a += x[i] * weightv[i];
            }
            return a;
        }
    }
}
