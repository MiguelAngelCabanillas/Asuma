using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    class Error : Exception
    {
        public Error() : base() { }
        public Error(string message) : base(message) { }
    }
}
