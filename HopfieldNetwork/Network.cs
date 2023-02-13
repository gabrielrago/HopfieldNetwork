using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HopfieldNetwork
{
    internal class Network
    {
        public int[] output = new int[9];
        public Neuron[] nrn = new Neuron[9];

        public Network(int[] a, int[] b, int[] c, int[] d, int[] e, int[] f, int[] g, int[] h, int[] i)
        {
            nrn[0] = new Neuron(a);
            nrn[1] = new Neuron(b);
            nrn[2] = new Neuron(c);
            nrn[3] = new Neuron(d);
            nrn[4] = new Neuron(e);
            nrn[5] = new Neuron(f);
            nrn[6] = new Neuron(g);
            nrn[7] = new Neuron(h);
            nrn[8] = new Neuron(i);
        }

        public int Threshold(int k)
        {
            return (k >= 0) ? 1 : 0;
        }

        public void Activation(int[] patrn)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine($"nrn[{i}].weightv[{j}] is {nrn[i].weightv[j]}");
                }
                nrn[i].Activation = nrn[i].Act(4, patrn);
                Console.WriteLine($"activation is {nrn[i].Activation}");
                output[i] = Threshold(nrn[i].Activation);
                Console.WriteLine($"output value is {output[i]}");
            }
        }
    }
}
