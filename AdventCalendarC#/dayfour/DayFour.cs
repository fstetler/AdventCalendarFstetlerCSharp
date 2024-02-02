using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class DayFour : PrintSolution {

        public List<string>? removeFrontPartOfStrings(List<string> strings) {
            return strings.Select(s => s.Split(":").Last()).ToList();
        }

        public void PrintSolutionOne() {
            throw new NotImplementedException();
        }

        public void PrintSolutionTwo() {
            throw new NotImplementedException();
        }

        public List<string> getStringsFromFile() {
            return Util.getListOfStringsFromFile("resources\\dayfour.txt");
        }

    }
}
