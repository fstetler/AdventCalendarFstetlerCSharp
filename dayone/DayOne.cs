using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {
        public int returnOne() {
            return 1;
        }

        public void printSolutionOne() {
            Console.WriteLine(Util.getListOfStringsFromFile("C:\\Programming\\C#\\AdventCalendarC#\\resources\\dayone.txt")[0]);
        }

        public void printSolutionTwo() {
            Console.WriteLine(returnOne());
        }
    }
}
