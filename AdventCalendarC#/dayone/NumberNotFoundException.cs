using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class NumberNotFoundException : Exception {

        public NumberNotFoundException() { }

        public NumberNotFoundException(string message) : base(message) { }


    }
}
