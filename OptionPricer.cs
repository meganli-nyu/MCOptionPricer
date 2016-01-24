using System;

namespace MCOptionPricer
{
    // This class contains static method to compute option price
    class OptionPricer
    {
        public static void MCPriceOption(double s0, double drift, double sigma, double maturity, double strike
                                      , PutCallOption optionType, int numOfSteps
                                      , StockPathGenerator stockpathGenerator, PayoffCalculator payoffCalculator
                                      , RandomSequenceGenerator randomSequenceGenerator)
        {
            StatisticTracker tracker = new StatisticTracker();
            while (tracker.needMoreSimulation())
            {
                tracker.putNewResult(payoffCalculator.computePayoff(strike
                , stockpathGenerator.getPath(s0, drift, sigma, maturity, numOfSteps, randomSequenceGenerator)
                , optionType));
            }
            Console.Write("option price is ");
            Console.WriteLine(tracker.getMean());
            Console.Write("option price standard deviation is ");
            Console.WriteLine(tracker.getStdDev());
        }
    }
}
