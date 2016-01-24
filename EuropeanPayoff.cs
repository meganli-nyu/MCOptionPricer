using System;


namespace MCOptionPricer
{
    // This class is used to compute European option payoff
    class EuropeanPayoff : PayoffCalculator
    {
        public double computePayoff(double strike, double[] stockPath, PutCallOption putCallOption)
        {
            if (putCallOption == PutCallOption.CALL_OPTION)
            {
                return Math.Max(stockPath[stockPath.Length - 1] - strike, 0);
            }
            else
            {
                return Math.Max(strike - stockPath[stockPath.Length - 1], 0);
            }
        }
    }
}
