

namespace MCOptionPricer
{
    interface PayoffCalculator
    {
        double computePayoff(double strike, double[] stockPath, PutCallOption putCallOption);
    }
}
