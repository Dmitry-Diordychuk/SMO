using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SMO
{
    static class Arrival
    {
        public static int Max { get; set; } = 1000;
        public static int Counter { get; set; } = 0;
        public static double a { get; set; } = 0;
        public static double b { get; set; } = 10;
        public static int time { get; set; }
        public static bool Closed { get => (Counter+Queue.Losses >= Max); }
        static public double GetNextTime()
        {
            Counter++;
            Random rand = new Random();
            double R = Convert.ToDouble( rand.Next( 1,100 ) ) / 100;
            time = (int)Math.Round(a + ( b - a ) * R);
            return time;
        }
    }
}
