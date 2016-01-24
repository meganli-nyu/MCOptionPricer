using System;

namespace MCOptionPricer
{
    class StatisticTracker
    {
        public void putNewResult(double result)
        {
            sumPrice += result;
            sumPriceSqr += result * result;
            ++numOfSimulation;
        }

        public bool needMoreSimulation()
        {
            return (numOfSimulation < 1000000);
        }

        public double getStdDev()
        {
            return Math.Sqrt(sumPriceSqr / numOfSimulation - (sumPrice / numOfSimulation) * (sumPrice / numOfSimulation));
        }

        public double getMean()
        {
            return sumPrice / numOfSimulation;
        }

        private double sumPrice = 0;
        private double sumPriceSqr = 0;
        private int numOfSimulation = 0;
    }
}
