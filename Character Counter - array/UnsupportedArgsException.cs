using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Counter___array
{
    class UnsupportedArgsException : Exception
    {
        public UnsupportedArgsException()
        {

        }

        public UnsupportedArgsException(string message)
            : base(message)
        {

        }

        public UnsupportedArgsException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
