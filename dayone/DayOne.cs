using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {
        
        public string getFirstNumberFromString(string s, bool partOne) {
            List<string> numbersAsString = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
            return getNumberFromString(partOne, numbersAsString, s);
        }

        public string getFirstNumberFromReversedString(string s, bool partOne) {
            List<string> numbersAsString = ["eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin"];
            String newS = reverseString(s);
            return getNumberFromString(partOne, numbersAsString, newS);
        }

        private string getNumberFromString(bool partOne, List<string> numbersAsString, string newS) {
            for (int i = 0; i < newS.Length; i++) {
                if (Char.IsDigit(newS[i])) {
                    Console.WriteLine("Hallå");
                    return newS[i].ToString();
                }
                if (!partOne) {
                    for (int j = 0; j < numbersAsString.Count(); j++) {
                        if (newS.Substring(i).StartsWith(numbersAsString[j])) {
                            Console.WriteLine("hejsan");
                            return (j + 1).ToString();
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
            Console.WriteLine(Util.getListOfStringsFromFile("C:\\Programming\\C#\\AdventCalendarC#\\resources\\dayone.txt")[0]);
        }

        public void printSolutionTwo() {
            Console.WriteLine();
        }
    }
}
