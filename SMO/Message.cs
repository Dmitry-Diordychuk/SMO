using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SMO
{
    class Message
    {
        public Stopwatch watch;
        //public bool Lost { get; set; } = false;


        public void StartTimer()
        {
            watch = Stopwatch.StartNew();
        }
        public void StopTimer()
        {
            watch.Stop();
        }
    }
}
