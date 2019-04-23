using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMO
{
    static class Service
    {
        // Erlang
        public static double lambda = 2;
        public static int shape = 9;
        static double BusyTime;

        public static double Work()
        {
            Random rand = new Random();
            double R;
            R = Convert.ToDouble( rand.Next( 1,100 ) ) / 100;
            double sum = 0;
            for( int i = 0; i < shape; i++ )
            {
                sum += Math.Log( 1 - R );
                R = Convert.ToDouble( rand.Next( 100 ) ) / 100;
            }
            BusyTime = - ( 1 / ( shape * lambda ) ) * sum;
            if ( BusyTime == 0 )
            {
                BusyTime = 1;
            }
            return BusyTime;
        }
    }
}

