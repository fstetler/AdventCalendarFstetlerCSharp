using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {
        
        public int getFirstNumberFromString(string s, bool partOne) {
            List<string> numbersAsString = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
            return getNumberFromString(partOne, numbersAsString, s);
        }

        public int getFirstNumberFromReversedString(string s, bool partOne) {
            List<string> numbersAsString = ["eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin"];
            String newS = reverseString(s);
            return getNumberFromString(partOne, numbersAsString, newS);
        }

        private int getNumberFromString(bool partOne, List<string> numbersAsString, string newS) {
            for (int i = 0; i < newS.Length; i++) {
                if (Char.IsDigit(newS[i])) {
                    return (int) Char.GetNumericValue(newS[i]);
                }
                if (!partOne) {
                    for (int j = 0; j < numbersAsString.Count(); j++) {
                        if (newS.Substring(i).StartsWith(numbersAsString[j])) {
                            return (j + 1);
                        }
                    }
                }
            }
//  gör ot till int
            throw new Exception("hey");
        }



        private string reverseString(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void printSolutionOne() {
        

        }

        public void printSolutionTwo() {
            Console.WriteLine();
        }
    }
}
