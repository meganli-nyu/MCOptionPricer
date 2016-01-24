using System;

namespace MCOptionPricer
{
    // The class has Main function to test MC option pricer
    class TestOptionPricer
    {
        static void Main(string[] args)
        {
            OptionPricer op = new OptionPricer();

            /* Define simulation parameters */
            double s0 = 100;
            double drift = 0.01;
            double sigma = 0.2;
            double maturity = 0.1; // Maturity is in unit of year
            double strike = 100;
            PutCallOption optionType = PutCallOption.CALL_OPTION;
            int numOfSteps = 100;
            StockPathGenerator stockpathGenerator = new EulerGBMPath(); // Use Euler discretization method
            PayoffCalculator payoffCalculator = new EuropeanPayoff(); // Use European option payoff
            RandomSequenceGenerator randomSequenceGenerator = new NormalRandomSequence(); // Use normal random vector 

            Console.WriteLine("Option Type=European Call" + " S0=" + s0 + " Drift=" + drift + " Sigma=" + sigma + " Maturity(in year)=" + maturity + " Strike=" + strike);
            Console.WriteLine("The number of simulation=" + 1000000);
            Console.WriteLine("The number of steps=" + numOfSteps + "\n");
            Console.WriteLine("Computing Monte Carlo Option Price\n");
            /* Run the Monte Carlo simulation option pricing function */
            OptionPricer.MCPriceOption( s0,  drift,  sigma,  maturity, strike, optionType, numOfSteps
                                      ,  stockpathGenerator,  payoffCalculator
                                      ,  randomSequenceGenerator);

            Console.ReadKey();
        }
    }
}
