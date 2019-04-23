using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMO
{
    static class Queue
    {
        static bool Overflow { get; set; } = false;
        public static bool Empty { get; set; } = true;

        public static int Size { get; set; } = 10;
        public static int Counter { get; set; } = 0;
        public static int Losses { get; set; } = 0;

        static public void AddTo()
        {
            if( Counter < Size )
            {
                Counter++;
                Empty = false;
            }
            else if( Counter == Size )
            {
                Overflow = true;
                Losses++;
            }
        }
        static public bool GetFrom()
        {
            if( !Empty )
            {
                Counter--;
                if( Counter == 0 )
                    Empty = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
