using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {

        readonly List<string> reversedNumbersAsString = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

        readonly List<string> numbersAsString = ["eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin"];


        //public int solvePartOne(List<String> strings) {
        //    for (int i = 0; i < strings.Count; i++) {
        //        string s = strings[i];
        //        int numberFromLeft = getFirstNumberFromStringPartOne(s);
        //        int numberFromRight = getFirstNumberFromReversedStringPartOne(s);



        //    }
        //}

        public List<int> numbersFromLeftPartOne(List<String> strings) {
            List<int> numbers = new List<int>();

            for (int i = 0; i < strings.Count; i++) {
                int numberFromLeft = getFirstNumberFromStringPartOne(strings[i]);
                numbers.Add(numberFromLeft);
            }
            return numbers;
        }

        public int getFirstNumberFromReversedStringPartOne(string s) {
            String newS = reverseString(s);
            return getFirstNumberFromStringPartOne(newS);
        }

        public int getFirstNumberFromStringPartOne(string s) {
            for (int i = 0; i < s.Length; i++) {
                if (Char.IsDigit(s[i])) {
                    return (int) Char.GetNumericValue(s[i]);
                }
             
            }
//  gör ot till int
            throw new Exception("hey");
        }

        public int getNumberFromStringPartTwo(bool partOne, List<string> numbersAsString, string s) {
            for (int i = 0; i < s.Length; i++) {
                if (Char.IsDigit(s[i])) {
                    return (int)Char.GetNumericValue(s[i]);
                }
                if (!partOne) {
                    for (int j = 0; j < numbersAsString.Count(); j++) {
                        if (s.Substring(i).StartsWith(numbersAsString[j])) {
                            return (j + 1);
                        }
                    }
                }
            }
            throw new Exception("Shouldnt happen");
        }

        private string reverseString(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public void printSolutionOne() {
        

        }

        public void printSolutionTwo() {
        }
    }
}
