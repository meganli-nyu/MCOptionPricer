

namespace MCOptionPricer
{
    interface StockPathGenerator
    {
        double[] getPath(double s0, double drift, double sigma, double maturity, int numOfSteps
                            , RandomSequenceGenerator randomSequenceGenerator);
    }
}
