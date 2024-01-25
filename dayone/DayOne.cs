using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {
        
        public string getFirstNumberFromString(string s, bool reversed, bool partOne) {

            String result = "";

            List<string> numbersAsString = getNumbersAsString(s, reversed);
            s = getString(s, reversed);

            bool found = false;
            for (int i = 0; i < s.Length; i++ ) {
                if (Char.IsDigit(s[i])) {
                    result = s[i].ToString();
                    break;
                } else {
                    for (int j = 0; j < numbersAsString.Count(); j++) {
                        if (s.Substring(i).StartsWith(numbersAsString[j]) && !partOne) {
                            result = (j+1).ToString();
                            found = true;
                            break;
                        }
                    }
                }
                if (found) {
                    break;
                }
            }

            return result;
        }

        public List<string> getNumbersAsString(String s, Boolean reversed) { 
            if (reversed) {
                return ["eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin"];
            }
            return ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        }

        public string getString(string s, bool reversed) {
            if (reversed) {
                return reverseString(s);
            }
            return s;
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
