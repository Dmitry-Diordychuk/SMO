using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Accord.Statistics.Distributions.Univariate;

namespace SMO
{
    static class ArrivalRate
    {
        static double lambda = 2;

        static int shape = 9;
        static double timeOfNextArrival;

        static public double GetNextTime()
        {
            Random rand = new Random();
            double temp;
            temp = Convert.ToDouble( rand.Next( 100 ) ) / 100;
            double sum = 0;
            for (int i = 0; i < shape; i++ )
            {
                sum += Math.Log( 1 - temp );
                temp = Convert.ToDouble( rand.Next( 100 ) ) / 100;
            }
            timeOfNextArrival = - ( 1 / ( shape * lambda ) ) * sum;
            if ( timeOfNextArrival == 0 )
            {
                timeOfNextArrival = 1;
            }
            return timeOfNextArrival;
        }

    }
}
