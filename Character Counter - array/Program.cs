using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array     // "__" ..really? this isn't php! 
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            //args = new[] { "wap.txt", "out.txt" };
            args = new[] { "wp.txt" };
            #endif
            CounterManager capp = new CounterManager(args);
        }
    }
}
