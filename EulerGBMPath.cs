using System;


namespace MCOptionPricer
{
    // This class is used to generate Euler discretization geometric brownian motion stock path
    class EulerGBMPath : StockPathGenerator
    {
        public double[] getPath(double s0, double drift, double sigma, double maturity, int numOfSteps
                                    , RandomSequenceGenerator randomSequenceGenerator)
        {
            double dt = maturity / numOfSteps;
            double[] stockPath = new double[numOfSteps + 1];
            stockPath[0] = s0;
            double[] randomSeq = randomSequenceGenerator.getSequence(numOfSteps);
            for (int i = 1; i < numOfSteps + 1; ++i)
            {
                stockPath[i] = stockPath[i - 1] + drift * stockPath[i - 1] * dt + sigma * stockPath[i - 1] * Math.Sqrt(dt) * randomSeq[i - 1];
            }
            return stockPath;
        }
    }
}
