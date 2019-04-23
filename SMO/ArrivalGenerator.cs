using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Accord.Statistics.Distributions.Univariate;

namespace SMO
{
    static class ArrivalGenerator
    {
        public static double a { get; set; } = 0;
        public static double b { get; set; } = 10;
        public static int time { get; set; }
        static public double GetNextTime()
        {
            Random rand = new Random();
            double R = Convert.ToDouble( rand.Next( 1,100 ) ) / 100;
            time = (int)Math.Ceiling(a + ( b - a ) * R);
            return time;
        }
    }
}
