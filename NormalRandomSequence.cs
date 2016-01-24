using System;

namespace MCOptionPricer
{
    // This class is used to generate independent normal random vector
    class NormalRandomSequence : RandomSequenceGenerator
    {
        public double[] getSequence(int numOfElements)
        {
            Random rand = new Random();
            double[] seq = new double[numOfElements];
            for (int i = 0; i < numOfElements; ++i)
            {
                seq[i] = 0;
                for (int j = 0; j < 12; ++j)
                    seq[i] += rand.NextDouble();
                seq[i] = seq[i] - 6;
            }

            return seq;
        }
    }
}